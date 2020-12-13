using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinHexLikeDecoder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //binhexで使われる文字種　位置が変換後の数値(0～63)に対応
        static string chars = "!\"#$%&'()*+,-012345689@ABCDEFGHIJKLMNPQRSTUVXYZ[`abcdefhijklmpqr";

        //binhexっぽいテキストをバイト配列に変換
        private byte[] BinHexLike2Bytes(string binhexText)
        {
            binhexText = binhexText.Replace("\r\n", "\n");
            string[] lines = binhexText.Split('\n');
            if (lines[0] == "(This file must be converted with BinHex 4.0)")
            {
                //先頭行を削除
                List<string> tmpLines = new List<string>(lines);
                tmpLines.RemoveAt(0);
                lines = tmpLines.ToArray();
            }
            //文字部分すべてつなげる
            string binhexStr = string.Join("", lines);
            //前後の:除去
            binhexStr = binhexStr.Trim(':');

            List<byte> byteList = new List<byte>();

            for (int i = 0; i < binhexStr.Length / 4; i++)
            {
                byte[] bytes = new byte[3];
                int[] indices = new int[4];
                //文字→数値変換
                for (int j = 0; j < 4; j++)
                {
                    indices[j] = chars.IndexOf(binhexStr[i * 4 + j]);
                    if (indices[j] < 0)
                        return new byte[1];    //不正な文字が来たら長さ1の配列返す
                }

                //何故かシフト演算使ってなかった時の
                bytes[0] = (byte)(indices[0] * 4 + indices[1] / 16);
                bytes[1] = (byte)(indices[1] % 16 * 16 + indices[2] / 4);
                bytes[2] = (byte)(indices[2] % 4 * 64 + indices[3]);

                bytes[0] = (byte)((indices[0] << 2) + (indices[1] >> 4));
                bytes[1] = (byte)(((indices[1] & 0x0F) << 4) + (indices[2] >> 2));
                bytes[2] = (byte)(((indices[2] & 0x03) << 6) + indices[3]);

                byteList.AddRange(bytes);
            }

            //ランレングス展開 
            for (int i = 0; i < byteList.Count; i++)
            {
                if (byteList[i] == 0x90)
                {
                    if (byteList[i + 1] == 0x00)
                    {
                        //0x90 0x00なら0x00消す
                        byteList.RemoveAt(i + 1);
                        continue;
                    }
                    //0x90削除
                    byteList.RemoveAt(i);
                    //繰り返し数取得
                    int repeat = byteList[i];
                    //繰り返し数削除
                    byteList.RemoveAt(i);
                    i--;
                    //iに繰り返すものが入っているので繰り返し追加(元から1つ入っているので-1回)
                    for (int j = 0; j < repeat - 1; j++)
                    {
                        byteList.Insert(i, byteList[i]);
                        i++;
                    }
                }
            }

            return byteList.ToArray();
        }

        private void BinHexTextBox_TextChanged(object sender, EventArgs e)
        {
            byte[] decodedBytes = BinHexLike2Bytes(BinHexTextBox.Text);

            string decodedStr = "";
            for (int i = 0; i < decodedBytes.Length; i++)
            {
                decodedStr += BitConverter.ToString(new byte[] { decodedBytes[i] });
                if ((i + 1) % 16 == 0)
                    decodedStr += "\r\n";
                else
                    decodedStr += " ";
            }

            ByteRichTextBox.Text = decodedStr;

            //配列コピー
            byte[] toASCII = new byte[decodedBytes.Length];
            Array.Copy(decodedBytes, toASCII, decodedBytes.Length);

            for (int i = 0; i < toASCII.Length; i++)
            {
                //制御文字と0x7F以降なら.に
                if (toASCII[i] < 0x20 || 0x7F <= toASCII[i])
                    toASCII[i] = 0x2E;
            }
            string ASCIIstr = "";
            ASCIIEncoding ascii = new ASCIIEncoding();
            for (int i = 0; i < toASCII.Length; i++)
            {
                ASCIIstr += ascii.GetString(new byte[] { toASCII[i] });
                if ((i + 1) % 16 == 0)
                    ASCIIstr += "\r\n";
            }

            ASCIIRichTextBox.Text = ASCIIstr;
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            if (ByteRichTextBox.Text == null || ByteRichTextBox.Text == "") return; //空だったら何もしない

            string tmp = ByteRichTextBox.Text.Replace("\r\n", " ");
            tmp = tmp.Replace("\r", " ");
            tmp = tmp.Replace("\n", " ");
            Clipboard.SetText(tmp);
        }

    }
}

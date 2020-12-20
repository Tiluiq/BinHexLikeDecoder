
namespace BinHexLikeDecoder
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.BinHexLabel = new System.Windows.Forms.Label();
            this.ByteLabel = new System.Windows.Forms.Label();
            this.CopyButton = new System.Windows.Forms.Button();
            this.ASCIILabel = new System.Windows.Forms.Label();
            this.BinHexTextBox = new System.Windows.Forms.TextBox();
            this.ByteRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ASCIIRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // BinHexLabel
            // 
            this.BinHexLabel.AutoSize = true;
            this.BinHexLabel.Location = new System.Drawing.Point(13, 13);
            this.BinHexLabel.Name = "BinHexLabel";
            this.BinHexLabel.Size = new System.Drawing.Size(106, 12);
            this.BinHexLabel.TabIndex = 0;
            this.BinHexLabel.Text = "BinHexっぽいテキスト";
            // 
            // ByteLabel
            // 
            this.ByteLabel.AutoSize = true;
            this.ByteLabel.Location = new System.Drawing.Point(470, 13);
            this.ByteLabel.Name = "ByteLabel";
            this.ByteLabel.Size = new System.Drawing.Size(44, 12);
            this.ByteLabel.TabIndex = 2;
            this.ByteLabel.Text = "バイト列";
            // 
            // CopyButton
            // 
            this.CopyButton.Location = new System.Drawing.Point(713, 416);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(75, 23);
            this.CopyButton.TabIndex = 4;
            this.CopyButton.Text = "コピー";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // ASCIILabel
            // 
            this.ASCIILabel.AutoSize = true;
            this.ASCIILabel.Location = new System.Drawing.Point(792, 13);
            this.ASCIILabel.Name = "ASCIILabel";
            this.ASCIILabel.Size = new System.Drawing.Size(34, 12);
            this.ASCIILabel.TabIndex = 5;
            this.ASCIILabel.Text = "ASCII";
            // 
            // BinHexTextBox
            // 
            this.BinHexTextBox.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BinHexTextBox.Location = new System.Drawing.Point(12, 29);
            this.BinHexTextBox.MaxLength = 0;
            this.BinHexTextBox.Multiline = true;
            this.BinHexTextBox.Name = "BinHexTextBox";
            this.BinHexTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.BinHexTextBox.Size = new System.Drawing.Size(454, 381);
            this.BinHexTextBox.TabIndex = 7;
            this.BinHexTextBox.TextChanged += new System.EventHandler(this.BinHexTextBox_TextChanged);
            // 
            // ByteRichTextBox
            // 
            this.ByteRichTextBox.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ByteRichTextBox.Location = new System.Drawing.Point(472, 28);
            this.ByteRichTextBox.Name = "ByteRichTextBox";
            this.ByteRichTextBox.ReadOnly = true;
            this.ByteRichTextBox.Size = new System.Drawing.Size(316, 381);
            this.ByteRichTextBox.TabIndex = 10;
            this.ByteRichTextBox.Text = "";
            // 
            // ASCIIRichTextBox
            // 
            this.ASCIIRichTextBox.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ASCIIRichTextBox.Location = new System.Drawing.Point(794, 29);
            this.ASCIIRichTextBox.Name = "ASCIIRichTextBox";
            this.ASCIIRichTextBox.ReadOnly = true;
            this.ASCIIRichTextBox.Size = new System.Drawing.Size(129, 381);
            this.ASCIIRichTextBox.TabIndex = 11;
            this.ASCIIRichTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 450);
            this.Controls.Add(this.ASCIIRichTextBox);
            this.Controls.Add(this.ByteRichTextBox);
            this.Controls.Add(this.BinHexTextBox);
            this.Controls.Add(this.ASCIILabel);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.ByteLabel);
            this.Controls.Add(this.BinHexLabel);
            this.Name = "Form1";
            this.Text = "BinHexLikeDecoder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BinHexLabel;
        private System.Windows.Forms.Label ByteLabel;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.Label ASCIILabel;
        private System.Windows.Forms.TextBox BinHexTextBox;
        private System.Windows.Forms.RichTextBox ByteRichTextBox;
        private System.Windows.Forms.RichTextBox ASCIIRichTextBox;
    }
}


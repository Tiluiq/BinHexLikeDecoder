# BinHexLikeDecoder
BinHex形式っぽいテキストをバイト列(を表すテキスト)に直すやつ

## 使い方
BinHex形式っぽいテキストを左のテキストボックスに入力すると、変換後のテキストが真ん中に、それをASCIIで表したものが右に表示されます。<br>
真ん中に表示されたものには16バイト分ごとに空白ではなく改行が含まれていますが、下部の"コピー"ボタンを押すと改行を含まず全て空白で区切られたテキストがクリップボードにコピーされます。

### 注意事項
元のファイルに戻すのではなくRFC1741の下の方のAppendix A (https://tools.ietf.org/html/rfc1741#appendix-A) で示されているバイト列(ファイル情報?+データフォーク+リソースフォーク)の状態を表すテキストを出すだけなので注意(バイナリエディタに突っ込む等が必要)<br>
誤り検出はしていないので注意(誤り検出されないために作ったので)

正確に変換できているかは保証できませんのでご了承ください。変換された文字列は自己責任でご利用ください。


### 雑記とか仕様っぽいものとか
なんでこんなもの作ったかというと、一部文字が不明な(=誤り検出されると弾かれる)BinHexのテキストからファイルを復元したかったからです。

ちなみに
* 1行目に"(This file must be converted with BinHex 4.0)"が無くてもよい(あるなら正確にこれである必要有)
* 2行目以降に"(This file must be converted with BinHex 4.0)"があってもそれ以前を無視とかせずエラーにしてしまう
* データ部分の前後に:がついていてもいなくても、どちらか一方だけでも良い
* 別に1行が64文字でなくてもよい

というように雑に処理しているのでRFC1741のAppendix Aに多少反していても変換するのでBinHex形式"っぽい"としています。

BinHex形式で使える以下の文字以外が1行目の"(This file must be converted with BinHex 4.0)"とデータ部分前後の":"以外の場所にあると00を出すようにしているため、その場合は誤りがないか確認してみてください。
* !"#$%&'()*+,-012345689@ABCDEFGHIJKLMNPQRSTUVXYZ[`abcdefhijklmpqr

データ部分("(This file must be converted with BinHex 4.0)"とデータ部分前後の":"及び改行以外)の文字数が4の倍数でない場合には、余りの部分に対応する部分は出力されないのでご注意ください。

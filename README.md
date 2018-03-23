# REON-4213.Script #

この文書は書きかけです

このスクリプトは、人工言語"REON-4213.11" をリスペクトして作成されたスクリプトエンジンです。

###REON-4213.11とは###
[REON4213.11 - PukiWiki](http://www.genomirai.com/WorldSettingDocument/index.php?REON4213.11) をご覧ください。

##このスクリプトエンジンの仕様##
本来のREON-4213.11と似ていますが、下記の点が異なります。 

* 1行1構文です。改行は使用できません
* QuelI -> EX[実行コマンド] <- {オプション1 & オプション2 & ... } -> {実行先} の形式です

###QuelI###

* スクリプトエンジンのシグネチャとして使用しています。
* 大文字で表すと "QUELI" です。全部小文字でも大文字でも判定しますが。
* ぶっちゃけ雰囲気出すためのアレ

###実行コマンド###

* -> の後に EX[ ] で囲んで実行するコマンドを書きます。
* 実行先が{CMD}の場合はCMD.EXEで実行されるコマンドを書きます（例：EX[ipconfig]）（※１）
* 実行先が{REG}の場合は、書き込むレジストリのキーを書きます。（例：EX["HKCU\Software\Microsoft\Internet Explorer\Main"]）（※１）
{}
###オプション###

* <- の後に{ } で囲みます。オプション間は & で区切ります。
* 実行先が{CMD}の場合はコマンドオプションを書きます（例：{"/all"}）（※１）
* 実行先が{REG}の場合は、書き込み値とデータを書きます。（例：{"Start Page" & SZ::"http://www.yahoo.co.jp"}）（※１）

（※１）文字列にスペースを含む場合は、"" で囲む必要があります。

###実行先が{REG}の場合のオプションの書き方

* オプションの順番は{名前 & データ}です
* 名前はキーに対する名前を、データには データ型::データ の形で記述します。

####レジストリのデータ型について####

REON-4213.Scriptでのレジストリアクセスの際のデータ型の一覧を以下に示します

REON-4213.Scriptでの記法|実際のレジストリデータ型|備考
------|---------|-----
SZ|REG_SZ|実装済
DW|REG_DWORD|実装済
BI|REG_BINARY|未実装
MZ|REG_MULTI_SZ|未実装
EZ|REG_EXPAND_SZ|未実装

###実行先###
* {CMD} … コマンドプロンプトを介して実行されます
* {REG} … レジストリに対して実行されます

##使い方##
起動すると上下２つのペインがあります。上部のペインにスクリプトを入力し、メニューバーのデバッグ→実行(F5)で実行されます。
下のペインには、デバッグ情報と実行毛化が表示されます。現状はIDE（Windows Form内での実行のみとなります）
将来的にはDLL部分のみに独立してのライブラリ化を考えています。


### How do I get set up? ###

* Summary of set up
Visual Studio 2015 Community w/ VB.NET
* Configuration
* 依存コンポーネント  
Nlog, Nlog.Windows.forms
* Deployment instructions

### Contribution guidelines ###

* Writing tests
テストなんて無い（書きたいけど書き方知らないのが本音）
* Code review
それっぽく
* Other guidelines

### Who do I talk to? ###

* Repo owner or admin
* Other community or team contact
# [EST] English Slide Translation
Zoomなどを用いたオンラインの国際会議において，画面共有で表示されているスライドのキャプション・翻訳を行うソフト．  
一部の処理に[Google Cloud Vision](https://cloud.google.com/vision/)と[DeepL](https://www.deepl.com/)を用いています．

## 動作イメージ
* 開発中

## 環境
* Windows10
* [.NET Framework 4.8](https://dotnet.microsoft.com/download/dotnet-framework/net48)
* インターネット接続環境

その他，ソフトウェアの実行に`GCPサービスアカウントキー`と`DeepL API key`が必要です．  
また，これらのキー類の発行に必要なアカウントを登録する際には，身元確認の為`クレジットカード`が必要です．  

## インストール・設定
### ソフトウェアのインストール
1. （未インストールの場合）[.NET Framework 4.8](https://dotnet.microsoft.com/download/dotnet-framework/net48) をインストールする．
1. [GitHub Releases](https://github.com/penguin-syan/English_slide_translation/releases)より，インストーラーをダウンロードする．
1. ダウンロードしたインストーラーを実行し，ソフトウェアをインストールする．

### 初期設定
1. DeepL API 認証キーを取得．
   1. [DeepL API](https://www.deepl.com/pro-api)にアクセスし，`DeepL API Free`のアカウントを作成する．
   1. `アカウント情報`を確認し，`DeepL APIで使用する認証キー`を取得する．
1. Google Cloud Visionの認証キーを取得する．
   1. Google Cloud Consoleの[APIライブラリ](https://console.cloud.google.com/project/_/apis/library)にアクセスし，ログインする．
   1. `プロジェクトを作成`をクリックし，新規プロジェクトを作成する．  
   この時，`プロジェクト名`は`任意`に決定することができる．
   1. （自動で選択されなければ）作成したプロジェクトを選択する．
   1. `Cloud Vision API`を検索・選択し，`有効`にする．
   1. `ナビゲーションメニュー`（左上の≡）を開き，`IAMと管理`，`サービスアカウント`の順に選択する．
   1. `サービスアカウントの作成`をクリックし，サービスアカウントを作成する．
      * `サービスアカウント名`は`任意`の名称を定めることができる．
      * プロジェクトへのアクセスを許可する`ロール`には，`クイックアクセス`>`基本`の中にある`参照者`を設定する．
   1. 作成したサービスアカウントの横にある`操作（⁝）`から`鍵を管理`を開き，

### ソフトウェアの更新

### ソフトウェアのアンインストール

## 使い方
* 開発中

## ライセンス
* Copyright (c) 2021 [penguin_syan](https://github.com/penguin-syan)  
* Released under the MIT license.  
see [https://opensource.org/licenses/MIT](https://en.wikipedia.org/wiki/MIT_License).

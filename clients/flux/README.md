# atom-babel-react-starter
windows で、atom editor を使って babel, react を利用する際のテンプレート

# Getting Start
`> npm i`

`> npm start`

# npm run scripts
## `> npm start`
- [Webpack Dev Server] http://localhost:3000 起動。
- [Proxy] /api/ へのリクエストは、 http://localhost:24273/api/ を呼び出す。
- lint (eslint)
- [Hot Module Replacement] src ファイルが更新されたらブラウザも更新。

## `> npm run build`
- dist/ ディレクトリへ、ビルドしたスクリプトを配置。

## `> npm run clean`
- dist/ ディレクトリクリア。

# eslint
[rackt/eslint-config-rackt](https://github.com/rackt/eslint-config-rackt)
 参考。

## atom で lint する apm
- `> amp install linter`
- `> amp install linter-eslint`

# editorconfig
[redux/.editorconfig at master · rackt/redux](https://github.com/rackt/redux/blob/master/.editorconfig) 参考。

## atom で editorconfig を有効にする apm
- `> amp install editorconfig`

# atom 上で Babel ES6 javascript を実行する
ファイルフォーマットを、Babel ES6 Javascript にして実行。  
Terminal から atom を起動しないと結果が出力されないことがある？

## apm
- `> apm install script`  
atom 上でスクリプトを実行するのに使用。
- `> apm install language-babel`  
Babel ES6 Javascript のフォーマットを追加。

## global npm
- `> npm i -g babel-cli`  
babel-node を global で使えるようにする。  
※ `> npm i -D babel-cli` だと babel-node がみつからない。

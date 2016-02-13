cd %~dp0
pandoc -s -i -t revealjs -V theme=black Document.md -o Document.html
rem pandoc -D revealjs > template/template.revealjs

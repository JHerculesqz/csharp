cd %~dp0
pandoc -s -i -t revealjs -V theme=black %~dp0Document.md -o %~dp0Document.html
rem pandoc -D revealjs > template/template.revealjs

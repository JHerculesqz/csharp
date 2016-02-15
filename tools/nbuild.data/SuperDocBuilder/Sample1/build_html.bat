cd %~dp0
pandoc -s --mathml -i -t dzslides -c %~dp0gertiejs/css/theme2.css %~dp0Document.md -o %~dp0Document.html
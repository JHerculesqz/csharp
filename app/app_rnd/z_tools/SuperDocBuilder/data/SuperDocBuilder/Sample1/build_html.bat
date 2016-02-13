cd %~dp0
pandoc -s --mathml -i -t dzslides -c gertiejs/css/theme2.css Document.md -o Document.html
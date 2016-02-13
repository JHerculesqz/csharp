rem 1.打zip(%1:DirPathSolution,%2:PrjName,%3:DirPathPrj)
set FILE_PATH_7z=%1tools\7z32\7z.exe
set FILE_PATH_zip=%3%2.zip
set DIR_PATH_debug=%3bin\Debug\*
%FILE_PATH_7z% a %FILE_PATH_zip% %DIR_PATH_debug%

rem 2.modify xml
set FILE_PATH_XML_SRC=%3updateInfo.xml
set FILE_PATH_XML_DST=%3updateInfo_%2.xml
xcopy %FILE_PATH_XML_SRC% %FILE_PATH_XML_DST%* /y

rem 3.xcopy
set DIR_PATH_url=C:\1.Monkey\1.Research\1.Tools\SuperTools
set FILE_PATH_zip_url=%DIR_PATH_url%\%2.zip*
set FILE_PATH_xml_url=%DIR_PATH_url%\updateInfo_%2.xml*
xcopy %FILE_PATH_zip% %FILE_PATH_zip_url% /y
xcopy %FILE_PATH_XML_DST% %FILE_PATH_xml_url% /y

rem 4.del
del %FILE_PATH_zip% /q /s
del %FILE_PATH_XML_DST% /q /s

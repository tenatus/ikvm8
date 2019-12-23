call nant signed
copy bin\* C:\Engineering\RC.Net\APIs\IKVM.WINDWARD.8.5.0.3\lib
copy bin\* C:\Engineering\Binaries\Debug

cd \GitHub\tabula-java\scripts
call BuildTabula.IKVM.cmd
copy ..\target\Tabula.IKVM.* C:\Engineering\RC.Net\APIs\Tabula.IKVM\target

cd \GitHub\OpenNLP.IKVM\OpenNLP.IKVM\OpenNLP.IKVM\Scripts
call BuildOpenNLP.IKVM.cmd
copy ..\Lib\OpenNLP.IKVM.exe C:\Engineering\RC.Net\APIs\OpenNLP.IKVM.1.8.1\lib

cd \GitHub\ikvm8

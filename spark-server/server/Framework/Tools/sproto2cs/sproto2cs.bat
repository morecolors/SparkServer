@REM author:Manistein
@REM since:2019.04.26
@REM desc:dump sproto 2 cs

set RPCProtoCS=%~dp0..\\..\\Resource\\RPCProtoCS\\
set RPCProtoSchema=%~dp0..\\..\\Resource\\RPCProtoSchema\\

set WorkingPath=.\\lib\\
pushd %WorkingPath%

lua.exe ..\\sproto2cs.lua %RPCProtoSchema% %RPCProtoCS%

pause
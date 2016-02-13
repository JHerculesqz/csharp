####Debug
C:\1.Monkey\1.Research\4.SCMGit\csharp\app\app_rnd\z_tools\SuperRndTemplate\bin\Debug\SuperRndTemplate.exe http://localhost:9999/updateInfo_SuperRndTemplate.xml

####Use
前置条件0.按照walle.update/walle.update.utils/build目录建立工程
前置条件1.Build Pre Event
$(SolutionDir)build\buildWalleUpdate.bat $(SolutionDir) $(ProjectDir)
前置条件2.Build After Event
$(SolutionDir)build\publishWalleUpdate.bat $(SolutionDir) $(ProjectName) $(ProjectDir)
前置条件3.建立updateInfo.xml
STEP1.修改updateInfo.xml
STEP2.修改Properties->Application->Assembly Information->File Version
STEP3.编译Project

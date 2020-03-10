set msBuildDir=C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\MSBuild\Current\Bin
rem set MSBuildSDKsPath=C:\Program Files (x86)\dotnet\shared\Microsoft.AspNetCore.App\3.1.1
set logFile=build/MSBuild_ReleaseVersion_LOG.log

echo "clean resource"
if not exist "build" mkdir build
if exist %logFile% del %logFile%
echo "build"
call "%msBuildDir%\msbuild.exe"  TestAutomationFramework.sln /p:Configuration=Release /l:FileLogger,Microsoft.Build.Engine;logfile=build/MSBuild_ReleaseVersion_LOG.log

rem The assemblies under test have to be an absolute path, which is annoying
rem  and means you will need to make sure they are correct if using this file
rem  locally
rem Normally I just run GenerateCodeFromExcelTest directly from visual studio
rem  when developing, instead of using this script
rem This file is used during the appveyor build, so the paths need to work there
"..\packages\customertestsexcel\2.0.0\tools\GenerateCodeFromExcelTest\GenerateCodeFromExcelTest.exe" /folder "..\SampleTests" /namespace SampleTests /usings "SampleSystemUnderTest SampleSystemUnderTest.AnovaCalculator SampleSystemUnderTest.Routing SampleSystemUnderTest.VermeulenNearWakeLength SampleSystemUnderTest.Calculator SampleSystemUnderTest.CustomProperties SampleSystemUnderTest.Misc" /assertionClassPrefix "I" /assembliesUnderTest "C:\Users\cburge\Documents\repos\customer-tests-excel-scaffolding\SampleSystemUnderTest\obj\Debug\SampleSystemUnderTest.dll"
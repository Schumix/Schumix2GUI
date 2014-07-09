#!/bin/bash

xbuild /p:Configuration="Debug" Schumix.GUI/Schumix.GUI.sln /flp:LogFile=xbuild.log;Verbosity=Detailed

#cd Run/Tests/Debug
#nunit-console Test.dll

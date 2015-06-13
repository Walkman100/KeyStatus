@echo off

    color 0A
    title Compiling KeyStatus...
    cd %~dp0

echo Starting MSBuild compile for KeyStatus...
    rem Run the MSBuild command
        "%ProgramFiles%\MSBuild\12.0\bin\msbuild.exe" /property:Configuration=Release "KeyStatus.sln"
        echo.

    rem If it doesn't fail, go to next step
        if Not ERRORLEVEL==1 goto nsis

    echo MSBuild command failed, trying again in 32-bit program files folder...
        "%ProgramFiles(x86)%\MSBuild\12.0\bin\msbuild.exe" /property:Configuration=Release "KeyStatus.sln"
        echo.

        if Not ERRORLEVEL==1 goto nsis

    echo MSBuild-32 command failed, trying again in 64-bit program files folder...
        "%ProgramW6432%\MSBuild\12.0\bin\msbuild.exe" /property:Configuration=Release "KeyStatus.sln"
        echo.

        if Not ERRORLEVEL==1 goto nsis

    color 0C
        echo MSBuild Commands Failed!
        pause
        goto eof

:nsis

    echo Starting MakeNSIS Installer script for %~1...
    rem Run the MakeNSIS command
        "%ProgramFiles%\NSIS\makensis.exe" "NSIS Installer for KeyStatus.nsi"
        echo.

    rem If it doesn't fail, go to next step
        if Not ERRORLEVEL==1 goto rar

    echo MakeNSIS command failed, trying again in 32-bit program files folder...
        "%ProgramFiles(x86)%\NSIS\makensis.exe" "NSIS Installer for KeyStatus.nsi"
        echo.

        if Not ERRORLEVEL==1 goto rar

    echo MakeNSIS-32 command failed, trying again in 64-bit program files folder...
        "%ProgramW6432%\NSIS\makensis.exe" "NSIS Installer for KeyStatus.nsi"
        echo.

        if Not ERRORLEVEL==1 goto rar

    color 0C
        echo MakeNSIS Commands Failed!
        pause
        goto eof

:rar

echo RARing portable release with WinRAR...
    rem Run the WinRAR command
        "%ProgramFiles%\WinRAR\WinRAR.exe" a -ep1 -scul -r0 -iext -- bin\Release\GitUpdater-Portable.rar bin\Release\GitUpdater.exe bin\Release\GitUpdater.bat bin\Release\OpenRepoInBash.bat bin\Release\OpenRepoInPS.bat bin\Release\PS
        echo.

    rem If it doesn't fail, go to next step
        if Not ERRORLEVEL==1 goto done

    echo WinRAR command failed, trying again in 32-bit program files folder...
        "%ProgramFiles(x86)%\WinRAR\WinRAR.exe" a -ep1 -scul -r0 -iext -- bin\Release\GitUpdater-Portable.rar bin\Release\GitUpdater.exe bin\Release\GitUpdater.bat bin\Release\OpenRepoInBash.bat bin\Release\OpenRepoInPS.bat bin\Release\PS
        echo.

        if Not ERRORLEVEL==1 goto done

    echo WinRAR-32 command failed, trying again in 64-bit program files folder...
        "%ProgramW6432%\WinRAR\WinRAR.exe" a -ep1 -scul -r0 -iext -- bin\Release\GitUpdater-Portable.rar bin\Release\GitUpdater.exe bin\Release\GitUpdater.bat bin\Release\OpenRepoInBash.bat bin\Release\OpenRepoInPS.bat bin\Release\PS
        echo.

        if Not ERRORLEVEL==1 goto done

    color 0C
        echo WinRAR RAR Commands Failed!
        pause
        goto eof

:openOutputDir
    echo RARing portable release with WinRAR done.
    echo launching Explorer...
        explorer.exe "bin\Release"
        timeout /t 5
@echo off

    color 0A
    title Compiling KeyStatus...
    cd %~dp0

echo Starting MSBuild compile for KeyStatus...
    rem Run the MSBuild command
        "%ProgramFiles%\MSBuild\12.0\bin\msbuild.exe" /property:Configuration=Release "KeyStatus.sln"
        echo.

    rem If it doesn't fail, go to next step
        if Not ERRORLEVEL==1 goto ahk

    echo MSBuild command failed, trying again in 32-bit program files folder...
        "%ProgramFiles(x86)%\MSBuild\12.0\bin\msbuild.exe" /property:Configuration=Release "KeyStatus.sln"
        echo.

        if Not ERRORLEVEL==1 goto ahk

    echo MSBuild-32 command failed, trying again in 64-bit program files folder...
        "%ProgramW6432%\MSBuild\12.0\bin\msbuild.exe" /property:Configuration=Release "KeyStatus.sln"
        echo.

        if Not ERRORLEVEL==1 goto ahk

    color 0C
        echo MSBuild Commands Failed!
        pause
        goto eof

:ahk
    echo Compiling AHK scripts...
    rem Run the Ahk2Exe command
        "%ProgramFiles%\AutoHotkey\Compiler\Ahk2Exe" /in "%~dp0\toggleNumLock.ahk" /out "%~dp0\bin\Release\toggleNumLock.exe"
        echo.
        
    rem If it doesn't fail, go to next step
        if Not ERRORLEVEL==1 goto ahk2-orig
        
    echo Ahk2Exe command failed, trying again in 32-bit program files folder...
        "%ProgramFiles(x86)%\AutoHotkey\Compiler\Ahk2Exe" /in "%~dp0\toggleNumLock.ahk" /out "%~dp0\bin\Release\toggleNumLock.exe"
        echo.

        if Not ERRORLEVEL==1 goto ahk2-32

    echo Ahk2Exe-32 command failed, trying again in 64-bit program files folder...
        "%ProgramW6432%\AutoHotkey\Compiler\Ahk2Exe" /in "%~dp0\toggleNumLock.ahk" /out "%~dp0\bin\Release\toggleNumLock.exe"
        echo.

        if Not ERRORLEVEL==1 goto ahk2-64

    color 0C
        echo AHK Script compile Failed!
        pause
        goto eof

:ahk2-orig
        "%ProgramFiles%\AutoHotkey\Compiler\Ahk2Exe" /in "%~dp0\toggleCapsLock.ahk" /out "%~dp0\bin\Release\toggleCapsLock.exe"
        echo.
        
    rem If it doesn't fail, go to next step
        if Not ERRORLEVEL==1 goto ahk3-orig
        
    color 0C
        echo toggleCapsLock AHK Script compile Failed!
        pause
        goto eof

:ahk2-32
        "%ProgramFiles(x86)%\AutoHotkey\Compiler\Ahk2Exe" /in "%~dp0\toggleCapsLock.ahk" /out "%~dp0\bin\Release\toggleCapsLock.exe"
        echo.
        
    rem If it doesn't fail, go to next step
        if Not ERRORLEVEL==1 goto ahk3-32
        
    color 0C
        echo toggleCapsLock AHK Script compile-32 Failed!
        pause
        goto eof

:ahk2-64
        "%ProgramW6432%\AutoHotkey\Compiler\Ahk2Exe" /in "%~dp0\toggleCapsLock.ahk" /out "%~dp0\bin\Release\toggleCapsLock.exe"
        echo.
        
    rem If it doesn't fail, go to next step
        if Not ERRORLEVEL==1 goto ahk3-64
        
    color 0C
        echo toggleCapsLock AHK Script compile-64 Failed!
        pause
        goto eof

:ahk3-orig
        "%ProgramFiles%\AutoHotkey\Compiler\Ahk2Exe" /in "%~dp0\toggleScrollLock.ahk" /out "%~dp0\bin\Release\toggleScrollLock.exe"
        echo.
        
    rem If it doesn't fail, go to next step
        if Not ERRORLEVEL==1 goto nsis
        
    color 0C
        echo toggleScrollLock AHK Script compile Failed!
        pause
        goto eof

:ahk3-32
        "%ProgramFiles(x86)%\AutoHotkey\Compiler\Ahk2Exe" /in "%~dp0\toggleScrollLock.ahk" /out "%~dp0\bin\Release\toggleScrollLock.exe"
        echo.
        
    rem If it doesn't fail, go to next step
        if Not ERRORLEVEL==1 goto nsis
        
    color 0C
        echo toggleScrollLock AHK Script compile-32 Failed!
        pause
        goto eof

:ahk3-64
        "%ProgramW6432%\AutoHotkey\Compiler\Ahk2Exe" /in "%~dp0\toggleScrollLock.ahk" /out "%~dp0\bin\Release\toggleScrollLock.exe"
        echo.
        
    rem If it doesn't fail, go to next step
        if Not ERRORLEVEL==1 goto nsis
        
    color 0C
        echo toggleScrollLock AHK Script compile-64 Failed!
        pause
        goto eof

:nsis
    echo Starting MakeNSIS Installer script for KeyStatus...
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
        echo Press enter to continue with portable release generating...
        pause
        rem goto eof
        rem disabled since nsis commands failing only means there won't
        rem be an installer - it's not needed for the portable releases

:rar
    echo RARing portable releases with WinRAR...
    rem Run the WinRAR command
        "%ProgramFiles%\WinRAR\WinRAR.exe" a -ep1 -scul -r0 -iext -- bin\Release\KeyStatus-Portable-noAutoHotkey.rar bin\Release\KeyStatus.exe bin\Release\toggleNumLock.exe bin\Release\toggleCapsLock.exe bin\Release\toggleScrollLock.exe
        echo.

    rem If it doesn't fail, go to next step
        if Not ERRORLEVEL==1 goto rar2-orig

    echo WinRAR command failed, trying again in 32-bit program files folder...
        "%ProgramFiles(x86)%\WinRAR\WinRAR.exe" a -ep1 -scul -r0 -iext -- bin\Release\KeyStatus-Portable-noAutoHotkey.rar bin\Release\KeyStatus.exe bin\Release\toggleNumLock.exe bin\Release\toggleCapsLock.exe bin\Release\toggleScrollLock.exe
        echo.

        if Not ERRORLEVEL==1 goto rar2-32

    echo WinRAR-32 command failed, trying again in 64-bit program files folder...
        "%ProgramW6432%\WinRAR\WinRAR.exe" a -ep1 -scul -r0 -iext -- bin\Release\KeyStatus-Portable-noAutoHotkey.rar bin\Release\KeyStatus.exe bin\Release\toggleNumLock.exe bin\Release\toggleCapsLock.exe bin\Release\toggleScrollLock.exe
        echo.

        if Not ERRORLEVEL==1 goto rar2-64

    color 0C
        echo WinRAR RAR Commands Failed!
        echo Press enter to continue with portable release generating...
        pause
        goto openOutputDir

:rar2-orig
    echo RARing portable releases with WinRAR...
    rem Run the WinRAR command
        "%ProgramFiles%\WinRAR\WinRAR.exe" a -ep1 -scul -r0 -iext -- bin\Release\KeyStatus-Portable-requiresAutoHotkey.rar bin\Release\KeyStatus.exe bin\Release\toggleNumLock.exe bin\Release\toggleCapsLock.exe bin\Release\toggleScrollLock.exe
        echo.

    rem If it doesn't fail, go to next step
        if Not ERRORLEVEL==1 goto openOutputDir

    color 0C
        echo WinRAR RAR-2 Command Failed!
        echo Press enter to continue with portable release generating...
        pause
        goto openOutputDir

:rar2-32
    echo RARing portable releases with WinRAR...
    rem Run the WinRAR command
        "%ProgramFiles(x86)%\WinRAR\WinRAR.exe" a -ep1 -scul -r0 -iext -- bin\Release\KeyStatus-Portable-requiresAutoHotkey.rar bin\Release\KeyStatus.exe bin\Release\toggleNumLock.exe bin\Release\toggleCapsLock.exe bin\Release\toggleScrollLock.exe
        echo.

    rem If it doesn't fail, go to next step
        if Not ERRORLEVEL==1 goto openOutputDir

    color 0C
        echo WinRAR RAR-2-32 Command Failed!
        echo Press enter to continue with portable release generating...
        pause
        goto openOutputDir

:rar2-64
    echo RARing portable releases with WinRAR...
    rem Run the WinRAR command
        "%ProgramW6432%\WinRAR\WinRAR.exe" a -ep1 -scul -r0 -iext -- bin\Release\KeyStatus-Portable-requiresAutoHotkey.rar bin\Release\KeyStatus.exe bin\Release\toggleNumLock.exe bin\Release\toggleCapsLock.exe bin\Release\toggleScrollLock.exe
        echo.

    rem If it doesn't fail, go to next step
        if Not ERRORLEVEL==1 goto openOutputDir

    color 0C
        echo WinRAR RAR-2-64 Command Failed!
        echo Press enter to continue with portable release generating...
        pause

:openOutputDir
    echo RARing portable release with WinRAR done.
    rem Delete previous portable executable, rename new one to portable
        del "bin\Release\KeyStatus-Portable-noDisableLock.exe"
        ren "bin\Release\KeyStatus.exe" KeyStatus-Portable-noDisableLock.exe
    echo launching Explorer...
        explorer.exe "bin\Release"
        timeout /t 5

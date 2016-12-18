@echo off

    set defaultColor=0A
    color %defaultColor%
    title Compiling KeyStatus...
    cd %~dp0

:MSBuild
    echo ==== Starting MSBuild compile for KeyStatus ====
    "%WinDir%\Microsoft.NET\Framework\v4.0.30319\msbuild.exe" /property:Configuration=Release "KeyStatus.sln"

if Not ERRORLEVEL==1 goto ahk

    echo MSBuild command failed, trying again in v3.5...
    "%WinDir%\Microsoft.NET\Framework\v3.5\msbuild.exe" /property:Configuration=Release "KeyStatus.sln"

if Not ERRORLEVEL==1 goto ahk

    echo MSBuild_v3.5 command failed, trying again in v3.0...
    "%WinDir%\Microsoft.NET\Framework\v3.0\msbuild.exe" /property:Configuration=Release "KeyStatus.sln"

if Not ERRORLEVEL==1 goto ahk

    color 0C
        echo ==== MSBuild Commands Failed! ====
        pause
        goto eof

:ahk
    echo ==== MSBuild Done ====
    echo.
    echo ==== Compiling AHK scripts ===
    "%ProgramFiles%\AutoHotkey\Compiler\Ahk2Exe" /in "%~dp0\toggleNumLock.ahk" /out "%~dp0\bin\Release\toggleNumLock.exe"

if Not ERRORLEVEL==1 goto ahk2-orig

    echo Ahk2Exe command failed, trying again in 32-bit program files folder...
    "%ProgramFiles(x86)%\AutoHotkey\Compiler\Ahk2Exe" /in "%~dp0\toggleNumLock.ahk" /out "%~dp0\bin\Release\toggleNumLock.exe"

if Not ERRORLEVEL==1 goto ahk2-32

    echo Ahk2Exe-32 command failed, trying again in 64-bit program files folder...
    "%ProgramW6432%\AutoHotkey\Compiler\Ahk2Exe" /in "%~dp0\toggleNumLock.ahk" /out "%~dp0\bin\Release\toggleNumLock.exe"

if Not ERRORLEVEL==1 goto ahk2-64

    color 0C
        echo ==== AHK Script compile Failed! ====
        pause
        goto eof

:ahk2-orig
    "%ProgramFiles%\AutoHotkey\Compiler\Ahk2Exe" /in "%~dp0\toggleCapsLock.ahk" /out "%~dp0\bin\Release\toggleCapsLock.exe"

if Not ERRORLEVEL==1 goto ahk3-orig

    color 0C
        echo toggleCapsLock AHK Script compile Failed!
        pause
        goto eof

:ahk2-32
    "%ProgramFiles(x86)%\AutoHotkey\Compiler\Ahk2Exe" /in "%~dp0\toggleCapsLock.ahk" /out "%~dp0\bin\Release\toggleCapsLock.exe"

if Not ERRORLEVEL==1 goto ahk3-32

    color 0C
        echo toggleCapsLock AHK Script compile-32 Failed!
        pause
        goto eof

:ahk2-64
    "%ProgramW6432%\AutoHotkey\Compiler\Ahk2Exe" /in "%~dp0\toggleCapsLock.ahk" /out "%~dp0\bin\Release\toggleCapsLock.exe"

if Not ERRORLEVEL==1 goto ahk3-64

    color 0C
        echo toggleCapsLock AHK Script compile-64 Failed!
        pause
        goto eof

:ahk3-orig
    "%ProgramFiles%\AutoHotkey\Compiler\Ahk2Exe" /in "%~dp0\toggleScrollLock.ahk" /out "%~dp0\bin\Release\toggleScrollLock.exe"

if Not ERRORLEVEL==1 goto PortableCert

    color 0C
        echo toggleScrollLock AHK Script compile Failed!
        pause
        goto eof

:ahk3-32
    "%ProgramFiles(x86)%\AutoHotkey\Compiler\Ahk2Exe" /in "%~dp0\toggleScrollLock.ahk" /out "%~dp0\bin\Release\toggleScrollLock.exe"

if Not ERRORLEVEL==1 goto PortableCert

    color 0C
        echo toggleScrollLock AHK Script compile-32 Failed!
        pause
        goto eof

:ahk3-64
    "%ProgramW6432%\AutoHotkey\Compiler\Ahk2Exe" /in "%~dp0\toggleScrollLock.ahk" /out "%~dp0\bin\Release\toggleScrollLock.exe"

if Not ERRORLEVEL==1 goto PortableCert

    color 0C
        echo toggleScrollLock AHK Script compile-64 Failed!
        pause
        goto eof

:PortableCert
    echo ==== Compiling AHK Scripts Done ====
    echo.
    echo ==== Signing KeyStatus.exe ====
        echo %~dp0..\WinCompile\WalkmanOSS.cer
        echo %~dp0..\WinCompile\WalkmanOSS.pvk
        echo https://github.com/Walkman100/KeyStatus
        echo http://timestamp.verisign.com/scripts/timstamp.dll
    %~dp0..\WinCompile\signtool signwizard "%~dp0bin\Release\KeyStatus.exe"

if Not ERRORLEVEL==1 goto PortableCertDone

    echo ==== Signing KeyStatus.exe Failed! ====
    echo.
        goto NSIS

:PortableCertDone
    echo ==== Signing KeyStatus.exe done ====
    echo.

:NSIS
    echo ==== Starting MakeNSIS Installer script for KeyStatus ====
    "%ProgramFiles%\NSIS\makensis.exe" "NSIS Installer for KeyStatus.nsi"

if Not ERRORLEVEL==1 goto InstallerCert

    echo MakeNSIS command failed, trying again in 32-bit program files folder...
    "%ProgramFiles(x86)%\NSIS\makensis.exe" "NSIS Installer for KeyStatus.nsi"

if Not ERRORLEVEL==1 goto InstallerCert

    echo MakeNSIS-32 command failed, trying again in 64-bit program files folder...
    "%ProgramW6432%\NSIS\makensis.exe" "NSIS Installer for KeyStatus.nsi"

if Not ERRORLEVEL==1 goto InstallerCert

    color 0C
    echo ==== MakeNSIS Commands Failed! ====
    echo.
        echo Press enter to continue with portable release generating...
        pause
        color %defaultColor%

:InstallerCert
    echo ==== MakeNSIS Script done ====
    echo.
    echo ==== Signing KeyStatus-Installer.exe ====
        echo %~dp0..\WinCompile\WalkmanOSS.cer
        echo %~dp0..\WinCompile\WalkmanOSS.pvk
        echo https://github.com/Walkman100/KeyStatus
        echo http://timestamp.verisign.com/scripts/timstamp.dll
    %~dp0..\WinCompile\signtool signwizard "%~dp0bin\Release\KeyStatus-Installer.exe"

if Not ERRORLEVEL==1 goto InstallerCertDone

    echo ==== Signing KeyStatus-Installer.exe Failed! ====
    echo.
        goto rar

:InstallerCertDone
    echo ==== Signing KeyStatus-Installer.exe done ====
    echo.

:rar
    echo ==== RARing portable releases with WinRAR ====
    rem remove previous archives, as WinRar tries to merge them
        del "bin\Release\KeyStatus-Portable-noAutoHotkey.rar"
        del "bin\Release\KeyStatus-Portable-requiresAutoHotkey.rar"

    "%ProgramFiles%\WinRAR\WinRAR.exe" a -ep1 -scul -r0 -iext -- bin\Release\KeyStatus-Portable-noAutoHotkey.rar bin\Release\KeyStatus.exe bin\Release\toggleNumLock.exe bin\Release\toggleCapsLock.exe bin\Release\toggleScrollLock.exe
        echo.

if Not ERRORLEVEL==1 goto rar2-orig

    echo WinRAR command failed, trying again in 32-bit program files folder...
    "%ProgramFiles(x86)%\WinRAR\WinRAR.exe" a -ep1 -scul -r0 -iext -- bin\Release\KeyStatus-Portable-noAutoHotkey.rar bin\Release\KeyStatus.exe bin\Release\toggleNumLock.exe bin\Release\toggleCapsLock.exe bin\Release\toggleScrollLock.exe

if Not ERRORLEVEL==1 goto rar2-32

    echo WinRAR-32 command failed, trying again in 64-bit program files folder...
    "%ProgramW6432%\WinRAR\WinRAR.exe" a -ep1 -scul -r0 -iext -- bin\Release\KeyStatus-Portable-noAutoHotkey.rar bin\Release\KeyStatus.exe bin\Release\toggleNumLock.exe bin\Release\toggleCapsLock.exe bin\Release\toggleScrollLock.exe

if Not ERRORLEVEL==1 goto rar2-64

    color 0C
    echo ==== WinRAR RAR Commands Failed! ====
    echo.
        echo Press enter to continue with portable release generating...
        pause
        goto openOutputDir

:rar2-orig
    "%ProgramFiles%\WinRAR\WinRAR.exe" a -ep1 -scul -r0 -iext -- bin\Release\KeyStatus-Portable-requiresAutoHotkey.rar bin\Release\KeyStatus.exe toggleCapsLock.ahk toggleNumLock.ahk toggleScrollLock.ahk

if Not ERRORLEVEL==1 goto openOutputDir

    color 0C
    echo ==== WinRAR RAR-2 Command Failed! ====
    echo.
        echo Press enter to continue with portable release generating...
        pause
        goto openOutputDir

:rar2-32
    "%ProgramFiles(x86)%\WinRAR\WinRAR.exe" a -ep1 -scul -r0 -iext -- bin\Release\KeyStatus-Portable-requiresAutoHotkey.rar bin\Release\KeyStatus.exe toggleCapsLock.ahk toggleNumLock.ahk toggleScrollLock.ahk

if Not ERRORLEVEL==1 goto openOutputDir

    color 0C
    echo ==== WinRAR RAR-2-32 Command Failed! ====
    echo.
        echo Press enter to continue with portable release generating...
        pause
        goto openOutputDir

:rar2-64
    "%ProgramW6432%\WinRAR\WinRAR.exe" a -ep1 -scul -r0 -iext -- bin\Release\KeyStatus-Portable-requiresAutoHotkey.rar bin\Release\KeyStatus.exe toggleCapsLock.ahk toggleNumLock.ahk toggleScrollLock.ahk

if Not ERRORLEVEL==1 goto openOutputDir

    color 0C
    echo ==== WinRAR RAR-2-64 Command Failed! ====
    echo.
        echo Press enter to continue with portable release generating...
        pause

:openOutputDir
    echo ==== RARing portable releases with WinRAR done ====
    rem Delete previous portable executable, rename new one to portable
        del "bin\Release\KeyStatus-Portable-noDisableLock.exe"
        ren "bin\Release\KeyStatus.exe" KeyStatus-Portable-noDisableLock.exe
    echo.
    echo ==== Launching Explorer ====
    @echo on
        explorer.exe "bin\Release"
    @echo off
        timeout /t 5

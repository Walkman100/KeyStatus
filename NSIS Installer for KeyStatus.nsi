; KeyStatus Installer NSIS Script
; get NSIS at http://nsis.sourceforge.net/Download
; As a program that all Power PC users should have, Notepad++ is recommended to edit this file

Icon "My Project\1371918331_keyboard.ico"
Caption "KeyStatus Installer"
Name "KeyStatus"
AutoCloseWindow true
ShowInstDetails show

LicenseBkColor /windows
LicenseData "LICENSE.md"
LicenseText "Please acknowledge the license below before installing KeyStatus."

InstallDir $PROGRAMFILES\WalkmanOSS

OutFile "bin\Release\KeyStatus-Installer.exe"

; Pages

Page license
Page components
Page directory
Page instfiles
UninstPage uninstConfirm
UninstPage instfiles

; Sections

Section "KeyStatus Executable & Uninstaller"
  SectionIn RO
  SetOutPath $INSTDIR
  File "bin\Release\KeyStatus.exe"
  WriteUninstaller "KeyStatus-Uninst.exe"
SectionEnd

Section "AHK Scripts (if you have AutoHotkey installed)"
  SetOutPath $INSTDIR
  File "toggleCapsLock.ahk"
  File "toggleNumLock.ahk"
  File "toggleScrollLock.ahk"
SectionEnd

Section "AHK Scripts converted to exe (if you don't have AutoHotkey installed)"
  SetOutPath $INSTDIR
  File "bin\Release\toggleNumLock.exe"
  File "bin\Release\toggleCapsLock.exe"
  File "bin\Release\toggleScrollLock.exe"
SectionEnd

Section "KeyStatus Start Menu Shortcuts"
  CreateDirectory "$SMPROGRAMS\WalkmanOSS"
  CreateShortCut "$SMPROGRAMS\WalkmanOSS\KeyStatus.lnk" "$INSTDIR\KeyStatus.exe" "" "$INSTDIR\KeyStatus.exe" "" "" "" "KeyStatus"
  CreateShortCut "$SMPROGRAMS\WalkmanOSS\Uninstall KeyStatus.lnk" "$INSTDIR\KeyStatus-Uninst.exe" "" "" "" "" "" "Uninstall KeyStatus"
  ;Syntax for CreateShortCut: link.lnk target.file [parameters [icon.file [icon_index_number [start_options [keyboard_shortcut [description]]]]]]
SectionEnd

Section "KeyStatus Desktop Shortcut"
  CreateShortCut "$DESKTOP\KeyStatus.lnk" "$INSTDIR\KeyStatus.exe" "" "$INSTDIR\KeyStatus.exe" "" "" "" "KeyStatus"
SectionEnd

Section "KeyStatus Quick Launch Shortcut"
  CreateShortCut "$QUICKLAUNCH\KeyStatus.lnk" "$INSTDIR\KeyStatus.exe" "" "$INSTDIR\KeyStatus.exe" "" "" "" "KeyStatus"
SectionEnd

; Functions

Function .onInit
  MessageBox MB_YESNO "This will install KeyStatus. Do you wish to continue?" IDYES gogogo
    Abort
  gogogo:
  SetShellVarContext all
  SetAutoClose true
FunctionEnd

Function .onInstSuccess
    MessageBox MB_YESNO "Install Succeeded! Open ReadMe?" IDNO NoReadme
      ExecShell "open" "https://github.com/Walkman100/KeyStatus/blob/master/README.md#keystatus-"
    NoReadme:
FunctionEnd

; Uninstaller

Section "Uninstall"
  Delete "$INSTDIR\KeyStatus-Uninst.exe"   ; Remove Application Files
  Delete "$INSTDIR\KeyStatus.exe"
  RMDir $INSTDIR
  
  Delete "$SMPROGRAMS\WalkmanOSS\KeyStatus.lnk"   ; Remove Start Menu Shortcuts & Folder
  Delete "$SMPROGRAMS\WalkmanOSS\Uninstall KeyStatus.lnk"
  RMDir "$SMPROGRAMS\WalkmanOSS"
  
  Delete "$DESKTOP\KeyStatus.lnk"   ; Remove Desktop Shortcut
  Delete "$QUICKLAUNCH\KeyStatus.lnk"   ; Remove Quick Launch shortcut
SectionEnd

; Uninstaller Functions

Function un.onInit
    MessageBox MB_YESNO "This will uninstall KeyStatus. Continue?" IDYES NoAbort
      Abort ; causes uninstaller to quit.
    NoAbort:
    SetShellVarContext all
    SetAutoClose true
FunctionEnd

Function un.onUninstFailed
    MessageBox MB_OK "Uninstall Cancelled"
FunctionEnd

Function un.onUninstSuccess
    MessageBox MB_OK "Uninstall Completed"
FunctionEnd

# KeyStatus [![Build status](https://ci.appveyor.com/api/projects/status/9iuxa35vg8bhsscl)](https://ci.appveyor.com/project/Walkman100/KeyStatus)
A fork of [Deavmi/KeyStatus](https://github.com/Walkman-Mirror/KeyStatus) simplified, and with options to how you want key changes to be displayed

## Screenshot
[![screenshot][screenshot]][screenshot]

  [screenshot]: http://walkman100.github.io/images/Screenshots/My_Projects/KeyStatus/MainWindow.png

## Download
Get the latest version [here](https://github.com/Walkman100/KeyStatus/releases), and the latest build from commit
[here](https://ci.appveyor.com/project/Walkman100/KeyStatus/build/artifacts)
(note that these builds are built for the Debug config and so are not optimised)

## Command line arguments
CLAs are defined [here](https://github.com/Walkman100/KeyStatus/blob/master/KeyStatus.vb#L12-51).
- `Hide`: Minimises the window to tray on start
- `ShowAppIcon`: Show KeyStatus's tray icon
- `AlwaysShowIcons`: Show lock icons no matter the state (alternative is only when lock is enabled)
- `NoToggle`: Disable clicking on lock tray icons to toggle locks
- `AlwaysUseScripts`: Always use the provided scripts to toggle locks, instead of enabling them within the program
- `NoIcons`: Don't show lock tray icons
- `AllIcons`: Opposite of `NoIcons`, show all lock tray icons
- `NoPopup`: Disable popup on lock state change
- `PopupDelay=1000`: Set popup delay (in ms) to value
- `PopupLocation=2`: Set popup location option: The list in the dropdown is numbered from `0` to `10`, so `Top Right` would be `2`.
- `ShowBalloons`: Show Tray icon balloons on lock state change

To help make this info easier to understand, here is a screenshot with the args next to the option they change:

[![screenshot with args][screenshot with args]][screenshot with args]

  [screenshot with args]: http://walkman100.github.io/images/Screenshots/My_Projects/KeyStatus/MainWindowArgs.png

## Compile requirements
Before running `Compile.bat` (just double-click on it), make sure you have the following installed:

- `MSBuild` - You can either install
[Visual Studio 2013 Express for Windows Desktop](http://go.microsoft.com/?linkid=9832280&clcid=0x409)
[[ISO](http://go.microsoft.com/?linkid=9832270&clcid=0x409)]
[[All Downloads](http://www.visualstudio.com/en-us/downloads/download-visual-studio-vs#DownloadFamilies_2)]
or extract the contents of
[`MSBuild.zip`](https://github.com/Walkman100/WinCompile/raw/master/MSBuild.zip)
to `%ProgramFiles%\MSBuild`

- AutoHotkey - [Download page](http://ahkscript.org/download/)

- NSIS (Optional) - [NSIS-2.46-setup.exe](https://github.com/Walkman100/WinCompile/raw/master/NSIS-2.46-setup.exe):
Without NSIS, there won't be an installer - not needed for portable releases

- WinRAR (Optional) - [WinRAR-2.9-setup.exe](https://github.com/Walkman100/WinCompile/raw/master/WinRAR-2.9-setup.exe):
Without WinRAR, there won't be nicely packaged release files,
but the original files that would've been packaged will still be there

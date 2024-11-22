SetTitleMatchMode 2
MsgBox "1"
if (WinExist("Q240003-E.T LA CHINA(FAT) - PCM600 64-bit")) {
    WinActivate "Q240003-E.T LA CHINA(FAT) - PCM600 64-bit"
    WinMaximize "Q240003-E.T LA CHINA(FAT) - PCM600 64-bit"
    MsgBox "3"
    MouseMove 1000,500
    SendInput "^H"
    MouseClick "left"
}
if (WinExist("notepad")) {
    WinActivate "notepad"
    WinMaximize "notepad"
    MsgBox "3"
    MouseMove 1000,500
    SendInput "^H"
    MouseClick "left"
}

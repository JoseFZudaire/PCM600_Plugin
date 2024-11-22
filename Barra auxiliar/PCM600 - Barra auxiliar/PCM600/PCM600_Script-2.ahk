SetTitleMatchMode 2
if (WinExist("PCM")) {
    WinActivate "PCM"
    WinMaximize "PCM"

    mov_z := 300

    Loop 5 
    {
        MouseMove 1400,mov_z
        SendInput "^H"
        MouseMove 900,345
        MouseClick "left"
        MouseMove 1000,740
        MouseClick "left"
        Send "{Enter}"

        mov_z += 50
    }

    MouseMove 1050,330 
    MouseClick "left"
    SendInput "^M"

}







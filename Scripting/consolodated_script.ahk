#NoEnv  ; Recommended for performance and compatibility with future AutoHotkey releases.
; #Warn  ; Enable warnings to assist with detecting common errors.
SendMode Input  ; Recommended for new scripts due to its superior speed and reliability.
SetWorkingDir %A_ScriptDir%  ; Ensures a consistent starting directory.

;disables web browser nav buttons on the mouse
XButton1::Return
XButton2::Return

;makes current window be always on top when left ctl and space are pressed
^SPACE::  Winset, Alwaysontop, , A

;maps f12 to run cmd window
f12:: Run cmd

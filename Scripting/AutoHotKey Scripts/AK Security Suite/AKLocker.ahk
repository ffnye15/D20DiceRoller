; This script is designed to remove almost all common navigation key combinations. 
; The only thing it won't prevent is ctrl+alt+del. That will be taken care of via 
; sharp keys and a registry edit 
;


; Uncomment this to disable shift + right click
; +RButton::Return

;Sets scroll lock as delete
ScrollLock::Del
f1::!
; Disables ctrl+shift+esc
+^Esc::Return 

; Disables windows keys
LWin::Return
RWin::Return

; Disable Alt-Tab
!Tab::return	

; Following disables mouse clicks and clicks with special keys
RButton::Return
MButton::Return
^MButton::Return
!MButton::Return
+MButton::Return
^RButton::Return
!RButton::Return
^LButton::Return
!LButton::Return
+LButton::Return
^WheelDown::Return
^WheelUp::Return

;Disables windows key based shortucuts
#E::Return
#D::Return
#M::Return
#+M::Return
#^F::Return
#L::Return
#R::Return
#T::Return
#1::Return
#2::Return
#3::Return
#4::Return
#5::Return
#6::Return
#7::Return
#8::Return
#9::Return
#0::Return
#^1::Return
#^2::Return
#^3::Return
#^4::Return
#^5::Return
#^6::Return
#^7::Return
#^8::Return
#^9::Return
#^0::Return
#+1::Return
#+2::Return
#+3::Return
#+4::Return
#+5::Return
#+6::Return
#+7::Return
#+8::Return
#+9::Return
#+0::Return
#!1::Return
#!2::Return
#!3::Return
#!4::Return
#!5::Return
#!6::Return
#!7::Return
#!8::Return
#!9::Return
#!0::Return
#tab::Return
#+tab::Return
#^tab::Return
#^B::Return
#Space::Return
#up::Return
#down::Return
#left::Return
#right::Return
#p::Return
#g::Return
#u::Return
#x::Return


; Disables ctl/alt/shift combined with letters
^J::Return
^F1::Return
!Space::Return
^N::Return
+N::Return
!N::Return
^D::Return
+^P::Return
^P::Return
^T::Return
!D::Return
^E::Return
^Down::Return
!Enter::Return
^H::Return
^W::Return
^G::Return
^S::Return
^B::Return
^O::Return
^I::Return
+F10::Return
^+Delete::Return
^!Delete::Return
^NumpadAdd::Return
^NumpadSub::Return
^=::Return
^-::Return
!f4::Return
^f4::Return
^esc::Return
!esc::Return
+esc::Return		

; Disables special keyboard keys
Browser_Back::Return
Browser_Forward::Return
Browser_Refresh::Return
; Bowser_Stop::Return <----Win7 didn't recognize this command when I compiled the exe
Browser_Search::Return
Browser_Favorites::Return
Browser_Home::Return
Volume_Mute::Return
Volume_Down::Return
Volume_Up::Return
Media_Next::Return
Media_Prev::Return
Media_Stop::Return
Media_Play_Pause::Return
Launch_Mail::Return
Launch_Media::Return
Launch_App1::Return
Launch_App2::Return
AppsKey::Return
Sleep::Return

; Disables all F Keys
F1::Return
F2::Return
F3::Return
F4::Return
F5::Return
F6::Return
F7::Return
F8::Return
F9::Return
F10::Return
F11::Return
F12::Return
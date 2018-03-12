kind of a shotgun approach, disables known interface names, then reenables them.

.bat files don't normally run as admin, so the shortcut is set to run as admin without triggering UAC.

Use for situations where netowrking needs to be reset, but you won't be able to turn it back on (ie remotely)

if you need more interfaces, run in cmd
	netsh interface show interface
make sure you set them to reenable, or else you'll be properly screwed.

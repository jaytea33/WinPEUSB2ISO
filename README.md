# WinPE USB to ISO Converter
Let's say you have a WinPE USB or Windows 10 installer USB and wish to create an ISO from it. Maybe you want to boot the ISO in a virtual machine or burn it to
optical media. You can do this by leveraging Microsoft's "oscdimg.exe" tool, which is included in Microsoft's Windows 10 ADK (Assessment and Deployment Kit, not the
significantly larger WinPE add-on). However, the command to do this is extremely convoluted and complex in order to create a bootable WinPE or Windows installer ISO.

All this simple and ugly app does, is allow you to select the necessary files on the USB and construct the ISO using oscdimg, which is notably not included since it's
illegal, but there are links in the application to make things easier.

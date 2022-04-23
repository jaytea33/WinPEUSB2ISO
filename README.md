# WinPE USB to ISO Converter
Let's say you have a WinPE USB or Windows 10 installer USB and wish to create an ISO from it. Maybe you want to boot the ISO in a virtual machine or burn it to
optical media, or just have a backup of it. You can do this by leveraging Microsoft's "oscdimg.exe" tool, which is included in Microsoft's Windows 10 ADK (not the significantly larger WinPE add-on). However, the command to do this is extremely convoluted and complex in order to create a bootable WinPE or Windows installer ISO.

All this simple and ugly app does, is allow you to select the necessary files on the USB and construct the ISO using oscdimg, which is notably not included since it's
illegal, but there are links in the application to make things easier.

![WinPEtoISOConverter](https://user-images.githubusercontent.com/26644134/164884690-7b6d835c-9a24-4b14-96bf-b6dab83c798a.png)

Instructions:

1. Simply go down the list. The "File Exists" checkboxes will indicate whether the files exist on your system. If you don't have oscdimg, click "Download ADK" followed by "Install oscdimg"
2. Select the letter of your USB. You can test this with a mounted ISO as well if you wish, all it needs is the files referenced and it'll build the ISO.
3. After selecting the letter of the USB the rest of the fields fill out accordingly.
4. Select the path where you wish to save your ISO

It's unlikely I'll ever update this, as working around syntax errors due to space characters made this a lot harder than it needed to be, but feel free to use it however necessary.

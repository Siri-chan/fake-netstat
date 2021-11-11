# Notes
**IMPORTANT:** While you can use this software on a hardware-based machine, I am not responsible for any damage that this software, or any scammers cause. I would recommend using Oracle VM VirtualBox, but a couple of my peers can testify for VMWare.


**Furthermore,** This is a pre-emptive piece of software. Install it long before a scammer makes their way onto your VM, because the install process is slow, and a scammer won't let you install it while they're connected to the VM anyway.
# Install steps:
## Prior Setup
Ensure you have:
- A Windows Virtual Machine with
    - the .NET runtime installed,
    - a folder (preferably near root) to hide scambaiting resources,
    - VMWare Tools / VirtualBox Guest Additions, and 
    - an accessable Administrator account.
- The .NET SDK on your host machine.
- A basic knowledge of Windows Batch (CMD Language)

## Setup
1. Run `dotnet build -o <folder>` to build to the specified folder. (This supports ./ and ../)
3. Zip that folder up. 
3. Transfer it to your guest

3. Extract the zip on your guest.

4. use registry/autorun/doskey [(here's a stack overflow post)](https://superuser.com/a/1134468) to alias the custom exe to netstat


# To Do:
- finish command
- do all the params
- set title quicker

# Other Useful Software
i will make an ipconfig
### Host:
- Wireshark

### VM:
- 
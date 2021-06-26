Install steps:
ensure you have the .NET runtime on your VM guest, and .NET SDK on your host machine

run `dotnet build -o <folder>` to build to a folder, then zip that folder up, and transfer it to your guest.

extract it on your guest

use registry/autorun/doskey (i'll leave a stack overflow post) to alias the custom exe to netstat


todo:
finish command
set title quicker
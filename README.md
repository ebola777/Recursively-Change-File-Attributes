# Recursively Change File Attributes

A simple C# program to change file attribute Modified Date to Creation Date.

I created this program because foobar2000 ReplayGain always changes my music modified date attribute, so that if I use filter like "%last_modified% AFTER 2012" in foobar, it would include files modified recently by ReplayGain, which sucks. This tool simply searches all files under a folder and replace Modified Date with Creation Date, so you can still use ReplayGain without worries. You can include or exclude file paths as well.

Download binary file [here][binary]. (Requires .NET Framework 4 or higher)

## How to Use

1. Browse the music root folder
2. Click "Preview" to list files under the folder
3. Click "Execute" to let the program change file attributes

## Examples

![screenshot1][screenshot1]

Modified parameters:
- Folder: C:\\Users\\Public\\Music

## Customize

### How program changes attributes

- FormMain.cs
    - ChangeAttrib(string path)

### How program checks processed files

- FormMain.cs
    - CheckIgnore(string path)

## Build

Visual Studio 2010 or higher

## License

Copyright (c) 2014 Shawn

See the LICENSE file for license rights and limitations (MIT).

[binary]: /binaries/Change-Modified-Date-to-Creation-Date.zip
[screenshot1]: /doc/screenshot1.jpg

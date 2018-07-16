# Serilog.Sinks.Udp - Sample in .NET Core

[![Build status](https://ci.appveyor.com/api/projects/status/p6khviimlpbmbkf8/branch/master?svg=true)](https://ci.appveyor.com/project/FantasticFiasco/serilog-sinks-udp-sample-dotnet-core/branch/master)

This repository contains a sample application of [Serilog.Sinks.Udp](https://github.com/FantasticFiasco/serilog-sinks-upd) producing log events sent using UDP to Log2Console.

## Running the application

1. Download the [latest release of Log2Console](https://github.com/Statyk7/log2console/releases)
1. Unzip the release
1. Install Log2Console using the installer found in the `output` folder
1. Start Log2Console and add a UDP receiver with the following settings:
    - Multicast Group Address (Optional): 
    - Receive Buffer Size: 10000
    - UDP Port Number: 7071
    - Use IPv6 Addresses: False
1. Open `dotnet-core-sample.sln` is Visual Studio
1. Press _F5_ to start debugging

What you will end up with is a console application producing log events displayed in Log2Console.

![Log2Console](./doc/resources/log2console.jpg)
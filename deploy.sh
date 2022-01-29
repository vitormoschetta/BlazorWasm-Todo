#!bin/bash

dotnet publish -c Release
vercel --prod ./src/bin/Release/net5.0/publish/wwwroot
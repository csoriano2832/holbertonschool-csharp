#!/usr/bin/env bash

dir="$1"
file="$2"

mkdir -p "$dir/$file" && cd "$dir/$file";
dotnet new console;
mv Program.cs "$file.cs"
sed -i '5 i \\t\t<DocumentationFile>bin\\$(Configuration)\\$(TargetFramework)\\$(AssemblyName).xml</DocumentationFile>' "$file.csproj";
cd ../../

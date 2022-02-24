#!/usr/bin/env bash

dir=$1
file=$2
namespace=$3
testspace="$namespace.Tests"

mkdir -p "$dir/$file" && cd "$dir/$file";
dotnet new sln;
mkdir "$namespace" && cd "$namespace";
dotnet new classlib && mv *.cs "$namespace.cs";
sed -i '5 i \\t\t<DocumentationFile>bin\\$(Configuration)\\$(TargetFramework)\\$(AssemblyName).xml</DocumentationFile>' "$namespace.csproj"
cd ../ && dotnet sln add "$namespace/$namespace.csproj";
mkdir "$testspace" && cd "$testspace";
dotnet new nunit && mv *.cs "$testspace.cs";
dotnet add reference "../$namespace/$namespace.csproj";
cd ../ && dotnet sln add "$testspace/$testspace.csproj";
cd ../

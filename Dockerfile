FROM mcr.microsoft.com/dotnet/sdk:5.0-alpine
WORKDIR /source

COPY SQLiteTest/*.csproj ./SQLiteTest/
COPY SQLiteTest/. ./SQLiteTest/

WORKDIR /source/SQLiteTest

RUN dotnet run .

#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["RouletteCore.csproj", "RouletteCore/"]
COPY ["../RouletteCore.DataAccess.csproj", "RouletteCore.DataAccess/"]
COPY ["../RouletteCore.Security.csproj", "RouletteCore.Security/"]
RUN dotnet restore "RouletteCore/RouletteCore.csproj"
COPY . .
WORKDIR "/src/RouletteCore"
RUN Update-Database
RUN dotnet build "RouletteCore.csproj" -c Release -o /app/build

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-nanoserver-1903 AS migration
WORKDIR /src
COPY . .
RUN dotnet restore "RouletteCore.DataAccess/RouletteCore.DataAccess.csproj"
COPY . .
WORKDIR "/src/RouletteCore.DataAccess"
RUN dotnet build "RouletteCore.DataAccess.csproj" -c Release -o /app/migration

FROM build AS publish
RUN dotnet publish "RouletteCore.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /migration
COPY --from=migration /app/migration .
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RouletteCore.dll"]

#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["RouletteCore/RouletteCore.csproj", "RouletteCore/"]
COPY ["RouletteCore.DataAccess/RouletteCore.DataAccess.csproj", "RouletteCore.DataAccess/"]
COPY ["RouletteCore.Security/RouletteCore.Security.csproj", "RouletteCore.Security/"]
RUN dotnet restore "RouletteCore/RouletteCore.csproj"
COPY . .
WORKDIR "/src/RouletteCore"
RUN dotnet build "RouletteCore.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RouletteCore.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RouletteCore.dll"]

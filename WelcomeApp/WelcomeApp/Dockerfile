#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["WelcomeApp/WelcomeApp.csproj", "WelcomeApp/"]
RUN dotnet restore "WelcomeApp/WelcomeApp.csproj"
COPY . .
WORKDIR "/src/WelcomeApp"
RUN dotnet build "WelcomeApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WelcomeApp.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WelcomeApp.dll"]
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["source/webapp/Buddy.WebApp/Buddy.WebApp.csproj", "source/webapp/Buddy.WebApp/"]
RUN dotnet restore "source/webapp/Buddy.WebApp/Buddy.WebApp.csproj"
COPY . .
WORKDIR "/src/source/webapp/Buddy.WebApp"
RUN dotnet build "Buddy.WebApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Buddy.WebApp.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Buddy.WebApp.dll"]

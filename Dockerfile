FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["vega.csproj", "./"]
RUN dotnet restore "./vega.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "vega.csproj" -c Release -o /app/build
RUN apt-get update && \
    apt-get install -y wget && \
    apt-get install -y gnupg2 && \
    wget -qO- https://deb.nodesource.com/setup_10.x | bash - && \
    apt-get install -y build-essential nodejs

FROM build AS publish
RUN dotnet publish "vega.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
# ENTRYPOINT ["dotnet", "vega.dll"]
CMD ASPNETCORE_URLS=http://*:$PORT dotnet vega.dll


#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

ENV JWT_KEY="RaIdJifRxeDVT9XHwkQqwEvQpHd2TrI4wq2c434m324"
ENV JWT_ISSUER="kidds"
ENV JWT_AUDIENCE="sritel"
ENV JWT_DURATION_IN_MINUTES=60

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["AdminAPI/AdminAPI.csproj", "AdminAPI/"]
RUN dotnet restore "./AdminAPI/AdminAPI.csproj"
COPY . .
WORKDIR "/src/AdminAPI"
RUN dotnet build "./AdminAPI.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./AdminAPI.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AdminAPI.dll"]
# Base image for the runtime environment
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

ENV JWT_KEY="RaIdJifRxeDVT9XHwkQqwEvQpHd2TrI4"
ENV JWT_ISSUER="kidds"
ENV JWT_AUDIENCE="sritel"
ENV JWT_DURATION_IN_MINUTES=60


# Build image for compiling the application
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["AuthAPI/AuthAPI.csproj", "AuthAPI/"]
RUN dotnet restore "AuthAPI/AuthAPI.csproj"
COPY . .
WORKDIR "/src/AuthAPI"
RUN dotnet build "AuthAPI.csproj" -c Release -o /app/build

# Publish image for preparing the final build output
FROM build AS publish
RUN dotnet publish "AuthAPI.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Final image for running the application
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AuthAPI.dll"]
# Base image for running the app
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080

ENV JWT_KEY="RaIdJifRxeDVT9XHwkQqwEvQpHd2TrI4"
ENV JWT_ISSUER="kidds"
ENV JWT_AUDIENCE="sritel"
ENV JWT_DURATION_IN_MINUTES=60

# SDK image for building the app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy project file and restore dependencies
COPY ["VisaAPI/VisaAPI.csproj", "VisaAPI/"]
RUN dotnet restore "VisaAPI/VisaAPI.csproj"

# Copy the rest of the source code
COPY . .

# Set the working directory and build the project
WORKDIR "/src/VisaAPI"
RUN dotnet build "VisaAPI.csproj" -c Release -o /app/build

# Publish the application to a folder
FROM build AS publish
RUN dotnet publish "VisaAPI.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Final stage for the runtime image
FROM base AS final
WORKDIR /app

# Copy the published files from the build stage
COPY --from=publish /app/publish .

# Set the entry point for the container
ENTRYPOINT ["dotnet", "VisaAPI.dll"]

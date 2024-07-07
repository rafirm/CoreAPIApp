# Use the official .NET 5 SDK image as the build environment
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env

# Set the working directory in the container
WORKDIR /app

# Copy the csproj file and restore any dependencies
COPY *.csproj ./
RUN dotnet restore

# Copy the entire project and build it
COPY . ./
RUN dotnet publish -c Release -o out

# Use the official .NET 5 runtime image as the runtime environment
FROM mcr.microsoft.com/dotnet/aspnet:5.0

# Set the working directory in the container
WORKDIR /app

# Copy the build output from the build environment
COPY --from=build-env /app/out .

# Expose port 80 to the outside world
EXPOSE 80

# Set the entry point for the application
ENTRYPOINT ["dotnet", "commander.dll"]

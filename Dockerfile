# Use the official ASP.NET Core runtime as a base image
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

# Use the SDK image to build the application
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["GreenDefined/GreenDefined.csproj", "GreenDefined/"]
RUN dotnet restore "GreenDefined/GreenDefined.csproj"
COPY . .
WORKDIR "/src/GreenDefined"
RUN dotnet build "GreenDefined.csproj" -c Release -o /app/build

# Publish the application
FROM build AS publish
RUN dotnet publish "GreenDefined.csproj" -c Release -o /app/publish

# Final stage to run the application
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GreenDefined.dll"]
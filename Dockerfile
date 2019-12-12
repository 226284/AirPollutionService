FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

COPY ["AirPollution/out", "./"]

ENTRYPOINT ["dotnet", "AirPollution.dll"]

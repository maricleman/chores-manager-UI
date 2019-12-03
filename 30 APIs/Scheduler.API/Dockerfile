FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["30 APIs/Scheduler.API/Scheduler.API.csproj", "30 APIs/Scheduler.API/"]
RUN dotnet restore "30 APIs/Scheduler.API/Scheduler.API.csproj"
COPY . .
WORKDIR "/src/30 APIs/Scheduler.API"
RUN dotnet build "Scheduler.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Scheduler.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Scheduler.API.dll"]
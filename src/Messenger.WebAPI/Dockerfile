FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["src/Messenger.WebAPI/Messenger.WebAPI.csproj", "Messenger.WebAPI/"]
COPY ["src/Messenger.Application/Messenger.Application.csproj", "Messenger.Application/"]
COPY ["src/Messenger.Infrastructure/Messenger.Infrastructure.csproj", "Messenger.Infrastructure/"]
COPY ["src/Messenger.Domain/Messenger.Domain.csproj", "Messenger.Domain/"]
RUN dotnet restore "Messenger.WebAPI/Messenger.WebAPI.csproj"
COPY src/ .
WORKDIR "/src/Messenger.WebAPI"
RUN dotnet build "Messenger.WebAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Messenger.WebAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Messenger.WebAPI.dll"]

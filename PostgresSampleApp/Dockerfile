FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["PostgresSampleApp/PostgresSampleApp.csproj", "PostgresSampleApp/"]
RUN dotnet restore "PostgresSampleApp/PostgresSampleApp.csproj"
COPY . .
WORKDIR "/src/PostgresSampleApp"
RUN dotnet build "PostgresSampleApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PostgresSampleApp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PostgresSampleApp.dll"]

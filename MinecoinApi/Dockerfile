FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["MinecoinApi/MinecoinApi.csproj", "MinecoinApi/"]
RUN dotnet restore "MinecoinApi/MinecoinApi.csproj"
COPY . .
WORKDIR "/src/MinecoinApi"
RUN dotnet build "MinecoinApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MinecoinApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MinecoinApi.dll"]

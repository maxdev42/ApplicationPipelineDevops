FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base

WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY . .
RUN dotnet restore "TestAppCi.Client/TestAppCi.Client.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "TestAppCi.Client/TestAppCi.Client.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TestAppCi.Client/TestAppCi.Client.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TestAppCi.Client.dll"]

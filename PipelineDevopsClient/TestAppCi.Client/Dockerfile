#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["
.Client/TestAppCi.Client.csproj", "TestAppCi.Client/"]
RUN dotnet restore "TestAppCi.Client/TestAppCi.Client.csproj"
COPY . .
WORKDIR "/src/TestAppCi.Client"
RUN dotnet build "TestAppCi.Client.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TestAppCi.Client.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TestAppCi.Client.dll"]
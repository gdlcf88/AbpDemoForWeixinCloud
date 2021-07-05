FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["src/AbpDemoForWeixinCloud.Web/AbpDemoForWeixinCloud.Web.csproj", "AbpDemoForWeixinCloud.Web/"]
RUN dotnet restore "AbpDemoForWeixinCloud.Web/AbpDemoForWeixinCloud.Web.csproj"
COPY ./src .
WORKDIR "/src/AbpDemoForWeixinCloud.Web"
RUN dotnet build "AbpDemoForWeixinCloud.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AbpDemoForWeixinCloud.Web.csproj" --no-restore -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AbpDemoForWeixinCloud.Web.dll"]
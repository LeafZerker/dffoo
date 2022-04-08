FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /src
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["dffoo/Client/dffoo.Client.csproj", "dffoo/Client/"]
COPY ["dffoo/Shared/dffoo.Shared.csproj", "dffoo/Shared/"]
RUN dotnet restore "dffoo/Client/dffoo.Client.csproj"
COPY . .
WORKDIR "/src/dffoo/Client"
RUN dotnet build "dffoo.Client.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "dffoo.Client.csproj" -c Release -o /app/publish

FROM nginx:alpine AS final
WORKDIR /usr/share/nginx/html
COPY --from=publish /app/publish/wwwroot .
COPY nginx.conf /etc/nginx/nginx.conf

FROM mcr.microsoft.com/dotnet/sdk:6.0-alpine as build
WORKDIR /app
COPY *.sln .
COPY OverReacted.Api/*.csproj ./OverReacted.Api/
COPY OverReacted.Application/*.csproj ./OverReacted.Application/
COPY OverReacted.Domain/*.csproj ./OverReacted.Domain/
COPY OverReacted.Infrastructure/*.csproj ./OverReacted.Infrastructure/ 
RUN dotnet restore

COPY OverReacted.Api/. ./OverReacted.Api/
COPY OverReacted.Application/. ./OverReacted.Application/
COPY OverReacted.Domain/. ./OverReacted.Domain/ 
COPY OverReacted.Infrastructure/. ./OverReacted.Infrastructure/ 
RUN dotnet publish -o /app/published-app

FROM mcr.microsoft.com/dotnet/aspnet:6.0-alpine as runtime
WORKDIR /app
COPY --from=build /app/published-app /app
ENTRYPOINT [ "dotnet", "/app/OverReacted.Api.dll" ]
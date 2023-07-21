# syntax=docker/dockerfile:1
#FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS base
EXPOSE 5240

FROM local:doojoe-shared-base AS build
WORKDIR /
COPY --from=local:doojoe-shared-base . .

COPY ./src/+Modules/Required/AccountModule/+API/+AccountModuleApi/src/entrypoint.sh /src/+Modules/Required/AccountModule/+API/+AccountModuleApi/src/entrypoint.sh
COPY ./src/+Modules/Required/AccountModule/+API/+AccountModuleApi/src/AccountModuleApi.csproj /src/+Modules/Required/AccountModule/+API/+AccountModuleApi/src/AccountModuleApi.csproj 
RUN dotnet restore /src/+Modules/Required/AccountModule/+API/+AccountModuleApi/src/AccountModuleApi.csproj

FROM build AS publish
WORKDIR /

COPY ./src/+Modules/Required/AccountModule/+API/+AccountModuleApi/src/ /src/+Modules/Required/AccountModule/+API/+AccountModuleApi/src/
RUN dotnet publish /src/+Modules/Required/AccountModule/+API/+AccountModuleApi/src/AccountModuleApi.csproj -c Release -o /app/publish
#RUN chmod +x ./entrypoint.sh

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENV ASPNETCORE_FORWARDEDHEADERS_ENABLED=true
ENTRYPOINT ["dotnet", "AccountModuleApi.dll"]
#CMD /bin/bash ./entrypoint.sh
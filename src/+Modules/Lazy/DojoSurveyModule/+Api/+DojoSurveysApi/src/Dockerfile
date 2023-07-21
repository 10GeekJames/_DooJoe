# syntax=docker/dockerfile:1
#FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS base
EXPOSE 5250

FROM local:doojoe-shared-base AS build
WORKDIR /
COPY --from=local:doojoe-shared-base . .

COPY ./src/+Modules/Lazy/DojoSurveyModule/+Api/+DojoSurveysApi/src/entrypoint.sh /src/+Modules/Lazy/DojoSurveyModule/+Api/+DojoSurveysApi/src/entrypoint.sh
COPY ./src/+Modules/Lazy/DojoSurveyModule/+Api/+DojoSurveysApi/src/DojoSurveysApi.csproj /src/+Modules/Lazy/DojoSurveyModule/+Api/+DojoSurveysApi/src/DojoSurveysApi.csproj 
RUN dotnet restore /src/+Modules/Lazy/DojoSurveyModule/+Api/+DojoSurveysApi/src/DojoSurveysApi.csproj

FROM build AS publish                     
WORKDIR /

COPY ./src/+Modules/Lazy/DojoSurveyModule/+Api/+DojoSurveysApi/src/ /src/+Modules/Lazy/DojoSurveyModule/+Api/+DojoSurveysApi/src/
RUN dotnet publish /src/+Modules/Lazy/DojoSurveyModule/+Api/+DojoSurveysApi/src/DojoSurveysApi.csproj -c Release -o /app/publish

#RUN chmod +x ./entrypoint.sh

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENV ASPNETCORE_FORWARDEDHEADERS_ENABLED=true
ENTRYPOINT ["dotnet", "DojoSurveysApi.dll"]
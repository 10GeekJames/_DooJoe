# syntax=docker/dockerfile:1
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS copy-project-files
WORKDIR /

RUN apt-get update && apt-get install -y curl sudo
RUN curl -sL https://deb.nodesource.com/setup_18.x | bash - 
RUN apt-get install -y nodejs

RUN npm install -g yarn
RUN npm upgrade --global yarn
RUN npm install -g sass

COPY ./src/__Kernel/DooJoe.KernelShared/src/DooJoe.KernelShared.csproj                                                                  /src/__Kernel/DooJoe.KernelShared/src/DooJoe.KernelShared.csproj
COPY ./src/+Modules/Required/AccountModule/____Core/__AccountModuleCore/src/AccountModuleCore.csproj                                    /src/+Modules/Required/AccountModule/____Core/__AccountModuleCore/src/AccountModuleCore.csproj
COPY ./src/+Modules/Required/AccountModule/____Core/_AccountModuleCore.TestData/src/AccountModuleCore.TestData.csproj                   /src/+Modules/Required/AccountModule/____Core/_AccountModuleCore.TestData/src/AccountModuleCore.TestData.csproj
COPY ./src/+Modules/Required/AccountModule/___Infrastructure/AccountModuleInfrastructure/src/AccountModuleInfrastructure.csproj         /src/+Modules/Required/AccountModule/___Infrastructure/AccountModuleInfrastructure/src/AccountModuleInfrastructure.csproj
COPY ./src/+Modules/Required/AccountModule/_Application/_AccountModuleApplication.Shared/src/AccountModuleApplication.Shared.csproj     /src/+Modules/Required/AccountModule/_Application/_AccountModuleApplication.Shared/src/AccountModuleApplication.Shared.csproj
COPY ./src/+Modules/Required/AccountModule/_Application/AccountModuleApplication/src/AccountModuleApplication.csproj                    /src/+Modules/Required/AccountModule/_Application/AccountModuleApplication/src/AccountModuleApplication.csproj
COPY ./src/+Modules/Required/AccountModule/UI/_AccountModuleClientServiceLoader/src/AccountModuleClientServiceLoader.csproj             /src/+Modules/Required/AccountModule/UI/_AccountModuleClientServiceLoader/src/AccountModuleClientServiceLoader.csproj
COPY ./src/+Modules/Required/AccountModule/UI/AccountModuleBlazorModuleAdmin/src/AccountModuleBlazorModuleAdmin.csproj                  /src/+Modules/Required/AccountModule/UI/AccountModuleBlazorModuleAdmin/src/AccountModuleBlazorModuleAdmin.csproj
COPY ./src/+Modules/Lazy/DojoSurveyModule/____Core/__DojoSurveysCore/src/DojoSurveysCore.csproj                                         /src/+Modules/Lazy/DojoSurveyModule/____Core/__DojoSurveysCore/src/DojoSurveysCore.csproj
COPY ./src/+Modules/Lazy/DojoSurveyModule/____Core/DojoSurveysCore.DojoSurveysTestData/src/DojoSurveysCore.DojoSurveysTestData.csproj   /src/+Modules/Lazy/DojoSurveyModule/____Core/DojoSurveysCore.DojoSurveysTestData/src/DojoSurveysCore.DojoSurveysTestData.csproj
COPY ./src/+Modules/Lazy/DojoSurveyModule/___Infrastructure/DojoSurveysInfrastructure/src/DojoSurveysInfrastructure.csproj              /src/+Modules/Lazy/DojoSurveyModule/___Infrastructure/DojoSurveysInfrastructure/src/DojoSurveysInfrastructure.csproj
COPY ./src/+Modules/Lazy/DojoSurveyModule/_Application/_DojoSurveysApplication.Shared/src/DojoSurveysApplication.Shared.csproj          /src/+Modules/Lazy/DojoSurveyModule/_Application/_DojoSurveysApplication.Shared/src/DojoSurveysApplication.Shared.csproj
COPY ./src/+Modules/Lazy/DojoSurveyModule/_Application/DojoSurveysApplication/src/DojoSurveysApplication.csproj                         /src/+Modules/Lazy/DojoSurveyModule/_Application/DojoSurveysApplication/src/DojoSurveysApplication.csproj
COPY ./src/+Modules/Lazy/DojoSurveyModule/UI/_DojoSurveysModuleClientServiceLoader/src/DojoSurveysModuleClientServiceLoader.csproj      /src/+Modules/Lazy/DojoSurveyModule/UI/_DojoSurveysModuleClientServiceLoader/src/DojoSurveysModuleClientServiceLoader.csproj
COPY ./src/+Modules/Lazy/DojoSurveyModule/UI/DojoSurveysBlazorModule/src/DojoSurveysBlazorModule.csproj                                 /src/+Modules/Lazy/DojoSurveyModule/UI/DojoSurveysBlazorModule/src/DojoSurveysBlazorModule.csproj
COPY ./src/+Modules/Lazy/DojoSurveyModule/UI/DojoSurveysBlazorModuleAdmin/src/DojoSurveysBlazorModuleAdmin.csproj                       /src/+Modules/Lazy/DojoSurveyModule/UI/DojoSurveysBlazorModuleAdmin/src/DojoSurveysBlazorModuleAdmin.csproj
COPY ./src/_Common/DooJoe.Common/src/DooJoe.Common.csproj /src/_Common/DooJoe.Common/src/DooJoe.Common.csproj

FROM copy-project-files AS restore-all
WORKDIR /
COPY --from=copy-project-files . .

RUN dotnet restore ./src/__Kernel/DooJoe.KernelShared/src/DooJoe.KernelShared.csproj
RUN dotnet restore ./src/+Modules/Required/AccountModule/____Core/__AccountModuleCore/src/AccountModuleCore.csproj
RUN dotnet restore ./src/+Modules/Required/AccountModule/____Core/_AccountModuleCore.TestData/src/AccountModuleCore.TestData.csproj
RUN dotnet restore ./src/+Modules/Required/AccountModule/___Infrastructure/AccountModuleInfrastructure/src/AccountModuleInfrastructure.csproj
RUN dotnet restore ./src/+Modules/Required/AccountModule/_Application/_AccountModuleApplication.Shared/src/AccountModuleApplication.Shared.csproj
RUN dotnet restore ./src/+Modules/Required/AccountModule/_Application/AccountModuleApplication/src/AccountModuleApplication.csproj
RUN dotnet restore ./src/+Modules/Required/AccountModule/UI/_AccountModuleClientServiceLoader/src/AccountModuleClientServiceLoader.csproj
RUN dotnet restore ./src/+Modules/Required/AccountModule/UI/AccountModuleBlazorModuleAdmin/src/AccountModuleBlazorModuleAdmin.csproj
RUN dotnet restore ./src/+Modules/Lazy/DojoSurveyModule/____Core/__DojoSurveysCore/src/DojoSurveysCore.csproj
RUN dotnet restore ./src/+Modules/Lazy/DojoSurveyModule/____Core/DojoSurveysCore.DojoSurveysTestData/src/DojoSurveysCore.DojoSurveysTestData.csproj
RUN dotnet restore ./src/+Modules/Lazy/DojoSurveyModule/___Infrastructure/DojoSurveysInfrastructure/src/DojoSurveysInfrastructure.csproj
RUN dotnet restore ./src/+Modules/Lazy/DojoSurveyModule/_Application/_DojoSurveysApplication.Shared/src/DojoSurveysApplication.Shared.csproj
RUN dotnet restore ./src/+Modules/Lazy/DojoSurveyModule/_Application/DojoSurveysApplication/src/DojoSurveysApplication.csproj
RUN dotnet restore ./src/+Modules/Lazy/DojoSurveyModule/UI/_DojoSurveysModuleClientServiceLoader/src/DojoSurveysModuleClientServiceLoader.csproj
RUN dotnet restore ./src/+Modules/Lazy/DojoSurveyModule/UI/DojoSurveysBlazorModule/src/DojoSurveysBlazorModule.csproj
RUN dotnet restore ./src/+Modules/Lazy/DojoSurveyModule/UI/DojoSurveysBlazorModuleAdmin/src/DojoSurveysBlazorModuleAdmin.csproj
RUN dotnet restore /src/_Common/DooJoe.Common/src/DooJoe.Common.csproj


FROM restore-all AS copy-all
WORKDIR /
COPY --from=restore-all . .

COPY ./src/__Kernel/DooJoe.KernelShared/src/                                                    /src/__Kernel/DooJoe.KernelShared/src/
COPY ./src/+Modules/Required/AccountModule/____Core/__AccountModuleCore/src/                    /src/+Modules/Required/AccountModule/____Core/__AccountModuleCore/src/
COPY ./src/+Modules/Required/AccountModule/____Core/_AccountModuleCore.TestData/src/            /src/+Modules/Required/AccountModule/____Core/_AccountModuleCore.TestData/src/
COPY ./src/+Modules/Required/AccountModule/___Infrastructure/AccountModuleInfrastructure/src/   /src/+Modules/Required/AccountModule/___Infrastructure/AccountModuleInfrastructure/src/
COPY ./src/+Modules/Required/AccountModule/_Application/_AccountModuleApplication.Shared/src/   /src/+Modules/Required/AccountModule/_Application/_AccountModuleApplication.Shared/src/
COPY ./src/+Modules/Required/AccountModule/_Application/AccountModuleApplication/src/           /src/+Modules/Required/AccountModule/_Application/AccountModuleApplication/src/
COPY ./src/+Modules/Required/AccountModule/UI/_AccountModuleClientServiceLoader/src/            /src/+Modules/Required/AccountModule/UI/_AccountModuleClientServiceLoader/src/
COPY ./src/+Modules/Required/AccountModule/UI/AccountModuleBlazorModuleAdmin/src/               /src/+Modules/Required/AccountModule/UI/AccountModuleBlazorModuleAdmin/src/
COPY ./src/+Modules/Lazy/DojoSurveyModule/____Core/__DojoSurveysCore/src/                       /src/+Modules/Lazy/DojoSurveyModule/____Core/__DojoSurveysCore/src/
COPY ./src/+Modules/Lazy/DojoSurveyModule/____Core/DojoSurveysCore.DojoSurveysTestData/src/     /src/+Modules/Lazy/DojoSurveyModule/____Core/DojoSurveysCore.DojoSurveysTestData/src/
COPY ./src/+Modules/Lazy/DojoSurveyModule/___Infrastructure/DojoSurveysInfrastructure/src/      /src/+Modules/Lazy/DojoSurveyModule/___Infrastructure/DojoSurveysInfrastructure/src/
COPY ./src/+Modules/Lazy/DojoSurveyModule/_Application/_DojoSurveysApplication.Shared/src/      /src/+Modules/Lazy/DojoSurveyModule/_Application/_DojoSurveysApplication.Shared/src/
COPY ./src/+Modules/Lazy/DojoSurveyModule/_Application/DojoSurveysApplication/src/              /src/+Modules/Lazy/DojoSurveyModule/_Application/DojoSurveysApplication/src/
COPY ./src/+Modules/Lazy/DojoSurveyModule/UI/_DojoSurveysModuleClientServiceLoader/src/         /src/+Modules/Lazy/DojoSurveyModule/UI/_DojoSurveysModuleClientServiceLoader/src/
COPY ./src/+Modules/Lazy/DojoSurveyModule/UI/DojoSurveysBlazorModule/src/                       /src/+Modules/Lazy/DojoSurveyModule/UI/DojoSurveysBlazorModule/src/
COPY ./src/+Modules/Lazy/DojoSurveyModule/UI/DojoSurveysBlazorModuleAdmin/src/                  /src/+Modules/Lazy/DojoSurveyModule/UI/DojoSurveysBlazorModuleAdmin/src/
COPY ./src/_Common/DooJoe.Common/src/ /src/_Common/DooJoe.Common/src/

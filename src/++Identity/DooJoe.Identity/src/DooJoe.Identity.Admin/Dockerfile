FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 44302
EXPOSE 44303
EXPOSE 44310


FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/DooJoe.Identity.Admin/DooJoe.Identity.Admin.csproj", "src/DooJoe.Identity.Admin/"]
COPY ["src/DooJoe.Identity.Admin.EntityFramework.Shared/DooJoe.Identity.Admin.EntityFramework.Shared.csproj", "src/DooJoe.Identity.Admin.EntityFramework.Shared/"]
COPY ["src/DooJoe.Identity.Admin.EntityFramework.SqlServer/DooJoe.Identity.Admin.EntityFramework.SqlServer.csproj", "src/DooJoe.Identity.Admin.EntityFramework.SqlServer/"]
COPY ["src/DooJoe.Identity.Shared/DooJoe.Identity.Shared.csproj", "src/DooJoe.Identity.Shared/"]
COPY ["src/DooJoe.Identity.Admin.EntityFramework.PostgreSQL/DooJoe.Identity.Admin.EntityFramework.PostgreSQL.csproj", "src/DooJoe.Identity.Admin.EntityFramework.PostgreSQL/"]
COPY ["src/DooJoe.Identity.Admin.EntityFramework.MySql/DooJoe.Identity.Admin.EntityFramework.MySql.csproj", "src/DooJoe.Identity.Admin.EntityFramework.MySql/"]
RUN dotnet restore "src/DooJoe.Identity.Admin/DooJoe.Identity.Admin.csproj"
COPY . .
WORKDIR "/src/src/DooJoe.Identity.Admin"
RUN dotnet build "DooJoe.Identity.Admin.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DooJoe.Identity.Admin.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENV ASPNETCORE_FORWARDEDHEADERS_ENABLED=true
ENTRYPOINT ["dotnet", "DooJoe.Identity.Admin.dll"]
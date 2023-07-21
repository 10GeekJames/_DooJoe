FROM nginx:alpine as final
EXPOSE 5020/tcp

FROM local:doojoe-shared-base AS build
WORKDIR /
COPY --from=local:doojoe-shared-base . .

COPY ./src/UI/Client/DooJoe.BlazorClient/src/DooJoe.BlazorClient.csproj /src/UI/Client/DooJoe.BlazorClient/src/DooJoe.BlazorClient.csproj
RUN dotnet restore /src/UI/Client/DooJoe.BlazorClient/src/DooJoe.BlazorClient.csproj

FROM build as publish
WORKDIR /

COPY ./src/UI/Client/DooJoe.BlazorClient/src/ src/UI/Client/DooJoe.BlazorClient/src/
RUN dotnet publish /src/UI/Client/DooJoe.BlazorClient/src/DooJoe.BlazorClient.csproj -c Release -o /app/publish

FROM final
WORKDIR /usr/share/nginx/html
COPY --from=publish /app/publish .
ENV ASPNETCORE_FORWARDEDHEADERS_ENABLED=true
ENTRYPOINT ["dotnet", "AccountModuleApi.dll"]

WORKDIR /
COPY ./src/UI/Client/DooJoe.BlazorClient/src/ngix.conf /etc/nginx/nginx.conf
COPY ./src/UI/Client/DooJoe.BlazorClient/src/entrypoint.sh .
#RUN chmod +x ./entrypoint.sh
ENV ASPNETCORE_FORWARDEDHEADERS_ENABLED=true
CMD ["nginx", "-g", "daemon off;"]
 
#CMD /bin/bash ./entrypoint.sh

FROM mcr.microsoft.com/dotnet/aspnet:5.0

ENV ASPNETCORE_URLS=http://*:5000
ENV ASPNETCORE_ENVIRONMENT="production"

RUN apt-get -q -y update

EXPOSE 5000

WORKDIR /app

COPY ./publish .

ENTRYPOINT ["dotnet", "/app/Sge.Catalogos.WebApi.dll"]
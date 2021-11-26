
FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
#EXPOSE 80
#EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build

#ENV ASPNETCORE_ENVIRONMENT=Development 

WORKDIR /src
COPY  . . 
#["Api.csproj", "."]
RUN dotnet restore "./Api/Api.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "./Api/Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "./Api/Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Api.dll"]


#Teste
# docker build -t testeapp .
# docker run -d -p 8080:80 --name testeapp testeapp
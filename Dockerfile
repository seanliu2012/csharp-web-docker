# https://hub.docker.com/_/microsoft-dotnet
FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS BUILD
WORKDIR /app

# copy csproj and restore as distinct layers
COPY *.sln ./
COPY src/Example.Service/*.csproj ./src/Example.Service/
COPY tests/Example.Service.ComponentTests/*.csproj ./tests/Example.Service.ComponentTests/
COPY tests/Example.Service.UnitTests/*.csproj ./tests/Example.Service.UnitTests/
RUN dotnet restore

# copy everything else and build app
COPY . ./
WORKDIR /app/src/Example.Service
RUN dotnet publish -c Release -o out

# final stage/image
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS RUNTIME
WORKDIR /app
COPY --from=BUILD /app/src/Example.Service/out ./

EXPOSE 5000
ENV ASPNETCORE_URLS http://*:5000

ENTRYPOINT ["dotnet", "Example.Service.dll"]

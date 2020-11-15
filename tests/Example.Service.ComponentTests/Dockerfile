# https://hub.docker.com/_/microsoft-dotnet
FROM mcr.microsoft.com/dotnet/core/sdk:3.1
WORKDIR /app

# copy csproj and restore as distinct layers
COPY *.sln ./
COPY src/Example.Service/*.csproj ./src/Example.Service/
COPY tests/Example.Service.ComponentTests/*.csproj ./tests/Example.Service.ComponentTests/
COPY tests/Example.Service.UnitTests/*.csproj ./tests/Example.Service.UnitTests/
RUN dotnet restore

# copy everything else and start test
COPY . ./

CMD [ "dotnet", "test", "./tests/Example.Service.ComponentTests/" ]

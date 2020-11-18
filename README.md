# csharp-web-docker

Example c# web service using docker to build and test

## Build all projects

```sh
dotnet build
```

## Run web service locally

```sh
dotnet run -p src/Example.Service
```

## Run all tests

```sh
dotnet test
```

## Run component tests locally

```sh
ls -d ../*/tests/*.ComponentTests/ | xargs -n 1 dotnet test
```

## Run component tests via docker containers

```sh
docker-compose run --rm component-tests
```

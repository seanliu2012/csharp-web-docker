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

## Run just component tests

```sh
ls -d ../*/tests/*.ComponentTests/ | xargs -n 1 dotnet test
```

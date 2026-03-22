# Experiment-Dotnet-HelloWorld

Simple example .NET hello world solution split into:

- `src/HelloWorld.Generator`: class library that generates the hello world message
- `src/HelloWorld.ConsoleApp`: console app that writes the message to stdout
- `tests/HelloWorld.Generator.Tests`: xUnit tests that verify the generated message

## Build, test, and run

```bash
dotnet restore ./HelloWorld.sln
dotnet build ./HelloWorld.sln --configuration Release --no-restore
dotnet test ./HelloWorld.sln --configuration Release --no-build
dotnet run --project ./src/HelloWorld.ConsoleApp/HelloWorld.ConsoleApp.csproj --configuration Release --no-build
```

## Continuous integration

A GitHub Actions workflow is included at `.github/workflows/dotnet.yml`.
It restores dependencies, builds the solution, runs the automated tests, and then runs the console application on pushes to `main` and on pull requests.

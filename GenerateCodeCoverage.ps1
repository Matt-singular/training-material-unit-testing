### This script will run dotnet tests and then generate a code coverage report from the results
### If you receive a digital signing error then run the follwoing command: Set-ExecutionPolicy -ExecutionPolicy RemoteSigned -Scope Process

# Clear out the contents of the TestResults folder
if (Test-Path -Path "Domain.Tests/TestResults") {
    Get-ChildItem -Path "Domain.Tests/TestResults" | Remove-Item -Recurse -Force
}

# Generate the code coverage using Coverlet
dotnet test --collect:"XPlat Code Coverage"

# Generate a CoverageReport
reportgenerator -reports:Domain.Tests/TestResults/*/coverage.cobertura.xml -targetdir:Application/CoverageReport
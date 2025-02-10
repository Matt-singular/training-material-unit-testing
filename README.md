# [Unit Testing](Application/CoverageReport/index.html)

## Introduction

This repository goes through some of the basics of unit testing in .NET aimed at Junior software developers.

We will be utilising the following tools though note that there are many other tools available, it is important to understand the concepts.

- [XUnit](https://www.nuget.org/packages/xunit) - A unit testing framework
- [NSubstitute](https://www.nuget.org/packages/NSubstitute) - A mocking framework
- [FluentAssertions](https://www.nuget.org/packages/FluentAssertions) - Allow you to more naturally specify the expected outcome of tests
- [Coverlet](https://www.nuget.org/packages/coverlet.collector) - A code coverage tool
- [ReportGenerator](https://www.nuget.org/packages/dotnet-reportgenerator-globaltool) - A tool to generate code coverage reports

## Contents

1. [Unit tests](#unit-tests) - Facts, Theories, InlineData, MemberData
2. [Integration tests](#integration-tests) - Testing the interaction between components
3. [Code coverage](#code-coverage) - Coverlet, ReportGenerator
4. [Test driven development (TDD)](#test-driven-development-tdd) - Writing tests before the code

## Unit Tests

TODO

## Integration Tests

TODO

## Code Coverage

A simple way to measure the effectiveness of your tests is to use a code coverage tool. This will show you how much of your code is covered by your tests.

A simple script [GenerateCodeCoverage.ps1](GenerateCodeCoverage.ps1) has been created to generate the code coverage report.)

## Test Driven Development (TDD)

TODO

## Extras

- testenvironments.json
- Runsettings
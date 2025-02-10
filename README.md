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

Tests a single unit of work, typically a method or function. The goal is to isolate the code under test and verify that it behaves as expected.

- [Unit tests using Facts](Domain.Tests/Services/Calculator/AddOperationTests.cs)
- [Unit tests using Theories](Domain.Tests/Services/Calculator/MinusOperationTests.cs)
- [Unit tests using Mocks](Domain.Tests/Services/Calculator/MultiplyOperationTests.cs)

## Integration Tests

Tests the interaction between components. This can be a database, file system, network, or even other services.

- [Integration test for an interaction with a third party API](Domain.Tests/Services/Calculator/DivideOperationTests.cs)

## Code Coverage

A simple way to measure the effectiveness of your tests is to use a code coverage tool. This will show you how much of your code is covered by your tests.

A simple script [GenerateCodeCoverage.ps1](GenerateCodeCoverage.ps1) has been created to generate the code coverage report.)

## Test Driven Development (TDD)

A software methodology that emphasizes writing tests before writing the actual code in order to ensure that the code is always tested and functional, reducing bugs and improving code quality. In TDD, developers write small, focused tests that define the desired functionality, then write the minimum code necessary to pass these tests, and finally refactor the code to improve structure and performance.

## Extras not covered

- [Test Environments](https://learn.microsoft.com/en-us/visualstudio/test/remote-testing)
- [Runsettings](https://learn.microsoft.com/en-us/visualstudio/test/configure-unit-tests-by-using-a-dot-runsettings-file)
- [In-memory database](https://learn.microsoft.com/en-us/ef/core/providers/in-memory)
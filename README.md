BankingPlaywrightVSSolution

This is an automation solution developed as a demo for a banking application using Playwright with NUnit in a .NET environment.

Adding More Tests:

You can expand the solution by adding more NUnit test cases. Simply create new methods annotated with [Test] and use Playwright to interact with various web elements.

Headless/Headful Modes:

In the Setup method, you can toggle between headless and headful modes by setting Headless = true to run tests without opening a browser window.

Cross-Browser Testing:

You can add support for different browsers, such as Firefox or WebKit, by initializing their respective browser instances in Playwright.

Steps to Set Up Playwright with NUnit and C# in Visual Studio on Mac:

Prerequisites:

1) Install .NET SDK: Ensure you have the .NET SDK installed. Check the version by running:
dotnet --version

2) Visual Studio for Mac: Install Visual Studio for Mac if not already installed.

3) Node.js: Playwright requires Node.js for installation and setup. Ensure it's installed.

Setting Up Playwright with NUnit:

Step 1: Create a New NUnit Project

        Open Visual Studio for Mac.
        Navigate to File > New Solution.
        Select .NET Core > App > Console Application or NUnit project template.
        Choose C# as the language and name your project (e.g., PlaywrightNUnitProject).
        Set the target framework to .NET 6.0 or the latest version.
        Click Create.

Step 2: Initialize Playwright

        After adding the Playwright package, open the terminal inside Visual Studio (or macOS terminal).
        Install the necessary browsers for Playwright by running:
        npx playwright install
        
Step 3: Create the Playwright Test Class

        Start writing tests by creating a new class file and adding Playwright test methods using NUnit.

Executing the Tests:

1. Running Tests from Visual Studio:
   
    Build the project: Build > Build All.
    Open the Test Explorer: View > Pads > Unit Tests.
    Select and run individual tests, or click Run All to execute all tests.

3. Running Tests from the Command Line:
   
    You can also run tests using the following command:
    dotnet test
   
Additional Information:

Configure for CI/CD:

    If you're integrating the tests into a CI/CD pipeline, ensure Playwright is set to run in headless mode, and configure any necessary files like playwright.config.json for proper execution.

Jenkins step by step configuration

To link GitHub with Jenkins for Continuous Integration (CI) or Continuous Deployment (CD), you need to set up webhooks, configure a Jenkins job, and make sure Jenkins can access the repository. Here's a step-by-step guide:

Prerequisites
Jenkins installed and running.
GitHub account and a repository.
Git plugin and GitHub Integration plugin installed in Jenkins.

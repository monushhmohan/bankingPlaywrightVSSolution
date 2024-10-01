BankingPlaywrightVSSolution
This automation solution was developed as a demo for the Para Bank application, utilizing Playwright with NUnit in a .NET environment to showcase efficient testing capabilities.

To use this or add more tests onto this solution:

Step 1: Clone repo
Step 2: Get the Prerequisites set up:

        1) Install .NET SDK: Ensure you have the .NET SDK installed. 
                Check the version by running:
                dotnet --version

        2) Install Visual Studio for Mac(if not already installed).

        3) Node.js: Playwright requires Node.js for installation and setup. Ensure it's installed. 

Step 3: Setting Up Playwright with NUnit on Visual Studio:

        1) Open the Solution File (.sln) or Project Directory on Visual studio

                Open Visual Studio for Mac.
                Go to File > Open > Project/Solution.
                Navigate to the folder containing the .sln file and select it.
                Click Open

        2) Initialize Playwright

                After adding the Playwright package, open the terminal inside Visual Studio (or macOS terminal).
                Install the necessary browsers for Playwright by running:
                npx playwright install
        
        3)  Create the Playwright Test Class
        
                Start writing tests by creating a new class file and adding Playwright test methods using NUnit.

Step 4: Executing Tests:

        1. Running Tests from Visual Studio:
           
                    Build the project: Build > Build All.
                    Open the Test Explorer: View > Tests.
                    Select and run individual tests, or click Run All to execute all tests.

        2. Running Tests from the Command Line:
           
                    You can also run tests using the following command:
                    dotnet test


Additional Information:

        Headless/Headful Modes:

                In the Setup method, you can toggle between headless and headful modes by setting Headless = true to run tests without opening a browser window.
        
        Cross-Browser Testing:
        
                You can add support for different browsers, such as Firefox or WebKit, by initializing their respective browser instances in Playwright.

Configure for CI/CD:

        If you're integrating the tests into a CI/CD pipeline, ensure Playwright is set to run in headless mode, and configure any necessary files like playwright.config.json for               proper execution.

Jenkins step by step configuration

        To link GitHub with Jenkins for Continuous Integration (CI) or Continuous Deployment (CD), you need to set up webhooks, configure a Jenkins job, and make sure Jenkins can               access the repository. Here's a step-by-step guide:

        Prerequisites
                Jenkins installed and running.
                GitHub account and a repository.
                Git plugin and GitHub Integration plugin installed in Jenkins.

                        Step 1: Install Jenkins Plugins
                        Step 2: Configure GitHub Credentials in Jenkins
                        Step 3: Create a Jenkins Job
                        Step 4: Configure Source Code Management (SCM)
                        Step 5: Set Build Triggers
                        Step 6: Configure GitHub Webhook
                        Step 7: Build and Test the Job

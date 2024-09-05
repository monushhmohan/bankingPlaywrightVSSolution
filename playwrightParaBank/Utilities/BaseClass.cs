using System;
using Microsoft.Playwright;

namespace playwrightParaBank.Tests
{
    public class BaseClass

    {
        protected IPlaywright playwright;
        protected IBrowser browser;
        protected IBrowserContext context;
        protected IPage page;

        [SetUp]
        public async Task SetUp()
        {

            playwright = await Playwright.CreateAsync();
            browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false,
                SlowMo = 300,
                Timeout = 80000
            });
            context = await browser.NewContextAsync();
            page = await context.NewPageAsync();
            await RegisterNewUserAndLogin();

        }

        private async Task RegisterNewUserAndLogin()
        {

            await page.GotoAsync("https://parabank.parasoft.com");

            //Register a new user

            await page.Locator("//*[@id=\"loginPanel\"]/p[2]/a").ClickAsync();
            await page.Locator("//*[@id='customer.firstName']").FillAsync("Test");
            await page.Locator("//*[@id='customer.lastName']").FillAsync("Test");
            await page.Locator("//*[@id='customer.address.street']").FillAsync("Test");
            await page.Locator("//*[@id='customer.address.city']").FillAsync("Test");
            await page.Locator("//*[@id='customer.address.state']").FillAsync("Test");
            await page.Locator("//*[@id='customer.address.zipCode']").FillAsync("Test");
            await page.Locator("//*[@id='customer.phoneNumber']").FillAsync("1234");
            await page.Locator("//*[@id='customer.ssn']").FillAsync("Test");
            var username = GenerateRandomString(9);
            await page.Locator("//*[@id='customer.username']").FillAsync(username);
            Console.WriteLine($"Username = {username}");
            var password = GenerateRandomString(9);
            Console.WriteLine($"Password = {password}");
            await page.Locator("//*[@id='customer.password']").FillAsync(password);
            await page.Locator("//*[@id='repeatedPassword']").FillAsync(password);
            await page.Locator("//*[@value='Register']").ClickAsync();
            await page.Locator("//*[contains(@href,'logout')]").ClickAsync();

            //Login using the above user
            await page.Locator("//*[@name='username']").FillAsync(username);
            await page.Locator("//*[@name='password']").FillAsync(password);
            await page.Locator("//*[@type='submit']").ClickAsync();
            var pageTitle = await page.TitleAsync();
            await Assertions.Expect(page).ToHaveTitleAsync(pageTitle);

        }

        private string GenerateRandomString(int length)
        {
            // Define the characters allowed in the random string
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

            // Create an instance of the Random class
            Random random = new Random();

            // Generate the random string
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        [TearDown]
        public async Task TearDown()
        {
            // Clean up Playwright resources
            if (page != null)
            {
                await page.CloseAsync();
            }
            if (context != null)
            {
                await context.CloseAsync();
            }
            if (browser != null)
            {
                await browser.CloseAsync();
            }
            if (playwright != null)
            {
                playwright.Dispose();
            }
        }
    }
}
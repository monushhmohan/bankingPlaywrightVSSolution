using System;
using Microsoft.Playwright;

namespace playwrightParaBank.Tests
{
	public class RegisterUser

	{
		public async Task<(string,string)> RegisterNewUser()
		{
			var playwright = await Playwright.CreateAsync();
			var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions {
				Headless = true, SlowMo = 5, Timeout= 80000
			});
			var context = await browser.NewContextAsync();
			var page = await context.NewPageAsync();

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
            var password = GenerateRandomString(9);
            await page.Locator("//*[@id='customer.password']").FillAsync(password);
            await page.Locator("//*[@id='repeatedPassword']").FillAsync(password);
            await page.Locator("//*[@value='Register']").ClickAsync();
            return (username, password);
        }

        static string GenerateRandomString(int length)
        {
            // Define the characters allowed in the random string
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

            // Create an instance of the Random class
            Random random = new Random();

            // Generate the random string
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}


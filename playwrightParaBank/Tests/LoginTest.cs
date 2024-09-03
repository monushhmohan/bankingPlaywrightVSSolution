using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework; // or MSTest equivalent
using playwrightParaBank.Tests;

namespace playwrightParaBank.Tests
{

    public class LoginTest : RegisterUser
    {
   
        [Test]
        public async Task Login_test001()
        {
            RegisterUser user = new RegisterUser();
            var(username, password) = await user.RegisterNewUser();

            var playwright = await Playwright.CreateAsync();
            var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false,
                SlowMo = 500,
                Timeout = 80000
            });
            var context = await browser.NewContextAsync();
            var page = await context.NewPageAsync();

            await page.GotoAsync("https://parabank.parasoft.com");

            await page.Locator("//*[@name='username']").FillAsync(username);
            await page.Locator("//*[@name='password']").FillAsync(password);
            await page.Locator("//*[@type='submit']").ClickAsync();
            var pageTitle  = await page.TitleAsync();
            await Assertions.Expect(page).ToHaveTitleAsync(pageTitle);

        }
    }
}
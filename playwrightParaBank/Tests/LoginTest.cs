using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework; // or MSTest equivalent
using playwrightParaBank.Tests;

public class LoginTest : RegisterTest
{

    [Test]
    public async Task Login_test001()
    {

        var playwright = await Playwright.CreateAsync();
        var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions {
            Headless= false, SlowMo = 500, Timeout= 80000
        });
        var context = await browser.NewContextAsync();
        var page = await context.NewPageAsync();

        await page.GotoAsync("https://parabank.parasoft.com");

        //Login with the above created user creds

        await page.Locator("//*[@name='username']").FillAsync("user001");
        await page.Locator("//*[@name='password']").FillAsync("pass001");
        await page.Locator("//*[@type='submit']").ClickAsync();
        await Assertions.Expect(page.Locator("//*[@id='leftPanel']/p/text()")).ToHaveTextAsync("Test Test");

    }
}
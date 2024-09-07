using Microsoft.Playwright;
using playwrightParaBank.Pages;

namespace playwrightParaBank.Tests
{

    public class OpenNewSavingsAccountTest : BaseClass
    {
        [Test]
        public async Task OpenNewSavingsAccount_test002()
        {
            await page.GetByText("Welcome test test").ClickAsync();
 
            HomePage home = new HomePage(page);
            await home.ClickOnOpenANewAccount();
            await page.Locator("#type").SelectOptionAsync(new[] { "1" });
            await page.Locator("//*[@value='Open New Account']").ClickAsync();
            await page.GetByText("Congratulations, your account").ClickAsync();
            //await page.GetByRole(AriaRole.Link, new() { Name = "17673" }).ClickAsync();

        }

    }
}


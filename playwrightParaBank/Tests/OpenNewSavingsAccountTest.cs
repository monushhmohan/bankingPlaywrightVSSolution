using Microsoft.Playwright;

namespace playwrightParaBank.Tests
{

    public class OpenNewSavingsAccountTest : BaseClass
    {
        [Test]
        public async Task OpenNewSavingsAccount_test002()
        {
            await page.GetByText("Welcome test test").ClickAsync();
            await page.GetByRole(AriaRole.Heading, new() { Name = "Account Services" }).ClickAsync();
            await page.GetByRole(AriaRole.Link, new() { Name = "Open New Account" }).ClickAsync();
            await page.Locator("#type").SelectOptionAsync(new[] { "1" });
            await page.Locator("//*[@value='Open New Account']").ClickAsync();
            //*[@id="openAccountForm"]/form/div/input
            //*[@value="Open New Account"]
            await page.GetByText("Congratulations, your account").ClickAsync();
            //await page.GetByRole(AriaRole.Link, new() { Name = "17673" }).ClickAsync();

        }

    }
}


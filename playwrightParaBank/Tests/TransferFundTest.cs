using System;
using Microsoft.Playwright;

namespace playwrightParaBank.Tests
{

    public class TransferFundTest: BaseClass
    {
        [Test]
        public async Task TransferFunds_test003(){
            await page.Locator("#leftPanel").GetByRole(AriaRole.Link, new() { Name = "Transfer Funds" }).ClickAsync();
            await page.Locator("#amount").ClickAsync();
            await page.Locator("#amount").FillAsync("100");
            await page.GetByRole(AriaRole.Button, new() { Name = "Transfer" }).ClickAsync();
            await page.GetByRole(AriaRole.Heading, new() { Name = "Transfer Complete!" }).ClickAsync();
        }
    }
}


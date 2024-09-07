using System;
using Microsoft.Playwright;
using static System.Net.Mime.MediaTypeNames;

namespace playwrightParaBank.Pages
{
    public class HomePage
    {
        private readonly IPage page;
        public HomePage(IPage page)
        {
            this.page = page;
        }

        // Selectors for the elements
        private ILocator AccountServicesLink => page.GetByRole(AriaRole.Heading, new() { Name = "Account Services" });
        private ILocator OpenNewAccountLink => page.GetByRole(AriaRole.Link, new() { Name = "Open New Account" });

        // Methods for actions on the page
        public async Task ClickOnOpenANewAccount()
        {
            await AccountServicesLink.ClickAsync();
            await OpenNewAccountLink.ClickAsync();
        }
    }
}


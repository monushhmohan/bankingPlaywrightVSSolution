using System;
using Microsoft.Playwright;

namespace playwrightParaBank.Tests
{
	public class UpdateContactInfoTest : BaseClass
	{
        public UpdateContactInfoTest()
        {
        }

        [Test]
        public async Task UpdateContactInfo_test004()
        {
            await page.GetByRole(AriaRole.Link, new() { Name = "Update Contact Info" }).ClickAsync();
            await page.Locator("[id='customer.address.city']").ClickAsync();
            await page.Locator("[id='customer.address.street']").FillAsync("Xyz Street");
            await page.Locator("[id='customer.address.city']").FillAsync("Southampton");
            await page.GetByRole(AriaRole.Button, new() { Name = "Update Profile" }).ClickAsync();
            await page.GetByText("Your updated address and").ClickAsync();
            await page.GetByRole(AriaRole.Heading, new() { Name = "Profile Updated" }).ClickAsync();
        }


    }
}


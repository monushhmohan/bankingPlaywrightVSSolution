﻿using Microsoft.Playwright;

public class LoginTest
{

    [Test]
    public async Task Login_test001()
    {

        var playwright = await Playwright.CreateAsync();
        var browser = await playwright.Chromium.LaunchAsync();
        var context = await browser.NewContextAsync();
        var page = await context.NewPageAsync();

        await page.GotoAsync("https://parabank.parasoft.com");

    }

}
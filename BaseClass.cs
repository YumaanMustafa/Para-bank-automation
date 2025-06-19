using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace SQA_Testing_Project
{
    public class BaseClass
    {
        public static IPage page;
        IPlaywright playwright;

        public async Task OpenBrowser()
        {
            playwright = await Playwright.CreateAsync();
            var browser = await playwright.Chromium.LaunchAsync(
                new BrowserTypeLaunchOptions { Headless = false }
                
                );
            page = await browser.NewPageAsync();
        }

        public async Task GoToURL()
        {
            var jsonData = JsonObject.Parse(File.ReadAllText("C:\\Users\\HAMZA SIRAJ\\source\\repos\\SQA_Testing_Project\\SQA_Testing_Project\\data.json"));
            string url = jsonData["url"].ToString();
            await page.GotoAsync( url );
        }

        public async Task CloseBrowser()
        {
            await page.CloseAsync();

        }
    }
}

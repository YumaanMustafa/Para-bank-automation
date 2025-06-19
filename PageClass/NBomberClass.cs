using Microsoft.Playwright;
using NBomber.Contracts.Stats;
using NBomber.Contracts;
using NBomber.Http;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using NBomber.CSharp;

namespace SQA_Testing_Project.PageClass
{
    public class NBomberClass:BaseClass
    {
        IPage _page;
        

        
        
        public async Task NbomberLoginUsers()
        {

            var jsonData = JsonObject.Parse(File.ReadAllText("C:\\Users\\HAMZA SIRAJ\\source\\repos\\SQA_Testing_Project\\SQA_Testing_Project\\data.json"));
            string username = jsonData["username"].ToString();
            string password = jsonData["password"].ToString();

            string sce = "Load Test with Playwright in ParaBank Application";
            var playwright = await Playwright.CreateAsync();
            var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false
            });
           
            
            
            var scenario = Scenario.Create(sce, async scenarioContext =>
            {
                var page = await browser.NewPageAsync();

                await page.GotoAsync("https://parabank.parasoft.com/parabank/index.htm");

                await page.Locator(LocatorClass.LoginUsername).FillAsync(username);
                await page.Locator(LocatorClass.LoginPassword).FillAsync(password);
                await page.Locator(LocatorClass.LoginButton).ClickAsync();
                
                return Response.Ok();
                await page.CloseAsync();

            }).WithLoadSimulations(LoadSimulation.NewRampingConstant(5, TimeSpan.FromSeconds(30)));
            var result = NBomberRunner.RegisterScenarios(scenario)
          .WithReportFolder("Reports1")       
          .WithReportFormats(ReportFormat.Html) 
          .WithWorkerPlugins(new HttpMetricsPlugin(new[] { HttpVersion.Version1 }))
          .Run();

            Assert.That(result.ScenarioStats.Get(sce).Ok.Latency.Percent75 < 6000);
        }


        public async Task NbomberLoginUsersAndBillPayment()
        {

            var jsonData = JsonObject.Parse(File.ReadAllText("C:\\Users\\HAMZA SIRAJ\\source\\repos\\SQA_Testing_Project\\SQA_Testing_Project\\data.json"));
            string username = jsonData["username"].ToString();
            string password = jsonData["password"].ToString();

            string billpayee = jsonData["Billpayeename"].ToString();
            string billaddress = jsonData["BillAddress"].ToString();
            string billcity = jsonData["BillCity"].ToString();
            string billstate = jsonData["BillState"].ToString();
            string billzipcode = jsonData["BillZipcode"].ToString();
            string billPhone = jsonData["BillPhone"].ToString();
            string billAccount = jsonData["BillAccount"].ToString();
            string billVerifyAccount = jsonData["BillVerifyAccount"].ToString();
            string billAmount = jsonData["BillAmount"].ToString();

            string sce = "Load Test with Playwright in ParaBank Application";
            var playwright = await Playwright.CreateAsync();
            var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false
            });


            
            var scenario = Scenario.Create(sce, async scenarioContext =>
            {
                var page = await browser.NewPageAsync();

                await page.GotoAsync("https://parabank.parasoft.com/parabank/index.htm");

                await page.Locator(LocatorClass.LoginUsername).FillAsync(username);
                await page.Locator(LocatorClass.LoginPassword).FillAsync(password);
                await page.Locator(LocatorClass.LoginButton).ClickAsync();

                await page.Locator(LocatorClass.NavigationtoBillPay).ClickAsync();
                await page.Locator(LocatorClass.PayeeName).FillAsync(billpayee);
                await page.Locator(LocatorClass.BillAdress).FillAsync(billaddress);
                await page.Locator(LocatorClass.BillCity).FillAsync(billcity);
                await page.Locator(LocatorClass.BillState).FillAsync(billstate);
                await page.Locator(LocatorClass.BillZipcode).FillAsync(billzipcode);
                await page.Locator(LocatorClass.BillPhone).FillAsync(billPhone);
                await page.Locator(LocatorClass.BillAccount).FillAsync(billAccount);
                await page.Locator(LocatorClass.BillVerifyAccount).FillAsync(billVerifyAccount);
                await page.Locator(LocatorClass.BillAmount).FillAsync(billAmount);
                await page.Locator(LocatorClass.BillFromAccount).SelectOptionAsync(new SelectOptionValue { Index = 0 });
                await page.Locator(LocatorClass.BillPayButton).ClickAsync();

                return Response.Ok();
                await page.CloseAsync();

            }).WithLoadSimulations(LoadSimulation.NewRampingConstant(5, TimeSpan.FromSeconds(30)));
            var result = NBomberRunner.RegisterScenarios(scenario)
          .WithReportFolder("Reports2")       
          .WithReportFormats(ReportFormat.Html) 
          .WithWorkerPlugins(new HttpMetricsPlugin(new[] { HttpVersion.Version1 })) 
          .Run();

            Assert.That(result.ScenarioStats.Get(sce).Ok.Latency.Percent75 < 7000);
        }

    }
}

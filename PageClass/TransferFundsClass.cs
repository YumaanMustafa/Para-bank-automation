using Microsoft.Playwright;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace SQA_Testing_Project.PageClass
{
    public class TransferFundsClass : BaseClass
    {
        IPage _page;
        ILocator NavigationTransferFund;
        ILocator TransferFundAmount;
        ILocator TransferFundFromAmount;
        ILocator TransferFundToAmount;
        ILocator TransferFundButton;
        ILocator TransferFundSuccess;
        ILocator TransferFundError;

        ILocator LoginUsername;
        ILocator LoginPassword;
        ILocator LoginButton;

        public TransferFundsClass(IPage page)
        {
            _page = page;
            NavigationTransferFund = _page.Locator(LocatorClass.NavigationTransferFund);
            TransferFundAmount = _page.Locator(LocatorClass.TransferFundAmount);
            TransferFundFromAmount = _page.Locator(LocatorClass.TransferFundFromAmount);
            TransferFundToAmount = _page.Locator(LocatorClass.TransferFundToAmount);
            TransferFundButton = _page.Locator(LocatorClass.TransferFundButton);
            TransferFundSuccess = _page.Locator(LocatorClass.TransferFundSuccess);
            TransferFundError = _page.Locator(LocatorClass.TransferFundError);

            LoginUsername = _page.Locator(LocatorClass.LoginUsername);
            LoginPassword = _page.Locator(LocatorClass.LoginPassword);
            LoginButton = _page.Locator(LocatorClass.LoginButton);

        }

        public async Task TransferFundValid()
        {
            var jsonData = JsonObject.Parse(File.ReadAllText("C:\\Users\\HAMZA SIRAJ\\source\\repos\\SQA_Testing_Project\\SQA_Testing_Project\\data.json"));
            string username = jsonData["username"].ToString();
            string password = jsonData["password"].ToString();
            string Amount = jsonData["TransferFundAmount"].ToString();
            string ExpectedResult = jsonData["TransferFundSuccess"].ToString();

            await LoginUsername.FillAsync(username);
            await LoginPassword.FillAsync(password);
            await LoginButton.ClickAsync();

            await NavigationTransferFund.ClickAsync();
            await TransferFundAmount.FillAsync(Amount);
            await TransferFundFromAmount.SelectOptionAsync(new SelectOptionValue { Index = 0 });
            await TransferFundToAmount.SelectOptionAsync(new SelectOptionValue { Index = 1 });
            await TransferFundButton.ClickAsync();

            Assert.That(ExpectedResult.Trim(), Is.EqualTo((await _page.InnerHTMLAsync(LocatorClass.TransferFundSuccess)).Trim()));
        }

        public async Task TransferFundEmptyAmount()
        {
            var jsonData = JsonObject.Parse(File.ReadAllText("C:\\Users\\HAMZA SIRAJ\\source\\repos\\SQA_Testing_Project\\SQA_Testing_Project\\data.json"));
            string username = jsonData["username"].ToString();
            string password = jsonData["password"].ToString();
            
            string ErrorResult = jsonData["TransferFundError"].ToString();

            await LoginUsername.FillAsync(username);
            await LoginPassword.FillAsync(password);
            await LoginButton.ClickAsync();

            await NavigationTransferFund.ClickAsync();
            await TransferFundFromAmount.SelectOptionAsync(new SelectOptionValue { Index = 0 });
            await TransferFundToAmount.SelectOptionAsync(new SelectOptionValue { Index = 1 });
            await TransferFundButton.ClickAsync();

            Assert.That(ErrorResult.Trim(), Is.EqualTo((await _page.InnerHTMLAsync(LocatorClass.TransferFundError)).Trim()));
        }

        public async Task TransferFundSpecialCharAmount()
        {
            var jsonData = JsonObject.Parse(File.ReadAllText("C:\\Users\\HAMZA SIRAJ\\source\\repos\\SQA_Testing_Project\\SQA_Testing_Project\\data.json"));
            string username = jsonData["username"].ToString();
            string password = jsonData["password"].ToString();
            string Amount = jsonData["TransferFundSpecialCharAmount"].ToString();
            string ErrorResult = jsonData["TransferFundError"].ToString();

            await LoginUsername.FillAsync(username);
            await LoginPassword.FillAsync(password);
            await LoginButton.ClickAsync();
            await NavigationTransferFund.ClickAsync();
            await TransferFundAmount.FillAsync(Amount);
            await TransferFundFromAmount.SelectOptionAsync(new SelectOptionValue { Index = 0 });
            await TransferFundToAmount.SelectOptionAsync(new SelectOptionValue { Index = 1 });
            await TransferFundButton.ClickAsync();

            Assert.That(ErrorResult.Trim(), Is.EqualTo((await _page.InnerHTMLAsync(LocatorClass.TransferFundError)).Trim()));
        }
    }
}
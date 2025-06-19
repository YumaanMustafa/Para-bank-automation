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
    public class OpenNewAccountClass:BaseClass
    {
       IPage _page;

        ILocator LoginUsername;
        ILocator LoginPassword;
        ILocator LoginButton;
        ILocator CheckingType;
        ILocator OpenNewAccountButton;
        ILocator expectedtextcong;
        ILocator navtonewAccount;
        ILocator PageOpenNewAccount;
        ILocator Accountno;
        ILocator ActivityPriod;
        ILocator Type;
        ILocator GoButton;
        ILocator navTransactionDetails;
        ILocator credittype;
        ILocator debittype;
        public OpenNewAccountClass(IPage page)
        {
            _page = page;

            LoginUsername = _page.Locator(LocatorClass.LoginUsername);
            LoginPassword = _page.Locator(LocatorClass.LoginPassword);
            LoginButton = _page.Locator(LocatorClass.LoginButton);
            CheckingType = _page.Locator(LocatorClass.checkingtype);
            OpenNewAccountButton = _page.Locator(LocatorClass.OpenNewAccountButton);
            expectedtextcong = _page.Locator(LocatorClass.expectedtextcong);
            navtonewAccount = _page.Locator(LocatorClass.navtonewAccount);
            PageOpenNewAccount = _page.Locator(LocatorClass.PageofOpenNewAccount);
            Accountno = _page.Locator(LocatorClass.Accountno);
            ActivityPriod = _page.Locator(LocatorClass.ActivityPriod);
            Type = _page.Locator(LocatorClass.Type);
            GoButton = _page.Locator(LocatorClass.GoButton);
            navTransactionDetails = _page.Locator(LocatorClass.navTransactionDetails);
            credittype = _page.Locator(LocatorClass.credittype);
            debittype = _page.Locator(LocatorClass.debittype);
        }


        public async Task OpenNewAccountCredit()
        {
            var jsonData = JsonObject.Parse(File.ReadAllText("C:\\Users\\HAMZA SIRAJ\\source\\repos\\SQA_Testing_Project\\SQA_Testing_Project\\data.json"));
            string username = jsonData["username"].ToString();
            string password = jsonData["password"].ToString();
            string ExpectedCongration = jsonData["ExpectedAccountOpenText"].ToString();
            string ExpectedtypeCredit = jsonData["ExpectedtypeCredit"].ToString();

            await LoginUsername.FillAsync(username);
            await LoginPassword.FillAsync(password);    
            await LoginButton.ClickAsync();     
            await PageOpenNewAccount.ClickAsync();
   
            await CheckingType.SelectOptionAsync(new SelectOptionValue { Index = 0});
            await Accountno.SelectOptionAsync(new SelectOptionValue { Index = 0 });
            await OpenNewAccountButton.ClickAsync();
           
            Assert.That(ExpectedCongration, Is.EqualTo(await _page.InnerTextAsync(LocatorClass.expectedtextcong)));
            
            await navtonewAccount.ClickAsync();

            await ActivityPriod.SelectOptionAsync(new SelectOptionValue { Index = 0});
            await Type.SelectOptionAsync(new SelectOptionValue { Index = 1 });

            await GoButton.ClickAsync();
            await navTransactionDetails.ClickAsync();

            Assert.That(ExpectedtypeCredit, Is.EqualTo(await _page.InnerTextAsync(LocatorClass.credittype)));

        }

        public async Task OpenNewAccountDebit()
        {
            var jsonData = JsonObject.Parse(File.ReadAllText("C:\\Users\\HAMZA SIRAJ\\source\\repos\\SQA_Testing_Project\\SQA_Testing_Project\\data.json"));
            string username = jsonData["username"].ToString();
            string password = jsonData["password"].ToString();
            string ExpectedCongration = jsonData["ExpectedAccountOpenText"].ToString();
            string ExpectedtypeDebit = jsonData["ExpectedtypeDebit"].ToString();

            await LoginUsername.FillAsync(username);
            await LoginPassword.FillAsync(password);
            await LoginButton.ClickAsync();
            await PageOpenNewAccount.ClickAsync();

            await CheckingType.SelectOptionAsync(new SelectOptionValue { Index = 0 });
            await Accountno.SelectOptionAsync(new SelectOptionValue { Index = 0 });
            await OpenNewAccountButton.ClickAsync();

            Assert.That(ExpectedCongration, Is.EqualTo(await _page.InnerTextAsync(LocatorClass.expectedtextcong)));

            await navtonewAccount.ClickAsync();

            await ActivityPriod.SelectOptionAsync(new SelectOptionValue { Index = 0 });
            await Type.SelectOptionAsync(new SelectOptionValue { Index = 2 });

            await GoButton.ClickAsync();
            

            Assert.That(ExpectedtypeDebit, Is.EqualTo(await _page.InnerTextAsync(LocatorClass.debittype)));

        }
    }
}

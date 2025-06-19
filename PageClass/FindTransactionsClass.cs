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
    public class FindTransactionsClass : BaseClass
    {
        IPage _page;

        ILocator NavigationToFindTransactions;
        ILocator FindSelectAmount;
        ILocator FindByDate;
        ILocator FindByDateButton;
        ILocator FindByDateRangeBetween;
        ILocator FindByDateRangeAnd;
        ILocator FindByDateRangeButton;
        ILocator FindByAmount;
        ILocator FindByAmountButton;
        ILocator InvalidFindByDate;
        ILocator InvalidFindByDateRange;
        ILocator InvalidFindByAmount;
        ILocator ConfirmFindByDate;
        ILocator ConfirmFindByAmountDebit;
        ILocator ConfirmFindByAmountCredit;
        ILocator FindByEXBAD;

        ILocator LoginUsername;
        ILocator LoginPassword;
        ILocator LoginButton;

        public FindTransactionsClass(IPage page)
        {
            _page = page;
            NavigationToFindTransactions = _page.Locator(LocatorClass.NavigationToFindTransactions);
            FindSelectAmount = _page.Locator(LocatorClass.FindSelectAmount);
            FindByDate = _page.Locator(LocatorClass.FindByDate);
            FindByDateButton = _page.Locator(LocatorClass.FindByDateButton);
            FindByDateRangeBetween = _page.Locator(LocatorClass.FindByDateRangeBetween);
            FindByDateRangeAnd = _page.Locator(LocatorClass.FindByDateRangeAnd);
            FindByDateRangeButton = _page.Locator(LocatorClass.FindByDateRangeButton);
            FindByAmount = _page.Locator(LocatorClass.FindByAmount);
            FindByAmountButton = _page.Locator(LocatorClass.FindByAmountButton);
            InvalidFindByDate = _page.Locator(LocatorClass.InvalidFindByDate);
            InvalidFindByDateRange = _page.Locator(LocatorClass.InvalidFindByDateRange);
            InvalidFindByAmount = _page.Locator(LocatorClass.InvalidFindByAmount);
            ConfirmFindByDate = _page.Locator(LocatorClass.ConfirmFindByDate);
            ConfirmFindByAmountDebit = _page.Locator(LocatorClass.ConfirmFindByAmountDebit);
            ConfirmFindByAmountCredit = _page.Locator(LocatorClass.ConfirmFindByAmountCredit);
            FindByEXBAD = _page.Locator(LocatorClass.FindByEXBAD);

            LoginUsername = _page.Locator(LocatorClass.LoginUsername);
            LoginPassword = _page.Locator(LocatorClass.LoginPassword);
            LoginButton = _page.Locator(LocatorClass.LoginButton);
        }

        public async Task FindByDateValid()
        {
            var jsonData = JsonObject.Parse(File.ReadAllText("C:\\Users\\HAMZA SIRAJ\\source\\repos\\SQA_Testing_Project\\SQA_Testing_Project\\data.json"));
            string username = jsonData["username"].ToString();
            string password = jsonData["password"].ToString();
            string ExpectedDate = jsonData["FindByDateInputOne"].ToString();

            await LoginUsername.FillAsync(username);
            await LoginPassword.FillAsync(password);
            await LoginButton.ClickAsync();

            await NavigationToFindTransactions.ClickAsync();
            await FindSelectAmount.SelectOptionAsync(new SelectOptionValue { Index = 3 });
            await Task.Delay(1000);
            await FindByDate.FillAsync(ExpectedDate);
            await FindByDateButton.ClickAsync();

            Assert.That(ExpectedDate.Trim(), Is.EqualTo((await _page.InnerHTMLAsync(LocatorClass.ConfirmFindByDate)).Trim()));
        }

        public async Task FindByDateEmptyField()
        {
            var jsonData = JsonObject.Parse(File.ReadAllText("C:\\Users\\HAMZA SIRAJ\\source\\repos\\SQA_Testing_Project\\SQA_Testing_Project\\data.json"));
            string username = jsonData["username"].ToString();
            string password = jsonData["password"].ToString();
            string EmptyFieldError = jsonData["FindByInvalidDate"].ToString();

            await LoginUsername.FillAsync(username);
            await LoginPassword.FillAsync(password);
            await LoginButton.ClickAsync();

            await NavigationToFindTransactions.ClickAsync();
            await FindSelectAmount.SelectOptionAsync(new SelectOptionValue { Index = 3 });
            await Task.Delay(1000);

            await FindByDateButton.ClickAsync();

            Assert.That(EmptyFieldError.Trim(), Is.EqualTo((await _page.InnerHTMLAsync(LocatorClass.InvalidFindByDate)).Trim()));
        }


        public async Task FindByDateInvalid()
        {
            var jsonData = JsonObject.Parse(File.ReadAllText("C:\\Users\\HAMZA SIRAJ\\source\\repos\\SQA_Testing_Project\\SQA_Testing_Project\\data.json"));
            string username = jsonData["username"].ToString();
            string password = jsonData["password"].ToString();
            string WrongDate = jsonData["FindBydateInputWrong"].ToString();
            string Error = jsonData["FindByInvalidDate"].ToString();

            await LoginUsername.FillAsync(username);
            await LoginPassword.FillAsync(password);
            await LoginButton.ClickAsync();



            await NavigationToFindTransactions.ClickAsync();
            await FindSelectAmount.SelectOptionAsync(new SelectOptionValue { Index = 3 });
            await Task.Delay(1000);

            await FindByDate.FillAsync(WrongDate);
            await FindByDateButton.ClickAsync();

            Assert.That(Error.Trim(), Is.EqualTo((await _page.InnerHTMLAsync(LocatorClass.InvalidFindByDate)).Trim()));
        }

        public async Task FindByDateSpecialChar()
        {
            var jsonData = JsonObject.Parse(File.ReadAllText("C:\\Users\\HAMZA SIRAJ\\source\\repos\\SQA_Testing_Project\\SQA_Testing_Project\\data.json"));
            string username = jsonData["username"].ToString();
            string password = jsonData["password"].ToString();
            string SpecialCharDate = jsonData["FindBySpecialChar"].ToString();
            string Error = jsonData["FindByInvalidDate"].ToString();

            await LoginUsername.FillAsync(username);
            await LoginPassword.FillAsync(password);
            await LoginButton.ClickAsync();

            await NavigationToFindTransactions.ClickAsync();
            await FindSelectAmount.SelectOptionAsync(new SelectOptionValue { Index = 3 });
            await Task.Delay(1000);
            await FindByDate.FillAsync(SpecialCharDate);
            await FindByDateButton.ClickAsync();

            Assert.That(Error.Trim(), Is.EqualTo((await _page.InnerHTMLAsync(LocatorClass.InvalidFindByDate)).Trim()));
        }

        public async Task FindByDateRangeValid()
        {
            var jsonData = JsonObject.Parse(File.ReadAllText("C:\\Users\\HAMZA SIRAJ\\source\\repos\\SQA_Testing_Project\\SQA_Testing_Project\\data.json"));
            string username = jsonData["username"].ToString();
            string password = jsonData["password"].ToString();
            string ExpectedDateone = jsonData["FindByDateInputOne"].ToString();
            string ExpectedDatetwo = jsonData["FindByDateInputTwo"].ToString();

            await LoginUsername.FillAsync(username);
            await LoginPassword.FillAsync(password);
            await LoginButton.ClickAsync();

            await NavigationToFindTransactions.ClickAsync();
            await FindSelectAmount.SelectOptionAsync(new SelectOptionValue { Index = 3 });
            await Task.Delay(1000);
            await FindByDateRangeBetween.FillAsync(ExpectedDateone);
            await FindByDateRangeAnd.FillAsync(ExpectedDatetwo);
            await FindByDateRangeButton.ClickAsync();

            Assert.That(ExpectedDatetwo.Trim(), Is.EqualTo((await _page.InnerHTMLAsync(LocatorClass.ConfirmFindByDate)).Trim()));
        }

        public async Task FindByDateRangeEmptyField()
        {
            var jsonData = JsonObject.Parse(File.ReadAllText("C:\\Users\\HAMZA SIRAJ\\source\\repos\\SQA_Testing_Project\\SQA_Testing_Project\\data.json"));
            string username = jsonData["username"].ToString();
            string password = jsonData["password"].ToString();
            string EmptyFieldError = jsonData["FindByInvalidDate"].ToString();

            await LoginUsername.FillAsync(username);
            await LoginPassword.FillAsync(password);
            await LoginButton.ClickAsync();

            await NavigationToFindTransactions.ClickAsync();
            await FindSelectAmount.SelectOptionAsync(new SelectOptionValue { Index = 3 });
            await Task.Delay(1000);

            await FindByDateRangeButton.ClickAsync();

            Assert.That(EmptyFieldError.Trim(), Is.EqualTo((await _page.InnerHTMLAsync(LocatorClass.InvalidFindByDateRange)).Trim()));
        }


        public async Task FindByDateRangeInvalid()
        {
            var jsonData = JsonObject.Parse(File.ReadAllText("C:\\Users\\HAMZA SIRAJ\\source\\repos\\SQA_Testing_Project\\SQA_Testing_Project\\data.json"));
            string username = jsonData["username"].ToString();
            string password = jsonData["password"].ToString();
            string WrongDate = jsonData["FindBydateInputWrong"].ToString();
            string Error = jsonData["FindByInvalidDate"].ToString();

            await LoginUsername.FillAsync(username);
            await LoginPassword.FillAsync(password);
            await LoginButton.ClickAsync();

            await NavigationToFindTransactions.ClickAsync();
            await FindSelectAmount.SelectOptionAsync(new SelectOptionValue { Index = 3 });
            await Task.Delay(1000);
            await FindByDateRangeBetween.FillAsync(WrongDate);
            await FindByDateRangeAnd.FillAsync(WrongDate);
            await FindByDateRangeButton.ClickAsync();

            Assert.That(Error.Trim(), Is.EqualTo((await _page.InnerHTMLAsync(LocatorClass.InvalidFindByDateRange)).Trim()));
        }

        public async Task FindByDateRangeSpecialChar()
        {
            var jsonData = JsonObject.Parse(File.ReadAllText("C:\\Users\\HAMZA SIRAJ\\source\\repos\\SQA_Testing_Project\\SQA_Testing_Project\\data.json"));
            string username = jsonData["username"].ToString();
            string password = jsonData["password"].ToString();
            string SpecialCharDate = jsonData["FindBySpecialChar"].ToString();
            string Error = jsonData["FindByInvalidDate"].ToString();

            await LoginUsername.FillAsync(username);
            await LoginPassword.FillAsync(password);
            await LoginButton.ClickAsync();

            await NavigationToFindTransactions.ClickAsync();
            await FindSelectAmount.SelectOptionAsync(new SelectOptionValue { Index = 3 });
            await Task.Delay(1000);
            await FindByDateRangeBetween.FillAsync(SpecialCharDate);
            await FindByDateRangeAnd.FillAsync(SpecialCharDate);
            await FindByDateRangeButton.ClickAsync();

            Assert.That(Error.Trim(), Is.EqualTo((await _page.InnerHTMLAsync(LocatorClass.InvalidFindByDateRange)).Trim()));
        }

        public async Task FindByAmountValid()
        {
            var jsonData = JsonObject.Parse(File.ReadAllText("C:\\Users\\HAMZA SIRAJ\\source\\repos\\SQA_Testing_Project\\SQA_Testing_Project\\data.json"));
            string username = jsonData["username"].ToString();
            string password = jsonData["password"].ToString();
           // string Amount = jsonData["FindByAmountInput"].ToString();
            string Creditfind = jsonData["FindByCreditAmount"].ToString();
            string Debitfind = jsonData["FindByDebitAmount"].ToString();
            string transferfind = jsonData["FindByAmountInput"].ToString();
            string Credit = jsonData["Amountcredit"].ToString();
            string Debit = jsonData["DownPayment"].ToString();
            string transfer = jsonData["TransferFundAmount"].ToString();
            string EXBAD = jsonData["FindByEXBad"].ToString();

            await LoginUsername.FillAsync(username);
            await LoginPassword.FillAsync(password);
            await LoginButton.ClickAsync();

            // find by credit amount
            await NavigationToFindTransactions.ClickAsync();
            await FindSelectAmount.SelectOptionAsync(new SelectOptionValue { Index = 3});
            await Task.Delay(1000);
            await FindByAmount.FillAsync(Credit);
            await FindByAmountButton.ClickAsync();
            Assert.That(Creditfind.Trim(), Is.EqualTo((await _page.InnerHTMLAsync(LocatorClass.ConfirmFindByAmountCredit)).Trim()));

            // find by Request loan amount
            await NavigationToFindTransactions.ClickAsync();
            await FindSelectAmount.SelectOptionAsync(new SelectOptionValue { Index = 3 });
            await Task.Delay(1000);
            await FindByAmount.FillAsync(Debit);
            await FindByAmountButton.ClickAsync();
            if (Debitfind == await _page.InnerHTMLAsync(LocatorClass.ConfirmFindByAmountDebit))
            {
                Assert.That(Debitfind.Trim(), Is.EqualTo((await _page.InnerHTMLAsync(LocatorClass.ConfirmFindByAmountDebit)).Trim()));
            }
            else
            {
                Assert.That(EXBAD.Trim(), Is.EqualTo((await _page.InnerHTMLAsync(LocatorClass.FindByEXBAD)).Trim()));
            }


            //find by Transfer funds amount
            await NavigationToFindTransactions.ClickAsync();
            await FindSelectAmount.SelectOptionAsync(new SelectOptionValue { Index = 3 });
            await Task.Delay(1000);
            await FindByAmount.FillAsync(transfer);
            await FindByAmountButton.ClickAsync();
            if (transferfind == await _page.InnerHTMLAsync(LocatorClass.confirmFindByTransferRecieved))
            {
                Assert.That(transferfind.Trim(), Is.EqualTo((await _page.InnerHTMLAsync(LocatorClass.confirmFindByTransferRecieved)).Trim()));
            }
            else
            {
                Assert.That(EXBAD.Trim(), Is.EqualTo((await _page.InnerHTMLAsync(LocatorClass.FindByEXBAD)).Trim()));
            }

        }

        public async Task FindByAmountSpecialcharsAndLetters()
        {
            var jsonData = JsonObject.Parse(File.ReadAllText("C:\\Users\\HAMZA SIRAJ\\source\\repos\\SQA_Testing_Project\\SQA_Testing_Project\\data.json"));
            string username = jsonData["username"].ToString();
            string password = jsonData["password"].ToString();
           
            string specialcharsAndLetters = jsonData["findByspecailcharandlettersAmount"].ToString();
            string Error = jsonData["FindByInvalidAmount"].ToString();

            await LoginUsername.FillAsync(username);
            await LoginPassword.FillAsync(password);
            await LoginButton.ClickAsync();

            // find by credit amount
            await NavigationToFindTransactions.ClickAsync();
            await FindSelectAmount.SelectOptionAsync(new SelectOptionValue { Index = 3 });
            await Task.Delay(1000);
            await FindByAmount.FillAsync(specialcharsAndLetters);
            await FindByAmountButton.ClickAsync();
            Assert.That(Error.Trim(), Is.EqualTo((await _page.InnerHTMLAsync(LocatorClass.InvalidFindByAmount)).Trim()));

            
        }


        public async Task FindByAmountEmptyField()
        {
            var jsonData = JsonObject.Parse(File.ReadAllText("C:\\Users\\HAMZA SIRAJ\\source\\repos\\SQA_Testing_Project\\SQA_Testing_Project\\data.json"));
            string username = jsonData["username"].ToString();
            string password = jsonData["password"].ToString();

            
            string Error = jsonData["FindByInvalidAmount"].ToString();

            await LoginUsername.FillAsync(username);
            await LoginPassword.FillAsync(password);
            await LoginButton.ClickAsync();

            // find by credit amount
            await NavigationToFindTransactions.ClickAsync();
            await FindSelectAmount.SelectOptionAsync(new SelectOptionValue { Index = 3 });
            await Task.Delay(1000);
            
            await FindByAmountButton.ClickAsync();
            Assert.That(Error.Trim(), Is.EqualTo((await _page.InnerHTMLAsync(LocatorClass.InvalidFindByAmount)).Trim()));


        }
    }
}

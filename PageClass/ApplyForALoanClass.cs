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
    public class ApplyForALoanClass:BaseClass
    {
        IPage _page;

        ILocator NavigationtoApplyforLoan;
        ILocator LoanAmount;
        ILocator DownPayment;
        ILocator FromAccount;
        ILocator ApplyForLoanButton;
        ILocator ExpectedSuccessLoanText;
        ILocator navtoNewLoanAccount;
        ILocator ExpectedTextLoan;
        ILocator LoginUsername;
        ILocator LoginPassword;
        ILocator LoginButton;
        ILocator ErrorApplyLoan;
        ILocator FieldErrorApplyLoan;

        public ApplyForALoanClass (IPage page)
        {
            _page = page;
            NavigationtoApplyforLoan = _page.Locator(LocatorClass.NavigationtoApplyforLoan);
            LoanAmount = _page.Locator(LocatorClass.LoanAmount);
            DownPayment = _page.Locator(LocatorClass.DownPayment);
            FromAccount = _page.Locator(LocatorClass.FromAccount);
            ApplyForLoanButton = _page.Locator(LocatorClass.ApplyForLoanButton);
            ExpectedSuccessLoanText = _page.Locator(LocatorClass.ExpectedSuccessLoanText);
            navtoNewLoanAccount = _page.Locator(LocatorClass.navtoNewLoanAccount);
            ExpectedTextLoan = _page.Locator(LocatorClass.ExpectedTextLoan);
            LoginUsername = _page.Locator(LocatorClass.LoginUsername);
            LoginPassword = _page.Locator(LocatorClass.LoginPassword);
            LoginButton = _page.Locator(LocatorClass.LoginButton);
            ErrorApplyLoan = _page.Locator (LocatorClass.ErrorApplyLoan);
            FieldErrorApplyLoan = _page.Locator(LocatorClass.FieldErrorApplyLoan);
        }


        public async Task ApplyForLoanApproved()
        {
            var jsonData = JsonObject.Parse(File.ReadAllText("C:\\Users\\HAMZA SIRAJ\\source\\repos\\SQA_Testing_Project\\SQA_Testing_Project\\data.json"));
            string username = jsonData["username"].ToString();
            string password = jsonData["password"].ToString();
            string loanAmount = jsonData["LoanAmount"].ToString();
            string downpayment = jsonData["DownPayment"].ToString();
            string successText = jsonData["ExpectedSuccessLoanText"].ToString();
            string expectedLoanText = jsonData["ExpectedLoanText"].ToString();
            await Task.Delay(250);
            await LoginUsername.FillAsync(username);
            await Task.Delay(250);
            await LoginPassword.FillAsync(password);
            await Task.Delay(250);
            await LoginButton.ClickAsync();

            await NavigationtoApplyforLoan.ClickAsync();
            await Task.Delay(250);
            await LoanAmount.FillAsync(loanAmount);
            await Task.Delay(250);
            await DownPayment.FillAsync(downpayment);
            await Task.Delay(250);
            await FromAccount.SelectOptionAsync(new SelectOptionValue { Index = 0});
            await Task.Delay(250);
            await ApplyForLoanButton.ClickAsync();
            await Task.Delay(250);
            Assert.That(successText, Is.EqualTo(await _page.InnerTextAsync(LocatorClass.ExpectedSuccessLoanText)));
            await Task.Delay(250);
            await navtoNewLoanAccount.ClickAsync();
            await Task.Delay(250);
            Assert.That(expectedLoanText, Is.EqualTo(await _page.InnerTextAsync(LocatorClass.ExpectedTextLoan)));

        }

        public async Task ApplyForLoanDenied()
        {
            var jsonData = JsonObject.Parse(File.ReadAllText("C:\\Users\\HAMZA SIRAJ\\source\\repos\\SQA_Testing_Project\\SQA_Testing_Project\\data.json"));
            string username = jsonData["username"].ToString();
            string password = jsonData["password"].ToString();
            string loanAmount = jsonData["LoanAmount"].ToString();
            string downpayment = jsonData["DownPayment"].ToString();
            string ErrorText = jsonData["ErrorApplyLoan"].ToString();

            await Task.Delay(250);
            await LoginUsername.FillAsync(username);
            await Task.Delay(250);
            await LoginPassword.FillAsync(password);
            await Task.Delay(250);
            await LoginButton.ClickAsync();

            await NavigationtoApplyforLoan.ClickAsync();
            await Task.Delay(250);
            await LoanAmount.FillAsync(loanAmount);
            await Task.Delay(250);
            await DownPayment.FillAsync(downpayment);
            await Task.Delay(250);
            await FromAccount.SelectOptionAsync(new SelectOptionValue { Index = 0 });
            await Task.Delay(250);
            await ApplyForLoanButton.ClickAsync();
            await Task.Delay(250);
            Assert.That(ErrorText, Is.EqualTo(await _page.InnerTextAsync(LocatorClass.ErrorApplyLoan)));
           

        }

        public async Task ApplyForLoanEmptyFields()
        {
            var jsonData = JsonObject.Parse(File.ReadAllText("C:\\Users\\HAMZA SIRAJ\\source\\repos\\SQA_Testing_Project\\SQA_Testing_Project\\data.json"));
            string username = jsonData["username"].ToString();
            string password = jsonData["password"].ToString();
            
            string ErrorText = jsonData["ErrorofFieldApplyLoan"].ToString();

            await Task.Delay(250);
            await LoginUsername.FillAsync(username);
            await Task.Delay(250);
            await LoginPassword.FillAsync(password);
            await Task.Delay(250);
            await LoginButton.ClickAsync();

            await NavigationtoApplyforLoan.ClickAsync();
           
           
            await ApplyForLoanButton.ClickAsync();
            Assert.That(ErrorText, Is.EqualTo(await _page.InnerTextAsync(LocatorClass.FieldErrorApplyLoan)));


        }

        public async Task ApplyForLoanSpecialCharAndLettersFields()
        {
            var jsonData = JsonObject.Parse(File.ReadAllText("C:\\Users\\HAMZA SIRAJ\\source\\repos\\SQA_Testing_Project\\SQA_Testing_Project\\data.json"));
            string username = jsonData["username"].ToString();
            string password = jsonData["password"].ToString();
            string loanAmount = jsonData["CharLetLoanAmount"].ToString();
            string downpayment = jsonData["CharLetDownPayment"].ToString();
            string ErrorText = jsonData["ErrorofFieldApplyLoan"].ToString();

            await Task.Delay(250);
            await LoginUsername.FillAsync(username);
            await Task.Delay(250);
            await LoginPassword.FillAsync(password);
            await Task.Delay(250);
            await LoginButton.ClickAsync();

            await NavigationtoApplyforLoan.ClickAsync();

            await FromAccount.SelectOptionAsync(new SelectOptionValue { Index = 0 });
            await ApplyForLoanButton.ClickAsync();
            Assert.That(ErrorText, Is.EqualTo(await _page.InnerTextAsync(LocatorClass.FieldErrorApplyLoan)));


        }
    }
}

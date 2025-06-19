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
    public class BillPaymentClass:BaseClass
    {
        IPage _page;

        ILocator NavigationtoBillPay;
        ILocator PayeeName;
        ILocator BillAdress;
        ILocator BillCity;
        ILocator BillState;
        ILocator BillZipcode;
        ILocator BillPhone;
        ILocator BillAccount;
        ILocator BillVerifyAccount;
        ILocator BillAmount;
        ILocator BillFromAccount;
        ILocator BillPayButton;
        ILocator BillPaySuccess;
        ILocator LoginUsername;
        ILocator LoginPassword;
        ILocator LoginButton;
        ILocator ErrorPayeename;
        ILocator ErrorAddress;
        ILocator ErrorCity;
        ILocator ErrorState;
        ILocator ErrorZipcode;
        ILocator ErrorPhone;
        ILocator ErrorAccount;
        ILocator ErrorVerifyAccount;
        ILocator ErrorAmount;
        ILocator SpecCharALetAmountError;
        ILocator NonMatchBillAccountVerify;

        public BillPaymentClass(IPage page) 
        {
            _page = page;
            NavigationtoBillPay = _page.Locator(LocatorClass.NavigationtoBillPay);
            PayeeName = _page.Locator(LocatorClass.PayeeName);
            BillAdress = _page.Locator(LocatorClass.BillAdress);
            BillCity = _page.Locator(LocatorClass.BillCity);
            BillState = _page.Locator(LocatorClass.BillState);
            BillZipcode = _page.Locator(LocatorClass.BillZipcode);
            BillPhone = _page.Locator(LocatorClass.BillPhone);
            BillAccount = _page.Locator(LocatorClass.BillAccount);
            BillVerifyAccount = _page.Locator(LocatorClass.BillVerifyAccount);
            BillAmount = _page.Locator(LocatorClass.BillAmount);
            BillFromAccount = _page.Locator(LocatorClass.BillFromAccount);
            BillPayButton = _page.Locator(LocatorClass.BillPayButton);
            BillPaySuccess = _page.Locator(LocatorClass.BillPaySuccess);
            LoginUsername = _page.Locator(LocatorClass.LoginUsername);
            LoginPassword = _page.Locator(LocatorClass.LoginPassword);
            LoginButton = _page.Locator(LocatorClass.LoginButton);
            ErrorPayeename = _page.Locator(LocatorClass.ErrorPayeename);
            ErrorAddress = _page.Locator(LocatorClass.ErrorAddress);
            ErrorCity = _page.Locator(LocatorClass.ErrorCity);
            ErrorState = _page.Locator(LocatorClass.ErrorState);
            ErrorZipcode = _page.Locator(LocatorClass.ErrorZipcode);
            ErrorPhone = _page.Locator(LocatorClass.ErrorPhone);
            ErrorAccount = _page.Locator(LocatorClass.ErrorAccount);
            ErrorVerifyAccount = _page.Locator(LocatorClass.ErrorVerifyAccount);
            ErrorAmount = _page.Locator(LocatorClass.ErrorAmount);
            SpecCharALetAmountError = _page.Locator(LocatorClass.SpecCharALetAmountError);
            NonMatchBillAccountVerify = _page.Locator(LocatorClass.NonMatchBillAccountVerify);
        }


        public async Task BillPaymentSuccess()
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
            string billsuccessExpected = jsonData["BillPaySuccess"].ToString();


            await LoginUsername.FillAsync(username);
            await LoginPassword.FillAsync(password);
            await LoginButton.ClickAsync();
            
            await NavigationtoBillPay.ClickAsync();
            await PayeeName.FillAsync(billpayee);
            await BillAdress.FillAsync(billaddress);
            await BillCity.FillAsync(billcity);
            await BillState.FillAsync(billstate);
            await BillZipcode.FillAsync(billzipcode);
            await BillPhone.FillAsync(billPhone);
            await BillAccount.FillAsync(billAccount);
            await BillVerifyAccount.FillAsync(billVerifyAccount);
            await BillAmount.FillAsync(billAmount);
            await BillFromAccount.SelectOptionAsync(new SelectOptionValue { Index = 0 });
            await BillPayButton.ClickAsync();

            Assert.That(billsuccessExpected, Is.EqualTo(await _page.InnerTextAsync(LocatorClass.BillPaySuccess)));

        }


        public async Task BillPayEmptyFields()
        {
            var jsonData = JsonObject.Parse(File.ReadAllText("C:\\Users\\HAMZA SIRAJ\\source\\repos\\SQA_Testing_Project\\SQA_Testing_Project\\data.json"));
            string username = jsonData["username"].ToString();
            string password = jsonData["password"].ToString();

            string billpayee = jsonData["ErrorpayeeName"].ToString();
            string billaddress = jsonData["ErrorAddress"].ToString();
            string billcity = jsonData["ErrorCity"].ToString();
            string billstate = jsonData["ErrorState"].ToString();
            string billzipcode = jsonData["ErrorZipcode"].ToString();
            string billPhone = jsonData["ErrorPhone"].ToString();
            string billAccount = jsonData["ErrorAccount"].ToString();
            string billVerifyAccount = jsonData["ErrorVerifyAccount"].ToString();
            string billAmount = jsonData["ErrorAmount"].ToString();
            

            await LoginUsername.FillAsync(username);
            await LoginPassword.FillAsync(password);
            await LoginButton.ClickAsync();

            await NavigationtoBillPay.ClickAsync();
            await BillPayButton.ClickAsync();

            Assert.That(billpayee.Trim(), Is.EqualTo(await _page.InnerTextAsync(LocatorClass.ErrorPayeename)));
            Assert.That(billaddress.Trim(), Is.EqualTo(await _page.InnerTextAsync(LocatorClass.ErrorAddress)));
            Assert.That(billcity.Trim(), Is.EqualTo(await _page.InnerTextAsync(LocatorClass.ErrorCity)));
            Assert.That(billstate.Trim(), Is.EqualTo(await _page.InnerTextAsync(LocatorClass.ErrorState)));
            Assert.That(billzipcode.Trim(), Is.EqualTo(await _page.InnerTextAsync(LocatorClass.ErrorZipcode)));
            Assert.That(billPhone.Trim(), Is.EqualTo(await _page.InnerTextAsync(LocatorClass.ErrorPhone)));
            Assert.That(billAccount.Trim(), Is.EqualTo(await _page.InnerTextAsync(LocatorClass.ErrorAccount)));
            Assert.That(billVerifyAccount.Trim(), Is.EqualTo(await _page.InnerTextAsync(LocatorClass.ErrorVerifyAccount)));

            Assert.That(billAmount.Trim(), Is.EqualTo((await _page.InnerTextAsync(LocatorClass.ErrorAmount)).Trim()));


        }


        public async Task BillPayAmountInSpecailAndLetter()
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
            string billAmount = jsonData["BillAmountSpecialCharAndLetter"].ToString();
            string ErrorExpected = jsonData["BillSpecCharALetErrorAmount"].ToString();


            await LoginUsername.FillAsync(username);
            await LoginPassword.FillAsync(password);
            await LoginButton.ClickAsync();

            await NavigationtoBillPay.ClickAsync();
            await PayeeName.FillAsync(billpayee);
            await BillAdress.FillAsync(billaddress);
            await BillCity.FillAsync(billcity);
            await BillState.FillAsync(billstate);
            await BillZipcode.FillAsync(billzipcode);
            await BillPhone.FillAsync(billPhone);
            await BillAccount.FillAsync(billAccount);
            await BillVerifyAccount.FillAsync(billVerifyAccount);
            await BillAmount.FillAsync(billAmount);
            await BillFromAccount.SelectOptionAsync(new SelectOptionValue { Index = 0 });
            await BillPayButton.ClickAsync();

            Assert.That(ErrorExpected, Is.EqualTo(await _page.InnerTextAsync(LocatorClass.SpecCharALetAmountError)));

        }
        
        public async Task BillPayNonMatchingAccountNoVerify()
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
            string billVerifyAccount = jsonData["WBillAcountverify"].ToString();
            string billAmount = jsonData["BillAmount"].ToString();
            string ErrorExpected = jsonData["BillnonmatchVerifyAccountNo"].ToString();


            await LoginUsername.FillAsync(username);
            await LoginPassword.FillAsync(password);
            await LoginButton.ClickAsync();

            await NavigationtoBillPay.ClickAsync();
            await PayeeName.FillAsync(billpayee);
            await BillAdress.FillAsync(billaddress);
            await BillCity.FillAsync(billcity);
            await BillState.FillAsync(billstate);
            await BillZipcode.FillAsync(billzipcode);
            await BillPhone.FillAsync(billPhone);
            await BillAccount.FillAsync(billAccount);
            await BillVerifyAccount.FillAsync(billVerifyAccount);
            await BillAmount.FillAsync(billAmount);
            await BillFromAccount.SelectOptionAsync(new SelectOptionValue { Index = 0 });
            await BillPayButton.ClickAsync();

            Assert.That(ErrorExpected, Is.EqualTo(await _page.InnerTextAsync(LocatorClass.NonMatchBillAccountVerify)));
        }

        public async Task BillPaySpecCharAndLetterInAccountandVerifyAccount()
        {

        }
    }
}

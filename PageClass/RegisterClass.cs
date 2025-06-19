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
    public class RegisterClass : BaseClass
    {

        IPage _page;

        ILocator RegisterPage;
        ILocator FirstName;
        ILocator LastName;
        ILocator Address;
        ILocator City;
        ILocator State;
        ILocator ZipCode;
        ILocator Phone;
        ILocator SSN;
        ILocator UserName;
        ILocator Password;
        ILocator Confirm;
        ILocator RegisterButton;
        ILocator ExpectedRegisterResult;
        ILocator ExpectedDuplicatedError;
        ILocator Logout;
        ILocator ErrorFirstname;
        ILocator ErrorLastname;
        ILocator ErrorAddress;
        ILocator ErrorCity;
        ILocator ErrorState;
        ILocator ErrorZipCode;
        ILocator ErrorSSN;
        ILocator ErrorUserName;
        ILocator ErrorPassword;
        ILocator ErrorConfirm;
        ILocator ErrorNotPutCorrectConfirmLikePassword;
        public RegisterClass(IPage page) 
        {

            _page = page;

            RegisterPage = _page.Locator(LocatorClass.RegisterPage);
            FirstName = _page.Locator(LocatorClass.FirstName);
            LastName = _page.Locator(LocatorClass.LastName);
            Address = _page.Locator(LocatorClass.Address);
            City = _page.Locator(LocatorClass.City);
            State = _page.Locator(LocatorClass.State);
            ZipCode = _page.Locator(LocatorClass.ZipCode);
            Phone = _page.Locator(LocatorClass.Phone);
            SSN = _page.Locator(LocatorClass.SSN);
            UserName = _page.Locator(LocatorClass.UserName);
            Password = _page.Locator(LocatorClass.Password);
            Confirm = _page.Locator(LocatorClass.confirm);
            RegisterButton = _page.Locator(LocatorClass.RegisterButton);
            ExpectedRegisterResult = _page.Locator(LocatorClass.expectedRegisterResult);
            ExpectedDuplicatedError = _page.Locator(LocatorClass.expectedDuplicatedError);
           Logout = _page.Locator(LocatorClass.logout);
            ErrorFirstname = _page.Locator(LocatorClass.errorFirstname);
            ErrorLastname = _page.Locator(LocatorClass.errorLastname);
            ErrorAddress = _page.Locator(LocatorClass.errorAddress);
            ErrorCity = _page.Locator(LocatorClass.errorCity);
            ErrorState = _page.Locator(LocatorClass.errorState);
            ErrorZipCode = _page.Locator(LocatorClass.errorZipcode);
            ErrorSSN = _page.Locator(LocatorClass.errorSSN);
            ErrorUserName = _page.Locator(LocatorClass.errorUsername);
            ErrorPassword = _page.Locator(LocatorClass.errorPassword);
            ErrorConfirm  = _page.Locator(LocatorClass.errorconfirm);
            ErrorNotPutCorrectConfirmLikePassword = _page.Locator(LocatorClass.errornotputCorrectConfirm);
        }

        public async Task RegisterValid()
        {
            var jsonData = JsonObject.Parse(File.ReadAllText("C:\\Users\\HAMZA SIRAJ\\source\\repos\\SQA_Testing_Project\\SQA_Testing_Project\\data.json"));
            string firstname = jsonData["First Name"].ToString();
            string lastname = jsonData["Last Name"].ToString();
            string address = jsonData["Address"].ToString();
            string city = jsonData["City"].ToString();
            string state = jsonData["State"].ToString();
            string zipcode = jsonData["Zip Code"].ToString();
            string phone = jsonData["Phone"].ToString();
            string ssn = jsonData["SSN"].ToString();
            string username = jsonData["username"].ToString();
            string password = jsonData["password"].ToString();
            string expectedRegisterText = jsonData["ExpectedRegisterResult"].ToString();

            await RegisterPage.ClickAsync();
            await FirstName.FillAsync(firstname);
            await Task.Delay(250);
            await LastName.FillAsync(lastname);
            await Task.Delay(250);
            await Address.FillAsync(address);
            await Task.Delay(250);
            await City.FillAsync(city);
            await Task.Delay(250);
            await State.FillAsync(state);
            await Task.Delay(250);
            await ZipCode.FillAsync(zipcode);
            await Task.Delay(250);
            await Phone.FillAsync(phone);
            await Task.Delay(250);
            await SSN.FillAsync(ssn);
            await Task.Delay(250);
            await UserName.FillAsync(username);
            await Task.Delay(250);
            await Password.FillAsync(password);
            await Task.Delay(250);
            await Confirm.FillAsync(password);
            await Task.Delay(250);
            await RegisterButton.ClickAsync();
            
            Assert.That(expectedRegisterText, Is.EqualTo(await _page.InnerTextAsync(LocatorClass.expectedRegisterResult)));
           // await _page.ScreenshotAsync(new PageScreenshotOptions { Path = "D:\\BSSE 6A\\Software Testing\\screenShot of SQT_ParaBank_Testing\\shot1.png" });

        }
        public async Task RegisterDuplicatedUsername()
        {
            var jsonData = JsonObject.Parse(File.ReadAllText("C:\\Users\\HAMZA SIRAJ\\source\\repos\\SQA_Testing_Project\\SQA_Testing_Project\\data.json"));
            string firstname = jsonData["First Name"].ToString();
            string lastname = jsonData["Last Name"].ToString();
            string address = jsonData["Address"].ToString();
            string city = jsonData["City"].ToString();
            string state = jsonData["State"].ToString();
            string zipcode = jsonData["Zip Code"].ToString();
            string phone = jsonData["Phone"].ToString();
            string ssn = jsonData["SSN"].ToString();
            string username = jsonData["dusername"].ToString();
            string password = jsonData["password"].ToString();
            string expectedDupicatedError = jsonData["ExpectedDuplicatedUsernameError"].ToString();

            await RegisterPage.ClickAsync();
            await FirstName.FillAsync(firstname);
            await Task.Delay(1000);
            await LastName.FillAsync(lastname);
            await Task.Delay(250);
            await Address.FillAsync(address);
            await Task.Delay(250);
            await City.FillAsync(city);
            await Task.Delay(250);
            await State.FillAsync(state);
            await Task.Delay(250);
            await ZipCode.FillAsync(zipcode);
            await Task.Delay(250);
            await Phone.FillAsync(phone);
            await Task.Delay(250);
            await SSN.FillAsync(ssn);
            await Task.Delay(250);
            await UserName.FillAsync(username);
            await Task.Delay(250);
            await Password.FillAsync(password);
            await Task.Delay(250);
            await Confirm.FillAsync(password);
            await Task.Delay(250);
            await RegisterButton.ClickAsync();
            await Task.Delay(250);
            await Logout.ClickAsync();
            await Task.Delay(250);
            await RegisterPage.ClickAsync();
            await Task.Delay(250);
            await FirstName.FillAsync(firstname);
            await Task.Delay(250);
            await LastName.FillAsync(lastname);
            await Task.Delay(250);
            await Address.FillAsync(address);
            await Task.Delay(250);
            await City.FillAsync(city);
            await Task.Delay(250);
            await State.FillAsync(state);
            await Task.Delay(250);
            await ZipCode.FillAsync(zipcode);
            await Task.Delay(250);
            await Phone.FillAsync(phone);
            await Task.Delay(250);
            await SSN.FillAsync(ssn);
            await Task.Delay(250);
            await UserName.FillAsync(username);
            await Task.Delay(250);
            await Password.FillAsync(password);
            await Task.Delay(250);
            await Confirm.FillAsync(password);
            await Task.Delay(250);
            await RegisterButton.ClickAsync();

            Assert.That(expectedDupicatedError.Trim(), Is.EqualTo((await _page.InnerTextAsync(LocatorClass.expectedDuplicatedError)).Trim()));

        }

        public async Task RegisterEmptyFields()
        {
            var jsonData = JsonObject.Parse(File.ReadAllText("C:\\Users\\HAMZA SIRAJ\\source\\repos\\SQA_Testing_Project\\SQA_Testing_Project\\data.json"));
            string Efirstname = jsonData["ExpectedErrorFirstName"].ToString();
            string Elastname = jsonData["ExpectedErrorLastName"].ToString();
            string Eaddress = jsonData["ExpectedErrorAddress"].ToString();
            string Ecity = jsonData["ExpectedErrorCity"].ToString();
            string Estate = jsonData["ExpectedErrorState"].ToString();
            string Ezipcode = jsonData["ExpectedErrorZipCode"].ToString();
            string Essn = jsonData["ExpectedErrorSSN"].ToString();
            string Eusername = jsonData["ExpectedErrorUsername"].ToString();
            string Epassword = jsonData["ExpectedErrorPassword"].ToString();
            string Econfirm = jsonData["ExpectedErrorConfirm"].ToString();


            await RegisterPage.ClickAsync();
            await RegisterButton.ClickAsync();


            Assert.That(Efirstname, Is.EqualTo(await _page.InnerTextAsync(LocatorClass.errorFirstname)));
            Assert.That(Elastname, Is.EqualTo(await _page.InnerTextAsync(LocatorClass.errorLastname)));
            Assert.That(Eaddress, Is.EqualTo(await _page.InnerTextAsync(LocatorClass.errorAddress)));
            Assert.That(Ecity, Is.EqualTo(await _page.InnerTextAsync(LocatorClass.errorCity)));
            Assert.That(Estate, Is.EqualTo(await _page.InnerTextAsync(LocatorClass.errorState)));
            Assert.That(Ezipcode, Is.EqualTo(await _page.InnerTextAsync(LocatorClass.errorZipcode)));
            Assert.That(Essn, Is.EqualTo(await _page.InnerTextAsync(LocatorClass.errorSSN)));
            Assert.That(Eusername, Is.EqualTo(await _page.InnerTextAsync(LocatorClass.errorUsername)));
            Assert.That(Epassword, Is.EqualTo(await _page.InnerTextAsync(LocatorClass.errorPassword)));
            Assert.That(Econfirm, Is.EqualTo(await _page.InnerTextAsync(LocatorClass.errorconfirm)));

        }
        public async Task RegisterNotInputCorrectConfirmLikePassword()
        {
            var jsonData = JsonObject.Parse(File.ReadAllText("C:\\Users\\HAMZA SIRAJ\\source\\repos\\SQA_Testing_Project\\SQA_Testing_Project\\data.json"));
            string firstname = jsonData["First Name"].ToString();
            string lastname = jsonData["Last Name"].ToString();
            string address = jsonData["Address"].ToString();
            string city = jsonData["City"].ToString();
            string state = jsonData["State"].ToString();
            string zipcode = jsonData["Zip Code"].ToString();
            string phone = jsonData["Phone"].ToString();
            string ssn = jsonData["SSN"].ToString();
            string username = jsonData["username"].ToString();
            string password = jsonData["password"].ToString();
            string confirm = jsonData["Wpassword"].ToString();
            string expectedError = jsonData["ExpectedErrornotputsamepasswordinConfirm"].ToString();

            await RegisterPage.ClickAsync();
            await FirstName.FillAsync(firstname);
            await Task.Delay(250);
            await LastName.FillAsync(lastname);
            await Task.Delay(250);
            await Address.FillAsync(address);
            await Task.Delay(250);
            await City.FillAsync(city);
            await Task.Delay(250);
            await State.FillAsync(state);
            await Task.Delay(250);
            await ZipCode.FillAsync(zipcode);
            await Task.Delay(250);
            await Phone.FillAsync(phone);
            await Task.Delay(250);
            await SSN.FillAsync(ssn);
            await Task.Delay(250);
            await UserName.FillAsync(username);
            await Task.Delay(250);
            await Password.FillAsync(password);
            await Task.Delay(250);
            await Confirm.FillAsync(confirm);
            await Task.Delay(250);
            await RegisterButton.ClickAsync();

            Assert.That(expectedError, Is.EqualTo(await _page.InnerTextAsync(LocatorClass.errornotputCorrectConfirm)));

        }
    }
}

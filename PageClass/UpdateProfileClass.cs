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
    public class UpdateProfileClass :BaseClass
    {
        IPage _page;

        ILocator ExpectedUpdateInfoText;
        ILocator UpdateFirstName;
        ILocator UpdateLastName;
        ILocator UpdateAddress;
        ILocator UpdateCity;
        ILocator UpdateState;
        ILocator UpdateZipCode;
        ILocator UpdatePhone;
        ILocator UpdateProfileButton;
        ILocator NavigationToUpdateContactInfo;
        ILocator LoginUsername;
        ILocator LoginPassword;
        ILocator LoginButton;

        public UpdateProfileClass(IPage page) 
        {
            _page = page;

            ExpectedUpdateInfoText = _page.Locator(LocatorClass.ExpectedUpdateInfoText);
            UpdateFirstName = _page.Locator(LocatorClass.UpdateFirstName);
            UpdateLastName = _page.Locator(LocatorClass.UpdateLastName);
            UpdateAddress = _page.Locator(LocatorClass.UpdateAddress);
            UpdateCity = _page.Locator(LocatorClass.UpdateCity);
            UpdateState = _page.Locator(LocatorClass.UpdateState);
            UpdateZipCode = _page.Locator(LocatorClass.UpdateZipcode);
            UpdatePhone = _page.Locator(LocatorClass.UpdatePhone);
            UpdateProfileButton = _page.Locator(LocatorClass.UpdateProfileButton);
            LoginUsername = _page.Locator(LocatorClass.LoginUsername);
            LoginPassword = _page.Locator(LocatorClass.LoginPassword);
            LoginButton = _page.Locator(LocatorClass.LoginButton);
            NavigationToUpdateContactInfo = _page.Locator(LocatorClass.NavigationToUpdateContactInfo); 
        }


        public async Task UpdateInfoProfile()
        {
            var jsonData = JsonObject.Parse(File.ReadAllText("C:\\Users\\HAMZA SIRAJ\\source\\repos\\SQA_Testing_Project\\SQA_Testing_Project\\data.json"));
            string username = jsonData["username"].ToString();
            string password = jsonData["password"].ToString();
            string updateFirstName = jsonData["UpdateFirstName"].ToString();
            string updateLastName = jsonData["UpdateLastName"].ToString();
            string updateAddress = jsonData["UpdateAddress"].ToString();
            string updateCity = jsonData["UpdateCity"].ToString();
            string updateState = jsonData["UpdateState"].ToString();
            string updateZipcode = jsonData["UpdateZipcode"].ToString();
            string updatePhone = jsonData["UpdatePhone"].ToString();
            string ExpectedUpdateText = jsonData["ExpectedUpdateInfoText"].ToString();

            await LoginUsername.FillAsync(username);
            await LoginPassword.FillAsync(password);
            await LoginButton.ClickAsync();

            await NavigationToUpdateContactInfo.ClickAsync();
            await UpdateFirstName.ClearAsync();
            await UpdateLastName.ClearAsync();
            await UpdateAddress.ClearAsync();
            await UpdateCity.ClearAsync();
            await UpdateState.ClearAsync();
            await UpdateZipCode.ClearAsync();
            await UpdatePhone.ClearAsync();

            await UpdateFirstName.FillAsync(updateFirstName);
            await UpdateLastName.FillAsync(updateLastName);
            await UpdateAddress.FillAsync(updateAddress);
            await UpdateCity.FillAsync(updateCity);
            await UpdateState.FillAsync(updateState);
            await UpdateZipCode.FillAsync(updateZipcode);
            await UpdatePhone.FillAsync(updatePhone);

            await UpdateProfileButton.ClickAsync();

            Assert.That(ExpectedUpdateText,Is.EqualTo(await _page.InnerTextAsync(LocatorClass.ExpectedUpdateInfoText)));

        }
    }
}

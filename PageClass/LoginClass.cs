using Microsoft.Playwright;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SQA_Testing_Project.PageClass
{
    public class LoginClass:BaseClass
    {
        
        IPage _page;

        ILocator LoginUsername;
        ILocator LoginPassword;
        ILocator LoginButton;
        ILocator ExpectedLoginText;
        

        public LoginClass(IPage page) 
        {

            _page = page;

            LoginUsername = _page.Locator(LocatorClass.LoginUsername);
            LoginPassword = _page.Locator(LocatorClass.LoginPassword);
            LoginButton = _page.Locator(LocatorClass.LoginButton);
            ExpectedLoginText = _page.Locator(LocatorClass.ExpectedLoginText);

        }

        public async Task ValidLogin()
        {
            var jsonData = JsonObject.Parse(File.ReadAllText("C:\\Users\\HAMZA SIRAJ\\source\\repos\\SQA_Testing_Project\\SQA_Testing_Project\\data.json"));
            string username = jsonData["username"].ToString();
            string password = jsonData["password"].ToString();
            string expectedText = jsonData["ExpectedLoginText"].ToString();
            await Task.Delay(250);
            await LoginUsername.FillAsync(username);
            await Task.Delay(250);
            await LoginPassword.FillAsync(password);
            await Task.Delay(250);
            await LoginButton.ClickAsync();

            Assert.That(expectedText,Is.EqualTo(await _page.InnerTextAsync(LocatorClass.ExpectedLoginText)));
        }

        public async Task EmptyLogin()
        {
            var jsonData = JsonObject.Parse(File.ReadAllText("C:\\Users\\HAMZA SIRAJ\\source\\repos\\SQA_Testing_Project\\SQA_Testing_Project\\data.json"));
            string errorText = jsonData["ErrorEmptyLogin"].ToString();

            
            await LoginButton.ClickAsync();

            Assert.That(errorText, Is.EqualTo(await _page.InnerTextAsync(LocatorClass.ErrorEmptyLogin)));
        }

        public async Task InvalidLogin()
        {
            var jsonData = JsonObject.Parse(File.ReadAllText("C:\\Users\\HAMZA SIRAJ\\source\\repos\\SQA_Testing_Project\\SQA_Testing_Project\\data.json"));
            string wusername = jsonData["Wusername"].ToString();
            string wpassword = jsonData["Wpassword"].ToString();
            string ErrorText = jsonData["ErrorofInvalidLogin"].ToString();
            string Error = jsonData["BadError"].ToString();
            await Task.Delay(250);
            await LoginUsername.FillAsync(wusername);
            await Task.Delay(250);
            await LoginPassword.FillAsync(wpassword);
            await Task.Delay(250);
            await LoginButton.ClickAsync();

            if (Error == await _page.InnerHTMLAsync(LocatorClass.ErrorInvalid))
            {
                Assert.That(Error.Trim(), Is.EqualTo(await _page.InnerTextAsync(LocatorClass.ErrorInvalid)));
            }
            else
            {
                Assert.That(ErrorText.Trim(), Is.EqualTo(await _page.InnerTextAsync(LocatorClass.ErrorInvalid)));
            }
            
        }
    }
}

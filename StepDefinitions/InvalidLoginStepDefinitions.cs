using System;
using System.Threading.Tasks;
using Reqnroll;
using SQA_Testing_Project.PageClass;

namespace SQA_Testing_Project.StepDefinitions
{
    [Binding]
    public class InvalidLoginStepDefinitions
    {
        LoginClass login;

        [Given("user will navigate to page")]
        public async Task GivenUserWillNavigateToPage()
        {
            BaseClass bs = new BaseClass();
            await bs.OpenBrowser();

            login = new LoginClass(BaseClass.page);
            await login.GoToURL();
        }

        [When("If user input wrong username and password it will show error")]
        public async Task WhenIfUserInputWrongUsernameAndPasswordItWillShowError()
        {
            await login.InvalidLogin();
        }

        [Then("page close")]
        public async Task ThenPageClose()
        {
            await login.CloseBrowser();
        }
    }
}

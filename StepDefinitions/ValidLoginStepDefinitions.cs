using System;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Reqnroll;
using SQA_Testing_Project.PageClass;

namespace SQA_Testing_Project.StepDefinitions
{
    [Binding]
    public class ValidLoginStepDefinitions
    {
        LoginClass login ;

        [Given("user will navigate to url")]
        public async Task GivenUserWillNavigateToUrl()
        {
           BaseClass bs = new BaseClass();
            await bs.OpenBrowser();
            login = new LoginClass(BaseClass.page);
            await login.GoToURL();
            
        }

        [When("User will input username and password and login the website")]
        public async Task WhenUserWillInputUsernameAndPasswordAndLoginTheWebsite()
        {
            await login.ValidLogin();
        }

        [Then("close page")]
        public async Task ThenClosePage()
        {
            await login.CloseBrowser();
        }
    }
}

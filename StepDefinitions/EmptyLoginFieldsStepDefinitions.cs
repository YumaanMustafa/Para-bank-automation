using System;
using System.Threading.Tasks;
using Reqnroll;
using SQA_Testing_Project.PageClass;

namespace SQA_Testing_Project.StepDefinitions
{
    [Binding]
    public class EmptyLoginFieldsStepDefinitions
    {
        LoginClass login ;

        [Given("user navigate to url")]
        public async Task GivenUserNavigateToUrl()
        {
           BaseClass bs = new BaseClass();
            await bs.OpenBrowser();
          login = new LoginClass(BaseClass.page);
            await login.GoToURL();
        }

        [When("If user will not input fields of username and password and click the login button it show error")]
        public async Task WhenIfUserWillNotInputFieldsOfUsernameAndPasswordAndClickTheLoginButtonItShowError()
        {
            await login.EmptyLogin();
        }

        [Then("closed the page")]
        public async Task ThenClosedThePage()
        {
            await login.CloseBrowser();
        }
    }
}

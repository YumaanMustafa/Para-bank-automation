using System;
using Reqnroll;
using SQA_Testing_Project.PageClass;


namespace SQA_Testing_Project.StepDefinitions
{
    [Binding]
    public class RegistervalidStepDefinitions 
    {
        RegisterClass register ;

        [Given("User navigate to the url")]
        public async Task GivenUserNavigateToTheUrl()
        {

            BaseClass bs = new BaseClass();
            await bs.OpenBrowser();
            register = new RegisterClass(BaseClass.page);
            await register.GoToURL();
        }

        [When("User Register the Page")]
        public async Task WhenUserRegisterThePage()
        {
            await register.RegisterValid();
        }

        [Then("Page Closed")]
        public async Task ThenPageClosed()
        {
            await register.CloseBrowser();
        }
    }
}

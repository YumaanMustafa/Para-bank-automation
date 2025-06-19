using System;
using System.Threading.Tasks;
using Reqnroll;
using SQA_Testing_Project.PageClass;

namespace SQA_Testing_Project.StepDefinitions
{
   
    [Binding]
    public class RegisterEmptyFieldsStepDefinitions
    {
        RegisterClass register;

        [Given("User will navigate to Url")]
        public async Task GivenUserWillNavigateToUrl()
        {

            BaseClass bs = new BaseClass();
            await bs.OpenBrowser();
            register = new RegisterClass(BaseClass.page);
            await register.GoToURL();
        }

        [When("If user will leave the field empty and click register button it will show errors")]
        public async Task WhenIfUserWillLeaveTheFieldEmptyAndClickRegisterButtonItWillShowErrors()
        {
            await register.RegisterEmptyFields();
        }

        [Then("page closed")]
        public async Task ThenPageClosed()
        {
            await register.CloseBrowser();
        }
    }
}

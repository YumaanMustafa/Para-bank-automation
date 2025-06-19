using System;
using System.Threading.Tasks;
using Reqnroll;
using SQA_Testing_Project.PageClass;

namespace SQA_Testing_Project.StepDefinitions
{
    [Binding]
    public class RegisterWrongConfirmStepDefinitions
    {

        RegisterClass register;

        [Given("user will navigate to Url")]
        public async Task GivenUserWillNavigateToUrl()
        {
           BaseClass bs = new BaseClass();
            await bs.OpenBrowser();
            register = new RegisterClass(BaseClass.page);
            await register.GoToURL();
        }

        [When("If user will put wrong confirm in the register page it will show error")]
        public async Task WhenIfUserWillPutWrongConfirmInTheRegisterPageItWillShowError()
        {
           await register.RegisterNotInputCorrectConfirmLikePassword();
        }

        [Then("closed page")]
        public async Task ThenClosedPage()
        {
         await register.CloseBrowser();   
        }
    }
}

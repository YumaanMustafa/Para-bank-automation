using System;
using System.Threading.Tasks;
using Reqnroll;
using SQA_Testing_Project.PageClass;

namespace SQA_Testing_Project.StepDefinitions
{
    [Binding]
    public class RegisterDuplicatedUsernameStepDefinitions
    {
        RegisterClass register;

        [Given("User will navigate to the URl")]
        public async Task GivenUserWillNavigateToTheURl()
        {
            BaseClass bs = new BaseClass();
            await bs.OpenBrowser();

            register = new RegisterClass(BaseClass.page);
            register.GoToURL();
        }

        [When("If user will input duplicated username that is already exist , it will give an error")]
        public async Task WhenIfUserWillInputDuplicatedUsernameThatIsAlreadyExistItWillGiveAnError()
        {
                await register.RegisterDuplicatedUsername();
        }

        [Then("The page will closed")]
        public async Task ThenThePageWillClosed()
        {
            await register.CloseBrowser();
        }
    }
}

using System;
using System.Threading.Tasks;
using Reqnroll;
using SQA_Testing_Project.PageClass;

namespace SQA_Testing_Project.StepDefinitions
{
    [Binding]
    public class FindByAmountSpecialCharandLettersStepDefinitions
    {
        FindTransactionsClass tran;

        [Given("user navigate url")]
        public async Task GivenUserNavigateUrl()
        {
            BaseClass bs = new BaseClass();
            await bs.OpenBrowser();

            tran = new FindTransactionsClass(BaseClass.page);
            await tran.GoToURL();
        }

        [When("If user will input special characters and letter on the Amount find field , it will give an error")]
        public async Task WhenIfUserWillInputSpecialCharactersAndLetterOnTheAmountFindFieldItWillGiveAnError()
        {
            await tran.FindByAmountSpecialcharsAndLetters();
        }

        [Then("page closed.")]
        public async Task ThenPageClosed_()
        {
            await tran.CloseBrowser();
        }
    }
}

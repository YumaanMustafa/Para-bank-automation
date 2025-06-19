using System;
using System.Threading.Tasks;
using Reqnroll;
using SQA_Testing_Project.PageClass;

namespace SQA_Testing_Project.StepDefinitions
{
    [Binding]
    public class FindByDateSpecialCharStepDefinitions
    {
        FindTransactionsClass tran;

        [Given("user Will navigate to url")]
        public async Task GivenUserWillNavigateToUrl()
        {
            BaseClass bs = new BaseClass();
            await bs.OpenBrowser();

            tran = new FindTransactionsClass(BaseClass.page);
            await tran.GoToURL();
        }

        [When("If user will input special char on the field of find date , it will give error")]
        public async Task WhenIfUserWillInputSpecialCharOnTheFieldOfFindDateItWillGiveError()
        {
            await tran.FindByDateSpecialChar();
        }

        [Then("the page will closed")]
        public async Task ThenThePageWillClosed()
        {
            await tran.CloseBrowser();
        }
    }
}

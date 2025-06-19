using System;
using System.Threading.Tasks;
using Reqnroll;
using SQA_Testing_Project.PageClass;

namespace SQA_Testing_Project.StepDefinitions
{
    [Binding]
    public class FindByDateInvalidStepDefinitions
    {
        FindTransactionsClass tran;

        [Given("user Will Navigate to url")]
        public async Task GivenUserWillNavigateToUrl()
        {
            BaseClass bs = new BaseClass();
            await bs.OpenBrowser();

            tran = new FindTransactionsClass(BaseClass.page);
            await tran.GoToURL();
        }

        [When("If user will input invalid date formate in the find date field , it will give error")]
        public async Task WhenIfUserWillInputInvalidDateFormateInTheFindDateFieldItWillGiveError()
        {
            await tran.FindByDateInvalid();
        }

        [Then("the Page will closed")]
        public async Task ThenThePageWillClosed()
        {
            await tran.CloseBrowser();
        }
    }
}

using System;
using System.Threading.Tasks;
using Reqnroll;
using SQA_Testing_Project.PageClass;

namespace SQA_Testing_Project.StepDefinitions
{
    [Binding]
    public class FindByDateValidStepDefinitions
    {
        FindTransactionsClass tran;

        [Given("user will navigate to URl")]
        public async Task GivenUserWillNavigateToURl()
        {
            BaseClass bs = new BaseClass();
            await bs.OpenBrowser();

            tran = new FindTransactionsClass(BaseClass.page);
            await tran.GoToURL();
        }

        [When("User will find transactions by Date")]
        public async Task WhenUserWillFindTransactionsByDate()
        {
           await tran.FindByDateValid();
        }

        [Then("The Page will closed")]
        public async Task ThenThePageWillClosed()
        {
            await tran.CloseBrowser();
        }
    }
}

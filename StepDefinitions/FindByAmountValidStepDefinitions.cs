using System;
using System.Threading.Tasks;
using Reqnroll;
using SQA_Testing_Project.PageClass;

namespace SQA_Testing_Project.StepDefinitions
{
    [Binding]
    public class FindByAmountValidStepDefinitions
    {
        FindTransactionsClass tran;

        [Given("user navigate to urL")]
        public async Task GivenUserNavigateToUrL()
        {
            BaseClass bs = new BaseClass();
            await bs.OpenBrowser();

            tran = new FindTransactionsClass(BaseClass.page);
            await tran.GoToURL();
        }

        [When("User will find transaction detail using amount")]
        public async Task WhenUserWillFindTransactionDetailUsingAmount()
        {
            await tran.FindByAmountValid();
        }

        [Then("Page closed.")]
        public async Task ThenPageClosed_()
        {
            await tran.CloseBrowser();
        }
    }
}

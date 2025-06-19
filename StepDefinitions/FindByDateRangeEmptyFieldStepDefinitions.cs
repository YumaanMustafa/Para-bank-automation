using System;
using System.Threading.Tasks;
using Reqnroll;
using SQA_Testing_Project.PageClass;

namespace SQA_Testing_Project.StepDefinitions
{
    [Binding]
    public class FindByDateRangeEmptyFieldStepDefinitions
    {
        FindTransactionsClass tran;

        [Given("User will Navigate to urL")]
        public async Task GivenUserWillNavigateToUrL()
        {
            BaseClass bs = new BaseClass();
            await bs.OpenBrowser();

            tran = new FindTransactionsClass(BaseClass.page);
            await tran.GoToURL();
        }

        [When("If user left the find by date range field blank , it will give error")]
        public async Task WhenIfUserLeftTheFindByDateRangeFieldBlankItWillGiveError()
        {
            await tran.FindByDateRangeEmptyField();
        }

        [Then("The Page Will Closed")]
        public async Task ThenThePageWillClosed()
        {
            await tran.CloseBrowser();
        }
    }
}

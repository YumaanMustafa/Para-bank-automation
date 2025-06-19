using System;
using System.Security.AccessControl;
using System.Threading.Tasks;
using Reqnroll;
using SQA_Testing_Project.PageClass;

namespace SQA_Testing_Project.StepDefinitions
{
    [Binding]
    public class FindByRangeValidDateStepDefinitions
    {
        FindTransactionsClass tran;

        [Given("User will Navigate to url")]
        public async Task GivenUserWillNavigateToUrl()
        {
            BaseClass bs = new BaseClass();
            await bs.OpenBrowser();

            tran = new FindTransactionsClass(BaseClass.page);
            await tran.GoToURL();
        }

        [When("user will Find Transactions using Date range")]
        public async Task WhenUserWillFindTransactionsUsingDateRange()
        {
            await tran.FindByDateRangeValid();
        }

        [Then("Closed The Page")]
        public async Task ThenClosedThePage()
        {
            await tran.CloseBrowser();
        }
    }
}

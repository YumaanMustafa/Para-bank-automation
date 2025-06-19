using System;
using System.Threading.Tasks;
using Reqnroll;
using SQA_Testing_Project.PageClass;

namespace SQA_Testing_Project.StepDefinitions
{
    [Binding]
    public class TransferFundInvalidStepDefinitions
    {
        TransferFundsClass fund;

        [Given("User will navigate to the url")]
        public async Task GivenUserWillNavigateToTheUrl()
        {
            BaseClass bs = new BaseClass();
            await bs.OpenBrowser();

            fund = new TransferFundsClass(BaseClass.page);
            await fund.GoToURL();
        }

        [When("If user willnot input amount it will give an error")]
        public async Task WhenIfUserWillnotInputAmountItWillGiveAnError()
        {
            await fund.TransferFundEmptyAmount();
        }

        [Then("page will Closed")]
        public async Task ThenPageWillClosed()
        {
            await fund.CloseBrowser();
        }
    }
}

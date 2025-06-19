using System;
using System.Threading.Tasks;
using Reqnroll;
using SQA_Testing_Project.PageClass;

namespace SQA_Testing_Project.StepDefinitions
{
    [Binding]
    public class TransferFundValidStepDefinitions
    {
        TransferFundsClass fund;

        [Given("User will navigate to URl")]
        public async Task GivenUserWillNavigateToURl()
        {
           BaseClass bs = new BaseClass();
            await bs.OpenBrowser();

            fund = new TransferFundsClass(BaseClass.page);
            await fund.GoToURL();
        }

        [When("User will input amount of valid numbers to Tranfer funds")]
        public async Task WhenUserWillInputAmountOfValidNumbersToTranferFunds()
        {
            await fund.TransferFundValid();
        }

        [Then("The page will Closed")]
        public async Task ThenThePageWillClosed()
        {
            await fund.CloseBrowser();
        }
    }
}

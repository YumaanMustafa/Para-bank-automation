using System;
using System.Threading.Tasks;
using Reqnroll;
using SQA_Testing_Project.PageClass;

namespace SQA_Testing_Project.StepDefinitions
{
    [Binding]
    public class TransferFundSpecialCharAmountStepDefinitions
    {
        TransferFundsClass fund;

        [Given("User will navigate to url")]
        public async Task GivenUserWillNavigateToUrl()
        {
            BaseClass bs = new BaseClass();
            await bs.OpenBrowser();

            fund = new TransferFundsClass(BaseClass.page);
            fund.GoToURL();
        }

        [When("If user will input special characters , it will give an error")]
        public async Task WhenIfUserWillInputSpecialCharactersItWillGiveAnError()
        {
          await  fund.TransferFundSpecialCharAmount();
        }

        [Then("page will closed")]
        public async Task ThenPageWillClosed()
        {
           await fund.CloseBrowser();
        }
    }
}

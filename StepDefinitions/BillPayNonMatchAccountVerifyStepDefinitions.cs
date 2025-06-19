using System;
using System.Threading.Tasks;
using Reqnroll;
using SQA_Testing_Project.PageClass;

namespace SQA_Testing_Project.StepDefinitions
{
    [Binding]
    public class BillPayNonMatchAccountVerifyStepDefinitions
    {
        BillPaymentClass bill;

        [Given("User will navigate to the URL")]
        public async Task GivenUserWillNavigateToTheURL()
        {
            BaseClass bs = new BaseClass();
            await bs.OpenBrowser();

            bill = new BillPaymentClass(BaseClass.page);

            await bill.GoToURL();
        }

        [When("If User will input Non Matching Account verify in the field it will show Error")]
        public async Task WhenIfUserWillInputNonMatchingAccountVerifyInTheFieldItWillShowError()
        {
            await bill.BillPayNonMatchingAccountNoVerify();
        }

        [Then("closed the  page")]
        public async Task ThenClosedThePage()
        {
            await bill.CloseBrowser();
        }
    }
}

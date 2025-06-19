using System;
using System.Threading.Tasks;
using Reqnroll;
using SQA_Testing_Project.PageClass;

namespace SQA_Testing_Project.StepDefinitions
{
    [Binding]
    public class BillPaySucessStepDefinitions
    {
        BillPaymentClass bill;

        [Given("user will navigate to the URl")]
        public async Task GivenUserWillNavigateToTheURl()
        {
            BaseClass bs = new BaseClass();
            await bs.OpenBrowser();

            bill = new BillPaymentClass(BaseClass.page);
            await bill.GoToURL();
        }

        [When("User will pay bill and it give success text")]
        public async Task WhenUserWillPayBillAndItGiveSuccessText()
        {
            await bill.BillPaymentSuccess();
        }

        [Then("Closed Page")]
        public async Task ThenClosedPage()
        {
            await bill.CloseBrowser();
        }
    }
}

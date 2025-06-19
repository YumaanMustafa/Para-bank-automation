using System;
using System.Threading.Tasks;
using Reqnroll;
using SQA_Testing_Project.PageClass;

namespace SQA_Testing_Project.StepDefinitions
{
    [Binding]
    public class BillPayEmptyFieldStepDefinitions
    {
        BillPaymentClass bill;

        [Given("user will navigate to the URL")]
        public async Task GivenUserWillNavigateToTheURL()
        {
            BaseClass bs = new BaseClass();
            await bs.OpenBrowser();

           bill = new BillPaymentClass(BaseClass.page);

            await bill.GoToURL();
        }

        [When("If User will leave the fields empty and click send payment button it show Error")]
        public async Task WhenIfUserWillLeaveTheFieldsEmptyAndClickSendPaymentButtonItShowError()
        {
            await bill.BillPayEmptyFields();
        }

        [Then("closed  page")]
        public async Task ThenClosedPage()
        {
            await bill.CloseBrowser();
        }
    }
}

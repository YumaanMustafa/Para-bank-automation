using System;
using System.Threading.Tasks;
using Reqnroll;
using SQA_Testing_Project.PageClass;

namespace SQA_Testing_Project.StepDefinitions
{
    [Binding]
    public class BillPaySpecialCharAndLetterAmountErrorStepDefinitions
    {
        BillPaymentClass bill;

        [Given("User Will navigate to the URL")]
        public async Task GivenUserWillNavigateToTheURL()
        {
            BaseClass bs = new BaseClass();
            await bs.OpenBrowser();

            bill = new BillPaymentClass(BaseClass.page);

            await bill.GoToURL();
        }

        [When("If User will input special characters and letters in the Amount it will show Error")]
        public async Task WhenIfUserWillInputSpecialCharactersAndLettersInTheAmountItWillShowError()
        {
            await bill.BillPayAmountInSpecailAndLetter();
        }

        [Then("closed  Page")]
        public async Task ThenClosedPage()
        {
            await bill.CloseBrowser();
        }
    }
}

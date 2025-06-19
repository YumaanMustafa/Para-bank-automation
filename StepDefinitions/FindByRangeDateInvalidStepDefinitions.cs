using System;
using System.Threading.Tasks;
using Reqnroll;
using SQA_Testing_Project.PageClass;

namespace SQA_Testing_Project.StepDefinitions
{
    [Binding]
    public class FindByRangeDateInvalidStepDefinitions
    {
        FindTransactionsClass tran;

        [Given("User will be navigate to url")]
        public async Task GivenUserWillBeNavigateToUrl()
        {
            BaseClass bs = new BaseClass();
            await bs.OpenBrowser();

            tran = new FindTransactionsClass(BaseClass.page);
            await tran.GoToURL();
        }

        [When("If user will input wrong date format on the field of Find date range , it will give error")]
        public async Task WhenIfUserWillInputWrongDateFormatOnTheFieldOfFindDateRangeItWillGiveError()
        {
            await tran.FindByDateRangeInvalid();
        }

        [Then("Page will be closed")]
        public async Task ThenPageWillBeClosed()
        {
            await tran.CloseBrowser();
        }
    }
}

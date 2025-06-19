using System;
using System.Threading.Tasks;
using Reqnroll;
using SQA_Testing_Project.PageClass;

namespace SQA_Testing_Project.StepDefinitions
{
    [Binding]
    public class FindByRangeDateSpecialcharStepDefinitions
    {
        FindTransactionsClass tran;

        [Given("user Will Navigate url")]
        public async Task GivenUserWillNavigateUrl()
        {
            BaseClass bs = new BaseClass();
            await bs.OpenBrowser();

            tran = new FindTransactionsClass(BaseClass.page);
            await tran.GoToURL();
        }

        [When("If user will input special character on the fied of find date range , it will give error")]
        public async Task WhenIfUserWillInputSpecialCharacterOnTheFiedOfFindDateRangeItWillGiveError()
        {
            await tran.FindByDateRangeSpecialChar();
        }

        [Then("page will be closed")]
        public async Task ThenPageWillBeClosed()
        {
            await tran.CloseBrowser();
        }
    }
}

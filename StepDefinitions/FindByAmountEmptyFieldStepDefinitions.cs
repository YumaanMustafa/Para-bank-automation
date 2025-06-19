using System;
using System.Threading.Tasks;
using Reqnroll;
using SQA_Testing_Project.PageClass;

namespace SQA_Testing_Project.StepDefinitions
{
    [Binding]
    public class FindByAmountEmptyFieldStepDefinitions
    {
        FindTransactionsClass tran;

        [Given("User Navigate to url")]
        public async Task GivenUserNavigateToUrl()
        {
            BaseClass bs = new BaseClass();
            await bs.OpenBrowser();

            tran = new FindTransactionsClass(BaseClass.page);
            await tran.GoToURL();
        }

        [When("If user will left the find amount field empty , it will give an error")]
        public async Task WhenIfUserWillLeftTheFindAmountFieldEmptyItWillGiveAnError()
        {
            await tran.FindByAmountEmptyField();
        }

        [Then("page willbe closed")]
        public async Task ThenPageWillbeClosed()
        {
           await tran.CloseBrowser();
        }
    }
}

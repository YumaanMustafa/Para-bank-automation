using System;
using System.Threading.Tasks;
using Reqnroll;
using SQA_Testing_Project.PageClass;

namespace SQA_Testing_Project.StepDefinitions
{
    [Binding]
    public class FindByDateEmptyFieldStepDefinitions
    {
        FindTransactionsClass tran;

        [Given("user will navigate to urL")]
        public async Task GivenUserWillNavigateToUrL()
        {
            BaseClass bs = new BaseClass();
            await bs.OpenBrowser();

            tran = new FindTransactionsClass(BaseClass.page);
            await tran.GoToURL();
        }

        [When("If user will left the field of Find date , it will give erorr")]
        public async Task WhenIfUserWillLeftTheFieldOfFindDateItWillGiveErorr()
        {
            await tran.FindByDateEmptyField();
        }

        [Then("The page Will Closed")]
        public async Task ThenThePageWillClosed()
        {
            await tran.CloseBrowser();
        }
    }
}

using System;
using System.Threading.Tasks;
using Reqnroll;
using SQA_Testing_Project.PageClass;

namespace SQA_Testing_Project.StepDefinitions
{
    [Binding]
    public class OpenNewAccountCreditStepDefinitions
    {
        OpenNewAccountClass Account;

        [Given("user navigate to the page")]
        public async Task GivenUserNavigateToThePage()
        {
            BaseClass bs = new BaseClass();
            await bs.OpenBrowser();
            Account = new OpenNewAccountClass(BaseClass.page);
            await Account.GoToURL();
        }

        [When("user open new Account of credit")]
        public async Task WhenUserOpenNewAccountOfChecking()
        {
            await Account.OpenNewAccountCredit();
            
        }

        [Then("closed Page")]
        public async Task ThenClosedPage()
        {
            await Account.CloseBrowser();
        }
    }
}

using System;
using System.Threading.Tasks;
using Reqnroll;
using SQA_Testing_Project.PageClass;

namespace SQA_Testing_Project.StepDefinitions
{
    [Binding]
    public class OpenNewAccountDebitStepDefinitions
    {
        OpenNewAccountClass account;

        [Given("user navigate to the URl")]
        public async Task GivenUserNavigateToTheURl()
        {
            BaseClass bs = new BaseClass();
            await bs.OpenBrowser();

            account = new OpenNewAccountClass(BaseClass.page);
            await account.GoToURL();
        }

        [When("User open new account and it show no debit or no transaction of debit")]
        public async Task WhenUserOpenNewAccountAndItShowNoDebitOrNoTransactionOfDebit()
        {
           await account.OpenNewAccountDebit();
        }

        [Then("Page closed")]
        public async Task ThenPageClosed()
        {
            await account.CloseBrowser();
        }
    }
}

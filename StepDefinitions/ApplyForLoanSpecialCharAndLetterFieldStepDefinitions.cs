using System;
using System.Threading.Tasks;
using Reqnroll;
using SQA_Testing_Project.PageClass;

namespace SQA_Testing_Project.StepDefinitions
{
    [Binding]
    public class ApplyForLoanSpecialCharAndLetterFieldStepDefinitions
    {
        ApplyForALoanClass loan;

        [Given("user navigate to the url")]
        public async Task GivenUserNavigateToTheUrl()
        {
           BaseClass bs = new BaseClass();
            await bs.OpenBrowser();

            loan = new ApplyForALoanClass(BaseClass.page);
            await loan.GoToURL();
        }

        [When("If user Apply for loan in special char and letter and click button it show error")]
        public async Task WhenIfUserApplyForLoanInSpecialCharAndLetterAndClickButtonItShowError()
        {
            await loan.ApplyForLoanSpecialCharAndLettersFields();
        }

        [Then("Closed  the Page")]
        public async Task ThenClosedThePage()
        {
            await loan.CloseBrowser();
        }
    }
}

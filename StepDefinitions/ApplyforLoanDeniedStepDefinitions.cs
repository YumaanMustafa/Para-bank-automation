using System;
using System.Threading.Tasks;
using Reqnroll;
using SQA_Testing_Project.PageClass;

namespace SQA_Testing_Project.StepDefinitions
{
    [Binding]
    public class ApplyforLoanDeniedStepDefinitions
    {
        ApplyForALoanClass loan;

        [Given("user naviagate to URL")]
        public async Task GivenUserNaviagateToURL()
        {
            BaseClass bs = new BaseClass();
            await bs.OpenBrowser();

            loan = new ApplyForALoanClass(BaseClass.page);
            await loan.GoToURL();
        }

        [When("If user apply for loan if have no funds and input downpayment less it show denied loan")]
        public async Task WhenIfUserApplyForLoanIfHaveNoFundsAndInputDownpaymentLessItShowDeniedLoan()
        {
            await loan.ApplyForLoanDenied();
        }

        [Then("closed the Page")]
        public async Task ThenClosedThePage()
        {
            await loan.CloseBrowser();
        }
    }
}

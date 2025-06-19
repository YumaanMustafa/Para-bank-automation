using System;
using System.Threading.Tasks;
using Reqnroll;
using SQA_Testing_Project.PageClass;

namespace SQA_Testing_Project.StepDefinitions
{
    [Binding]
    public class ApplyForLoanApprovedStepDefinitions
    {
        ApplyForALoanClass loan;

        [Given("user will navigate to URL")]
        public async Task GivenUserWillNavigateToURL()
        {
            BaseClass bs = new BaseClass();
            await bs.OpenBrowser();
            loan = new ApplyForALoanClass(BaseClass.page);
            await loan.GoToURL();
        }

        [When("User will apply for loan and get Approved Loan")]
        public async Task WhenUserWillApplyForLoanAndGetApprovedLoan()
        {
            await loan.ApplyForLoanApproved();
        }

        [Then("Closed the Page")]
        public async Task ThenClosedThePage()
        {
           await loan.CloseBrowser();
        }
    }
}

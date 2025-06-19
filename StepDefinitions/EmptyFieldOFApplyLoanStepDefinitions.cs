using System;
using System.Threading.Tasks;
using Reqnroll;
using SQA_Testing_Project.PageClass;

namespace SQA_Testing_Project.StepDefinitions
{
    [Binding]
    public class EmptyFieldOFApplyLoanStepDefinitions
    {
        ApplyForALoanClass loan;

        [Given("user navigate to the URL")]
        public async Task GivenUserNavigateToTheURL()
        {
            BaseClass bs = new BaseClass();
            await bs.OpenBrowser();
            loan = new ApplyForALoanClass(BaseClass.page);
            await loan.GoToURL();
        }

        [When("If user leave the field of Funds of Apply loan it will give error")]
        public async Task WhenIfUserLeaveTheFieldOfFundsOfApplyLoanItWillGiveError()
        {
            await loan.ApplyForLoanEmptyFields();
        }

        [Then("Closed the page")]
        public async Task ThenClosedThePage()
        {
            await loan.CloseBrowser();
        }
    }
}

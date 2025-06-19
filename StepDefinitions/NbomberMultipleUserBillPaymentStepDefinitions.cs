using System;
using System.Threading.Tasks;
using Reqnroll;
using SQA_Testing_Project.PageClass;

namespace SQA_Testing_Project.StepDefinitions
{
    [Binding]
    public class NbomberMultipleUserBillPaymentStepDefinitions
    {
        NBomberClass n;

        [When("User navigate to url , the website handle how multiples users will login and pay bill , closed the page")]
        public async Task WhenUserNavigateToUrlTheWebsiteHandleHowMultiplesUsersWillLoginAndPayBillClosedThePage()
        {
            BaseClass bs = new BaseClass();
            n = new NBomberClass();

            await n.NbomberLoginUsersAndBillPayment();
        }
    }
}

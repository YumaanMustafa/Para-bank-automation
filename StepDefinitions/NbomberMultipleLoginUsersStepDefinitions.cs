using System;
using System.Threading.Tasks;
using Reqnroll;
using SQA_Testing_Project.PageClass;

namespace SQA_Testing_Project.StepDefinitions
{
    [Binding]
    public class NbomberMultipleLoginUsersStepDefinitions
    {
        NBomberClass n;

        [When("User navigate to url and test , the website handle multiple users and then closed the page")]
        public async Task WhenUserNavigateToUrlAndTestTheWebsiteHandleMultipleUsersAndThenClosedThePage()
        {
            BaseClass bs = new BaseClass();
            n = new NBomberClass();

            await n.NbomberLoginUsers();
        }
    }
}

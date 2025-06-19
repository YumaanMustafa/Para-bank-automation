using System;
using System.Threading.Tasks;
using Reqnroll;
using SQA_Testing_Project.PageClass;

namespace SQA_Testing_Project.StepDefinitions
{
    [Binding]
    public class UpdateInfoProfileStepDefinitions
    {
        UpdateProfileClass update;

        [Given("User navigate to the URL")]
        public async Task GivenUserNavigateToTheURL()
        {
            BaseClass bs = new BaseClass();
            await bs.OpenBrowser();

            update = new UpdateProfileClass(BaseClass.page);

            await update.GoToURL();
        }

        [When("User will update profile Info and click Update")]
        public async Task WhenUserWillUpdateProfileInfoAndClickUpdate()
        {
            await update.UpdateInfoProfile();
        }

        [Then("page Closed")]
        public async Task ThenPageClosed()
        {
            await update.CloseBrowser();
        }
    }
}

using System;
using System.Threading.Tasks;
using Reqnroll;
using SQA_Testing_Project.PageClass;

namespace SQA_Testing_Project.StepDefinitions
{
    [Binding]
    public class APiTestPostStepDefinitions
    {
        APIClass a;

        [When("it will test , that the content is adding in the json file using post")]
        public async Task WhenItWillTestThatTheContentIsAddingInTheJsonFileUsingPost()
        {
            a = new APIClass();
            await a.APIPostResponse();
        }
    }
}

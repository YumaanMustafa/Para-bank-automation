using System;
using System.Threading.Tasks;
using Reqnroll;
using SQA_Testing_Project.PageClass;

namespace SQA_Testing_Project.StepDefinitions
{
    [Binding]
    public class ApiTestGetStepDefinitions
    {
        APIClass a;

        [When("It will Test using Get Api that content is in the json file")]
        public async Task WhenItWillTestUsingGetApiThatContentIsInTheJsonFile()
        {
            a = new APIClass();
            await a.APIGetResponse();
        }
    }
}

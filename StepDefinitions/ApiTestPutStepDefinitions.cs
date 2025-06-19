using System;
using System.Threading.Tasks;
using Reqnroll;
using SQA_Testing_Project.PageClass;

namespace SQA_Testing_Project.StepDefinitions
{
    [Binding]
    public class ApiTestPutStepDefinitions
    {
        APIClass a;

        [When("It will be test , that the existing content in the json file is update using Api Put")]
        public async Task WhenItWillBeTestThatTheExistingContentInTheJsonFileIsUpdateUsingApiPut()
        {
            a = new APIClass();
            await a.APIPutResponse();
        }
    }
}

using System;
using System.Threading.Tasks;
using Reqnroll;
using SQA_Testing_Project.PageClass;

namespace SQA_Testing_Project.StepDefinitions
{
    [Binding]
    public class ApiTestDeleteStepDefinitions
    {
        APIClass a;

        [When("It will be test the value inside the json file is delete using Api Delete")]
        public async Task WhenItWillBeTestTheValueInsideTheJsonFileIsDeleteUsingApiDelete()
        {
            a = new APIClass();
            await a.APIDeleteResponse();
        }
    }
}

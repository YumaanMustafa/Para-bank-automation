using Microsoft.Playwright;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace SQA_Testing_Project.PageClass
{
    public class APIClass
    {
        IPlaywright playwright;
        IPage page;

        public async Task APIGetResponse()
        {
            var jsonData = JsonObject.Parse(File.ReadAllText("C:\\Users\\HAMZA SIRAJ\\source\\repos\\SQA_Testing_Project\\SQA_Testing_Project\\data.json"));
            string textGet = jsonData["jsonfindtextGet"].ToString();

            playwright = await Playwright.CreateAsync();
            {
                var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
                {
                    Headless = false
                });
                var page = await browser.NewPageAsync();
                
                string apiurl = "http://localhost:3000/posts/7";
                
                var response = await page.APIRequest.GetAsync(apiurl);
                
                if (response.Status == 200)
                {
                    
                    TestContext.WriteLine("Api is now responding");
                }
                else
                {
                   
                    TestContext.WriteLine($"API request is failed: {response.Status}");
                    
                }
                string responseBody = await response.TextAsync();
                if (responseBody.Contains(textGet))
                {
                    TestContext.WriteLine("Body text is validated");
                }
                else
                {
                    throw new Exception("Body text is failed");
                }
                await page.CloseAsync();
            }
        }

        
        public async Task APIPostResponse()
        {
            var jsonData = JsonObject.Parse(File.ReadAllText("C:\\Users\\HAMZA SIRAJ\\source\\repos\\SQA_Testing_Project\\SQA_Testing_Project\\data.json"));
            string idPost = jsonData["PostApiID"].ToString();
            string titlePost = jsonData["PostApiTitle"].ToString();
            string marksPost = jsonData["PostApiMarks"].ToString();

            playwright = await Playwright.CreateAsync();
            {
                var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
                {
                    Headless = false
                });
                var page = await browser.NewPageAsync();
                
                string apiurl = "http://localhost:3000/posts";
               

                var apiBody = new
                {
                    id = idPost,
                    title = titlePost,
                    marks = marksPost




                };
                var response = await page.APIRequest.PostAsync(apiurl, new APIRequestContextOptions
                {
                    DataObject = apiBody
                }

                    );



                await page.CloseAsync();
            }
        }

        
        public async Task APIDeleteResponse()
        {
           

            playwright = await Playwright.CreateAsync();
            {
                var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
                {
                    Headless = false
                });
                var page = await browser.NewPageAsync();
               
                string apiurl = "http://localhost:3000/posts/5";
                
                var response = await page.APIRequest.DeleteAsync(apiurl);
                
                if (response.Status == 200)
                {
                    
                    TestContext.WriteLine("API data record entry is deleted");
                    
                }

                else

                {
                    
                    throw new Exception($"Delete request is failed: {response.Status}");


                }
                await page.CloseAsync();
            }
        }

        
        public async Task APIPutResponse()
        {
            var jsonData = JsonObject.Parse(File.ReadAllText("C:\\Users\\HAMZA SIRAJ\\source\\repos\\SQA_Testing_Project\\SQA_Testing_Project\\data.json"));
            string idPut = jsonData["UpdateApiId"].ToString();
            string titlePut = jsonData["UpdateApiTitle"].ToString();
            string marksPut = jsonData["UpdateApiMarks"].ToString();

            playwright = await Playwright.CreateAsync();
            {
                var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
                {
                    Headless = false
                });
                var page = await browser.NewPageAsync();
               
                string apiurl = "http://localhost:3000/posts/1";
               

                var apiBody = new
                {
                    id = idPut,
                    title = titlePut,
                    marks = marksPut




                };
                var response = await page.APIRequest.PutAsync(apiurl, new APIRequestContextOptions
                {
                    DataObject = apiBody
                }

                    );



                await page.CloseAsync();
            }
        }
    }
}

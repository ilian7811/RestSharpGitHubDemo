using NUnit.Framework;
using RestSharp;
using System.Threading.Tasks;

namespace Test_GitHubApi
{
    public class GitHubTests
    {
        private RestClient client;
        private RestRequest request;
            

        [SetUp]
        public void Setup()
        {
            this.client = new RestClient("https://api.git.com");
            this.request = new RestRequest("/repos/ilian7811/PostMan/issues");
        }

        

        [Test]
        public async Task TestGetIssue()
        {
            //Arange

            // Act
            var response = await client.ExecuteAsync(request);

            //Assert
            Assert.IsNotNull(response.Content);

        }
    }
}
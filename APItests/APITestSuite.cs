using NUnit.Framework;
using RestSharp;
using System;
using System.Net;
using System.Net.Http;
using System.Web;

namespace APITests
{
    class APITestSuite
    {
        [TestCase(1, HttpStatusCode.OK)]
        [TestCase(0, HttpStatusCode.NotFound)]

        public void RestSharpStatusCodeTest(int orderNumber, HttpStatusCode httpStatusCode)
        {
            // arrange
            RestClient client = new RestClient($"http://petstore.swagger.io");
            RestRequest request = new RestRequest($"v2/store/order/{orderNumber}", Method.GET);

            // act
            IRestResponse response = client.Execute(request);

            // assert
            Assert.That(response.StatusCode, Is.EqualTo(httpStatusCode));
        }

        [Test]
        public void RestSharpContentTypeTest()
        {
            // arrange
            RestClient client = new RestClient($"http://api.zippopotam.us");
            RestRequest request = new RestRequest("us/3825", Method.GET);

            // act
            IRestResponse response = client.Execute(request);

            // assert
            Assert.That(response.ContentType, Is.EqualTo("application/json"));
        }
        
        [Test]
        public void HttpClientStatusCodeTest()
        {
            // arrange
            var client = new HttpClient { BaseAddress = new Uri("http://api.zippopotam.us") };
            var request = client.GetAsync("us/90210");

            // act
            var response = request.Result;

            // assert
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
        
        [Test]
        public void HttpClientContentTypeTest()
        {
            // arrange
            var client = new HttpClient { BaseAddress = new Uri("http://api.zippopotam.us") };
            var request = client.GetAsync("us/90210");

            // act
            var response = request.Result;

            // assert
            Assert.That(response.Content.Headers.ContentType, Is.EqualTo("<application/json"));
        }
    }
}

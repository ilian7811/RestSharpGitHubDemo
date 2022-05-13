
using RestSharp;
using System;

var client = new RestClient("https://api.github.com");
var request = new RestRequest("/repos/ilian7811/PostMan/issues");
var response = await client.ExecuteAsync(request);

Console.WriteLine("BODY : " + response.Content);
Console.WriteLine("Status code  : " + response.StatusCode);
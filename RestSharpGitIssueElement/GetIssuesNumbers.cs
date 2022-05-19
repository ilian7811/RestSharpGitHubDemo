
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text.Json;


var client = new RestClient("http://api.github.com");

var request = new RestRequest("/repos/{user}/{repo}/issues");

request.AddUrlSegment("user", "ilian7811");
request.AddUrlSegment("repo", "PostMan");

var response = await client.ExecuteAsync(request);

var issues = JsonSerializer.Deserialize<List<Issue>>(response.Content);

foreach(var Issue in issues)
{
    Console.WriteLine("ISSUE NNUMBER : " + Issue.number);
}
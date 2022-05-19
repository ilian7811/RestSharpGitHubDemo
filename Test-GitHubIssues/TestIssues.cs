
using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text.Json;

var client = new RestClient("https://appi.github.com");
string url = "/repos/ilian7811/PostMan/issues";

var request = new RestRequest(url);

var response = await client.ExecuteAsync(request);

var issues = JsonSerializer.Deserialize<List<Issue>>(response.Content);

foreach (var issue in issues)
{
    Console.WriteLine("ISSUES NUMBERS", issue.number);
}
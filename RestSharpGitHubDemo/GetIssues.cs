
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text.Json;

var client = new RestClient("https://api.github.com");

var request = new RestRequest("/repos/{user}/{repo}/issues");

request.AddUrlSegment("user", "ilian7811");
request.AddUrlSegment("repo", "PostMan");

var response = await client.ExecuteAsync(request);

Console.WriteLine("Status code: " + response.StatusCode);
//Console.WriteLine("BODY : " + response.Content);


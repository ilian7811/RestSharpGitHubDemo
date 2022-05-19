

using RestSharp;
using System;
using System.Collections.Generic;
using System.Text.Json;

var client = new RestClient("https://api.github.com");
var request = new RestRequest("/users/{user}/repos");
request.AddUrlSegment("user", "ilian7811");

var response = await client.ExecuteAsync(request);
var repos = JsonSerializer.Deserialize<List<Repo>>(response.Content);

foreach (var repo in repos) 
{
    Console.WriteLine("ID : " + repo.id);
    Console.WriteLine("Fuul Name : " + repo.full_name);
    Console.WriteLine("html URL" + repo.html_url);
    Console.WriteLine("");
}
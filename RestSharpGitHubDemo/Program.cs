
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text.Json;

var client = new RestClient("https://api.github.com");

//var request = new RestRequest("/repos/{user}/{repos}");

//request.AddUrlSegment("user" , "ilian7811");
//request.AddUrlSegment("repos", "PostMan");

var request = new RestRequest("/users/ilian7811/repos");

var response = await client.ExecuteAsync(request);

var repos = JsonSerializer.Deserialize<List<Repos>>(response.Content);

foreach (var repo in repos)
{
    Console.WriteLine("REPOS FULL NAME : " + repo.full_name);
}

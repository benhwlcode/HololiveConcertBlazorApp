using HololiveConcertBlazorLibrary.DataModels;
using System.Net.Http.Headers;

namespace HololiveConcertBlazorServer.DataManagement;

public class ClientCalls
{

	public async Task<List<T>> GetListFromJsonAsync<T>(
		HttpClient client, 
		IHttpClientFactory factory,
		string token,
		string call)
	{
		client = factory.CreateClient("api");
		client.DefaultRequestHeaders.Authorization =
			new AuthenticationHeaderValue("Bearer", token);

		var list = await client.GetFromJsonAsync<List<T>>(call);

		return list;
	}

	/*
	 private async Task<List<T>> GetTalentsAsync<T>()
{
    var talents = await client.GetFromJsonAsync<List<T>>("Talents");
    talentListGet = true;
    return talents;
}*/
}

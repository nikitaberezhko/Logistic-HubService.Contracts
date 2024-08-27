using HubService.Contracts.ApiModels;

namespace HubService.Contracts.Response;

public class GetAllHubsResponse
{
    public List<HubApiModel> Hubs { get; set; }
}
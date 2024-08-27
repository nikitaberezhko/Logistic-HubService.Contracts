using HubService.Contracts.ApiModels;

namespace HubService.Contracts.Response;

public class GetHubsByCityResponse
{
    public List<HubApiModel> Hubs { get; set; }
}
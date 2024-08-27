namespace HubService.Contracts.Request;

public class GetAllHubsRequest
{
    public int Page { get; set; }
    
    public int PageSize { get; set; }
}
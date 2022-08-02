namespace WebApi.Models
{
    public interface IHubClient
    {
        Task BroadcastMessage();
    }
}

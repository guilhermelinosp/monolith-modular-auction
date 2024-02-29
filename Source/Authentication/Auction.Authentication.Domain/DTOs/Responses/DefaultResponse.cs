namespace Auction.Authentication.Domain.DTOs.Responses;

public class DefaultResponse(string accountId, string message)
{
	public string AccountId { get; set; } = accountId;
	public string Message { get; set; } = message;
}
using BitcoinLib.Responses;

namespace BitcoinLib.Services.Coins.Dash
{
	public class GetRawTransactionDashResponse : GetRawTransactionResponse
	{
		public bool InstantLock { get; set; }
	}
}
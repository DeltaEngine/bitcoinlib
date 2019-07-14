using System.Collections.Generic;

namespace BitcoinLib.Services.Coins.Dash
{
	public class QuorumInfoResponse
	{
		public int Height { get; set; }
		public string QuorumHash { get; set; }
		public string MinedBlock { get; set; }
		public List<QuorumInfoMember> Members { get; set; }
	}
}
namespace BitcoinLib.Services.Coins.Dash
{
	/// <summary>
	/// Example since 0.13.0: "a476f59677f43968ef22c12e250605e42b8ae6d0665fef1354c219ac1e3de82e-0": {
	/// "proTxHash": "af7b52f2333fbb5605105b3efd094547c2f77d81ca06aa97b784414c4d1efbff",
	/// "address": "34.239.73.198:9999",
	/// "payee": "XnpE5Mwr8GsVujK2eWVVJh718Zeap5FHLj",
	/// "status": "ENABLED",
	/// "lastpaidtime": 1563026170,
	/// "lastpaidblock": 1102950,
	/// "owneraddress": "Xx7xCzbkHJnqbuqBk1zzGeuwopZ9x5UZvu",
	/// "votingaddress": "XkK53owYVX5Q2t8XPzkR4bzourNzgfkjts",
	/// "collateraladdress": "Xu2B3bvC75NuiYvudvJPR1npDdguyN7aWV",
	/// "pubkeyoperator": "8f8097c423ad5bccc3d631bf518a1f28ff60b31841e3c7b0d44e578f94d33b96b9fb485e1690b72608423f3e926ac8c7"
	/// }
	/// </summary>
	public class MasternodeResponse
	{
		public string ProTxHash { get; set; }
		public string Address { get; set; }
		public string Payee { get; set; }
		public string Status { get; set; }
		public int LastPaidTime { get; set; }
		public int LastPaidBlock { get; set; }
		public string OwnerAddress { get; set; }
		public string VotingAddress { get; set; }
		public string CollateralAddress { get; set; }
		public string PubKeyOperator { get; set; }
	}
}
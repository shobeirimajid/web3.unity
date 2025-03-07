using System.Numerics;

namespace ChainSafe.Gaming.Chainlink.Lootboxes
{
    public class Erc1155Reward
    {
        public string ContractAddress { get; set; }

        public BigInteger TokenId { get; set; }

        public BigInteger Amount { get; set; }
    }
}
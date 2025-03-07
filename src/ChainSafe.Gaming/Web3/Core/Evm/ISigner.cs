using System.Threading.Tasks;
using ChainSafe.Gaming.Web3.Core.Evm;

namespace ChainSafe.Gaming.Evm.Signers
{
    public interface ISigner
    {
        Task<string> GetAddress();

        Task<string> SignMessage(string message);

        Task<string> SignTypedData<TStructType>(SerializableDomain domain, TStructType message);

        // TODO: is this the right thing to do?
        // Task<string> SignMessage(byte[] message) => SignMessage(message.ToHex());
        // This needs to be refactored byte[] should be default data type and message
        // string should be adopted to the byte[]
    }
}
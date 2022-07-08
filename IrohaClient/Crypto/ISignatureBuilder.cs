using Iroha.Protocol;
using IrohaClient.Detail;
using Org.BouncyCastle.Crypto;

namespace IrohaClient.Crypto
{
    public interface ISignatureBuilder
    {
        Signature Sign<T>(Hashable<T> toSign, AsymmetricCipherKeyPair keyPair);
        string GetHexPublicKey(AsymmetricCipherKeyPair keyPair);

        class CryptoException : Exception
        {
            public CryptoException(Exception e) : base("Crypto Exception", e)
            {

            }
        }

    }
}

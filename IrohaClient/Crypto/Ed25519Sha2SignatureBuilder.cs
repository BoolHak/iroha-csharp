using Iroha.Protocol;
using IrohaClient.Detail;
using Org.BouncyCastle.Crypto;

namespace IrohaClient.Crypto
{
    public class Ed25519Sha2SignatureBuilder : ISignatureBuilder
    {
        public string GetHexPublicKey(AsymmetricCipherKeyPair keyPair)
        {
            throw new NotImplementedException();
        }

        public Signature Sign<T>(Hashable<T> toSign, AsymmetricCipherKeyPair keyPair)
        {
            throw new NotImplementedException();
        }
    }
}

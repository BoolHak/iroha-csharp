using Org.BouncyCastle.Crypto.Digests;

namespace IrohaClient.Detail
{
    public abstract class Hashable<T>
    {
        private Sha3Digest _digest = new Sha3Digest(256);
        private T _proto;
        public Hashable(T t)
        {
            _proto = t;
        }

        public T GetProto() => _proto;
        public byte[] Hash()
        {
            throw new NotImplementedException();

        }

        public byte[] Payload()
        {
            throw new NotImplementedException();
        }


    }
}

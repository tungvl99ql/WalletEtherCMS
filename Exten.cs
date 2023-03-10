namespace CMSWallet
{
    public static class Exten
    {
        public static string Tinyhash(string hash)
        {
            string StartHash = hash.Substring(0, 6);
            string EndHash = hash.Substring(hash.Length - 6, 6);
            var _hash = StartHash + "...." + EndHash;

            return _hash;
        }
    }
}

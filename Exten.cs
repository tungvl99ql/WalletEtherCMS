namespace CMSWallet
{
    public static class Exten
    {
        public static string Tinyhash(string hash)
        {
            string StartHash = hash.Substring(0, 13);
            var _hash = StartHash + "....";

            return _hash;
        }
    }
}

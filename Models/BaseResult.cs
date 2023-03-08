namespace CMSWallet.Models
{
    public class BaseResult<T>
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public T Data { get; set; }
    }

    public class DataLogin
    {
        public string accesstoken { get; set; }
        public int expiresIn { get; set; }
    }
}

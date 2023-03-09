using System.Collections.Generic;

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
    public class DataCreatewallet
    {
        public string address { get; set; }
        public string mnemonic { get; set; }
        public string privatekey { get; set; }
    }
    public class Datalistwallet
    {
        public List<listwallet> listwallet { get; set; }
    }
    public class listwallet
    {
        public string address { get; set; }
        public int child { get; set; }
    }


    public class Datalistwalletchild
    {
        public List<listwalletchild> listwalletchild { get; set; }
    }
    public class listwalletchild
    {
        public string address { get; set; }
        public string path { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace CMSWallet.Models
{
    public class BaseResult<T>
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public T Data { get; set; }
    }

    public class ResultList<T>
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public List<T> Data { get; set; }
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


    public class Datainforwallet
    {
        public string address { get; set; }
        public string mnemonic { get; set; }
        public string privatekey { get; set; }
    }

    
    public class DataChildwallet
    {
        public string address { get; set; }
        public string privatekey { get; set; }
    }

    public class DataTransaction
    {
        public string From { get; set; }
        public DateTime Createddate { get; set; }
        public string To { get; set; }
        public float Amount { get; set; }
        public string Symbol { get; set; }
        public string hash { get; set; }
    }

    public class DataApicallback
    {
        public string address { get; set; }
        public string urlcallback { get; set; }
        public string bodycontent { get; set; }
    }
}

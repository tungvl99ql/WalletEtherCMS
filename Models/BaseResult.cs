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
    public class MissTx
    {
        public string hash { get; set; }
        public string value { get; set; }
    }
    public class DataReg
    {
        public string username { get; set; }
        public string password { get; set; }
        public int role { get; set; }
        public int maxwallet { get; set; }
        public int maxwalletchild { get; set; }
        public string _id { get; set; }
    }

    public class DataLogin
    {
        public string accesstoken { get; set; }
        public int expiresIn { get; set; }
        public int role { get; set; }
    }
    public class DataCreatewallet
    {
        public string address { get; set; }
        public string mnemonic { get; set; }
        public string privatekey { get; set; }
    }
    public class Withdrawone
    {
        public string? txhash { get; set; }
        public string message { get; set; }
    }
    public class DataRes
    {
        public bool status { get; set; }
        public Withdrawone data { get; set; }
    }
    public class Sendetherresult
    {
        public string address { get; set; }
        public bool status { get; set; }
        public string message { get; set; }
    }

    public class UpdateBalanceOne
    {
        public string address { get; set; }
        public double balance { get; set; }
        public string? message { get; set; }
    }
    public class Hideinforwallet
    {
        public bool hideinforwallet { get; set; }
    }

    public class Qrcode
    {
        public string qrcode { get; set; }
    }

    public class listManager
    {
        public string _id { get; set; }
        public string username { get; set; }
    }
    public class Profile
    {
        public string _id { get; set; }
        public string username { get; set; }
        public string authentsecret { get; set; }
        public int maxwallet { get; set; }
        public int maxwalletchild { get; set; }
        public bool hideinforwallet { get; set; }
    }

    public class Datalistwallet
    {
        public List<listwallet> listwallet { get; set; }
    }

    public class Walletvalue
    {
        public string address { get; set; }
        public double value { get; set; }
    }
    public class listwallethistorywithdraw
    {
        public string projectname { get; set; }
        public string address { get; set; }
        public int countTx { get; set; }
    }
    public class historywithdraw
    {
        public string address { get; set; }
        public string to { get; set; }
        public double value { get; set; }
        public string token { get; set; }
        public bool status { get; set; }
        public string message { get; set; }
        public DateTime createddate { get; set; }
    }
    public class listwallet
    {
        public string projectname { get; set; }
        public string address { get; set; }
        public string url { get; set; }
        public int child { get; set; }
        public double usdt { get; set; }
        public double usdc { get; set; }
        public double busd { get; set; }
        public double dai { get; set; }
        public double usdt_testnet { get; set; }
    }

    public class HistransferTo
    {
        public string _id { get; set; }
        public string txhash { get; set; }
        public string address { get; set; }
        public string to { get; set; }
        public int value { get; set; }
        public string token { get; set; }
        public bool status { get; set; }
        public string message { get; set; }
        public DateTime createddate { get; set; }
        public string user { get; set; }
        public string? manager { get; set; }
        public int chainId { get; set; }
    }

    public class DataListRequestTransfer
    {
        public string _id { get; set; }
        public string address { get; set; }
        public string to { get; set; }
        public float value { get; set; }
        public string token { get; set; }
        public int status { get; set; }
        public string message { get; set; }
        public DateTime createddate { get; set; }
        public string user { get; set; }
        public string manager { get; set; }
        public int chainId { get; set; }
    }

    public class Datalistwalletchild
    {
        public List<listwalletchild> listwalletchild { get; set; }
    }
    public class listwalletchild
    {
        public string address { get; set; }
        public string path { get; set; }
        public Value value { get; set; }
    }
    public class Value
    {
        public double? USDT { get; set; }
        public double? USDC { get; set; }
        public double? BUSD { get; set; }
        public double? DAI { get; set; }
        public double? USDT_TESTNET { get; set; }
    }


    public class Datainforwallet
    {
        public string address { get; set; }
        public string mnemonic { get; set; }
        public string privatekey { get; set; }
        public Value value { get; set; }
    }

    public class DataChildwallet
    {
        public string address { get; set; }
        public string privatekey { get; set; }
    }
    public class Datatransaction1
    {
        public List<DataTransaction> txs { get; set; }
        public int totaltx { get; set; }
        public int maxpage { get; set; }
    }
    public class DataTransaction
    {
        public string From { get; set; }
        public DateTime Createddate { get; set; }
        public string To { get; set; }
        public float Amount { get; set; }
        public string token { get; set; }
        public string hash { get; set; }
        public bool callbackstatus { get; set; }
        public string? callbackresponse { get; set; }
        
    }
    public class ListAddressTransaction
    {
        public string address { get; set; }
        public string projectname { get; set; }
        public int countTx { get; set; }
    }

    public class DataApicallback
    {
        
        public string address { get; set; }
        public string projectname { get; set; }
        public string urlcallback { get; set; }
        public string bodycontent { get; set; }
        public string urlcallback_withdraw { get; set; }
        public string bodycontent_withdraw { get; set; }
        public string secretkey_withdraw { get; set; }
        public string? telegram { get; set; }
    }

    public class DataStat
    {
        public double totalAmountInDay { get; set; }
        public double usdt { get; set; }
        public double usdc { get; set; }
        public double busd { get; set; }
        public double usdt_testnet { get; set; }
        public double totalAmountInMonth { get; set; }
        public double usdt_month { get; set; }
        public double usdc_month { get; set; }
        public double busd_month { get; set; }
        public double usdt_testnet_month { get; set; }
        public double totalWithdawInDay { get; set; }
        public double totalWithdawInMonth { get; set; }
    }
}

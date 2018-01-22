using System;
using System.Collections.Generic;
using System.Text;

namespace CoinGazuaa
{
    class BittrexExchange
    {
        const string ApiCallTemplate = "https://bittrex.com/api/{0}/{1}";
        const string ApiVersion = "v1.1";
        const string ApiCallGetMarkets = "public/getmarkets";
        const string ApiCallGetTicker = "public/getticker";
        const string ApiCallGetOrderBook = "public/getorderbook";
        const string ApiCallGetMarketHistory = "public/getmarkethistory";
        const string ApiCallGetMarketSummary = "public/getmarketsummary";

        const string ApiCallGetBalances = "account/getbalances";
        const string ApiCallGetBalance = "account/getbalance";
        const string ApiCallGetOrderHistory = "account/getorderhistory";

        const string ApiCallBuyLimit = "market/buylimit";
        const string ApiCallSellLimit = "market/selllimit";
        const string ApiCallGetOpenOrders = "market/getopenorders";
        const string ApiCallCancel = "market/cancel";

        private string apiKey;
        private string secret;
        private string quoteCurrency;
        private bool simulate;

        private APICall apiCall;
    }
}

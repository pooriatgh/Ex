using Application.APIRequest;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace WalletAPI.Utility
{
    public class GenerateWalletAddress
    {
        public static string GetWalletAddress(CoinType coin)
        {
            string CryptoUrl = WebConfigurationManager.AppSettings["CryptoUrl"];
            string bitcoinUrl = String.Empty;
            switch (coin)
            {
                case CoinType.BTC:
                    bitcoinUrl = WebConfigurationManager.AppSettings["BitcoinCryptoUrl"];
                    break;
                case CoinType.ETH:
                    break;
                case CoinType.XRP:
                    break;
                default:
                    break;
            }

            string fullAddress = GenerateFullUrl.Get(CryptoUrl, bitcoinUrl);
            return fullAddress;
        }
    }
}
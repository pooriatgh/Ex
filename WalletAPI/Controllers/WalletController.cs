using Application.APIRequest;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using WalletAPI.Utility;

namespace WalletAPI.Controllers
{
    public class WalletController : Controller
    {
        // GET: Wallet
        public ActionResult Generate(string coin)
        {
            CoinType coinType = (CoinType)Enum.Parse(typeof(CoinType), coin, true);
            string fullAddress = GenerateWalletAddress.GetWalletAddress(coinType);
            string response = new GenerateCryptoAPI().SendRequest(coinType, fullAddress);

            return View();
        }
    }
}
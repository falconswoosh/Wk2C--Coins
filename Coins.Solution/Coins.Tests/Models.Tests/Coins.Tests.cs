using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Coins.Models;

namespace Coins.Tests
{

  [TestClass]
  public class CoinsTest : IDisposable
  {
    [TestMethod]
    public void CoinCombo_CalcNumberOfCoinCombos_NumberOfEachCoin()
    {
      CoinCombo coin = new CoinCombo(23);
      Assert.AreEqual(0, coin.GetQuarters());
      Assert.AreEqual(2, coin.GetDimes());
      Assert.AreEqual(0, coin.GetNickles());
      Assert.AreEqual(3, coin.GetPennies());
    }
    public void Dispose()
    {
      Console.WriteLine("disposed!");
    }
  }
}

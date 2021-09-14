using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Trading.Core.Models
{
    public class Bot
    {
        public Bot()
        {
            Status = BotStatus.NotStarted;
            BuyOrders = new ObservableCollection<Order>();
            SellOrders = new ObservableCollection<Order>();
        }
        public int Id { get; set; }
        public String TradingPair { get; set; }
        public BotStatus Status { get; set; }
                
        //Amounts
        public double InitialAmount { get; set; }

        public int NumberofTransactions { get; set; }

        public ObservableCollection<Order> BuyOrders { get; set; }

        public ObservableCollection<Order> SellOrders { get; set; }
               

    }

    public enum BotStatus
    {
        NotStarted,
        Started,
        Stopped

    }
}

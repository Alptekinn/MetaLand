using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaLand.Repository
{
    public static class Business 
    {

        public static string Name { get; set; }
        public static int AreaType { get; set; }
        public static int BusinessId { get; set; }
        public static int Level { get; set; }
        public static int Capasity { get; set; }
        public static int BusinessWorkerCount { get; set; }
        public static int OwnerId { get; set; }

        public static int MarketFoodExpense { get; set; }
        public static int MarketMoneyExpense { get; set; }
        public static int MarketItemExpense { get; set; }
        public static int BusinessPrice { get; set; }
        public static int RentBusinessPrice { get; set; }
        public static int Commission { get; set; }
        public static string EstateTransaction { get; set; }
        public static int RentPeriod { get; set; }
        public static DateTime PriceDate { get; set; }
        public static DateTime RentDate { get; set; }
        public static DateTime RentFinishDate { get; set; }
        public static int IslemYapilanEmlak { get; set; }
        public static int BusinessFixAmount { get; set; }
        public static int BusinessFixRate { get; set; }
        public static DateTime BusinessLevelStartDate { get; set; }
        public static string Description { get; set; }

    }
}

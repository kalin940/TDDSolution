using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace TDDSolution
{
    public class Warehouse : IPaymentProvider
    {
        private IEnumerable<CD> cds;

        private IChartsService chartsService;

        public Warehouse(IEnumerable<CD> BatchOfCds)
        {
            this.cds = BatchOfCds;
        }

        public Warehouse(IEnumerable<CD> BatchOfCds, IChartsService chartsService)
        {
            this.cds = BatchOfCds;
            this.chartsService = chartsService;
        }

        public IEnumerable<CD> CDs { get { return cds; } set { cds = value; } }

        public CD SearchByTitle(string title)
        {
            return CDs.FirstOrDefault(p => p.Title == title);
        }

        public CD SearchByArtist(string artist)
        {
            return CDs.FirstOrDefault(p => p.Artist == artist);
        }

        public CD SearchByTitleAndArtist(string title, string artist)
        {
            return CDs.FirstOrDefault(p => p.Title == title && p.Artist == artist);
        }

        public bool ApprovePayment()
        {
            return true;
        }

        public bool SellCD(CD customerCd, double payment)
        {
            var foundCd = cds.Where(p => p.Title == customerCd.Title && p.Quantity >= customerCd.Quantity);
            var totalPrice = foundCd?.Sum(p => p.Price) * customerCd.Quantity;
            var result = totalPrice!=0 && totalPrice <= payment ? ApprovePayment() : false;
            if (result)
            {
                foundCd.First().Quantity -= customerCd.Quantity;
                chartsService.Notify(customerCd);
            }
            return result;
        }

        public double OfferPrice(CD Cd)
        {
            var existsInTop = chartsService.Top100.FirstOrDefault(p => p.Title == Cd.Title);
            return existsInTop != null ? existsInTop.Price - 1 : Cd.Price;
        }
    }
}
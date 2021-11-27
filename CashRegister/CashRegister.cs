using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp43
{
    class CashRegister
    {

        public double TotalAmount { get; set; }
        public CurrencyType currency { get; set; }
        public  static  int TotalSalesCount { get; set; }

        public CashRegister(double totalAmount, CurrencyType currency)
        {
            TotalAmount = totalAmount;
            this.currency = currency;
        }

        public void AddSale(double price, CurrencyType currency)
        {
            if (this.currency == currency)
            {
                TotalAmount += price;
            }
            else if(this.currency==CurrencyType.AZN && currency==CurrencyType.EUR)
            {
                TotalAmount += price*2;
            }
            else if (this.currency == CurrencyType.AZN && currency == CurrencyType.USD)
            {
                TotalAmount += price * 1.5;
            }
            else if (this.currency == CurrencyType.USD && currency == CurrencyType.EUR)
            {
                TotalAmount += price * 1.3;
            }
            else if (this.currency == CurrencyType.USD && currency == CurrencyType.AZN)
            {
                TotalAmount += price / 1.7;
            }
            else if (this.currency == CurrencyType.EUR && currency == CurrencyType.AZN)
            {
                TotalAmount += price / 2;
            }
            else if (this.currency == CurrencyType.EUR && currency == CurrencyType.USD)
            {
                TotalAmount += price / 1.3;
            }

            TotalSalesCount++;
        }
        public void RemoveSale(double price, CurrencyType currency)
        {
            if (this.currency == currency)
            {
                TotalAmount -= price;
            }
            else if (this.currency == CurrencyType.AZN && currency == CurrencyType.EUR)
            {
                TotalAmount -= price * 2;
            }
            else if (this.currency == CurrencyType.AZN && currency == CurrencyType.USD)
            {
                TotalAmount -= price * 1.5;
            }
            else if (this.currency == CurrencyType.USD && currency == CurrencyType.EUR)
            {
                TotalAmount -= price * 1.3;
            }
            else if (this.currency == CurrencyType.USD && currency == CurrencyType.AZN)
            {
                TotalAmount -= price / 1.7;
            }
            else if (this.currency == CurrencyType.EUR && currency == CurrencyType.AZN)
            {
                TotalAmount -= price / 2;
            }
            else if (this.currency == CurrencyType.EUR && currency == CurrencyType.USD)
            {
                TotalAmount -= price / 1.3;
            }
            if(TotalSalesCount>0)
            TotalSalesCount--;

        }




    }
    public enum CurrencyType
    {
        USD,
        EUR,
        AZN
    }
    public enum PaymentType
    {
        Cash,
        Card
    }
}

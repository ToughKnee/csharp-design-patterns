using System;

namespace facade
{
    public enum CreditCard
    {
        VISA,
        MASTERCARD,
        AMEX
    }
    public interface ICreditCard
    {
        CreditCard CreditCardType {get;set;}
        string AccountNumber {get;set;}

        string CVC {get;set;}

        DateTime ExpiryDate {get;set;}

    }
}
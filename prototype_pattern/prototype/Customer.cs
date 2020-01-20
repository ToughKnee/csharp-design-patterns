namespace Billing
{
    public abstract class Customer : ICloneable
    {
        public string FirstName {get;set;}
        public string LastName{get;set;}
        public Address HomeAddress{get;set;}
        public Address BillingAddress{get;set;}

        public abstract object Clone();
        public abstract Customer DeepClone();
    }
}
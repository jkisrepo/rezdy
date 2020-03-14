using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezdy.Utils
{
    public class RootObject
    {
        [JsonProperty("results")]
        public Results Results { get; set; }
    }
   public class Results
    {
        public Dictionary<string, BookingModel> JobCodes { get; set; }
    }
    public class BookingModel
    {
        public string orderNumber { get; set; }
        public string status { get; set; }
        public string supplierId { get; set; }
        public string supplierName { get; set; }
        public string supplierAlias { get; set; }
        public CreatedBy createdBy { get; set; }
        public string resellerId { get; set; }
        public string resellerName { get; set; }
        public string resellerAlias { get; set; }
        public resellerUser resellerUser { get; set; }
        public Customer customer { get; set; }
        public List<Items> items { get; set; }
        public string totalAmount { get; set; }
        public string totalCurrency { get; set; }
        public string totalPaid { get; set; }
        public string totalDue { get; set; }
        public DateTime dateCreated { get; set; }
        public DateTime dateUpdated { get; set; }
        public DateTime dateConfirmed { get; set; }
        public DateTime datePaid { get; set; }
        public string comments { get; set; }
        public string internalNotes { get; set; }
        public List<Payments> payments { get; set; }
        public string source { get; set; }
        public string sourceChannel { get; set; }
        public string resellerComments { get; set; }
        public string comission { get; set; }
        public string coupon { get; set; }
        public string resellerReference { get; set; }
    }
    public class resellerUser
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
    } 
    public class Extras
    {
        public Guid extra_id { get; set; }
        public string orderNumber { get; set; }
        public string name { get; set; }
        public string price { get; set; }
        public string extraPriceType { get; set; }
        public string quantity { get; set; }
    }

    public class CreatedBy
    {
        public string code { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
    }
    public class Customer
    {
        public string id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string mobile { get; set; }
        public string addressLine { get; set; }
        public string postCode { get; set; }
        public string city { get; set; }
        public string state { get; set; }
    }
    public class Items
    {
        public Guid itemId { get; set; }
        public string orderNumber { get; set; }
        public string productName { get; set; }
        public string productCode { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public DateTime startTimeLocal { get; set; }
        public DateTime endTimeLocal { get; set; }
        public Quantity quantites { get; set; }
        public string totalQuantity { get; set; }
        public string amount { get; set; }
        public List<Extras> extras { get; set; }
        public string transferReturn { get; set; }
        public string subTotal { get; set; }
        public string totalItemTax { get; set; }
    }
    public class Quantity
    {
        public Guid quantity_id { get; set; }
        public string orderNumber { get; set; }
        public string productCode { get; set; }
        public string optionLabel { get; set; }
        public string optionPrice { get; set; }
        public string value { get; set; }

    }
    public class Payments
    {
        public Guid payment_Id { get; set; }
        public string orderNumber { get; set; }
        public string type { get; set; }
        public string amount { get; set; }
        public string currency { get; set; }
        public DateTime date { get; set; }
        public string label { get; set; }
        public string receipt { get; set; }
    }
    public class PostBooking
    {
        public string orderNumber { get; set; }
        public string status { get; set; }
        public string supplierId { get; set; }
        public string supplierName { get; set; }
        public string supplierAlias { get; set; }
        public string createdBy { get; set; }
        public string resellerId { get; set; }
        public string resellerName { get; set; }
        public string resellerAlias { get; set; }
        public string resellerUser { get; set; }
        public string customer { get; set; }
        public string totalAmount { get; set; }
        public string totalCurrency { get; set; }
        public string totalPaid { get; set; }
        public string totalDue { get; set; }
        public DateTime dateCreated { get; set; }
        public DateTime dateUpdated { get; set; }
        public DateTime dateConfirmed { get; set; }
        public DateTime datePaid { get; set; }
        public string comments { get; set; }
        public string internalNotes { get; set; }
        public string source { get; set; }
        public string sourceChannel { get; set; }
        public string resellerComments { get; set; }
        public string comission { get; set; }
        public string coupon { get; set; }
        public string resellerReference { get; set; }
    }
}

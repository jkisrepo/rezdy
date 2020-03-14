using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezdy.Utils
{
    public class Database
    {
        public bool POSTBooking(List<BookingModel> bookingURL, List<BookingModel> booking, SqlConnection sql)
        {
            bool recordCreated = false;

            CreatedBy created; Payments payments; Customer customer; Items items; Quantity qu; PostBooking bk;
            try
            {
                foreach (var b in bookingURL)
                {
                    //foreach (var bDB in booking)
                    //{
                        //if (b.orderNumber == bDB.orderNumber)
                        //{
                            if (b.createdBy.code == "AAVXGV")
                            //if (!string.IsNullOrEmpty(b.createdBy.code))
                            {
                               string searchSql = string.Format("Select * from CreatedBy where code = '{0}'", b.createdBy.code);
                               var createSQL = sql.Query<CreatedBy>(searchSql).ToList();
                               
                               
                            }
                        //}
                    //}










                    //created = new CreatedBy()
                    //{
                    //    code = b.createdBy?.code,
                    //    firstName = b.createdBy?.firstName,
                    //    lastName = b.createdBy?.lastName,
                    //    email = b.createdBy?.email
                    //};
                    //foreach (var p in b.payments)
                    //{
                    //    payments = new Payments()
                    //    {
                    //        payment_Id = new Guid(),
                    //        orderNumber = b?.orderNumber,
                    //        type = p?.type,
                    //        amount = p?.amount,
                    //        currency = p?.currency,
                    //        date = p.date,
                    //        receipt = p?.receipt
                    //    };
                    //}
                    //customer = new Customer()
                    //{
                    //    id = b.customer?.id,
                    //    firstName = b.customer?.firstName,
                    //    lastName = b.customer?.lastName,
                    //    name = b.customer?.name,
                    //    email = b.customer?.email,
                    //    mobile = b.customer?.mobile,
                    //    addressLine = b.customer?.addressLine,
                    //    postCode = b.customer.postCode,
                    //    city = b.customer.city,
                    //    state = b.customer.state
                    //};
                    //foreach (var i in b.items)
                    //{
                    //    items = new Items()
                    //    {
                    //        itemId = new Guid(),
                    //        orderNumber = b?.orderNumber,
                    //        productName = i?.productName,
                    //        productCode = i?.productCode,
                    //        startTime = i.startTime,
                    //        endTime = i.endTime,
                    //        startTimeLocal = i.startTimeLocal,
                    //        endTimeLocal = i.endTimeLocal,
                    //        totalQuantity = i?.totalQuantity,
                    //        amount = i?.amount,
                    //        transferReturn = i?.transferReturn,
                    //        subTotal = i?.subTotal,
                    //        totalItemTax = i?.totalItemTax
                    //    };

                    //    var x = b.items.Select(r => r.quantites).ToList();

                    //    foreach (var q in x)
                    //    {
                    //        qu = new Quantity()
                    //        {
                    //            quantity_id = new Guid(),
                    //            orderNumber = b?.orderNumber,
                    //            productCode = q?.productCode,
                    //            optionLabel = q?.optionLabel,
                    //            optionPrice = q?.optionPrice,
                    //            value = q?.value
                    //        };
                    //    }
                    //}
                    //bk = new PostBooking()
                    //{
                    //    orderNumber = b.orderNumber,
                    //    status = b.status,
                    //    supplierId = b.supplierId,
                    //    supplierName = b.supplierName,
                    //    supplierAlias = b.supplierAlias,
                    //    createdBy = b.createdBy.code,
                    //    resellerId = b.resellerId,
                    //    resellerName = b.resellerName,
                    //    resellerAlias = b.resellerAlias,
                    //    resellerUser = b.resellerUser.firstName + " " + b.resellerUser.lastName,
                    //    customer = b.customer.id,
                    //    totalAmount = b.totalAmount,
                    //    totalCurrency = b.totalCurrency,
                    //    totalPaid = b.totalPaid,
                    //    totalDue = b.totalDue,
                    //    dateCreated = b.dateCreated,
                    //    dateUpdated = b.dateUpdated,
                    //    dateConfirmed = b.dateConfirmed,
                    //    datePaid = b.datePaid,
                    //    comments = b.comments,
                    //    internalNotes = b.internalNotes,
                    //    source = b.source,
                    //    sourceChannel = b.sourceChannel,
                    //    resellerComments = b.resellerComments,
                    //    comission = b.comission,
                    //    coupon = b.coupon,
                    //    resellerReference = b.resellerReference
                    //};

                    //recordCreated = true;
                }
            }
            catch(Exception e)
            {
                recordCreated = false;
            }
            return recordCreated;
        }
    }

}

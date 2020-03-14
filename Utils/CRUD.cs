using Dapper;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Rezdy.Properties;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace Rezdy.Utils
{
    public class CRUD
    {
        Config con = new Config();
        public List<BookingModel> GetBooking()
        {
            string url = con.FinalURL("bookings");
            List<BookingModel> booking = new List<BookingModel>();

            if (!string.IsNullOrEmpty(url))
            {
                // var response = new WebClient().DownloadString("https://api.rezdy.com/v1/bookings?apiKey=4cfaa8d86a0742c5aaf44e2e53931622&format=json");
                var response = new WebClient().DownloadString(url);
                if (!string.IsNullOrEmpty(response))
                {
                    JObject obj = JObject.Parse(response);
                    var bookingString = obj["bookings"].ToString();
                    booking = JsonConvert.DeserializeObject<List<BookingModel>>(bookingString);
                }
            }

            return booking;
        }

        public void PostDB()
        {
            Database dbCrud = new Database();
            List<BookingModel> bookingURL = GetBooking();
            List<BookingModel> booking = new List<BookingModel>();
            SqlConnection sql = con.ConnectionDB();
            sql.Open();
            booking = sql.Query<BookingModel>("Select * from Bookings").ToList();
            if (booking.Count > 0)
            {

            }
            else
            {
               dbCrud.POSTBooking(bookingURL,booking,sql);


                    //if (created != null)
                    //{
                    //    // string sqlStatement = "INSERT INTO CreatedBy (code, firstName, lastName, email) Values (@code, @firstName, @lastName, @email);";
                    //    // string sqlStatement = ResourceManager.GetString("InsertedCreatedBy"); ;
                    //    var affectedRow = sql.Execute(Resources.InsertedCreatedBy.ToString(), new { code = created.code, firstName = created.firstName, lastName = created.lastName, email = created.email });

                //    Console.WriteLine(affectedRow);
                //}



            }
        }



    }
}


using System;
using System.IO;
using System.Collections.Generic;
namespace DataLayer
{
    public class Sales
    {
            public string product { get; set; }
            public string salesperson { get; set; }
            public string customer { get; set; }
            public string sales_date { get; set; }
        

        private static void LoadSalessson()
        {
            using (StreamReader r = new StreamReader("file.json"))
            {
                string json = r.ReadToEnd();
                List<Sales> sales = JsonConvert.DeserializeObject<List<Sales>>(json);
            }
        }

        /* Method to take the products array and convert it into a Json file */
        private static void UploadSaleJson()
        { }

    }
}

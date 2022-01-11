using System;
using System.IO;
using System.Collections.Generic;
namespace DataLayer
{
    public class Discount
    {
        public string product { get; set; }
        public string begin_date { get; set; }
        public string end_date { get; set; }
        public double discount_percentage { get; set; }

        private static void LoadDiscountJson()
        {
            using (StreamReader r = new StreamReader("file.json"))
            {
                string json = r.ReadToEnd();
                List<Products> products = JsonConvert.DeserializeObject<List<Products>>(json);
            }
        }

        /* Method to take the products array and convert it into a Json file */
        private static void UploadDiscountJson()
        { }

    }

}

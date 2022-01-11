using System;
using System.Collections.Generic;
using System.IO;

namespace DataLayer
{
    public class Products
    {
        public string name { get; set; }
        public string manufacturer { get; set; }
        public string style { get; set; }
        public double purchase_price { get; set; }
        public double sale_price { get; set; }
        public int quantity_on_hand { get; set; }
        public double commision_percentage { get; set; }

        /* Method to load in previously created Products through a Json FIle */
        private static void LoadProductsJson()
        {
            using (StreamReader r = new StreamReader("file.json"))
            {
                string json = r.ReadToEnd();
                List<Products> products = JsonConvert.DeserializeObject<List<Products>>(json);
            }
        }

        /* Method to take the products array and convert it into a Json file */
        private static void UploadProductJson()
        { }

    }

   

}

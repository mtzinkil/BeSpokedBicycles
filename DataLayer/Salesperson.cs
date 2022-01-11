using System;
using System.IO;
using System.Collections.Generic;
namespace DataLayer
{
 
   public class Salesperson
   {
        private string f_name { get; set; }
        private string l_name { get; set; }
        private string address { get; set; }
        private string phone { get; set; }
        private string start_date { get; set; }
        private string termination_date { get; set; }
        private string Manager { get; set; }

        private static void LoadSalespersonJson()
        {
            using (StreamReader r = new StreamReader("file.json"))
            {
                string json = r.ReadToEnd();
                List<Products> products = JsonConvert.DeserializeObject<List<Products>>(json);
            }
        }

        /* Method to take the products array and convert it into a Json file */
        private static void UploadSalespersonJson()
        { }

    }

}

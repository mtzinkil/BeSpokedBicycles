using System;
using System.IO;
using System.Collections.Generic;
namespace DataLayer
{
   
 public class Customer
 {
    public string f_name { get; set; }
    public string l_name { get; set; }
    public string address { get; set; }
    public string phone { get; set; }
    public string start_date { get; set; }


    private static void LoadProducstJson()
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

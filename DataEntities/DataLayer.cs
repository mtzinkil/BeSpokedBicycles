using System;
using System.IO;
using System.Collections.Generic;
namespace DataEntities
{
    public class DataLayer
    {
        public static void Main(string[] args)
        {
        }

        class Products
        {
            private string name { get; set; }
            private string manufacturer { get; set; }
            private string style { get; set; }
            private double purchase_price { get; set; }
            private double sale_price { get; set; }
            private int quantity_on_hand { get; set; }
            private double commision_percentage { get; set; }

        }

        class Salesperson
        {
            private string f_name { get; set; }
            private string l_name { get; set; }
            private string address { get; set; }
            private string phone { get; set; }
            private string start_date { get; set; }
            private string termination_date { get; set; }
            private string Manager { get; set; }
        }

        class Customer
        {
            private string f_name { get; set; }
            private string l_name { get; set; }
            private string address { get; set; }
            private string phone { get; set; }
            private string start_date { get; set; }
        }

        class Sales
        {
            private string product { get; set; }
            private string salesperson { get; set; }
            private string customer { get; set; }
            private string sales_date { get; set; }
        }

        class Discount
        {
            private string product { get; set; }
            private string begin_date { get; set; }
            private string end_date { get; set; }
            private double discount_percentage { get; set; }
        }

        /* Below are the functions to load in the json files that may have 
         *pre-existing Entities through Json files */
        private static void LoadProducstJson()
        {
            using (StreamReader r = new StreamReader("file.json"))
            {
                string json = r.ReadToEnd();
                List<Products> products = JsonConvert.DeserializeObject<List<Products>>(json);
            }
        }

        private static void LoadSalesPersonJson()
        {
            using (StreamReader r = new StreamReader("file.json"))
            {
                string json = r.ReadToEnd();
                List<Salesperson> salespeople = JsonConvert.DeserializeObject<List<Salesperson>>(json);
             }

        }

        private static void LoadSCustomerJson()
        {
            using (StreamReader r = new StreamReader("file.json"))
            {
                string json = r.ReadToEnd();
                List<Customer> customer = JsonConvert.DeserializeObject<List<Customer>>(json);
            }

        }

        private static void LoadSalesJson()
        {
            using (StreamReader r = new StreamReader("file.json"))
            {
                string json = r.ReadToEnd();
                List<Sales> sales = JsonConvert.DeserializeObject<List<Sales>>(json);
            }

        }
        private static void LoadDiscountJson()
        {
            using (StreamReader r = new StreamReader("file.json"))
            {
                string json = r.ReadToEnd();
                List<Discount> discount = JsonConvert.DeserializeObject<List<Discount>>(json);
            }

        }

        /* Here are functions to add any entity that may need to be added*/
        private static void AddProduct()
        {
            
        }
    }
}
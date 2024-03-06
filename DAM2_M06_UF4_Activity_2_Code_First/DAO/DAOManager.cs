using CsvHelper;
using DAM2_M06_UF4_Activity_2_Code_First.MODEL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAM2_M06_UF4_Activity_2_Code_First.DAO
{
    public class DAOManager : IDAOManager
    {
        // TODO
        ClassicModelDbContext dbContext = null;
        public DAOManager(ClassicModelDbContext context)
        {
            dbContext = context;
        }
        public void LoadDatabase() // Recordatorio que esto petará si no está vacía (duplicado de registros) 
        {
            LoadProductLines();
            LoadProducts();
        }
        private void LoadProductLines()
        {

            // "productLine","textDescription","htmlDescription","image"
            CultureInfo culture = CultureInfo.InvariantCulture;
            using (var reader = new StreamReader("PRODUCTLINES.csv"))
            using (var csv = new CsvReader(reader, culture))
            {
                csv.Read(); //Saltem la primera linia
                while (csv.Read())
                {
                    var productLine = csv.GetField(0);
                    var textDescription = csv.GetField(1);
                    var htmlDescription = csv.GetField(2);
                    var image = csv.GetField(3);

                    ProductLine p = new ProductLine();
                    p.ProductLineCode = productLine;
                    p.TextDescription = textDescription;
                    p.HtmlDescription = htmlDescription;
                    if (image != null) p.Image = Encoding.UTF8.GetBytes(image);
                    AddProductLine(p);
                }
            }
            
        }
        private void AddProductLine(ProductLine p)
        {
           dbContext.ProductLines.Add(p);
           dbContext.SaveChanges();
        }

        private void LoadProducts() {
            // "productCode","productName","productLine","productScale","productVendor","productDescription","quantityInStock","buyPrice","MSRP"
            CultureInfo culture = CultureInfo.InvariantCulture;
            using (var reader = new StreamReader("PRODUCTS.csv"))
            using (var csv = new CsvReader(reader, culture))
            {
                csv.Read();
                while (csv.Read())
                {
                    var productCode = csv.GetField(0);
                    var productName = csv.GetField(1);
                    var productLine = csv.GetField(2);
                    var productScale = csv.GetField(3);
                    var productVendor = csv.GetField(4);
                    var productDescription = csv.GetField(5);
                    var quantityInStock = csv.GetField(6);
                    var buyPrice = csv.GetField(7);
                    var MSRP = csv.GetField(8);

                    int qty = Convert.ToInt32(quantityInStock);
                    decimal price = Convert.ToDecimal(buyPrice);
                    decimal msrp = Convert.ToDecimal(MSRP);


                    Product p = new Product();
                    p.ProductCode = productCode;
                    p.ProductName = productName;
                    p.ProductLine = productLine;
                    p.ProductScale = productScale;
                    p.ProductVendor = productVendor;
                    p.ProductDescription = productDescription;
                    p.QuantityInStock = qty;
                    p.BuyPrice = price;
                    p.MSRP = msrp;

                    AddProduct(p);
                }
            }
        }
        private void AddProduct(Product p){
            dbContext.Products.Add(p);
            dbContext.SaveChanges();
        }

        private void LoadOffices() { }
        private void AddOffice(Office o) { }

        private void LoadEmployees() { }
        private void AddEmployee(Employee e) { }
        private void LoadCustomers() { }
        private void AddCustomer(Customer c) { }
        private void LoadPayments() { }
        private void AddPayment(Payment p) { }

        private void LoadOrders() { }
        private void AddOrder(Order p) { }


    }
}

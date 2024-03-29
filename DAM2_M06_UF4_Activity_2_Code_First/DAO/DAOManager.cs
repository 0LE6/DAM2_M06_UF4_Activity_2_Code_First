﻿using CsvHelper;
using DAM2_M06_UF4_Activity_2_Code_First.MODEL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
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
        public void LoadDatabase() 
        {
            LoadProductLines();
            LoadProducts();
            LoadOffices();
            LoadEmployees();
            LoadCustomers();
            LoadPayments();
            LoadOrders();
            LoadOrderDetails();
        
        }

        #region LoadSpam
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
            var existingProductLine = dbContext.ProductLines.Find(p.ProductLineCode);
            if (existingProductLine == null) 
            {
                dbContext.ProductLines.Add(p);
                dbContext.SaveChanges();
            }
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
            var existingProduct = dbContext.Products.Find(p.ProductCode);
            if (existingProduct == null)
            {
                dbContext.Products.Add(p);
                dbContext.SaveChanges();
            }

        }

        private void LoadOffices()
        {
            // "officeCode","city","phone","addressLine1","addressLine2","state","country","postalCode","territory"
            CultureInfo culture = CultureInfo.InvariantCulture;
            using (var reader = new StreamReader("OFFICES.csv"))
            using (var csv = new CsvReader(reader, culture))
            {
                csv.Read(); // skip first line
                while (csv.Read())
                {
                    var officeCode = csv.GetField(0);
                    var city = csv.GetField(1);
                    var phone = csv.GetField(2);
                    var addressLine1 = csv.GetField(3);
                    var addressLine2 = csv.GetField(4);
                    var state = csv.GetField(5);
                    var country = csv.GetField(6);
                    var postalCode = csv.GetField(7);
                    var territory = csv.GetField(8);

                    Office o = new Office();
                    o.OfficeCode = officeCode;
                    o.City = city;
                    o.Phone = phone;
                    o.AddressLine1 = addressLine1;
                    o.AddressLine2 = addressLine2;
                    o.State = state;
                    o.Country = country;
                    o.PostalCode = postalCode;
                    o.Territory = territory;

                    AddOffice(o);


                }
            }
        }
        private void AddOffice(Office o) 
        {
            var existingOffice = dbContext.Offices.Find(o.OfficeCode);
            if (existingOffice == null)
            {
                dbContext.Offices.Add(o);
                dbContext.SaveChanges();
            }

        }

        private void LoadEmployees()
        {

            // "employeeNumber","lastName","firstName","extension","email","officeCode","reportsTo","jobTitle"
            CultureInfo culture = CultureInfo.InvariantCulture;
            using (var reader = new StreamReader("EMPLOYEES.csv"))
            using (var csv = new CsvReader(reader, culture))
            {
                csv.Read();
                while (csv.Read())
                {
                    var employeeNumber = csv.GetField(0);
                    var lastName = csv.GetField(1);
                    var firstName = csv.GetField(2);
                    var extension = csv.GetField(3);
                    var email = csv.GetField(4);
                    var officeCode = csv.GetField(5);
                    var reportsTo = csv.GetField(6);
                    var jobTitle = csv.GetField(7);

                    Employee e = new Employee();
                    e.EmployeeNumber = Convert.ToInt32(employeeNumber);
                    e.LastName = lastName;
                    e.FirstName = firstName;
                    e.Extension = extension;
                    e.Email = email;
                    e.OfficeCode = officeCode;
                    if (reportsTo == "NULL") e.ReportsTo = null;
                    else e.ReportsTo = Convert.ToInt32(reportsTo);

                    e.JobTitle = jobTitle;

                    AddEmployee(e);


                }
            }
        }
        private void AddEmployee(Employee e)
        {
            var employee = dbContext.Employees.Find(e.EmployeeNumber);
            if (employee == null)
            {
                dbContext.Employees.Add(e);
                dbContext.SaveChanges();
            }

        }
        private void LoadCustomers()
        {
            // "customerNumber","customerName","contactLastName","contactFirstName","phone","addressLine1","addressLine2",
            // "city","state","postalCode","country","salesRepEmployeeNumber","creditLimit"
            CultureInfo culture = CultureInfo.InvariantCulture;
            using (var reader = new StreamReader("CUSTOMERS.csv"))
            using (var csv = new CsvReader(reader, culture))
            {
                csv.Read();
                while (csv.Read())
                {
                    var customerNumber = csv.GetField(0);
                    var customerName = csv.GetField(1);
                    var contactLastName = csv.GetField(2);
                    var contactFirstName = csv.GetField(3);
                    var phone = csv.GetField(4);
                    var addressLine1 = csv.GetField(5);
                    var addressLine2 = csv.GetField(6);
                    var city = csv.GetField(7);
                    var state = csv.GetField(8);
                    var postalCode = csv.GetField(9);
                    var country = csv.GetField(10);
                    var salesRepEmployeeNumber = csv.GetField(11);
                    var creditLimit = csv.GetField(12);


                    Customer c = new Customer();
                    c.CustomerNumber = Convert.ToInt32(customerNumber);
                    c.CustomerName = customerName;
                    c.ContactLastName = contactLastName;
                    c.ContactFirstName = contactFirstName;
                    c.Phone = phone;
                    c.AddressLine1 = addressLine1;
                    c.AddressLine2 = addressLine2;
                    c.City = city;
                    c.State = state;
                    c.PostalCode = postalCode;
                    c.Country = country;
                    if (salesRepEmployeeNumber == "NULL") c.SalesRepEmployeeNumber = null;
                    else c.SalesRepEmployeeNumber = Convert.ToInt32(salesRepEmployeeNumber);
                    c.CreditLimit = Convert.ToDecimal(creditLimit);

                    AddCustomer(c);



                }
            }
        }
        private void AddCustomer(Customer c)
        {
            var customer = dbContext.Customers.Find(c.CustomerNumber);
            if (customer == null)
            {
                dbContext.Customers.Add(c);
                dbContext.SaveChanges();
            }

        }
        private void LoadPayments()
        {
            // "customerNumber","checkNumber","paymentDate","amount"
            CultureInfo culture = CultureInfo.InvariantCulture;
            using (var reader = new StreamReader("PAYMENTS.csv"))
            using (var csv = new CsvReader(reader, culture))
            {
                csv.Read();
                while (csv.Read())
                {
                    var customerNumber = csv.GetField(0);
                    var checkNumber = csv.GetField(1);
                    var paymentDate = csv.GetField(2);
                    var amount = csv.GetField(3);

                    Payment p = new Payment();
                    p.CustomerNumber = Convert.ToInt32(customerNumber);
                    p.CheckNumber = checkNumber;
                    p.PaymentDate = Convert.ToDateTime(paymentDate);
                    p.Amount = Convert.ToDecimal(amount);

                    AddPayment(p);
                }
            }
        }
        private void AddPayment(Payment p) 
        {
            var payment = dbContext.Payments.Find(p.CustomerNumber, p.CheckNumber);
            if (payment == null)
            {
                dbContext.Payments.Add(p);
                dbContext.SaveChanges();
            }

        }

        private void LoadOrders()
        {
            // "orderNumber","orderDate","requiredDate","shippedDate","status","comments","customerNumber"
            CultureInfo culture = CultureInfo.InvariantCulture;
            using (var reader = new StreamReader("ORDERS.csv"))
            using (var csv = new CsvReader(reader, culture))
            {
                csv.Read();
                while (csv.Read())
                {
                    var orderNumber = csv.GetField(0);
                    var orderDate = csv.GetField(1);
                    var requiredDate = csv.GetField(2);
                    var shippedDate = csv.GetField(3);
                    var status = csv.GetField(4);
                    var comments = csv.GetField(5);
                    var customerNumber = csv.GetField(6);

                    Order o = new Order();
                    o.OrderNumber = Convert.ToInt32(orderNumber);
                    o.OrderDate = Convert.ToDateTime(orderDate);
                    o.RequiredDate = Convert.ToDateTime(requiredDate);
                    if (shippedDate == "NULL") o.ShippedDate = null;
                    else o.ShippedDate = Convert.ToDateTime(shippedDate);
                    o.Status = status;
                    o.Comments = comments;
                    o.CustomerNumber = Convert.ToInt32(customerNumber);

                    AddOrder(o);

                }
            }
        }
        private void AddOrder(Order o)
        {
            var order = dbContext.Orders.Find(o.OrderNumber);
            if (order == null)
            {
                dbContext.Orders.Add(o);
                dbContext.SaveChanges();
            }

        }


        private void LoadOrderDetails()
        {
            // "orderNumber","productCode","quantityOrdered","priceEach","orderLineNumber"
            CultureInfo culture = CultureInfo.InvariantCulture;
            using (var reader = new StreamReader("ORDERDETAILS.csv"))
            using (var csv = new CsvReader(reader, culture))
            {
                csv.Read();
                while (csv.Read())
                {
                    var orderNumber = csv.GetField(0);
                    var productCode = csv.GetField(1);
                    var quantityOrdered = csv.GetField(2);
                    var priceEach = csv.GetField(3);
                    var orderLineNumber = csv.GetField(4);

                    OrderDetail od = new OrderDetail();
                    od.OrderNumber = Convert.ToInt32(orderNumber);
                    od.ProductCode = productCode;
                    od.QuantityOrdered = Convert.ToInt32(quantityOrdered);
                    od.PriceEach = Convert.ToDecimal(priceEach);
                    od.OrderLineNumber = Convert.ToInt32(orderLineNumber);

                    AddOrderDetail(od);
                }
            }
        }

        private void AddOrderDetail(OrderDetail od)
        {
            var orderDetail = dbContext.OrderDetails.Find(od.OrderNumber, od.ProductCode);
            if (orderDetail == null)
            {
                dbContext.OrderDetails.Add(od);
                dbContext.SaveChanges();
            }

        }
        #endregion

        #region LAS 12 QUERIES DE HERCULES
        //primera mitad
        public List<EmployeeOfficeInfo> Query1MostrarEmpleadosYSusOficinas()
        {
            var employeesAndOffices = dbContext.Employees
                .Join(dbContext.Offices,
                      employee => employee.OfficeCode,
                      office => office.OfficeCode,
                      (employee, office) => new EmployeeOfficeInfo
                      {
                          EmployeeNumber = employee.EmployeeNumber,
                          EmployeeName = employee.FirstName + " " + employee.LastName,
                          OfficeCity = office.City,
                          OfficeCountry = office.Country
                      })
                .ToList();

            return employeesAndOffices;
        }


        //segunda mitad

        public List<Employee> GetEmployees()
        {
            return dbContext.Employees.ToList();
        }
        public List<ProductLine> GetProductLines()
        {
            return dbContext.ProductLines.ToList();
        }
        public List<Employee> GetEmployeesByOfficeCode(string code)
        {
            return dbContext.Employees.Where(x => x.OfficeCode == code).ToList();
        }
        public List<Employee> GetEmployeesOrderedByOffice()
        {
            return dbContext.Employees.OrderBy(x => x.OfficeCode).ToList();

        }

        public List<Product> GetProductsOrderedByPrice()
        {
            return dbContext.Products.OrderBy(x => x.BuyPrice).ToList();

        }

        public List<Product> GetProductsOrdredByProfitMargin()
        {
            return dbContext.Products.OrderByDescending(o => o.MSRP - o.BuyPrice).ToList();
        }

        public string GetOfficeCityFromEmployeeCode(int empCode)
        {
            var city = dbContext.Employees
                    .Join(dbContext.Offices,
                    e => e.OfficeCode,
                    o => o.OfficeCode,
                    (e, o) => new { e.EmployeeNumber, o.City })
                    .Where(x => x.EmployeeNumber == empCode)
                    .Select(x => x.City)
                    .FirstOrDefault();

            return city;
        }

        public decimal SalesAmountByEmpCode(int empCode)
        {
            var totalAmount = dbContext.Payments
                .Join(dbContext.Customers,
                p => p.CustomerNumber,
                c => c.CustomerNumber,
                (p, c) => new {p.Amount, c.SalesRepEmployeeNumber})
                .Where(x => x.SalesRepEmployeeNumber == empCode)
                .Sum(x => x.Amount);
            return totalAmount;
        }

        public decimal SalesByProduct(string productCode)
        {
            var totalSalesPerProduct = dbContext.OrderDetails
                .Where(od => od.ProductCode == productCode)
                .GroupBy(od => od.ProductCode)
                .Select(group => new
                {
                    ProductCode = group.Key,
                    TotalSales = group.Sum(od => od.QuantityOrdered * od.PriceEach)
                })
                .FirstOrDefault()?.TotalSales ?? 0;

            return totalSalesPerProduct;
        }

        public List<Product> GetAllProducts()
        {
            return dbContext.Products.ToList();
        }

        public List<Payment> GetPaymentsByCustomerNumber(int customerNumber)
        {
            return dbContext.Payments.Where(x => x.CustomerNumber == customerNumber).ToList();
        }
        //Intent raro:

        public object SalesByProduct2(string productCode)
        {
            var totalSalesPerProduct = dbContext.OrderDetails
            .Where(od => od.ProductCode == productCode)
            .GroupBy(od => od.ProductCode)
            .Select(group => new
            {
                ProductCode = group.Key,
                TotalSales = group.Sum(od => od.QuantityOrdered * od.PriceEach)
            })
            .FirstOrDefault();

            return totalSalesPerProduct;
        }

        public List<Office> GetOffices()
        {
            return dbContext.Offices
                            .OrderByDescending(o => o.OfficeCode)
                            .ToList();
        }

        public List<MostSoldProductByOffice> GetMostSoldProductsByOffice()
        {
            // obtenemos todos los datos necesarios de la base de datos
            var salesData = dbContext.OrderDetails
                .Include(od => od.Order).ThenInclude(o => o.Customer).ThenInclude(c => c.SalesRep).ThenInclude(e => e.Office)
                .Include(od => od.Product)
                .Select(od => new
                {
                    OfficeCode = od.Order.Customer.SalesRep.Office.OfficeCode,
                    OfficeName = od.Order.Customer.SalesRep.Office.City, // Asumiendo que el nombre es la ciudad
                    OfficeCountry = od.Order.Customer.SalesRep.Office.Country,
                    ProductName = od.Product.ProductName,
                    od.QuantityOrdered,
                    TotalSales = od.QuantityOrdered * od.PriceEach
                })
                .AsEnumerable(); // traemos los datos a la memoria para procesar la siguiente parte

            // realizamos la agrupación y selección del producto más vendido por oficina en memoria
            var mostSoldProductsByOffice = salesData
                .GroupBy(sd => new { sd.OfficeCode, sd.ProductName })
                .Select(g => new
                {
                    g.Key.OfficeCode,
                    OfficeName = g.First().OfficeName, // usamos First() para obtener el nombre y país
                    OfficeCountry = g.First().OfficeCountry,
                    g.Key.ProductName,
                    TotalQuantity = g.Sum(x => x.QuantityOrdered),
                    TotalSales = g.Sum(x => x.TotalSales)
                })
                .GroupBy(x => x.OfficeCode)
                .Select(g => g.OrderByDescending(x => x.TotalSales).FirstOrDefault())
                .Where(x => x != null)
                .Select(x => new MostSoldProductByOffice
                {
                    OfficeCode = x.OfficeCode,
                    OfficeName = x.OfficeName,
                    OfficeCountry = x.OfficeCountry,
                    ProductName = x.ProductName,
                    TotalQuantity = x.TotalQuantity,
                    TotalSales = Math.Round(x.TotalSales, 2)
                })
                .ToList();

            return mostSoldProductsByOffice;
        }

        /*  lista de clientes junto al total de sus pagos, 
 
filtrando por aquellos clientes que hayan realizado pagos por encima de un cierto umbral 
y ordenando los resultados por el nombre del cliente.*/
        public List<CustomerPaymentInfo> GetCustomersWithTotalPaymentsAbove(decimal minimumPayment)
        {
            return dbContext.Customers
                .Where(c => c.Payments.Sum(p => p.Amount) > minimumPayment)
                .Select(c => new CustomerPaymentInfo
                {
                    CustomerNumber = c.CustomerNumber,
                    CustomerName = c.CustomerName,
                    TotalPayments = c.Payments.Sum(p => p.Amount)
                })
                .Where(cpi => cpi.TotalPayments > minimumPayment)
                .OrderByDescending(cpi => cpi.TotalPayments)
                .ToList();
        }

        #endregion


    }

    // Auxilar code
    public class CustomerPaymentInfo
    {
        public int CustomerNumber { get; set; }
        public string CustomerName { get; set; }
        public decimal TotalPayments { get; set; }
    }
    public class MostSoldProductByOffice
    {
        public string OfficeCode { get; set; }
        public string OfficeName { get; set; } 
        public string OfficeCountry { get; set; } 
        public string ProductName { get; set; }
        public int TotalQuantity { get; set; }
        public decimal TotalSales { get; set; }
    }

    public class EmployeeOfficeInfo
    {
        public int EmployeeNumber { get; set; }
        public string EmployeeName { get; set; }
        public string OfficeCity { get; set; }
        public string OfficeCountry { get; set; }
    }

    public class EmployeeSales
    {
        public Employee Employee { get; set; }
        public decimal Sales { get; set; }
    }




}

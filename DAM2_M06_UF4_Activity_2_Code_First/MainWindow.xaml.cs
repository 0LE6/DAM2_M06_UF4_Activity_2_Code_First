using DAM2_M06_UF4_Activity_2_Code_First.DAO;
using DAM2_M06_UF4_Activity_2_Code_First.MODEL;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DAM2_M06_UF4_Activity_2_Code_First
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ClassicModelDbContext myContext = new ClassicModelDbContext();
            DAOManager manager = new DAOManager(myContext);

            //manager.LoadDatabase();

            #region Testing Queries
            Console.WriteLine("Hola, edu! :D");

            //manager.Query1MostrarEmpleadosYSusOficinas();

            //Separació
            Console.WriteLine("Queries 2:");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("GetEmployees:");
            List<Employee> totsElsEmployees = manager.GetEmployees();
            foreach (Employee e in totsElsEmployees)
            {
                Console.WriteLine($"{e.EmployeeNumber} - {e.FirstName} {e.LastName} -- Office: {e.OfficeCode}");
            }
            Console.WriteLine("---------------------------------------------------");

            Console.WriteLine("Employees from office code 1: ");
            List<Employee> empsFromOfficeOne = manager.GetEmployeesByOfficeCode("1");
            foreach (Employee e in empsFromOfficeOne)
            {
                Console.WriteLine($"{e.EmployeeNumber} - {e.FirstName} {e.LastName} -- Office: {e.OfficeCode}");
            }
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Get Employees Ordered by office code");

            List<Employee> empsOrderedByOffice = manager.GetEmployeesOrderedByOffice();
            foreach (Employee e in empsOrderedByOffice)
            {
                Console.WriteLine($"{e.EmployeeNumber} - {e.FirstName} {e.LastName} -- Office: {e.OfficeCode}");
            }

            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Get Products Ordered by price");

            List<Product> productsOrderedByPrice = manager.GetProductsOrderedByPrice();
            foreach (Product p in productsOrderedByPrice)
            {
                Console.WriteLine($"{p.ProductCode} - {p.ProductName} -- Price: {p.BuyPrice}");
            }
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Get Products Ordered by Profit Margin");
            List<Product> productsOrderedByProfitMargin = manager.GetProductsOrdredByProfitMargin();
            foreach (Product p in productsOrderedByProfitMargin)
            {
                Console.WriteLine($"{p.ProductCode} - {p.ProductName} -- Price: {p.BuyPrice} -- Profit: {p.MSRP - p.BuyPrice}");
            }

            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Get Office City from employee code");

            string city = manager.GetOfficeCityFromEmployeeCode(1002);
            Console.WriteLine(city);

            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Get Amount By Emp Code");
            decimal salesSumByEmpCode = manager.SalesAmountByEmpCode(1165);
            Console.WriteLine(salesSumByEmpCode);

            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Get Amount From Every Employee");
            foreach (Employee e in totsElsEmployees)
            {
                decimal gains = manager.SalesAmountByEmpCode(e.EmployeeNumber);
                Console.WriteLine($"{e.FirstName} {e.LastName}: ${gains}");
            }

            // Recent sortides del forn

            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Recent sortides del forn: ");
            Console.WriteLine("Quantitat guanyada per cada producte");

            List<Product> productes = manager.GetAllProducts();
            foreach (Product p in productes)
            {
                decimal guanys = manager.SalesByProduct(p.ProductCode);
                Console.WriteLine($"Product: {p.ProductCode} '{p.ProductName}': {guanys} ");
            }

            #endregion

            //Alguna query per la interfície gràfica:

            //Query: Employees
            List<Employee> employees = manager.GetEmployees();
            dgEmployees.ItemsSource = employees;

            //Query2: Offices ordered
            List<Office> offices = manager.GetOffices();
            dgOficines.ItemsSource = offices;

            //Query3: Employees de la oficina 1
            List<Employee> employeesOffice1 = manager.GetEmployeesByOfficeCode("1");
            dgEmployeesByOffice.ItemsSource = employeesOffice1;

            //Query4: Products by margin
            List<Product> productsByMargin = manager.GetProductsOrdredByProfitMargin();
            dgProducts.ItemsSource = productsByMargin;

            //Query5: Combo Employee + Info de la seva oficina
            List<EmployeeOfficeInfo> employeeOfficeInfos = manager.Query1MostrarEmpleadosYSusOficinas();
            dgEmployeeOffices.ItemsSource = employeeOfficeInfos;

            //Query 6: Most sold products by office
            List<MostSoldProductByOffice> mostSoldProductByOffices = manager.GetMostSoldProductsByOffice();
            dgMostSoldProducts.ItemsSource = mostSoldProductByOffices;

            //Query 7: Product Lines
            List<ProductLine> productLines = manager.GetProductLines();
            dgProductLines.ItemsSource = productLines;

            //Query 8: Navigation among entities --> Fent una llista ordenada per product lines
            List<Product> productesOrdenatsPerProductLines = new List<Product>();
            foreach (ProductLine pL in productLines)
            {
                foreach (Product p in pL.Products)
                {
                    productesOrdenatsPerProductLines.Add(p);
                }
            }

            dgProductesPerProductLine.ItemsSource = productesOrdenatsPerProductLines;

            //Query 9: Employees que més han venut però a través de Navigation
            Dictionary<Employee, decimal> kvpEmployeesVendes = new Dictionary<Employee, decimal>();
            foreach (Employee e in employees)
            {
                decimal sumaVentes = 0;
                foreach (Customer c in e.Customers)
                {
                    List<Payment> payments = manager.GetPaymentsByCustomerNumber(c.CustomerNumber);
                    foreach (Payment payment in payments)
                    {
                        sumaVentes += payment.Amount;
                    }

                }
                kvpEmployeesVendes.Add(e, sumaVentes);
            }
            List<EmployeeSales> employeeSalesList = kvpEmployeesVendes.ToList().Select(x => new EmployeeSales { Employee = x.Key, Sales = x.Value }).ToList();





            //Query 10: 


            //Query 11:

            List<CustomerPaymentInfo> cpi = manager.GetCustomersWithTotalPaymentsAbove((decimal)100.0);
            dgCustomersWithTotalPaymentsAbove.ItemsSource = cpi;



        }
    }
}
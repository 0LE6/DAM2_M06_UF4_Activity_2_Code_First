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








        }
    }
}
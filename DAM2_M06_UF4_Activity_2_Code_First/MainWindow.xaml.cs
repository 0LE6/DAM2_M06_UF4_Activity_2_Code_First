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

            manager.LoadDatabase();
            
        }
    }
}
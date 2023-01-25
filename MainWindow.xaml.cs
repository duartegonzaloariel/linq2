using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;

namespace LINQ2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Atributos
        DataClasses1DataContext dataContext;
        //Agregar un elemento en el proyecto(agregar elemento en nombre proyecto) de tipo Clases de LINQ to SQL
        
        //Metodo principal
        public MainWindow()
        {
            InitializeComponent();
            string miConexion = ConfigurationManager.ConnectionStrings["LINQ2.Properties.Setting.CrudLinqSql"].ConnectionString;
            dataContext = new DataClasses1DataContext(miConexion);
        }
        

    }
}
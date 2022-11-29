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

namespace ClassesExampleExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            LibraryDataClassesDataContext dtx = new LibraryDataClassesDataContext();

            //var result=(from b in dtx.Books
            //           where b.Pages>500
            //           select b);

            //mydatagrid.ItemsSource = result;

            //var result = dtx.
            //             Books.
            //             Where(b => b.Pages > 500);


            //var result = from b in dtx.Books
            //             where b.Pages >=(dtx.Books.Max(i=>i.Pages))
            //             select new { Name = b.Name, Page = b.Pages };

            //var result = from b in dtx.Books
            //             where b.Pages > 500
            //             select new BookNameDto{ Name= b.Name, Page= b.Pages};

           // mydatagrid.ItemsSource = result;

        }
    }
}

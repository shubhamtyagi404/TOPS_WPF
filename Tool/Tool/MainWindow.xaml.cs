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
using Tool.Business;
using System.Data;

namespace Tool
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TradeData trade = new TradeData();
        Serialize json = new Serialize();
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            DataTable data = new DataTable();
            data=trade.GetTrade(Convert.ToInt32(this.textBox.Text));
            this.dataGrid.DataContext = data.DefaultView;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.textBlock.Text = json.ConvertToJson(trade.GetTrade(Convert.ToInt32(this.textBox.Text)));
           
        }
    }
}

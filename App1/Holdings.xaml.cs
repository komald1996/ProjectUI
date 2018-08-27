using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace App1
{
    /// <summary>
    /// Interaction logic for Holdings.xaml
    /// </summary>
    public partial class Holdings : Page
    {
        public Holdings()
        {
            InitializeComponent();
        }
        DataTable dt;
        DataRow dr;
        private void table_load(object sender, RoutedEventArgs e)
        {
            dt = new DataTable("Holdings");
            DataColumn StockName = new DataColumn("Stock Name", typeof(String));
            DataColumn Quantity = new DataColumn("Quantity", typeof(int));
            DataColumn MarketPrice = new DataColumn("Market Price", typeof(double));
            DataColumn PL = new DataColumn("Profit/Loss", typeof(double));
            dt.Columns.Add(StockName);
            dt.Columns.Add(Quantity);
            dt.Columns.Add(MarketPrice);
            dt.Columns.Add(PL);
            dtgridHoldings.ItemsSource = dt.DefaultView;

        }


        private void btn_Click(object sender, RoutedEventArgs e)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = "Data Source=GRAD27-HP; User ID=sa; Password=sa123; INITIAL CATALOG=project_db";
                connection.Open();
                string sql = "SELECT  FROM USER_INFO"; //CREATE A SQL COMMAND OBJECT
                SqlCommand myCommand = new SqlCommand(sql, connection);
                using (SqlDataReader myDataReader = myCommand.ExecuteReader())
                {
                    while (myDataReader.Read())
                    {
                        //Console.WriteLine($"->Code:{myDataReader["user_id"]}," + $"Name: {myDataReader["vFirstname"]}.");
                        dr = dt.NewRow();
                        dr[0] = myDataReader[""];
                        dr[1] = myDataReader[""];
                        dr[2] = myDataReader[""];
                        dr[3] = myDataReader[""];
                        dt.Rows.Add(dr);
                        dtgridHoldings.ItemsSource = dt.DefaultView;
                    }
                }
            }
        }
    }
}

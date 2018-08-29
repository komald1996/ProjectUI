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
    /// Interaction logic for AdminOrderBook.xaml
    /// </summary>
    public partial class AdminOrderBook : Page
    {
        public AdminOrderBook()
        {
            InitializeComponent();
        }

        DataTable dt;
        DataRow dr;

        private void admin_order_load(object sender, RoutedEventArgs e)
        {
            dt = new DataTable("AOrderBook");
            DataColumn OrderId = new DataColumn("Order ID", typeof(long));
            DataColumn UserId = new DataColumn("User ID", typeof(long));
            DataColumn StockName = new DataColumn("Stock Name", typeof(String));            
            DataColumn OrderType = new DataColumn("Order Type", typeof(String));
            DataColumn Min_Fill = new DataColumn("Min Fill", typeof(DateTime));
            DataColumn IsMarket = new DataColumn("Is Market", typeof(DateTime));
            DataColumn Quantity = new DataColumn("Quantity", typeof(int));
            DataColumn Price = new DataColumn("Trade Price", typeof(double));
            DataColumn OrderTime = new DataColumn("Order Time", typeof(DateTime)); 
            DataColumn OrderStatus = new DataColumn("Order Status", typeof(String));
            DataColumn StopLoss = new DataColumn("Stop Loss", typeof(long));

          //  DataColumn PercentOrder = new DataColumn("% of Order Executed", typeof(double));

            dt.Columns.Add(UserId);
            dt.Columns.Add(OrderId);
            dt.Columns.Add(OrderType);
            dt.Columns.Add(StockName);
            dt.Columns.Add(Quantity);
            dt.Columns.Add(Price);
            dt.Columns.Add(OrderStatus);
            dt.Columns.Add(OrderTime);
            dt.Columns.Add(StopLoss);
            dt.Columns.Add(Min_Fill);
            dt.Columns.Add(IsMarket);
            dtgridPositions.ItemsSource = dt.DefaultView;

        }

        int qty = 0;
        int qty1 = 0;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = "Data Source=GRAD27-HP; User ID=sa; Password=sa123; INITIAL CATALOG=project_db";
                connection.Open();
                string sql = "SELECT *  FROM ORDER_TABLE "; //CREATE A SQL COMMAND OBJECT
                SqlCommand myCommand = new SqlCommand(sql, connection);
                using (SqlDataReader myDataReader = myCommand.ExecuteReader())
                {
                    while (myDataReader.Read())
                    {
                        //Console.WriteLine($"->Code:{myDataReader["user_id"]}," + $"Name: {myDataReader["vFirstname"]}.");
                        dr = dt.NewRow();
                        dr[0] = myDataReader["order_id"];
                        dr[1] = myDataReader["user_id"];
                        dr[2] = myDataReader["stock_name"];
                        dr[3] = myDataReader["order_type"];
                        dr[4] = myDataReader["min_fill"];
                        qty1 = Convert.ToInt32(myDataReader["quantity"]); 
                        dr[5] = myDataReader["isMarket"];
                        dr[6] = myDataReader["quantity"];
                        dr[7] = myDataReader["price"];
                        dr[8] = myDataReader["order_time"];
                        dr[9] = myDataReader["order_status"];
                        dr[10] = myDataReader["col_stop_loss"];

                        
                        dt.Rows.Add(dr);
                        dtgridPositions.ItemsSource = dt.DefaultView;
                    }
                }



            }
        }

        private void dtgridPositions_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}

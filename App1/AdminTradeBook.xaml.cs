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
    /// Interaction logic for AdminTradeBook.xaml
    /// </summary>
    public partial class AdminTradeBook : Page
    {
        public AdminTradeBook()
        {
            InitializeComponent();
        }

        DataTable dt;
        DataRow dr;

        private void admin_trade_load(object sender, RoutedEventArgs e)
        {
            dt = new DataTable("ATradeBook");
            DataColumn TradeId = new DataColumn("Trade ID", typeof(long));
            DataColumn BuyerOrderId = new DataColumn("Buyer Order ID", typeof(long));
            DataColumn SellerOrderId = new DataColumn("Seller Order ID", typeof(long));
            DataColumn BuyerId = new DataColumn("Buyer ID", typeof(long));
            DataColumn SellerId = new DataColumn("Seller ID", typeof(long));
            DataColumn Price = new DataColumn("Trade Price", typeof(double));
            DataColumn ExecutionTime = new DataColumn("Exec Time", typeof(DateTime));
            DataColumn Quantity = new DataColumn("Quantity", typeof(int));

            //  DataColumn PercentOrder = new DataColumn("% of Order Executed", typeof(double));

            dt.Columns.Add(TradeId);
            dt.Columns.Add(BuyerOrderId);
            dt.Columns.Add(SellerOrderId);
            dt.Columns.Add(BuyerId);
            dt.Columns.Add(SellerId);
            dt.Columns.Add(Price);
            dt.Columns.Add(ExecutionTime);
            dt.Columns.Add(Quantity);
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
                        dr[0] = myDataReader["trade_id"];
                        dr[1] = myDataReader["buyer_order_id"];
                        dr[2] = myDataReader["seller_order_id"];
                        dr[3] = myDataReader["buyer_id"];
                        dr[4] = myDataReader["seller_id"];
                        qty1 = Convert.ToInt32(myDataReader["quantity"]);
                        dr[5] = myDataReader["price"];
                        dr[6] = myDataReader["execution_time"];
                        dr[7] = myDataReader["quantity"];


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

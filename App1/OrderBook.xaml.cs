﻿using System;
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
    /// Interaction logic for OrderBook.xaml
    /// </summary>
    public partial class OrderBook : Page
    {
        public OrderBook()
        {
            InitializeComponent();
        }
        DataTable dt;
        DataRow dr;
        long user_id = 0;

        private void OrderBook_load(object sender, RoutedEventArgs e)
        {
            dt = new DataTable("OrderBook");
            DataColumn OrderTime = new DataColumn("Time of Order", typeof(DateTime));
            DataColumn OrderId = new DataColumn("Order ID", typeof(long));
            DataColumn OrderType = new DataColumn("Type of Order", typeof(String));
            DataColumn StockName = new DataColumn("Stock Name", typeof(String));
            DataColumn Quantity = new DataColumn("Quantity", typeof(int));
            DataColumn Price = new DataColumn("Trade Price", typeof(double));
            DataColumn OrderStatus = new DataColumn("Status of Order", typeof(String));
            DataColumn TransacId = new DataColumn("Transaction ID", typeof(long));

            dt.Columns.Add(OrderTime);
            dt.Columns.Add(OrderId);
            dt.Columns.Add(OrderType);
            dt.Columns.Add(StockName);
            dt.Columns.Add(Quantity);
            dt.Columns.Add(Price);
            dt.Columns.Add(OrderStatus);
            dt.Columns.Add(TransacId);

            dtgridOrderBook.ItemsSource = dt.DefaultView;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = "Data Source=GRAD27-HP; User ID=sa; Password=sa123; INITIAL CATALOG=project_db";
                connection.Open();
                string sql = "SELECT ORDER_TIME, ORDER_ID, ORDER_TYPE, STOCK_NAME, QUANTITY, PRICE, ORDER_STATUS  FROM ORDER_TABLE WHERE" + $"USER_ID={user_id}"; //CREATE A SQL COMMAND OBJECT
                SqlCommand myCommand = new SqlCommand(sql, connection);
                using (SqlDataReader myDataReader = myCommand.ExecuteReader())
                {
                    while (myDataReader.Read())
                    {
                        //Console.WriteLine($"->Code:{myDataReader["user_id"]}," + $"Name: {myDataReader["vFirstname"]}.");
                        dr = dt.NewRow();
                        dr[0] = myDataReader["ORDER_TIME"];
                        dr[1] = myDataReader["ORDER_ID"];
                        dr[2] = myDataReader["ORDER_TYPE"];
                        dr[3] = myDataReader["STOCK_NAME"];
                        dr[4] = myDataReader["QUANTITY"];
                        dr[5] = myDataReader["PRICE"];
                        dr[6] = myDataReader["ORDER_STATUS"];
                        string sql1 = "SELECT TRADE_ID FROM EXECUTED_TABLE WHERE" + $"ORDER_ID={dr[1]}";
                        SqlCommand mycommand1 = new SqlCommand(sql1, connection);
                        using (SqlDataReader myDataReader1 = mycommand1.ExecuteReader())
                        {
                            while (myDataReader1.Read())
                            {
                                dr[7] = myDataReader["TRADE_ID"];
                            }
                        }


                        dt.Rows.Add(dr);
                        dtgridOrderBook.ItemsSource = dt.DefaultView;
                    }
                }
            }
        }

       
    }
}

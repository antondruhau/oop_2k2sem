﻿using System;
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
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data.Odbc;
using System.Configuration;

namespace lab10
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        string connectionString;
        SqlDataAdapter adapter;
        DataTable dataTable;
        public MainWindow()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["connectionDB"].ConnectionString;
        }

        private void win_Loaded(object sender, RoutedEventArgs e)
        {
            string sql = "select * from flat f inner join address a on f.address = a.address";
            dataTable = new DataTable();
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(sql, connection);
                adapter = new SqlDataAdapter(command);
                connection.Open();
                adapter.Fill(dataTable);
                flatGrid.ItemsSource = dataTable.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }

        }

        private void Update(object sender, RoutedEventArgs e)
        {
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
            adapter.Update(dataTable);
        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            if (flatGrid.SelectedItems != null)
            {
                for (int i = 0; i < flatGrid.SelectedItems.Count; i++)
                {
                    DataRowView datarowView = flatGrid.SelectedItems[i] as DataRowView;
                    if (datarowView != null)
                    {
                        DataRow dataRow = (DataRow)datarowView.Row;
                        dataRow.Delete();
                    }
                }
            }
            Update(sender,e);
        }
    }
}
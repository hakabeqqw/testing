﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using training.Classes;

namespace training
{
    public partial class Clients : Form
    {
        public Clients()
        {
            InitializeComponent();
        }

        private void Clients_Load(object sender, EventArgs e)
        {
            String SQL = "Select `customers`.`name_customer`, `customers`.`phone_customer`," +
            " `orders`.`name_order` From customers inner join orders on" +
            " `customers`.`id_customer`=`orders`.`customers_id_customer`";
            DataTable DataTable = DataBaseConnection.ExecuteDataQuery(SQL);
            CustomersDataGridView.DataSource = DataTable;
        }
    }
}

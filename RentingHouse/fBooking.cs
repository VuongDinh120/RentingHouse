﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

//Phải khai báo 2 cái này mới sử dụng đc DAO, DTO
using RentingHouse.DAO;
using RentingHouse.DTO;

namespace RentingHouse
{
    public partial class fBooking : Form
    {
        private int loginUser;

        public int LoginUser
        {
            get { return loginUser; }
            set { loginUser = value; }
        }

        public fBooking(int loginUser)
        {
            InitializeComponent();
            LoginUser = loginUser;
            dgvBooking.AutoGenerateColumns = false;
        }


        private void fBooking_Load(object sender, EventArgs e)
        {
            dgvBooking.DataSource = BookingDAO.Instance.GetBookingByUserId(LoginUser);
        }

        private void dgvBooking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                int bid = (int)dgvBooking.Rows[e.RowIndex].Cells[0].Value;
                new fBookingDetail(bid, LoginUser).Show();
            }
        }
    }
}

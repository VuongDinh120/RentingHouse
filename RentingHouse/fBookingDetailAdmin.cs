﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentingHouse
{
    public partial class fBookingDetailAdmin : Form
    {
        private int bookingId;

        public int BookingId
        {
            get { return bookingId; }
            set { bookingId = value; }
        }

        public fBookingDetailAdmin(int id)
        {
            InitializeComponent();
            BookingId = id;
        }
    }
}

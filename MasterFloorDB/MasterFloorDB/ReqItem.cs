using MasterFloorDB.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterFloorDB
{
    public partial class ReqItem : UserControl
    {
        public event EventHandler<Items> passItem;
        Items item;
        public ReqItem(int id, Types type, string lab2, string lab3, string lab4, string lab6)
        {
            InitializeComponent();

            label1.Text = type.Name;
            label2.Text = lab2;
            label3.Text = lab3;
            label4.Text = lab4;
            label6.Text = lab6;

            item = new Items()
            {
                Id = id,
                Type = type,
                Name = lab2,
                Director = lab3,
                Phone = lab4,
                Rating = int.Parse(lab6)
            };
        }

        private void ReqItem_Load(object sender, EventArgs e)
        {

        }

        private void ReqItem_Click(object sender, EventArgs e)
        {
            passItem?.Invoke(this, item);

            this.BorderStyle = BorderStyle.FixedSingle;
        }

        private void ReqItem_Leave(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.Fixed3D;
        }
    }
}

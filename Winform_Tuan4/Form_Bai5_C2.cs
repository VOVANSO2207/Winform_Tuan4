using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_Tuan4
{
    public partial class frm_Bai5_C2 : Form
    {
        public frm_Bai5_C2()
        {
            InitializeComponent();
        }

        private void btnAddName_Click(object sender, EventArgs e)
        {
            ListViewItem items = new ListViewItem();
            items.Text=txtLastname.Text;
            items.ImageIndex = 1;
            items.SubItems.Add(txtFirstName.Text);
            items.SubItems.Add(txtPhone.Text);
            lvThongTin.Items.Add(items);
        }
    }
}

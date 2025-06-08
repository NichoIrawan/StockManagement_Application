using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementViews.Views
{
    public partial class AddUserPopup : Form
    {
        String[] comboBoxOption = { "Staff", "Manager" };
        public AddUserPopup()
        {
            InitializeComponent();
        }

        private void AddUserPopup_Load(object sender, EventArgs e)
        {
            comboBoxRole.DataSource = comboBoxOption;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

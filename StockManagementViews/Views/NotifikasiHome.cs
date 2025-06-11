using StockManagement.Controller;
using StockManagement.Models;
using System.Text.Json;

namespace StockManagementViews
{
    public partial class NotifikasiHome : Form
    {
        private NotifikasiController _controller = new NotifikasiController();
        public NotifikasiHome()
        {
            InitializeComponent();
            this.Load += Notifikasi_Load;
        }

        private async void Notifikasi_Load(object sender, EventArgs e)
        {
            try
            {
                RefreshList();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private async void RefreshList()
        {
            dgvNotifications.DataSource = null;
            var stokSekarang = await _controller.GetBarangListFromApiAsync();
            var notificationItems = _controller.ProcessNotification(stokSekarang);

            dgvNotifications.DataSource = notificationItems;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            RefreshList();

        }
    }
}

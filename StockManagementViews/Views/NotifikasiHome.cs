using StockManagement.Controller;
using StockManagement.Models;
using System.Text.Json;

namespace StockManagementViews
{
    public partial class NotifikasiHome : Form
    {
        private NotifikasiController _controller = new NotifikasiController();
        private List<string> notifications = new List<string>();

        public NotifikasiHome()
        {
            InitializeComponent();
            this.Load += Notifikasi_Load;
            txtSearch.TextChanged += TxtSearch_TextChanged;
        }

        private async void Notifikasi_Load(object sender, EventArgs e)
        {
            var stokSekarang = await _controller.GetBarangListFromApiAsync();
            var notificationItems = _controller.ProcessNotification(stokSekarang);

            dgvNotifications.DataSource = notificationItems;
        }


        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            var filter = txtSearch.Text.ToLower();
            var filtered = notifications
                .Where(n => n.ToLower().Contains(filter))
                .Select(n => new { Notifikasi = n })
                .ToList();
            dgvNotifications.DataSource = filtered;
        }
    }
}

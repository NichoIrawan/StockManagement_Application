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
            // Fetch current stock from API
            var stokSekarang = await _controller.GetBarangListFromApiAsync();

            // Process notifications (expired & out of stock)
            notifications = _controller.ProcessNotification(stokSekarang);

            // Bind notifications to DataGridView
            dgvNotifications.DataSource = notifications.Select(n => new { Notifikasi = n }).ToList();
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

        private void headerPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

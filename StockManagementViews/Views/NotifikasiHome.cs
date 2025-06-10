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
            //var stokSebelumnya = await GetBarangListFromApi("api/barang/previous");
            //var stokSekarang = await GetBarangListFromApi("api/barang/current");
            var stokSebelumnya = await _controller.GetBarangListFromApiAsync();


            dgvNotifications.DataSource = notifications.Select(n => new { Notifikasi = n }).ToList();
        }

        private async Task<List<Barang>> GetBarangListFromApi(string endpoint)
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:5052/"); 
            var response = await client.GetAsync(endpoint);
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<List<Barang>>(json);
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

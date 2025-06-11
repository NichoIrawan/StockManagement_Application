namespace StockManagementLibrary
{
    public enum Kategori { Makanan, Minuman, Keperluan_rumahtangga, Lain_lain };
    public enum NotifApp { keluar, masuk, notif_habis, notif_expired };
    public enum Roles { USER, MANAGER, ADMIN, STAFF };
    public enum Bahasa { Indonesia, English };
    public enum State { CekMasuk, CekKeluar, CekStok, CekExpired, Selesai };
}

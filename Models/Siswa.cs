namespace db_siswa_api.Models
{
    public class Siswa
    {
        public int id { get; set; }
        public string nama { get; set; } = string.Empty;
        public int umur { get; set; }
        public string kelas { get; set; } = string.Empty;
    }
}
//pertama bikin models class siswa dengan property yg dibutuhkan
//pindah ke siswacontext
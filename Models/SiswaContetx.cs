using Microsoft.EntityFrameworkCore;

namespace db_siswa_api.Models
{
    public class SiswaContext : DbContext{
        public SiswaContext(DbContextOptions<SiswaContext> options) : base(options){}
        public DbSet<Siswa> siswa {get; set;}
    }

}
//ini merubakan dbcontext dimana dalam folder models disini akan saling berkaitan context nya ke dalam db,
//dbset db_siswa kemudian relasi tabel siswa 
//pindah ke appsetingsjson
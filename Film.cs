namespace TP_MOD10_103022400023
{
    public class Film
    {
        public int Id { get; set; }
        public string Judul { get; set; }
        public string Sutradara { get; set; }
        public int Tahun { get; set; }
        public string Genre { get; set; }
        public double Rating { get; set; }

        public Film(int id, string judul, string sutradara, int tahun, string genre, double rating)
        {
            Id = id;
            Judul = judul;
            Sutradara = sutradara;
            Tahun = tahun;
            Genre = genre;
            Rating = rating;
        }
    }
}

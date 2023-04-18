namespace modul9_1302210213
{
    public class mahasiswa
    {
        public string nama { get; set; }
        public string nim { get; set; }
        public List<String> Course { get; set; }
        public int Year { get; set; }

        public mahasiswa(string nama, string nim, List<String> Course, int Year)
        {
            this.nama = nama;
            this.nim = nim;
            this.Course = Course;
            this.Year = Year;
        }
    }
}



using System;

namespace SampleProject.Application.Mahasiswa
{
    public class MahasiswaDTO
    {
        public Guid Id { get; set; }

        public string name { get; set; }
        public int nim { get; set; }
        public string sex { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string date { get; set; }
        public string address { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SampleProject.Application.Mahasiswa.RegisterMahasiswa
{
    public class RegisterMahasiswaRequest
    {
        public string name { get; set; }
        public int nim { get; set; }
        public string sex { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string date { get; set; }
        public string address { get; set; }
    }
}

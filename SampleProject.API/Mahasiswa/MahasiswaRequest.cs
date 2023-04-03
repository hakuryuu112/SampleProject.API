using SampleProject.Application.Mahasiswa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleProject.API.Mahasiswa
{
    public class MahasiswaRequest
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

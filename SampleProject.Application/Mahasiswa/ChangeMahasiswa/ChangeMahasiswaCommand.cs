using MediatR;
using SampleProject.Application.Configuration.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleProject.Application.Mahasiswa.ChangeMahasiswa
{
    public class ChangeMahasiswaCommand : CommandBase<Unit>
    {
        public Guid id { get; }
        public string name { get; }
        public int nim { get; }
        public string sex { get; }
        public string city { get; }
        public string country { get; }
        public string date { get; }
        public string address { get; }

        public ChangeMahasiswaCommand(
            Guid id, 
            string name, 
            int nim, 
            string sex, 
            string city, 
            string country, 
            string date, 
            string address)
        {
            this.id = id;
            this.name = name;
            this.nim = nim;
            this.sex = sex;
            this.city = city;
            this.country = country;
            this.date = date;
            this.address = address;
        }
    }
}

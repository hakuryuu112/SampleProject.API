using System;
using System.Collections.Generic;
using System.Linq;
using SampleProject.Domain.SeedWork;

namespace SampleProject.Domain.Mahasiswa
{
    public class Mahasiswas : Entity, IAggregateRoot
    {
        public MahasiswaId Id { get; private set; }

        private string _name;
        private int _nim;
        private string _sex;
        private string _city;
        private string _country;
        private string _date;
        private string _address;

        private Mahasiswas (string name, int nim, string sex, string city, string country, string date, string address)
        {
            this.Id = new MahasiswaId(Guid.NewGuid());
            _name = name;
            _nim = nim;
            _sex = sex;
            _city = city;
            _country = country;
            _date = date;
            _address = address;

            this.AddDomainEvent(new MahasiswaRegisterEvent(this.Id));
        }

        public static Mahasiswas CreateMahasiswa (
            string name, 
            int nim, 
            string sex, 
            string city, 
            string country, 
            string date,
            string address
            )
        {
            return new Mahasiswas(name, nim, sex, city, country, date, address);
        }
    }
}

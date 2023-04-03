using System;
using System.Collections.Generic;
using System.Linq;
using SampleProject.Domain.Mahasiswa.Rules;
using SampleProject.Domain.SeedWork;

namespace SampleProject.Domain.Mahasiswa
{
    public class Mahasiswas : Entity, IAggregateRoot
    {
        private readonly List<Mahasiswas> _mahasiswa;
        public MahasiswaId id { get; private set; }

        private string _name;
        private int _nim;
        private string _sex;
        private string _city;
        private string _country;
        private string _date;
        private string _address;

        private Mahasiswas()
        {
            this._mahasiswa = new List<Mahasiswas>();
        }

        private Mahasiswas (string name, int nim, string sex, string city, string country, string date, string address)
        {
            this.id = new MahasiswaId(Guid.NewGuid());
            _name = name;
            _nim = nim;
            _sex = sex;
            _city = city;
            _country = country;
            _date = date;
            _address = address;

            this.AddDomainEvent(new MahasiswaRegisterEvent(this.id));
        }

        public static Mahasiswas CreateMahasiswa(
            string name,
            int nim,
            string sex,
            string city,
            string country,
            string date,
            string address,
            IMahasiswaUniquenessChecker mahasiswaUniquenessChecker
            )
        {
            CheckRule(new MahasiswaNimMustBeUniqueRule(mahasiswaUniquenessChecker, nim));

            return new Mahasiswas(name, nim, sex, city, country, date, address);
        }

        public void ChangeMahasiswa(MahasiswaId mahasiswaId, string name, int nim, string sex, string city, string country, string date, string address)
        {
            this.id = mahasiswaId;
            _name = name;
            _nim = nim;
            _sex = sex;
            _city = city;
            _country = country;
            _date = date;
            _address = address;

            this.AddDomainEvent(new MahasiswaRegisterEvent(this.id));
        }

        public void DeleteMahasiswa(MahasiswaId id)
        {
            this.id = id;

            this.AddDomainEvent(new MahasiswaDeleteEvent(id));
        }
    }
}

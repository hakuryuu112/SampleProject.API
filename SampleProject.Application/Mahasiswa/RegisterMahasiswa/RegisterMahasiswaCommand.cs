using SampleProject.Application.Configuration.Commands;

namespace SampleProject.Application.Mahasiswa.RegisterMahasiswa
{
    public class RegisterMahasiswaCommand : CommandBase<MahasiswaDTO>
    {
        public string name { get; }
        public int nim { get; }
        public string sex { get; }
        public string city { get; }
        public string country { get; }
        public string date { get; }
        public string address { get; }

        public RegisterMahasiswaCommand(string Name, int Nim, string Sex, string City, string Country, string Date, string Address)
        {
            this.name = Name;
            this.nim = Nim;
            this.sex = Sex;
            this.city = City;
            this.country = Country;
            this.date = Date;
            this.address = Address;
        }
    }
}

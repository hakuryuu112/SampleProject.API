using SampleProject.Domain.SeedWork;

namespace SampleProject.Domain.Mahasiswa.Rules
{
    public class MahasiswaNimMustBeUniqueRule : IBusinessRule
    {
        private readonly IMahasiswaUniquenessChecker _mahasiswaUniquenessChecker;

        private readonly int _nim;

        public MahasiswaNimMustBeUniqueRule(
            IMahasiswaUniquenessChecker mahasiswaUniquenessChecker,
            int nim)
        {
            _mahasiswaUniquenessChecker = mahasiswaUniquenessChecker;
            _nim = nim;
        }

        public bool IsBroken() => !_mahasiswaUniquenessChecker.IsUnique(_nim);

        public string Message => "Mahasiswa with this Nim already exists.";

    }
}

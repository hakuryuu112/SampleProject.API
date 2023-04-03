using System;
using System.Collections.Generic;
using System.Text;

namespace SampleProject.Domain.Mahasiswa
{
    public interface IMahasiswaUniquenessChecker
    {
        bool IsUnique(int mahasiswaNim);
    }
}

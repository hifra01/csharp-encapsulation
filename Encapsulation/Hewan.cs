using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Hewan
    {
        public string nama;
        protected string spesies;
        private protected int umur;

        public Hewan(string nama, string spesies, int umur)
        {
            this.nama = nama;
            this.spesies = spesies;
            this.umur = umur;
        }
    }

    class Kucing : Hewan
    {
        private int umur;

        public Kucing(string nama, int umur) : base(nama, "Kucing", umur)
        {
        }

        public void panggilSpesies()
        {
            Console.WriteLine(spesies);
        }

        public void panggilUmur()
        {
            Console.WriteLine(base.umur);
        }
    }
}

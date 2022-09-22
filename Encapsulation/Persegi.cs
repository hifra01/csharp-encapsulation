using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Persegi
    {
        private int _panjangSisi;
        private const int _jumlahSisi = 4;
        private int _luas;
        private int _keliling;

        public Persegi(int panjangSisi)
        {
            this.panjangSisi = panjangSisi;
            hitungKeliling();
            hitungLuas();
        }

        private void hitungKeliling()
        {
            _keliling = panjangSisi * jumlahSisi;
        }

        private void hitungLuas()
        {
            _luas = panjangSisi * panjangSisi;
        }

        public int panjangSisi
        {
            get { return _panjangSisi; }
            set 
            {
                _panjangSisi = value;
                hitungKeliling();
                hitungLuas();
            }
        }

        public int jumlahSisi
        {
            get { return _jumlahSisi; }
        }

        public int luas
        {
            get { return _luas; }
        }

        public int keliling
        {
            get { return _keliling; }
        }
    }
}

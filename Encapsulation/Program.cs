namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persegi persegi = new Persegi(5);

            Console.WriteLine(persegi.panjangSisi);
            
            Console.WriteLine(persegi.jumlahSisi);
            Console.WriteLine(persegi.luas);
            Console.WriteLine(persegi.keliling);



            ////persegi.luas = persegi.panjangSisi * persegi.panjangSisi;
            ////persegi.keliling = persegi.panjangSisi * persegi.jumlahSisi;

            ////Console.WriteLine(persegi.luas);
            ////Console.WriteLine(persegi.keliling);

            persegi.panjangSisi = 10;

            //Console.WriteLine(persegi.GetPanjangSisi());
            //Console.WriteLine(persegi.GetJumlahSisi());
            //Console.WriteLine(persegi.GetLuas());
            //Console.WriteLine(persegi.GetKeliling());

            Console.WriteLine(persegi.panjangSisi);
            Console.WriteLine(persegi.jumlahSisi);
            Console.WriteLine(persegi.luas);
            Console.WriteLine(persegi.keliling);

            //persegi.jumlahSisi = 10;

            //Console.WriteLine(persegi.panjangSisi);
            //Console.WriteLine(persegi.jumlahSisi);
            //Console.WriteLine(persegi.luas);
            //Console.WriteLine(persegi.keliling);

        }
    }
}
// See https://aka.ms/new-console-template for more information
namespace modul5_103022300153
{
    class PemrosesData
    {
        public void DapatkanNilaiTerbesar<T>(T nilai1, T nilai2, T nilai3)
        {
            dynamic temp1 = nilai1;
            dynamic temp2 = nilai2;
            dynamic temp3 = nilai3;
            if (temp1 > temp2 && temp1 > temp3)
            {
                Console.WriteLine("Nilai Terbesar: " + nilai1);
            }
            else if (temp2 > temp1 && temp2 > temp3)
            {
                Console.WriteLine("Nilai Terbesar: " + nilai2);
            }
            else if (temp3 > temp1 && temp3 > temp2)
            {
                Console.WriteLine("Nilai Terbesar: " + nilai3);
            }
        }
    }
    
    class Program
    {
        public static void Main(String[] args)
        {
            PemrosesData data = new PemrosesData();
            Console.WriteLine("Dari 10.0, 30.0, 22.0");
            data.DapatkanNilaiTerbesar(10.0, 30.0, 22.0);
        }
    }
}
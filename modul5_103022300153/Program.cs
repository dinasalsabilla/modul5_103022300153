// See https://aka.ms/new-console-template for more information
namespace modul5_103022300153
{
    class SimpleDataBase<T>
    {
        private List<T> storedData;
        private List<DateTime> inputDates;

        public SimpleDataBase()
        {
            storedData = new List<T>();
            inputDates = new List<DateTime>();
        }

        public void AddNewData(T data)
        {
            storedData.Add(data);
            inputDates.Add(DateTime.Now);
        }

        public void PrintAllData()
        {
            for (int i = 0; i < storedData.Count; i++)
            {
                Console.WriteLine("Data " + (i + 1) + " berisi: " + storedData[i] + ", yang disimpan pada waktu UTC: " + inputDates[i]);
            }
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            SimpleDataBase<double> print = new SimpleDataBase<double>();
            print.AddNewData(10.0);
            print.AddNewData(30.0);
            print.AddNewData(22.0);
            print.PrintAllData();

        }
    }
}
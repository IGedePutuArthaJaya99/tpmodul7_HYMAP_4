class Program
{
    static void Main(string[] args)
    {
        DataMahasiswa103082400020 dataMahasiswa = new DataMahasiswa103082400020();
        dataMahasiswa.ReadJSON();

        Console.WriteLine();

        KuliahMahasiswa103082400020 kuliahMahasiswa = new KuliahMahasiswa103082400020();
        kuliahMahasiswa.ReadJSON();
    }
}
using Csharp_study;

class Program
{
    static void Main(string[] args)
    {
        SingletonDatabase DB1 = SingletonDatabase.getInstance("abc");
        DB1.getDataFromAdress();
        SingletonDatabase DB2 = SingletonDatabase.getInstance("def");
        DB1.getDataFromAdress();
        DB2.getDataFromAdress();
    }
}

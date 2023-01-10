// See https://aka.ms/new-console-template for more information
namespace dotnet_six_csharp
{
    public class Program
    {
        public static int Main(string[] args)
        {
            if (args.Length < 2)
                return -1;

            switch (args[1].ToUpper())
            {
                case "ATR":
                    var test = new MyTestClass() { Id = 1, Name = "Teste 1" };

                    /// percorrer todas as propriedades da classe MyTest

                    System.Reflection.MemberInfo mi = typeof(MyTestClass).GetProperty("Id");

                    if (mi == null)
                        return -1;

                    var att = Attribute.GetCustomAttribute(mi, typeof(MyAttributeClass)) as MyAttributeClass;

                    if (att == null)
                        return -1;

                    Console.WriteLine($"Propriedade: {mi.Name}, Coluna: {att.ColumnName}");
                    break;

                case "FORMAT":
                    var Ft = new FormatTest(10, 0, 'N');
                    Console.WriteLine($"Teste de formatacao (inteiro): {Ft.Format(1003)}");
                    Ft = new FormatTest(10, 3, 'N');
                    Console.WriteLine($"Teste de formatacao (decimal): {Ft.Format(12.123m)}");
                    Console.WriteLine($"Teste de formatacao (decimal): {Ft.Format(1234.123m)}");
                    break;
            }

            return 0;
        }
    }
}
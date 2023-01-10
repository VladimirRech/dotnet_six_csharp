// See https://aka.ms/new-console-template for more information
namespace dotnet_six_csharp
{
    public class Program
    {
        public static int Main(string[] args)
        {
            var test = new MyTestClass() { Id = 1, Name = "Teste 1" };

            /// percorrer todas as propriedades da classe MyTest

            System.Reflection.MemberInfo mi = typeof(MyTestClass).GetProperty("Id");

            if (mi == null)
                return -1;

            var att = Attribute.GetCustomAttribute(mi, typeof(MyAttributeClass)) as MyAttributeClass;

            if (att == null)
                return -1;

            Console.WriteLine($"Propriedade: {mi.Name}, Coluna: {att.ColumnName}");


            return 0;
        }
    }
}
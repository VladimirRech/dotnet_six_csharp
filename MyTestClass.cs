namespace dotnet_six_csharp
{

    public class MyTestClass
    {
        [MyAttributeClass(ColumnName = "id_test", Size = 8)]
        public int Id { get; set; }

        [MyAttributeClass(ColumnName = "name_test", Size = 50)]
        public string Name { get; set; } = "";
    }
}
namespace dotnet_six_csharp{

[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
public class MyAttributeClass : Attribute 
{
    public string ColumnName { get; set; } = "";
    public int Size { get; set; }
}
}
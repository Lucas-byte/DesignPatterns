namespace DesignPatterns.Behavioral_Patterns.Strategy;
public class XmlExport : ExportStrategy
{
    public override void ExportFile(string fileName)
    {
        Console.WriteLine($"Exportando arquivo: {fileName}.xml");
    }
}


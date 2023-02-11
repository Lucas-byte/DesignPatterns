namespace DesignPatterns.Behavioral_Patterns.Strategy;
public class PdfExport : ExportStrategy
{
    public override void ExportFile(string fileName)
    {
        Console.WriteLine($"Exportando arquivo: {fileName}.pdf");
    }
}


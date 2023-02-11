namespace DesignPatterns.Behavioral_Patterns.Observer;

//Concrete Subject
public class VisualStudio : Microsoft
{
    public VisualStudio(string nameProduct, decimal versionProduct) : base(nameProduct, versionProduct)
    {
    }
}


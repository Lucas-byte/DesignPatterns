namespace DesignPatterns.Creational_Patterns.AbstractFactory;

//Product B2
public class Refrigerator : AbstractDrink
{
    public override string Output()
    {
        return "Refrigerante!";
    }
}

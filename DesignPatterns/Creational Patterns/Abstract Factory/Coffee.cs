namespace DesignPatterns.Creational_Patterns.AbstractFactory;

//Product B1
public class Coffee : AbstractDrink
{
    public override string Output()
    {
        return "Café com Leite!";
    }
}

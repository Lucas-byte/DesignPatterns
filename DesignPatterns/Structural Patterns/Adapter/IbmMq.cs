namespace DesignPatterns.Structural_Patterns.Adapter;

//Adaptee
public class IbmMq : IQueueXml
{
    public void PublishXML()
    {
        Console.WriteLine("Enviando mensagem com IBMMq");
    }

    public void SubscribeXML()
    {
        Console.WriteLine("Lendo mensagem com IBMMq");
    }
}


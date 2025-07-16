// Abstract Products
public interface IButton
{
    void Display();
}

public interface ICheckbox
{
    void Display();
}

// Concrete Products (Windows)
public class WindowsButton :IButton
{
    public void Display()
    {
        Console.WriteLine("Rendering a Windows Button");
    }
}

public class WindowsCheckbox : ICheckbox
{
    public void Display()
    {
        Console.WriteLine("Rendering a Windows Checkbox");
    }
}

//Concrete Products(Mac)
public class MacButton : IButton
{
    public void Display()
    {
        Console.WriteLine("Rendering a Mac Button");
    }
}

public class MacCheckbox : ICheckbox
{
    public void Display()
    {
        Console.WriteLine("Rendering a Mac Checkbox");
    }
}

// Abstract Factory
public interface IGUIFactory
{
    IButton CreateButton();
    ICheckbox CreateCheckbox();
}

// Concrete Factories
public class WindowsFactory : IGUIFactory
{
    public IButton CreateButton() => new WindowsButton();
    public ICheckbox CreateCheckbox() => new WindowsCheckbox();
}

public class MacFactory : IGUIFactory
{
    public IButton CreateButton() => new MacButton();
    public ICheckbox CreateCheckbox() => new MacCheckbox();
}

// Client Code
class Program
{
    static void RenderUI(IGUIFactory factory)
    {
        IButton button = factory.CreateButton();
        ICheckbox checkbox = factory.CreateCheckbox();
        button.Display();
        checkbox.Display();
    }

    static void Main(string[] args)
    {

        Console.WriteLine("You want to create object of windows or Mac");
        string choice = Console.ReadLine().ToLower();
        
        if (choice == "windows")
        {
            IGUIFactory factory = new WindowsFactory();
            RenderUI(factory);
        }
        else if(choice =="mac")
        {

            IGUIFactory factory1 = new MacFactory();
            RenderUI(factory1);
        }
        else
        {
            Console.WriteLine("Invalid Choice");
        }

    }
}

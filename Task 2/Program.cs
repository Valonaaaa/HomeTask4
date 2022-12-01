using System.Xml.Linq;

public abstract class Alive
{
    public string NameOfSpecies { get;private set; }

    public Alive(string nameOfSpecies)
    {
        NameOfSpecies = nameOfSpecies;
    }
}

public abstract class Animal: Alive
{
    public string ParticularIndividual { get; private set; }
    public Animal(string particularIndividual) : base(nameof(Animal))
    {
        ParticularIndividual = particularIndividual;
    }

   
}
 
public abstract class Herbal: Alive
{
    public Herbal(): base(nameof(Herbal))
    {

    }
}

public interface IHerbivore
{
    public void Eat(Herbal herbal);
    
}
public interface ICarnivore
{
    public void Eat(Animal animal);
    
}
public class Wolf: Animal, ICarnivore
{
    public Wolf(): base(nameof(Wolf))
    {
        }

    public void Eat(Animal animal)
    {
        Console.WriteLine("Wolf eat animal");
    }
}
public class Rabbit : Animal, IHerbivore

{
    public Rabbit(): base(nameof(Rabbit))
    {
    }
    public void Eat(Herbal herbal)
    {
        Console.WriteLine("Rabbit eat herbal");
    }
}
public class Bear : Animal, ICarnivore, IHerbivore
{
    public Bear() : base(nameof(Bear))
    {

    }
    public void Eat(Herbal herbal)
    {
        Console.WriteLine("Bear eat herbal");
    }
    public void Eat(Animal animal)
    {
        Console.WriteLine("Bear eat animal");
    }
}
public class Rose : Herbal
{

}
public class Grass : Herbal
{

}



internal class Program
{
    
   
    private static void Main(string[] args)
    {
        Wolf wolf = new Wolf();
        Bear bear = new Bear();
        Rabbit rabbit = new Rabbit();


        Rose rose = new Rose();
        Grass grass = new Grass();

        Console.WriteLine(rose.NameOfSpecies);
        Console.WriteLine(grass.NameOfSpecies);
        Console.WriteLine(bear.ParticularIndividual);

        wolf.Eat(bear);
        bear.Eat(grass);
        bear.Eat(rabbit);





    }

 
}
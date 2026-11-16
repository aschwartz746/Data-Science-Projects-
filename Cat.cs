using System.Diagnostics.Eventing.Reader;

public class Cat : Pet
{
    //Custom Constructor for the Cat Class 
    public Cat(string name, string favoriteToy)
        : base(name, favoriteToy)
    {
        PetType = "Cat";
        PetName = name;
        FavoriteToy = favoriteToy;

    }

    //The interaction 
    public override string Interaction(string action)
    {
        if (action == "Feed Pet")
            return $"{PetName} purrs happily when nibbling on the {FavoriteToy}!";
        else if (action == "Cuddle Pet")
            return $"{PetName} curls up on your lap and purrs!";
        else if (action == "Play With Pet")
            return $"{PetName} bats at the {FavoriteToy} with their paw!";
        else
            return $"{PetName} gives you a moment of love.";

    }
}

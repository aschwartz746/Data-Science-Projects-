using System.Diagnostics.Eventing.Reader;

public class Pig : Pet
{
    //Custom Constructor for the Pig Class 
    public Pig(string name, string favoriteToy)
        : base(name, favoriteToy)
    {
        PetType = "Pig";
        PetName = name;
        FavoriteToy = favoriteToy;
    }

    //The interaction method
    public override string Interaction(string action)
    {
        if (action == "Feed Pet")
            return $"{PetName} oinks happily when munching on some {FavoriteToy}!";
        else if (action == "Cuddle Pet")
            return $"{PetName} snuggles close and lets out a grunt!";
        else if (action == "Play With Pet")
            return $"{PetName} rolls around playing with the {FavoriteToy}!";
        else
            return $"{PetName} looks at you curiously.";

    }
}


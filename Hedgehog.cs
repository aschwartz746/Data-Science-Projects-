using System.Diagnostics.Eventing.Reader;

public class Hedgehog : Pet
{
    //Custom Constructor for the Hedgehog Class 
    public Hedgehog(string name, string favoriteToy)
        : base(name, favoriteToy)
    {
        PetType = "Hedgehog";
        PetName = name;
        FavoriteToy = favoriteToy;
    }

    //The interaction 
    public override string Interaction(string action)
    {
        if (action == "Feed Pet")
            return $"{PetName} sniffs happily and nibbles on the {FavoriteToy}!";
        else if (action == "Cuddle Pet")
            return $"{PetName} snuggles in a little ball next to you!";
        else if (action == "Play With Pet")
            return $"{PetName} shuffles around chasing the {FavoriteToy}!";
        else
            return $"{PetName} peaks out shyly.";

    }
}


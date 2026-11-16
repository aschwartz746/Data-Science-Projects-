using System.Diagnostics.Eventing.Reader;

public class Dog : Pet
{
    //Custom Constructor for the Dog Class 
    public Dog(string name, string favoriteToy)
        : base(name, favoriteToy)
    {
         PetType = "Dog";
         PetName = name;
         FavoriteToy = favoriteToy;

    }

    //The interaction 
    public override string Interaction(string action)
    {
        if (action == "Feed Pet")
            return $"{PetName} happily wags their tail around when eating a {FavoriteToy} treat!";
        else if (action == "Cuddle Pet")
            return $"{PetName} snuggles up next to you happily!";
        else if (action == "Play With Pet")
            return $"{PetName} runs around chasing the {FavoriteToy}!";
        else 
            return $"{PetName} tilts their head sideways, unsure what to do.";

    }
}


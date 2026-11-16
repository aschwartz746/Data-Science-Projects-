using System;
using System.Collections.Generic;

public abstract class Pet
{
    public string PetName { get; set; }

    public string PetType { get; set; }

    public string FavoriteToy { get; set; }

    public string Mood { get; set;}

    public byte[] ProfileImage { get; set;}

    public byte[] ToyImage { get; set; }

    public int PetID { get; set; }



   

    public Pet(string name, string favoriteToy)
    {
      PetName = name;
      FavoriteToy = favoriteToy;
      Mood = "Neutral";

    }
   
    public abstract string Interaction(string action);

    public virtual string UpdateMood(string mood, string action, byte[] petImage, byte[] toyImage)
    {
        switch (mood)
        {
            case "Happy":
                Mood = "Happy";
                break;
            case "Sad":
                Mood = "Sad";
                break;
            case "Joyful":
                Mood = "Joyful";
                break;
            case "Playful":
                Mood = "Playful";
                break;
            case "Energetic":
                Mood = "Energetic";
                break;
        }
    


                



        return $"Mood updated to {Mood} ";
    }

   
}


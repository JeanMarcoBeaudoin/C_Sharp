using System.Runtime.CompilerServices;

public class  RolePlayingGame()
{
    public void Fight()
    {
        bool attack = true;
        int heroHP = 10;
        int monsterHP = 10;
        Random random = new Random();

        do{
            int damage = random.Next(1, 10);
            if (attack == true)
            {
                monsterHP -= damage;
                Console.WriteLine($"Monster was damaged and lost {damage} and now has {monsterHP}");
                if(monsterHP <= 0){Console.WriteLine("Hero wins");}  
                attack = false;
            }
            else
            {   
                heroHP -= damage;
                Console.WriteLine($"Hero was damaged and lost {damage} and now has {heroHP}");
                if(heroHP <= 0){Console.WriteLine("Monster wins");}   
                attack = true;
            }
        }while(heroHP >= 0 && monsterHP >= 0); 
    }

}
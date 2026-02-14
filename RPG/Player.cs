using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public class Player
    {
        // Champs
        public int MaxHp
        {
            get { return maxHp; }
        }
        private int maxHp = 100;
        private int hp = 100;
        private int attack = 5;
        //a repenser
        private int bonusAttack = 0;
        private int defense = 0;
       
        public int Level
        {
            get { return level; }
        }
        private int level = 1;
        public int Experience
        {
            get { return experience; }
            set { experience = value; }
        }
        private int experience = 0;
        public int Money
        {
            get { return money; }
        }
        private int money = 0;

        //misc
        Random rnd = new Random();

        //Methodes
        public void Hurt(int recievedDamage)
        {
            int damage = rnd.Next(0, recievedDamage + 1) - defense;
            if (damage <= defense)
            {
                hp -= damage;
            }
        }

        public int Attack()
        {
            return rnd.Next(0, attack + 1) + bonusAttack;
        }

        public void Heal(int healAmount)
        {
            if (hp + healAmount >= maxHp)
            {
                hp = maxHp;
            }
            else
            {
                hp += healAmount;
            }
        }

        public void GetMoney(int ammountSet)
        {
            money += ammountSet;
        }

        public void SpendMoney(int ammountSet)
        {
            if (money <= ammountSet)
            {
                money = 0;
            }
            else
            {
                money -= ammountSet;
            }
        }

        public void LvUp()
        {
            if (experience >= level * 5)
            {
                experience -= level * 5;
                level += 1;
                attack += 2;
                maxHp += 15;
            }
        }

        public void ShowStats()
        {
            MessageBox.Show($"Level: {level}\nExperience: {experience}\nMax HP: {maxHp}\nAttaque: {attack}\nAttaque bonus: {bonusAttack}\nDefense: {defense}");
        }
    }

    public class Ennemy
    {
        public string Name { get; set; }
        public int Hp { get; set; }
        private int hp;
        public int Defense { get; set; }
        public int Attack { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }

        protected List<Ennemy> mobs = new List<Ennemy>();
        Random rnd = new Random();

        
        public int AttackPlayer()
        {
            return rnd.Next(Attack + 1);
        }

    }

    public class Goblin : Ennemy
    {
        //les nom sont inspirés de là
        //https://www.reddit.com/r/d100/comments/i0f9rx/my_list_of_100_goblin_names_for_your_consideration/
        List<string> names = new List<string>() { "Grubb", "Stub", "Glorp", "Plorp", "Gratch", "Borkle", "Mogglewog", "Piss Jar", "Spork", "Jeremy", "Odo", "Boblin", "Goblin qui s'apelle Goblin", "Rick" };
        Random rnd = new Random();


        public void CreateGoblin(Player player)
        {
            Goblin goblin = new Goblin();
            goblin.Name = names[rnd.Next(names.Count - 1)];
            goblin.Level = player.Level - 1;
            goblin.Hp = 90 + goblin.Level * 2;
            goblin.Attack = goblin.Level;
            goblin.Defense = 0;
            goblin.Experience = goblin.Level * 5;
            mobs.Add(goblin);
        }
    }
}
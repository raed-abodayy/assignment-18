using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UIElements;
namespace Assignment18
{
    public class Character
    {
        Position character = new Position();
        public string name;
        private int health;
        protected Position position = new Position(1, 1, 1);
        public int Health
        {
            get { return health; }
            set
            {
                health = value;
                if (health > 100)
                {
                    health = 100;
                }
                else if (health < 0)
                {
                    health = 0;
                }
            }
        }
        public Character() : this("No Name", 100, new Position(0, 0, 0)) // non-parametrized
        {
        }
        public Character(string name, int health, Position position)  // parametrized
        {
            this.name = name;
            Health = health;
            this.position = position;
        }
        public virtual void DisplayInfo()
        {
            Debug.Log(name + ", " + health + ", ");
            character.PrintPosition();

        }
        public void Attack(int damage, Character target)
        {
            target.health = target.health-damage;

        }
        public void Attack(int damage, Character target, string attacktype)
        {
            Attack(damage, target);
            Debug.Log(attacktype);
        }
    }
}
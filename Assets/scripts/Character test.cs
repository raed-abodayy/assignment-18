using System.Collections;
using System.Collections.Generic;
using Assignment18;
using UnityEngine;

public class Charactertest : MonoBehaviour
{
    Soldier soldier2 = new Soldier();
    Officer officer2 = new Officer();
    Character[] characters = new Character[2];
    void Start()
    {
        characters[0] = soldier2;
        characters[1] = officer2;
        for (int z = 0; z < characters.Length; z++)
        {
            Character character = characters[z];
            character.DisplayInfo();
        }
        soldier2.DisplayInfo();
        officer2.Attack(20, soldier2,"kick");
        soldier2.DisplayInfo();
    }


}

using System.Collections;
using System.Collections.Generic;
using Assignment18;
using UnityEngine;

public class Officer : Character
{
Character officer2= new Character("raed",100,new Position(1,1,1) );
    public override void DisplayInfo()
    {
        Debug.Log("officer");
        base.DisplayInfo();
    }
}

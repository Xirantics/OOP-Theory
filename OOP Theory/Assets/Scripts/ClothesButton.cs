using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClothesButton : Button // INHERITANCE
{
    // POLYMORPHISM
    public override void changeColor()
    {
        itemTag = "Clothes";

        base.changeColor();
    }
}

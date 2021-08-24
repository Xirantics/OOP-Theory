using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HairButton : Button // INHERITANCE
{
    // POLYMORPHISM
    public override void changeColor()
    {
        itemTag = "Hair";

        base.changeColor();
    }

}

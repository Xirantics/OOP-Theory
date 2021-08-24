using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OkButton : CharacterName
{
    public Text inputName;

    public void setCharacterName()
    {
        CharName = inputName.text;
    }
}

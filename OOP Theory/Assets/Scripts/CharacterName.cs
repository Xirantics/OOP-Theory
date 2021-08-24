using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterName : MonoBehaviour
{
    private string characterName;

    private Text errorMessage;

    private void Start()
    {
        errorMessage = GameObject.FindGameObjectWithTag("Error").GetComponent<Text>();
    }

    public string CharName

    {
        get { return characterName; }

        set
        {
            if (value.Length == 0 || value.Length > 20)
            {
                errorMessage.text = "Write a name between 1 and 20 characters!";
            }

            else
            {
                errorMessage.text = "";

                characterName = value;
                Debug.Log(characterName);
            }
        }
    }

}

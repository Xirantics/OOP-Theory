using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Button : MonoBehaviour
{
    public GameObject itemSelected;

    public string itemTag;

    // ABSTRACTION
    public virtual void changeColor()
    {
        GameObject itemToChange = GameObject.FindGameObjectWithTag(itemTag);

        itemSelected.SetActive(true);

        itemToChange.SetActive(false);
    }



}

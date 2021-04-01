using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveClothing : MonoBehaviour
{
    public Selection selection;

    public void TakeOffAccessory()
    {
        //Destroys accessory if one is selected
        if (selection.accessory != null)
        {
            Destroy(selection.accessory);
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClothingButton : MonoBehaviour
{
    //Drag the scriptable object that is instantiated with this button in here. Needs a maleCloth as well that will be controlled with an if-statement.
    public Clothing femaleCloth;
    public Clothing maleCloth;
    //Drag an image component with disabled image-script
    public Image icon;
    Transform player;
    CorePanel corePanel;

    void Start()
    {
        corePanel = FindObjectOfType<CorePanel>();
    }

    void Update()
    {
        //updates the player constantly, so when a gender is changed the player changes as well. Maybe should be changed using gender bools instead. Hmmhmm.
        if(FindObjectOfType<Selection>().gender != null)
        {
            player = FindObjectOfType<Selection>().gender.transform;
        }
        //changes icon to the icon that is saved on the scriptable object and turns image-script on
        if (corePanel.femaleChosen)
        {
            icon.sprite = femaleCloth.icon;
            icon.enabled = true;
        }
        else
        {
            icon.sprite = maleCloth.icon;
            icon.enabled = true;
        }
    }

    //Called from On-click event. Puts on the 3D-model of the clothing saved on the scriptable object.
    public void PutOn()
    {
        if (corePanel.femaleChosen)
        {
            femaleCloth.ChangeTo(player);
        }
        else
        {
            maleCloth.ChangeTo(player);
        }
        
    }
}

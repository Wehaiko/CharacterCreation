using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinButton : MonoBehaviour
{
    //Add this buttons material here in inspector
    public Material thisButtonsSkin;
    CorePanel corePanel;

    private void Start()
    {
        corePanel = GetComponentInParent<CorePanel>();
    }

    //Changes skin color the material saved in the inspector
    public void ChangeSkin()
    {
        corePanel.playerSkin.material = thisButtonsSkin;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorePanel : MonoBehaviour
{
    //When gender is chosen, instantiatied prefabs parent.transform is set to player
    public GameObject player;

    //For instantiating male
    public GameObject male;

    //For instantiating female
    public GameObject female;
    public bool femaleChosen;

    public Selection selection;

    //When gender is chosen playerSkin is set for selected gender instantiation
    public MeshRenderer playerSkin;

    /*public bool panelIsOpen;
    public Animator clothingPanelAnimator;
    public GameObject skinPanel;*/

    //Methods for GenderButtons
    public void GenderMale()
    {
        //Everything is in if-statement so that no more than 1 male is instantiated
        if (femaleChosen)
        {
            //If a female is selected and then player desides to go back to male, the selected female is destroyed
            if(selection.gender != null)
            {
                Destroy(selection.gender);
            }

            //Instantiate the male and set playerSkin renderer to selected male
            selection.gender = Instantiate(male, player.transform);
            playerSkin = selection.gender.GetComponentInChildren<MeshRenderer>();

            //Determine whitch gender is chosen
            femaleChosen = false;
        }
        /*if (!panelIsOpen)
        {
            clothingPanelAnimator.SetTrigger("OpenPanel");
            panelIsOpen = true;
        }
        skinPanel.SetActive(true);*/
    }
    public void GenderFemale()
    {
        //Everything is in if-statement so that no more than 1 female is instantiated
        if (!femaleChosen)
        {
            //If a male is selected and then player desides to go back to female, the selected male is destroyed
            if (selection.gender != null)
            {
                Destroy(selection.gender);
            }

            //Instantiate the female and set playerSkin renderer to selected female
            selection.gender = Instantiate(female, player.transform);
            playerSkin = selection.gender.GetComponentInChildren<MeshRenderer>();

            //Determine whitch gender is chosen
            femaleChosen = true;
        }
        /*if (!panelIsOpen)
        {
            clothingPanelAnimator.SetTrigger("OpenPanel");
            panelIsOpen = true;
        }
        skinPanel.SetActive(true);*/
    }

    public void ChangeSkin()
    {

    }
}

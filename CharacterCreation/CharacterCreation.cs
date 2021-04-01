using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCreation : MonoBehaviour
{
    //Whole canvas, where CharacterCreationUI is
    public GameObject characterCreationUi;

    public GameObject player;
    NewPlayerMovement movement;
    CharacterRotation rotation;

    private void Start()
    {
        movement = player.GetComponent<NewPlayerMovement>();
        rotation = player.GetComponent<CharacterRotation>();
    }

    //Called from Finish-button
    public void CloseCharacterCreation()
    {
        //Puts CharacterCreationUI away and sets move speed to 5, so player can move
        characterCreationUi.SetActive(false);

        movement.enabled = true;
        Destroy(rotation);
    }
}

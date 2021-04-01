using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterRotation : MonoBehaviour
{
    //Speed at which the player is rotated
    public float rotateSpeed;

    //Player can be rotated by click-and-dragging the player. Mouse needs to be moved on the x-axis.
    private void OnMouseDrag()
    {
        float rotate = Input.GetAxis("Mouse X") * rotateSpeed;

        transform.Rotate(Vector3.down, rotate);
    }
}

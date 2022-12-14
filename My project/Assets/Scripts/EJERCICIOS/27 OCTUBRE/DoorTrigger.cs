using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : PlayerTrigger
{
    public Animator doorAnimator;

    private bool doorIsOpen = true;

    public override void OnPlayerEnter(GameObject playerObject)
    {
        doorAnimator.SetBool("OpenDoor", doorIsOpen);
        doorIsOpen = !doorIsOpen;

        //doorAnimator.SetTrigger();
    }
}
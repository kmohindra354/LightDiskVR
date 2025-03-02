using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportationDisk : Weapon
{
    public Transform playerTransform;

    // Here so that the player can only teleport once per disk throw
    private bool teleported;

    // Start is called before the first frame update
    void Start()
    {
        isHeld = false;
        teleported = false;
    }

    public override void OnGrabFunction() {
        base.OnGrabFunction();
        teleported = false;
    }

    public override void MainButtonFunction()
    {
        if (!isHeld && !teleported) {
            Teleport();
        }
    }

    private void Teleport()
    {
        teleported = true;

        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit, Mathf.Infinity)) {
            playerTransform.position = hit.point;
            // Move it up by 1 just to make sure that the player doesn't enter the floor
        }
    }

}

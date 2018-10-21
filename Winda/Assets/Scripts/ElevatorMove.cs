using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorMove : MonoBehaviour
{



    public GameObject player;
    public float maxHeight = 10f;
    public float minHeight = 0f;
    public  float elevatorSpeed = 3f;
    public bool IsMoving;

    void OnTriggerEnter(Collider other)
    {
        IsMoving = true;
    }

    void OnTriggerExit(Collider other)
    {
        IsMoving = false;
    }


    void FixedUpdate()
    {
        if(IsMoving == true && transform.position.y < maxHeight)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + elevatorSpeed * Time.deltaTime, transform.position.z);
            player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + elevatorSpeed * Time.deltaTime, player.transform.position.z);
        }

        if(IsMoving == false && transform.position.y > minHeight)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - elevatorSpeed * Time.deltaTime, transform.position.z);
            player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y - elevatorSpeed * Time.deltaTime, player.transform.position.z);
        }


    }

}

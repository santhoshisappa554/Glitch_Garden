using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public Transform player;

    void LateUpdate()
    {
        transform.position = player.position;
       
    }
}


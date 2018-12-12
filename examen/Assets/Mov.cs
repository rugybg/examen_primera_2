using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov : MonoBehaviour
{


    //script en la bola
    public GameObject cubo;


    private void OnTriggerEnter3D(Collider collision)
    {
        Destroy(cubo);
    }
}

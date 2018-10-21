using UnityEngine;
using System.Collections;


public class DestroyedBlock : MonoBehaviour
{ 
    bool playerHit = true;


    private void OnTriggerEnter2D(Collider2D collision)
    {

        Destroy(gameObject);

    }
}


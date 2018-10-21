using UnityEngine;
using System.Collections;


public class SpawnBox : MonoBehaviour
{
    public GameObject Prefab;
    public Transform Spawnpoint;
    public int numberOfCoins;
    bool playerHit = true;
    public AudioSource bump;
    public AudioSource coin;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(Prefab, Spawnpoint.position, Spawnpoint.rotation);
        bump.Play();
        coin.Play();
    }
}


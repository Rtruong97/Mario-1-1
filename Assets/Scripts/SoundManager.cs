using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    public static AudioClip playerJump, playerDeath, endGame;
    static AudioSource audioSrc;


	// Use this for initialization
	void Start () {
        playerJump = Resources.Load<AudioClip>("jump");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

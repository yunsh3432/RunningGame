﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager_Overwatch : MonoBehaviour {

    public PlayerController player;

    public GameObject theArrow;
	public GameObject Hanzo;
	// Use this for initialization
	void Start () {
        player = FindObjectOfType<PlayerController>();
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
			Hanzo.SetActive (true);
            theArrow.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Charactermenu : MonoBehaviour {

	public string scenename;
	// Use this for initialization

	public void ReturnMain()
	{
		SceneManager.LoadScene (scenename);
	}

}

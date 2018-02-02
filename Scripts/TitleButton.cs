using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("escape")) {
			PushEscButton ();
		}
	}

	public void PushQuadButton(){
		SceneManager.LoadScene ("Game Scene");
	}

	public void PushPaintButton(){
		SceneManager.LoadScene ("Splatoon");
	}

	void PushEscButton(){
		SceneManager.LoadScene ("Title");
	}
}

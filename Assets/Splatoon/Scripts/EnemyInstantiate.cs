using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInstantiate : MonoBehaviour {

	private float timer = 5.0f;

	public GameObject enemy;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;

		if (timer < 0) {
			Instantiate (enemy, new Vector3 (Random.Range(-16f, 16f), 5f, Random.Range(-16f, 16f)), Quaternion.identity);
			timer = 5.0f;
		}
	}
}

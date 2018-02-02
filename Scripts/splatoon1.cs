using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class splatoon1 : MonoBehaviour {

	private float power = 700.0f;

	Rigidbody rbody;

	public GameObject particle;
	private GameObject enemy;

	void Awake (){
		enemy = GameObject.FindGameObjectWithTag("Enemy");
		rbody = GetComponent<Rigidbody> ();
	}

	void Start () {
		Destroy (gameObject, 3.0f);
		rbody.AddForce(transform.forward * power);
	}

	void OnCollisionEnter(Collision col){

		if (col.gameObject.tag == "Enemy") {
			Destroy (gameObject);
			Instantiate (particle, transform.position, transform.rotation);
			enemy.GetComponent<Enemy> ().life -= 100.0f;
		}
	}
}

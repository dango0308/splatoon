using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bom : MonoBehaviour {

	private float power = 1000.0f;

	public GameObject paint;
	public GameObject particle;

	Rigidbody rbody;

	private GameObject enemy;

	void Awake (){
		enemy = GameObject.FindGameObjectWithTag("Enemy");
		rbody = GetComponent<Rigidbody> ();
	}

	// Use this for initialization
	void Start () {
		Destroy (gameObject, 3.0f);
		rbody.AddForce(transform.forward * power);
	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "Stage") {
			Destroy (gameObject);
			GameObject obj = Instantiate (paint, transform.position, paint.transform.rotation);
			obj.transform.position = new Vector3 (obj.transform.position.x, 0.51f, obj.transform.position.z); 
		}

		if (col.gameObject.tag == "Enemy") {
			Destroy (gameObject);
			Instantiate (particle, transform.position, transform.rotation);
			enemy.GetComponent<Enemy> ().life -= 500.0f;
		}
	}
}

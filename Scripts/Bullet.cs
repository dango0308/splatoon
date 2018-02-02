using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
	
	private float power = 700.0f;

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
	
	// Update is called once per frame
	void Update () {
		//transform.Translate (Vector3.forward * power * Time.deltaTime);
	}

	void OnCollisionEnter(Collision col){
		//ステージに弾を当てたとき
		if (col.gameObject.tag == "Stage") {
			Destroy (gameObject);
			GameObject obj = Instantiate (paint, transform.position, paint.transform.rotation);
			obj.transform.position = new Vector3 (obj.transform.position.x, 0.51f, obj.transform.position.z); 
		}

		//敵に弾を当てたとき
		if (col.gameObject.tag == "Enemy") {
			Destroy (gameObject);
			Instantiate (particle, transform.position, transform.rotation);
			enemy.GetComponent<Enemy> ().life -= 100.0f;
		}
	}
}

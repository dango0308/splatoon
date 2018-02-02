using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PaintBullet : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//スケールをゼロに
		transform.localScale = Vector3.zero;

		//スケールの変化
		transform.DOScale (new Vector3(4f, 4f, 1f), 0.3f).OnComplete(() => transform.DOScale(new Vector3(3.5f, 3.5f, 1f), 0.3f));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

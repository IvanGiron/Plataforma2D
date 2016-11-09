using UnityEngine;
using System.Collections;

public class Moneda : MonoBehaviour {
	Rigidbody2D rigi;
	// Use this for initialization
	void Start () {
		rigi = GetComponent<Rigidbody2D>();
		Destroy (gameObject, 3); // sE DESTRUYE A LOS 3 SEGUNDOS
		rigi.AddForce (new Vector2(Random.Range(-100, 100),100));
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Player") {
			Destroy (gameObject, 1); // Se destruye a 1 segundo de tocarla
			Random.Range(0,10);
		}
	}
}

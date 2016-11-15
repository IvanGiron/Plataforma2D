using UnityEngine;
using System.Collections;

public class checkpoint : MonoBehaviour {
	
	private gameControlScript gameCS;
	// Use this for initialization
	void Start () {
		gameCS = GameObject.Find ("GameControl").GetComponent<gameControlScript>();//buscar el objeto que tiene el script y cogemos su script
	}
	void OnTriggerEnter2D(Collider2D objeto){
		if (objeto.tag == "Player") {
			gameCS.checkpoint (transform.position);
		}
	
}

}

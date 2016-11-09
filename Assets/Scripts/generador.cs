using UnityEngine;
using System.Collections;

public class generador : MonoBehaviour {
	public GameObject moneda;
	private GameObject monedaNueva;
	// Use this for initialization

	void OnTriggerEnter2D(Collider2D objeto){
		if (objeto.tag == "Player" && monedaNueva == null) {
			//Instantiate (moneda, transform.position, transform.rotation); // genero Moneda en el mismo sitio de donde esta el collider
			monedaNueva = (GameObject)Instantiate (moneda, transform.position, transform.rotation);
		}
	}
}

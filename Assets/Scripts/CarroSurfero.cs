using UnityEngine;
using System.Collections;

public class CarroSurfero : MonoBehaviour {
	private DistanceJoint2D conector;

	// Use this for initialization
	void Start () {
		conector = GetComponent<DistanceJoint2D>();
	}
	
	// Update is called once per frame
	void Update () {
		

	}

	void OnTriggerStay2D(Collider2D objeto){
		if (objeto.tag == "Player") {


			conector.enabled = true;
		}
	}

	void OnTriggerExit2D(Collider2D objeto){
		if (objeto.tag == "Player") {
			
			conector.enabled = false;
		}
	}


}



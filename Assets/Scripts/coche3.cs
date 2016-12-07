using UnityEngine;
using System.Collections;

public class coche3 : MonoBehaviour {
	
	// Definimos una variable para meter dentro el componente WheelJoint2D
	WheelJoint2D union_rueda; 
	JointMotor2D motor;
	public float aceleracion = 15f;
	private Rigidbody2D rb;
	public float velocidad = 5f;


	void Start () {
		//Metemos la información del componente WheelJoint2D en la variable
		union_rueda = GetComponent<WheelJoint2D> ();
		motor = union_rueda.motor; 
		rb = GetComponent<Rigidbody2D> ();
		union_rueda.motor = motor;

	}

	void Update () {



	}
	void OnTriggerEnter2D(Collider2D objeto){
		if (objeto.tag == "Pared") {
			motor.motorSpeed = 1000f;
			union_rueda.motor = motor;
		} 
		if (objeto.tag == "ParedRebote") {
			motor.motorSpeed = -1000f;
			union_rueda.motor = motor;
		} 
	}




}
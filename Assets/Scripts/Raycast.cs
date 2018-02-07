using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Raycast : MonoBehaviour {

	// Update is called once per frame
	void Update () {

		RaycastHit hit;
		float theDistance;

		Vector3 forward = transform.TransformDirection (Vector3.forward) * 50;
		Debug.DrawRay (transform.position, forward, Color.green);

		if (Physics.Raycast (transform.position, (forward), out hit)) {
			theDistance = hit.distance;
			hit.collider.gameObject.GetComponent <NavMeshAgent> ().enabled = false;

		} else
			hit.collider.gameObject.GetComponent <NavMeshAgent> ().enabled = true;
		
	}
}

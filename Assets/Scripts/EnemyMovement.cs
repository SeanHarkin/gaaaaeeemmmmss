	using UnityEngine;
	using UnityEngine.UI;
	using System.Collections;
	using UnityEngine.AI;

	public class EnemyMovement : MonoBehaviour
{

	GameObject Player;
	public float speed = 1f;
	Transform player;             
	NavMeshAgent nav;             
		


		void Awake ()
	{
			player = GameObject.FindGameObjectWithTag ("Player").transform;
			nav = GetComponent <NavMeshAgent> ();
	}



	void Update ()
	{
		nav.SetDestination (player.position);

	}
}

	



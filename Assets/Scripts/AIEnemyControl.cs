using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

//memastikan apakah component NavMeshAgent yang dibutuhkan sudah terdapat di inspector, sebelum menambahkan script tersebut ke GameObject tersebut
[RequireComponent(typeof (UnityEngine.AI.NavMeshAgent))]

public class AIEnemyControl : MonoBehaviour {

	public UnityEngine.AI.NavMeshAgent agent { get; private set; }
	public float speed;
	GameObject target;

	// Use this for initialization
	void Start () {
		//mamanggl komponen navmeshagent
		agent = GetComponentInChildren<NavMeshAgent> ();

		//memanggil gameobject yang memiliki tag player
		target = GameObject.FindGameObjectWithTag ("Player");

		//mengaktifkan pergerakan dan perputaran dari nav mesh agent
		agent.updateRotation = true;
		agent.speed = speed;
		agent.updatePosition = true;
	}
	
	// Update is called once per frame
	void Update () {
		//meletakan agent.setDestination di function update karena untuk posisi playerfps sebagai target dapat berubah-ubah. sehingga monster akan mengejarnya
		if (target != null) {
			agent.SetDestination (target.transform.position);
		}
	}
}

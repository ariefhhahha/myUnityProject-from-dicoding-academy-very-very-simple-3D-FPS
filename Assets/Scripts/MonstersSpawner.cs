using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonstersSpawner : MonoBehaviour {

	//objek yang akan dimunculkan
	public GameObject monster;

	// Use this for initialization
	void Start () {
		StartCoroutine (StartSpawning ());
	}
		
	IEnumerator StartSpawning(){
		//menjeda proses antara 5 sampai 7 detik
		yield return new WaitForSeconds (Random.Range (5f, 7f));

		//memunculkan monster
		Instantiate (monster, transform.position, Quaternion.identity);

		//malakukan pengulangan
		StartCoroutine (StartSpawning ());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed;

	public GameObject ball;
	public GameObject titikLontar;
	public float powerLontar;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//menggerakan objek.
		//"vertical" buat input W atau S atau panah atas atau bawah
		//speed buat ngatur kecepatan
		//time.deltatime selisih waktu ketika function update() terakhir dijalankan dan attribute tersebut digunakan, jadi gerakannya stabil
		transform.Translate (0, 0, Input.GetAxis ("Vertical") * speed * Time.deltaTime); 

		//transform, muterin objek berdasarkan sumbu x,y,z
		//"horizontal" buat input A atau D atau panah kanan kiri
		transform.Rotate (0, Input.GetAxis ("Horizontal") * 60 * Time.deltaTime, 0);

		//pas neken spasi
		//gameobject.instantiate(objek, posisi, rotasi) menciptakan objek ke dalam scene
		//_bal.get bla bla bla. mendorong objek
		//_ball.transform bla bla bla. memberi arah kepada objek berdasarkan sumbu Z. Right X. Up Y. untuk sebaliknya bisa forward * -1f
		if (Input.GetKeyDown (KeyCode.Space)) {
			GameObject _ball = GameObject.Instantiate (ball, titikLontar.transform.position, titikLontar.transform.rotation);
			_ball.GetComponent<Rigidbody> ().AddForce (_ball.transform.forward * powerLontar);
			GameObject.Destroy (_ball, 5);
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunLighting : MonoBehaviour {

	//buat nyimpen percepatan waktu buat periode siang dan malam
	public float speedRotationSun;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		//perputaran siang dan malam mebutuhkan 360 derajat. nah jadi tiap 1 detik nambah 1 derajat si mataharinya
		float angle = Time.deltaTime * speedRotationSun;
		transform.RotateAround (transform.position, Vector3.forward, angle);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotatation : MonoBehaviour {

	[SerializeField]
	float speed = 0;


	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.up * speed * Time.deltaTime);
	}
}

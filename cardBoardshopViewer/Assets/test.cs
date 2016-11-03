using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.forward * 20 * Time.deltaTime);
	}
}

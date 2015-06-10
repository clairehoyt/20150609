using UnityEngine;
using System.Collections;

public class Logic : MonoBehaviour {
		//public GameObject cube;
		public GameObject controlcube;

	// Use this for initialization
	void Start () {
				//cube.SetActive (false);
				controlcube.GetComponent<ControlCube> ().HideCube ();
				controlcube.GetComponent<ControlCube> ().WaitShow ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

using UnityEngine;
using System.Collections;

public class ControlCube : MonoBehaviour {
		public GameObject cube;
	// Use this for initialization
	void Start () {
				ShowCube ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
		public void HideCube()
		{
				cube.SetActive (false);
		}
		public void ShowCube()
		{
				cube.SetActive (true);
		}
}

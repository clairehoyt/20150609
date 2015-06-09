using UnityEngine;
using System.Collections;

public class ClickCube : MonoBehaviour {
		public GameObject cube;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
		void OnMouseDown()
		{
				//Debug.Log ("click cube");
				cube.SetActive (false);

		}
}

using UnityEngine;
using System.Collections;

public class flight : MonoBehaviour {
	public virtual void OnMouseEnter()
	{
		StaticVars.gameScore++;
		Object.Destroy (this.gameObject);
	}

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

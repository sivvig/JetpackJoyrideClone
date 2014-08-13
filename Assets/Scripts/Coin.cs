using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {

    public int value;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        gameObject.renderer.enabled = false;
    }
}
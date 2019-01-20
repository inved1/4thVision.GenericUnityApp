using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class invRotate : MonoBehaviour {


    /// <summary>
    /// The speed factor
    /// </summary>
    public float SpeedRotation = 100f;

    public bool allowRotation = false;

    /// <summary>
    /// 
    /// </summary>
    [Inject]
    DiContainer _container;

	// Use this for initialization
	void Start () {
		
	}



    public void toggleRotation()
    {
        this.allowRotation = !this.allowRotation;
        Debug.Log(_container.Resolve<Greeter>().Counter());
    }
	
	// Update is called once per frame
	void Update () {
        if (allowRotation) { 
            this.transform.Rotate(Vector3.up * SpeedRotation * Time.deltaTime);
        }
    }
}

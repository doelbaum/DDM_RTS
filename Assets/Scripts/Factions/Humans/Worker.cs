using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Worker : Unit {

    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

public struct MinedResource
{
    string m_Name;
    int m_Amount;

    MinedResource(string resourceName, int resourceAmount)
    {
        m_Name = resourceName;
        m_Amount = resourceAmount;
    }
}

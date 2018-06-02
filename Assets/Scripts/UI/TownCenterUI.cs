using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TownCenterUI : UIDisplay
{

    public GameObject m_UnitListContainer;

    public GameObject m_UnitCreationButton;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public override void Init()
    {
        GameObject tmp = Instantiate(m_UnitCreationButton, m_UnitListContainer.transform);
        tmp.GetComponent<UnitCreationButton>().NameButton("Worker");
    }
}

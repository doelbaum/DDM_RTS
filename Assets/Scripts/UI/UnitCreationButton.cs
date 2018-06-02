using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnitCreationButton : MonoBehaviour {

    public Button m_Button;
    string m_UnitName;
    public Text m_Text;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void NameButton(string newName)
    {
        m_Text.text = newName;
        m_UnitName = newName;
    }

    public void CreateUnit()
    {
        //UnitCreator.CreatUnit(m_Name);
    }
}

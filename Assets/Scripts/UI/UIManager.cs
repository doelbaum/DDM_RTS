using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour {

    public GameObject MasterUIObject;
    public GameObject[] UIScreens;


	// Use this for initialization
	void Start () {
        GetUIScreens();
        TestPopulateTownCenter();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void BuildingSelected(string buildingName)
    {
        bool buildingFound = false;

        for(int i = 0; i < UIScreens.Length; i++)
        {
            if(UIScreens[i].name == buildingName)
            {
                buildingFound = true;
                UIScreens[i].SetActive(true);
            }
            else
            {
                UIScreens[i].SetActive(false);
            }
        }

        if (!buildingFound)
        {
            Debug.Log("Could not find the building you were looking for whaaaaaat");
        }
    }

    void GetUIScreens()
    {

        UIScreens = new GameObject[MasterUIObject.transform.childCount];

        for(int i = 0; i < UIScreens.Length; i++)
        {
            UIScreens[i] = MasterUIObject.transform.GetChild(i).gameObject;
        }
    }

    public void TestPopulateTownCenter()
    {
        for(int i=0; i < UIScreens.Length; i++)
        {
            UIScreens[i].GetComponent<UIDisplay>().Init();
        }
    }


}

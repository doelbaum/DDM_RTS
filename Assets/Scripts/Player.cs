using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    Camera m_Camera;
    public GameObject m_SelectedObject;
    CameraControl m_CameraControl;

	// Use this for initialization
	void Start () {
        Cursor.visible = true;
        m_Camera = Camera.main;
        m_CameraControl = gameObject.AddComponent<CameraControl>();
	}
	
	// Update is called once per frame
	void Update () {

        RaycastHit hit;
        Ray ray = m_Camera.ScreenPointToRay(Input.mousePosition);
        int mask = 1 << LayerMask.NameToLayer("Unit");
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out hit, 100f, mask))
            {
                m_SelectedObject = hit.transform.gameObject;
            }else
            {
                m_SelectedObject = null;
            }
            //Debug.DrawRay()
        }
        else if (Input.GetMouseButtonDown(1))
        {
            if (m_SelectedObject != null)
            {
                EvaluateMouseClick(ray);
            }
        }
	}

    void EvaluateMouseClick(Ray ray)
    {
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if(hit.transform.gameObject.layer == LayerMask.NameToLayer("Terrain")){
                m_SelectedObject.GetComponent<Unit>().MoveTo(hit.point);
            }
            else
            {
                m_SelectedObject.GetComponent<Unit>().MoveTo(hit.transform.gameObject);
            }
        }
            
    }

}

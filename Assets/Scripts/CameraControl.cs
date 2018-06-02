using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

    Camera m_Camera;

    public float m_CamScrollSpeed = 1f;
    public float m_EdgeOffset = 20f;

    Vector3 m_MoveLeft;
    Vector3 m_MoveRight;
    Vector3 m_MoveUp;
    Vector3 m_MoveDown;

    // Use this for initialization
    void Start () {
        m_Camera = Camera.main;
        m_MoveLeft = new Vector3(0, 0, 1);
        m_MoveRight = new Vector3(0, 0, -1);
        m_MoveUp = new Vector3(1, 0, 0);
        m_MoveDown = new Vector3(-1, 0, 0);
    }
	
	// Update is called once per frame
	void Update () {
        if (MouseIsOnScreen())
        {
            if (Input.mousePosition.x <= 0 + m_EdgeOffset)
            {
                m_Camera.transform.position += (m_MoveLeft * m_CamScrollSpeed);
            }

            if (Input.mousePosition.x >= Screen.width - m_EdgeOffset)
            {
                m_Camera.transform.position += (m_MoveRight * m_CamScrollSpeed);
            }

            if (Input.mousePosition.y <= 0 + m_EdgeOffset)
            {
                m_Camera.transform.position += (m_MoveDown * m_CamScrollSpeed);
            }

            if (Input.mousePosition.y >= Screen.height - m_EdgeOffset)
            {
                m_Camera.transform.position += (m_MoveUp * m_CamScrollSpeed);
            }
        }
	}

    bool MouseIsOnScreen()
    {
        if(Input.mousePosition.x < 0 || Input.mousePosition.x > Screen.width || Input.mousePosition.y < 0 || Input.mousePosition.y > Screen.height)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}

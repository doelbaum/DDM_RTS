using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour {

    //General stuff
    public UnitState m_CurrentState;
    public string m_UnitName;

    //Moving Stuff
    public float speed;
    Vector3 m_Destination;
    GameObject m_destinationObject = null;

    // Use this for initialization
    void Start () {
        m_CurrentState = UnitState.IDLE;
	}

    // Update is called once per frame
    void Update() {
        switch (m_CurrentState)
        {
            case UnitState.MOVING:
                {
                    MoveUnit();
                    break;
                }
        }
    }
	

    void MoveUnit()
    {
        Vector3 endPoint;

        if (m_destinationObject)
        {
            endPoint = m_destinationObject.transform.position;
        }
        else
        {
            endPoint = m_Destination;
        }

        endPoint.y = transform.position.y;

        Vector3 movementDirection = (endPoint - transform.position).normalized;

        Vector3 potentialPosition = transform.position + (movementDirection * Time.deltaTime * speed);

        Quaternion lookAt = Quaternion.LookRotation(movementDirection);

        transform.rotation = lookAt;

        if ((potentialPosition - transform.position).sqrMagnitude < (endPoint - transform.position).sqrMagnitude)
        {
            transform.position = potentialPosition;
        }else
        {
            transform.position = endPoint;
            if (m_destinationObject)
            {
                m_destinationObject = null;
            }
            ChangeState(UnitState.IDLE);
        } 
    }

    void ChangeState(UnitState newState)
    {
        switch (newState)
        {
            case UnitState.MOVING:
                {
                    switch (m_CurrentState)
                    {
                        //Code
                    }
                    break;
                }
        }
        m_CurrentState = newState;
    }

    public void MoveTo(Vector3 newLoc)
    {
        m_Destination = newLoc;
        ChangeState(UnitState.MOVING);
    }

    public void MoveTo(GameObject destObject)
    {
        m_destinationObject = destObject;
        ChangeState(UnitState.MOVING);
    }

    public virtual void Interact()
    {

    }
}

public enum UnitState
{
    MOVING,
    IDLE
}

using System;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ScrollBarIncrementer : MonoBehaviour
{
    public Scrollbar Target;
    public Button TheOtherButton;
    public float Step = 0.1f;
    public bool isIncrementer;
    bool isMouseHovering = false;
    public bool isUpDown = true;

    private void Update()
    {
        if (isUpDown)
        {
            if (isMouseHovering)
            {
                if (isIncrementer)
                {
                    Increment();
                }
                else
                {
                    Decrement();
                }
            }
        }
        else
        {
            if (isMouseHovering)
            {
                if (isIncrementer)
                {
                    ToTheRight();
                }
                else
                {
                    TotheLeft();
                }
            }
        }
    }


    public void Increment()
    {
        if (Target == null || TheOtherButton == null) throw new Exception("Setup ScrollbarIncrementer first!");
        Target.value = Mathf.Clamp(Target.value + Step, 0, 1);
        GetComponent<Button>().interactable = Target.value != 1;
        TheOtherButton.interactable = true;
    }

    public void Decrement()
    {
        if (Target == null || TheOtherButton == null) throw new Exception("Setup ScrollbarIncrementer first!");
        Target.value = Mathf.Clamp(Target.value - Step, 0, 1);
        GetComponent<Button>().interactable = Target.value != 0; ;
        TheOtherButton.interactable = true;
    }

    public void TotheLeft()
    {
        if (Target == null || TheOtherButton == null) throw new Exception("Setup ScrollbarIncrementer first!");
        Target.value = Mathf.Clamp(Target.value + Step, 1, 0);
        GetComponent<Button>().interactable = Target.value != 1;
        TheOtherButton.interactable = true;
    }

    public void ToTheRight()
    {
        if (Target == null || TheOtherButton == null) throw new Exception("Setup ScrollbarIncrementer first!");
        Target.value = Mathf.Clamp(Target.value - Step, 1, 0);
        GetComponent<Button>().interactable = Target.value != 0; ;
        TheOtherButton.interactable = true;
    }


    public void SetMouseHover(bool setVal)
    {
        isMouseHovering = setVal;
    }
}

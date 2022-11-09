using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTriggerExamle : MonoBehaviour
{
   public void OnPointerEnter()
    {
        Debug.Log("OnPointerEnter");
    }

    public void OnPointerUp()
    {
        Debug.Log("OnPointerUp");
    }
    public void OnPointerDown()
    {
        Debug.Log("OnPointerDown");
    }
    public void OnPointerExit()
    {
        Debug.Log("OnPointerExit");
    }
}

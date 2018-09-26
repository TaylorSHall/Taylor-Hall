using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEventBehavior : MonoBehaviour
{
    public UnityEvent Enable;
    public UnityEvent Trigger;
    
    void OnEnable()
    {
        Enable.Invoke(); //Invoke calls the method
    } //block declares the method

    void OnTriggerEnter()
    {
        Trigger.Invoke();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

// WHEN IN DOUBT, MAKE EVERYTHING PUBLIC

public class WhatCanSeeIt : ScriptableObject
{
    private float health; //private and accessible to this OBJECT only
    protected float PowerLevel;
    public float EnergyLevel;

    private void AddHealth() //private because
    {
        health += 100;
    }

    protected void AddPower() //protected because 
    {
        AddHealth();
    }

    public void AddEnergy() //public because
    {
        
    }

}

public class ICanSeeIt : MonoBehaviour//This means this class can see 
{
    private WhatCanSeeIt newObject;

    private void Start()
    {
        newObject.EnergyLevel = 100;
        newObject.AddEnergy();
        //the predictive window cannot see AddHealth because it is protected
    }
}

public class Child : WhatCanSeeIt
{
    void CallThings()
    {
        //health cannot be called because private
        PowerLevel = 200; //this can be called because protected
        EnergyLevel = 300;
        AddPower();
        AddEnergy();
        //AddHealth cannot be called either because also private
    }
}
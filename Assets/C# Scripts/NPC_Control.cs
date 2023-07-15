using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract class NPC_Control : MonoBehaviour
{   
    public float time;

    public abstract void Start();

    // Update is called once per frame
    public abstract void Update();
    
    
}

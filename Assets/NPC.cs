using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{   
    public float x; //x座標
    public float y; //y座標
    public string key;
    public bool emerge_flag;
    public bool flag = false;
    
    public NPC(float x, float y, string key) {
        this.x = x; 
        this.y = y;
        this.key = key;
    }
    // Update is called once per frame

    public void Update()
    {
       if(Input.GetKey(key)){
            Destroy(this.gameObject);
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Right_man : MonoBehaviour
{
    public void  Start()
    {
    }

    // Update is called once per frame
    public void Update()
    {
        if(Input.GetKey(KeyCode.D)){
            ScoreManager2.Instance.AddScore();
            Destroy(this.gameObject);
        }
    }
}

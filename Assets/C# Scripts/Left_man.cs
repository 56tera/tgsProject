using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Left_man : MonoBehaviour
{
    public void  Start()
    {
    }

    // Update is called once per frame
    public void Update()
    {
        if(Input.GetKey(KeyCode.A)){
            //スコア加算の処理
            ScoreManager2.Instance.AddScore();
            Destroy(this.gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Front_man : MonoBehaviour
{
    // Start is called before the first frame update

    public void  Start()
    {
        //float time
    }

    // Update is called once per frame
    public void Update()
    {
        //time += delta_time
        if(Input.GetKey(KeyCode.W)){
            //スコア加算の処理
            ScoreManager2.Instance.AddScore();
            Destroy(this.gameObject);
        }
    }
}

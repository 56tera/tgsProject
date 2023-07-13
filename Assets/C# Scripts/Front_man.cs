using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Front_man : NPC_Control
{
    // Start is called before the first frame update
    ScoreManager2 scoreManager2;

    public override void  Start()
    {
        scoreManager2 = GameObject.Find("ScoreManager2").GetComponent<ScoreManager2>();
    }

    // Update is called once per frame
    public override void Update()
    {
        if(Input.GetKey(KeyCode.W)){
            //スコア加算の処理
            scoreManager2.AddScore();
            Destroy(this.gameObject);
        }
    }
}

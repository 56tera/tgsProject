using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Front_man : NPC_Control
{
    // Start is called before the first frame update
    public override void  Start()
    {
        
    }

    // Update is called once per frame
    public override void Update()
    {
        if(Input.GetKey(KeyCode.W)){
            //スコア加算の処理
            Destroy(this.gameObject);
        }
    }
}

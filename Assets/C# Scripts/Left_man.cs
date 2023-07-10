using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Left_man : NPC_Control
{
    public override void  Start()
    {
        
    }

    // Update is called once per frame
    public override void Update()
    {
        if(Input.GetKey(KeyCode.A)){
            //スコア加算の処理
            Destroy(this.gameObject);
        }
    }
}

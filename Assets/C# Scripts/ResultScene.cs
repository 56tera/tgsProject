using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultScene : MonoBehaviour
{
    private bool flag;
    // Start is called before the first frame update
    void Start()
    {
        flag = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(flag){
            if(Input.GetKeyDown(KeyCode.Return)){
                ChangeScene();
            }
        }
        if(Input.anyKeyDown){
            flag = true;
        }
        
    }

    void ChangeScene()
    {
        MyHelper.MyLoadScene(MyHelper.MyScene.TitleScene);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("ChangeScene", 30f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ChangeScene()
    {
        MyHelper.MyLoadScene(MyHelper.MyScene.TitleScene);
    }
}

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class TitleScene : MonoBehaviour
{



    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            MyHelper.MyLoadScene(MyHelper.MyScene.MainScene);
        }
    }

    //void ChangeScene()
    //{
    //    MyHelper.MyLoadScene (MyHelper.MyScene.MainScene);
    //}
}
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class TitleScene : MonoBehaviour
{



    // Use this for initialization
    void Start()
    {
        Invoke("ChangeScene", 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            MyHelper.MyLoadScene(MyHelper.MyScene.RandomScene);
        }
    }

    //void ChangeScene()
    //{
    //    MyHelper.MyLoadScene (MyHelper.MyScene.MainScene);
    //}
}
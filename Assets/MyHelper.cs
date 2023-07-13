using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;


static public class MyHelper
{
    public enum MyScene { TitleScene, MainScene, RandomScene};
    public static MyScene scene;

    static Dictionary<string, MyScene> sceneDic = new Dictionary<string, MyScene> {
        {"TitleScene", MyScene.TitleScene},
        {"MainScene", MyScene.MainScene},
        {"RandomScene", MyScene.RandomScene},
    };

    //enumのシーンで取得したシーンをロード
    public static void MyLoadScene(MyScene scene)
    {

        SceneManager.LoadScene(sceneDic.FirstOrDefault(x => x.Value == scene).Key);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateRangeRandomPosition : MonoBehaviour
{
    [SerializeField]
    [Tooltip("正面方向の画像")]
    private GameObject PrefabF;
    [SerializeField]
    [Tooltip("左方向の画像")]
    private GameObject PrefabL;
    [SerializeField]
    [Tooltip("右方向の画像")]
    private GameObject PrefabR;
    [SerializeField]
    [Tooltip("正面方向用の座標")]
    private Transform rangeF;
    [SerializeField]
    [Tooltip("左方向用の座標")]
    private Transform rangeL;
    [SerializeField]
    [Tooltip("右方向用の座標")]
    private Transform rangeR;
    

    // 経過時間
    private float x, y, z;
    //private GameObject createPrefab;
    private float time;
    private int flag;
    private bool flag_front = false;
    private bool flag_left = false;
    private bool flag_right = false;

    // Update is called once per frame
    void Update()
    {
        // 前フレームからの時間を加算していく
        time = time + Time.deltaTime;
        flag = Random.Range(1, 100) % 3;

        // 約1秒置きにランダムに生成されるようにする。
        if(time > Random.Range(1.0f, 2.0f))
		{
            var parent = this.transform;
            switch(flag){
                case 0: //正面用
                    if(!flag_front){
                        x = rangeF.position.x;
                        y = rangeF.position.y;
                        z = 50;
                        Instantiate(PrefabF, new Vector3(x,y,z), Quaternion.identity, parent);
                        flag_front = true;
                    }
                    break;
                case 1: //左用
                    if(!flag_left){
                        x = rangeL.position.x;
                        y = rangeL.position.y;
                        z = 50; 
                        Instantiate(PrefabL, new Vector3(x,y,z), Quaternion.identity, parent);
                        flag_left = true;
                    }
                    break;
                case 2: //右用
                    if(!flag_right){
                        x = rangeR.position.x;
                        y = rangeR.position.y; 
                        z = 50;
                        Instantiate(PrefabR, new Vector3(x,y,z), Quaternion.identity, parent);
                        flag_right = true;
                    }
                    break;
            }

            
            // NPC npc = new NPC(x, y, key);
            // // NPC npc = NPC_clone.GetComponent<NPC>();
            // // npc.NPC(x, y, key);

            // 経過時間リセット
            time = 0f;
        }

        if(Input.GetKeyDown(KeyCode.W)){
            flag_front = false;
        }

        if(Input.GetKeyDown(KeyCode.A)){
            flag_left = false;
        }
        if(Input.GetKeyDown(KeyCode.D)){
            flag_right = false;
        }
    }
}

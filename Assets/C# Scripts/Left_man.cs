using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Left_man : NPC_Control
{
    [SerializeField]
    [Tooltip("爆発エフェクト")]
    private GameObject ExplosionPrefab;


    public override void  Start()
    {
        time = 0;
    }

    // Update is called once per frame
    public override void Update()
    {
        time = time + Time.deltaTime;
        if(Input.GetKey(KeyCode.A)){
            ScoreManager2.Instance.AddScore(time);
            Instantiate(ExplosionPrefab, this.transform.position, Quaternion.identity, this.transform.parent);
            Destroy(this.gameObject);
        }
    }
}

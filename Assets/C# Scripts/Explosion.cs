using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    private float time;
    // Start is called before the first frame update
    void Start()
    {
        time = 0;
    }

    // Update is called once per frame
    public void Update()
    {
        time += Time.deltaTime;
        if (time > 0.5f)
        {
            Destroy(this.gameObject);
        }
    }
}

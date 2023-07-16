using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Please : MonoBehaviour
{
    public Text resultText;
    // Start is called before the first frame update
    void Start()
    {
        resultText.text = "please any Key";
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKeyDown){
            resultText.text = "Return to skip";
        }
        
    }
}

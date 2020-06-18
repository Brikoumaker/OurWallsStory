using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMessage : MonoBehaviour
{

    public bool AnimationFinished;
    public GameObject SubScene1_1_1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (AnimationFinished == true)
        {
            SubScene1_1_1.GetComponent<LR_Interactions_1_1_1>().StartGame = true;
        }
    }
}

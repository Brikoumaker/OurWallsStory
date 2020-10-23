using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMessage : MonoBehaviour
{

    public bool AnimationFinished;
    public GameObject SubScene1_1_1;
    private LR_Interactions_1_1_1 interaction;

    // Start is called before the first frame update
    void Start()
    {
        interaction = SubScene1_1_1.GetComponent<LR_Interactions_1_1_1>();
    }

    // Update is called once per frame
    void Update()
    {
        if (AnimationFinished == true)
        {
            interaction.StartGame = true;
        }
    }
}

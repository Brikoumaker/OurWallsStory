using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockNextSubscene : MonoBehaviour
{
    public GameObject House;
    public int Act;
    public int Scene;
    public int SubScene;

    private Animator House_Animator;

    // Start is called before the first frame update
    void Start()
    {
        House_Animator = House.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
     

    }

    public void SetNext()
    {
        House_Animator.SetInteger("Act", Act);
        House_Animator.SetInteger("Scene", Scene);
        House_Animator.SetInteger("SubScene", SubScene);
    }
}

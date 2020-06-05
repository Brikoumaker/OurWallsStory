using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BE_Interactions_1_3_3 : MonoBehaviour
{

    public GameObject BedLamp1;
    public GameObject BedLamp2;
    public GameObject Window;
    public GameObject House;
    public bool AnimationFinished;

    private Animator BedLamp1_Animator;
    private Animator BedLamp2_Animator;
    private Animator Window_Animator;
    private Animator House_Animator;

    // Start is called before the first frame update
    void Start()
    {
        BedLamp1_Animator = BedLamp1.GetComponent<Animator>();
        BedLamp2_Animator = BedLamp2.GetComponent<Animator>();
        Window_Animator = Window.GetComponent<Animator>();
        House_Animator = House.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Collider2D BedLamp1Coll = BedLamp1.GetComponent<Collider2D>();
            Collider2D BedLamp2Coll = BedLamp2.GetComponent<Collider2D>();
            Collider2D WindowColl = Window.GetComponent<Collider2D>();

            if (BedLamp1Coll.OverlapPoint(MousePos))
            {
                BedLamp1_Animator.SetBool("BedLamp1_Activated", true);
            }

            if (BedLamp2Coll.OverlapPoint(MousePos))
            {
                BedLamp2_Animator.SetBool("BedLamp2_Activated", true);
            }

            if (WindowColl.OverlapPoint(MousePos))
            {
                Window_Animator.SetBool("Window_Activated", true);

            }
        }
    }
}

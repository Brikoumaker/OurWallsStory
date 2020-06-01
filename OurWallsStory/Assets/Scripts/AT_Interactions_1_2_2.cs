using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AT_Interactions_1_2_2 : MonoBehaviour
{

    public GameObject Web1;
    public GameObject Web2;
    public GameObject Portrait;
    public GameObject Mannikin;
    public GameObject House;
    public bool AnimationFinished;

    private Animator Web1_Animator;
    private Animator Web2_Animator;
    private Animator Portrait_Animator;
    private Animator Mannikin_Animator;
    private Animator House_Animator;


    // Start is called before the first frame update
    void Start()
    {
        Web1_Animator = Web1.GetComponent<Animator>();
        Web2_Animator = Web2.GetComponent<Animator>();
        Portrait_Animator = Portrait.GetComponent<Animator>();
        Mannikin_Animator = Mannikin.GetComponent<Animator>();
        House_Animator = House.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Collider2D Web1Coll = Web1.GetComponent<Collider2D>();
            Collider2D Web2Coll = Web2.GetComponent<Collider2D>();
            Collider2D PortraitColl = Portrait.GetComponent<Collider2D>();
            Collider2D MannikinColl = Mannikin.GetComponent<Collider2D>();

            if (Web1Coll.OverlapPoint(MousePos))
            {
                Web1_Animator.SetBool("Web1_Activated", true);
            }

            if (Web2Coll.OverlapPoint(MousePos))
            {
                Web2_Animator.SetBool("Web2_Activated", true);
            }

            if (PortraitColl.OverlapPoint(MousePos))
            {
                Portrait_Animator.SetBool("Portrait_Activated", true);
            }

            if (MannikinColl.OverlapPoint(MousePos))
            {
                Mannikin_Animator.SetBool("Mannikin_Activated", true);
            }


        }
    }
}

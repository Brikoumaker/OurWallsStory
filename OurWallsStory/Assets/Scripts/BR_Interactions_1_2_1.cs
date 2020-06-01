using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BR_Interactions_1_2_1 : MonoBehaviour
{

    public GameObject Bath;
    public GameObject Shower;
    public GameObject Plant;
    public GameObject Paint;
    public GameObject Mirror;
    public GameObject Machine;
    public GameObject Wall;
    public GameObject House;
    public bool AnimationFinished;

    private Animator Bath_Animator;
    private Animator Shower_Animator;
    private Animator Plant_Animator;
    private Animator Paint_Animator;
    private Animator Mirror_Animator;
    private Animator Machine_Animator;
    private Animator House_Animator;


    // Start is called before the first frame update
    void Start()
    {
        Bath_Animator = Bath.GetComponent<Animator>();
        Shower_Animator = Shower.GetComponent<Animator>();
        Plant_Animator = Plant.GetComponent<Animator>();
        Paint_Animator = Paint.GetComponent<Animator>();
        Mirror_Animator = Mirror.GetComponent<Animator>();
        Machine_Animator = Machine.GetComponent<Animator>();
        House_Animator = House.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (AnimationFinished == true)
        {
            House_Animator.SetInteger("SubScene", 2);
        }

        if (Input.GetMouseButtonDown(0))
        {
            Vector3 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Collider2D BathColl = Bath.GetComponent<Collider2D>();
            Collider2D ShowerColl = Shower.GetComponent<Collider2D>();
            Collider2D PlantColl = Plant.GetComponent<Collider2D>();
            Collider2D PaintColl = Paint.GetComponent<Collider2D>();
            Collider2D MirrorColl = Mirror.GetComponent<Collider2D>();
            Collider2D MachineColl = Machine.GetComponent<Collider2D>();

            if (BathColl.OverlapPoint(MousePos))
            {
                Bath_Animator.SetBool("Bath_Activated", true);
            }

            if (ShowerColl.OverlapPoint(MousePos))
            {
                Shower_Animator.SetBool("Shower_Activated", true);
            }

            if (PlantColl.OverlapPoint(MousePos))
            {
                Plant_Animator.SetBool("Plant_Activated", true);
            }

            if (PaintColl.OverlapPoint(MousePos))
            {
                Paint_Animator.SetBool("Paint_Activated", true);
                Wall.SetActive(true);
            }

            if (MirrorColl.OverlapPoint(MousePos))
            {
                Mirror_Animator.SetBool("Mirror_Activated", true);
            }

            if (MachineColl.OverlapPoint(MousePos))
            {
                Machine_Animator.SetBool("Machine_Activated", true);
            }


        }
    }
}

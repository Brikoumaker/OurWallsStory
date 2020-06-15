using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LR2_Interactions_1_1_2 : MonoBehaviour
{
    public GameObject LampA;
    public GameObject LampB;
    public GameObject TV;
    public GameObject Carpet;
    public GameObject Table;
    public GameObject Shoes;
    public GameObject Hanger;
    public GameObject House;
    public GameObject Stairs;
    public GameObject Curtain1;
    public GameObject Curtain2;
    public GameObject Keys;
    public GameObject Canvas;
    public bool AnimationFinished;

    private Animator LampA_Animator;
    private Animator LampB_Animator;
    private Animator TV_Animator;
    private Animator Carpet_Animator;
    private Animator Table_Animator;
    private Animator Shoes_Animator;
    private Animator Hanger_Animator;
    private Animator House_Animator;
    private bool PauseActivated;

    // Start is called before the first frame update
    void Start()
    {
        LampA_Animator = LampA.GetComponent<Animator>();
        LampB_Animator = LampB.GetComponent<Animator>();
        TV_Animator = TV.GetComponent<Animator>();
        Carpet_Animator = Carpet.GetComponent<Animator>();
        Table_Animator = Table.GetComponent<Animator>();
        Shoes_Animator = Shoes.GetComponent<Animator>();
        Hanger_Animator = Hanger.GetComponent<Animator>();
        House_Animator = House.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        PauseActivated = Canvas.GetComponent<Pause_Menu>().PauseActivated;

        if (AnimationFinished == true)
        {
            House_Animator.SetInteger("SubScene", 1);
            House_Animator.SetInteger("Scene", 2);
            AnimationFinished = false;
        }
        if ((Input.GetMouseButtonDown(0)) && (PauseActivated == false))
        {
            Vector3 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 CamPos = Camera.main.transform.position;
            Collider2D LampAColl = LampA.GetComponent<Collider2D>();
            Collider2D LampBColl = LampB.GetComponent<Collider2D>();
            Collider2D TVColl = TV.GetComponent<Collider2D>();
            Collider2D CarpetColl = Carpet.GetComponent<Collider2D>();
            Collider2D TableColl = Table.GetComponent<Collider2D>();
            Collider2D ShoesColl = Shoes.GetComponent<Collider2D>();
            Collider2D HangerColl = Hanger.GetComponent<Collider2D>();
            Collider2D KeysColl = Keys.GetComponent<Collider2D>();
            Collider2D Curtain1Coll = Curtain1.GetComponent<Collider2D>();
            Collider2D Curtain2Coll = Curtain2.GetComponent<Collider2D>();
            Collider2D StairsColl = Stairs.GetComponent<Collider2D>();

            if (LampAColl.OverlapPoint(MousePos))
            {
                LampA_Animator.SetBool("Lampe2A_Activated", true);
            }

            if (LampBColl.OverlapPoint(MousePos))
            {
                LampB_Animator.SetBool("LampB_Activated", true);
            }

            if (TVColl.OverlapPoint(MousePos))
            {
                TV_Animator.SetBool("TV_Activated", true);
            }

            if (CarpetColl.OverlapPoint(MousePos))
            {
                Carpet_Animator.SetBool("Carpet_Activated", true);
            }

            if (TableColl.OverlapPoint(MousePos))
            {
                Table_Animator.SetBool("Table_Activated", true);
            }

            if (ShoesColl.OverlapPoint(MousePos))
            {
                Shoes_Animator.SetBool("Shoes_Activated", true);
            }

            if (HangerColl.OverlapPoint(MousePos))
            {
                Hanger_Animator.SetBool("Hanger_Activated", true);
            }

            if (KeysColl.OverlapPoint(MousePos))
            {
                FMODUnity.RuntimeManager.PlayOneShot("event:/SFX_Touch/SFX_Keys_Touch", CamPos);
            }

            if ((Curtain1Coll.OverlapPoint(MousePos)) || (Curtain2Coll.OverlapPoint(MousePos)))
            {
                FMODUnity.RuntimeManager.PlayOneShot("event:/SFX_Touch/SFX_Curtains_Touch", CamPos);
            }

            if (StairsColl.OverlapPoint(MousePos))
            {
                FMODUnity.RuntimeManager.PlayOneShot("event:/SFX_Touch/SFX_Stairs_Touch", CamPos);
            }

        }


        }
}

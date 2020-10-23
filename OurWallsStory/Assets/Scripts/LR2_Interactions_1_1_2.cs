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

    private Pause_Menu menuPause;

    private Camera cam;

    private int Scene = Animator.StringToHash("Scene");
    private int SubScene = Animator.StringToHash("SubScene");
    private int Lampe2A_Activated = Animator.StringToHash("Lampe2A_Activated");
    private int LampB_Activated = Animator.StringToHash("LampB_Activated");
    private int TV_Activated = Animator.StringToHash("TV_Activated");
    private int Carpet_Activated = Animator.StringToHash("Carpet_Activated");
    private int Table_Activated = Animator.StringToHash("Table_Activated");
    private int Shoes_Activated = Animator.StringToHash("Shoes_Activated");
    private int Hanger_Activated = Animator.StringToHash("Hanger_Activated");

    private Collider2D LampAColl;
    private Collider2D LampBColl;
    private Collider2D TVColl;
    private Collider2D CarpetColl;
    private Collider2D TableColl;
    private Collider2D ShoesColl;
    private Collider2D HangerColl;
    private Collider2D KeysColl;
    private Collider2D Curtain1Coll;
    private Collider2D Curtain2Coll;
    private Collider2D StairsColl;

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
        menuPause = Canvas.GetComponent<Pause_Menu>();
        cam = Camera.main;
        LampAColl = LampA.GetComponent<Collider2D>();
        LampBColl = LampB.GetComponent<Collider2D>();
        TVColl = TV.GetComponent<Collider2D>();
        CarpetColl = Carpet.GetComponent<Collider2D>();
        TableColl = Table.GetComponent<Collider2D>();
        ShoesColl = Shoes.GetComponent<Collider2D>();
        HangerColl = Hanger.GetComponent<Collider2D>();
        KeysColl = Keys.GetComponent<Collider2D>();
        Curtain1Coll = Curtain1.GetComponent<Collider2D>();
        Curtain2Coll = Curtain2.GetComponent<Collider2D>();
        StairsColl = Stairs.GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {

        PauseActivated = menuPause.PauseActivated;

        if (AnimationFinished == true)
        {
            House_Animator.SetInteger(SubScene, 1);
            House_Animator.SetInteger(Scene, 2);
            AnimationFinished = false;
        }
        if ((Input.GetMouseButtonDown(0)) && (PauseActivated == false))
        {
            Vector3 MousePos = cam.ScreenToWorldPoint(Input.mousePosition);
            Vector3 CamPos = cam.transform.position;
            

            if (LampAColl.OverlapPoint(MousePos))
            {
                LampA_Animator.SetBool(Lampe2A_Activated, true);
            }

            else if (LampBColl.OverlapPoint(MousePos))
            {
                LampB_Animator.SetBool(LampB_Activated, true);
            }

            else if (TVColl.OverlapPoint(MousePos))
            {
                TV_Animator.SetBool(TV_Activated, true);
            }

            else if (CarpetColl.OverlapPoint(MousePos))
            {
                Carpet_Animator.SetBool(Carpet_Activated, true);
            }

            else if (TableColl.OverlapPoint(MousePos))
            {
                Table_Animator.SetBool(Table_Activated, true);
            }

            else if (ShoesColl.OverlapPoint(MousePos))
            {
                Shoes_Animator.SetBool(Shoes_Activated, true);
            }

            else if (HangerColl.OverlapPoint(MousePos))
            {
                Hanger_Animator.SetBool(Hanger_Activated, true);
            }

            else if (KeysColl.OverlapPoint(MousePos))
            {
                FMODUnity.RuntimeManager.PlayOneShot("event:/SFX_Touch/SFX_Keys_Touch", CamPos);
            }

            else if ((Curtain1Coll.OverlapPoint(MousePos)) || (Curtain2Coll.OverlapPoint(MousePos)))
            {
                FMODUnity.RuntimeManager.PlayOneShot("event:/SFX_Touch/SFX_Curtains_Touch", CamPos);
            }

            else if (StairsColl.OverlapPoint(MousePos))
            {
                FMODUnity.RuntimeManager.PlayOneShot("event:/SFX_Touch/SFX_Stairs_Touch", CamPos);
            }

        }


        }
}

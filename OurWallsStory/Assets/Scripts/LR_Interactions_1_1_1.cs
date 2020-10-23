using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LR_Interactions_1_1_1 : MonoBehaviour
{
    public GameObject Curtains;
    public GameObject Keys;
    public GameObject Lamp;
    public GameObject House;
    public GameObject Curtain1;
    public GameObject Curtain2;
    public GameObject Stairs;
    public GameObject Canvas;
    public bool AnimationFinished;
    public bool StartGame;

    private Animator SubScene_Animator;
    private Animator Keys_Animator;
    private Animator House_Animator;
    private bool PauseActivated;

    private bool KeysOnce;

    private Camera cam;

    private Collider2D CurtainsColl;
    private Collider2D KeysColl;
    private Collider2D LampColl ;
    private Collider2D Curtain1Coll ;
    private Collider2D Curtain2Coll ;
    private Collider2D StairsColl;

    private Pause_Menu menuPause;

    private int SubScene = Animator.StringToHash("SubScene");
    private int Curtains_Activated = Animator.StringToHash("Curtains_Activated");
    private int Keys_Activated = Animator.StringToHash("Keys_Activated");
    private int Lamp_Activated = Animator.StringToHash("Lamp_Activated");

    // Start is called before the first frame update
    void Start()
    {
        SubScene_Animator = GetComponent<Animator>();
        Keys_Animator = Keys.GetComponent<Animator>();
        House_Animator = House.GetComponent<Animator>();
        cam = Camera.main;
        CurtainsColl = Curtains.GetComponent<Collider2D>();
        KeysColl = Keys.GetComponent<Collider2D>();
        LampColl = Lamp.GetComponent<Collider2D>();
        Curtain1Coll = Curtain1.GetComponent<Collider2D>();
        Curtain2Coll = Curtain2.GetComponent<Collider2D>();
        StairsColl = Stairs.GetComponent<Collider2D>();
        menuPause = Canvas.GetComponent<Pause_Menu>();

    }

    // Update is called once per frame
    void Update()
    {

        PauseActivated = menuPause.PauseActivated;
        


        if (AnimationFinished == true)
        {
            House_Animator.SetInteger(SubScene, 2);
            AnimationFinished = false;
        }

        if ((Input.GetMouseButtonDown(0)) && (PauseActivated == false) && (StartGame == true))
        {
            Vector3 MousePos = cam.ScreenToWorldPoint(Input.mousePosition);
            Vector3 CamPos = cam.transform.position;


            if (CurtainsColl.OverlapPoint(MousePos))
            {
                SubScene_Animator.SetBool(Curtains_Activated, true);
                House_Animator.SetInteger(SubScene, 1);
            }

            else if (KeysColl.OverlapPoint(MousePos))
            {
                Keys_Animator.SetBool(Keys_Activated, true);
                if (KeysOnce == true)
                {
                    FMODUnity.RuntimeManager.PlayOneShot("event:/SFX_Touch/SFX_Keys_Touch", CamPos);
                }
                KeysOnce = true;
            }

            else if(LampColl.OverlapPoint(MousePos))
            {
                SubScene_Animator.SetBool(Lamp_Activated, true);
            }

            else if((Curtain1Coll.OverlapPoint(MousePos)) || (Curtain2Coll.OverlapPoint(MousePos)))
            {
                FMODUnity.RuntimeManager.PlayOneShot("event:/SFX_Touch/SFX_Curtains_Touch", CamPos);
            }

            else if(StairsColl.OverlapPoint(MousePos))
            {
                FMODUnity.RuntimeManager.PlayOneShot("event:/SFX_Touch/SFX_Stairs_Touch", CamPos);
            }

        }
    }
}

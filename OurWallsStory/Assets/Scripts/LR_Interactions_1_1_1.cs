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

    private Animator SubScene_Animator;
    private Animator Keys_Animator;
    private Animator House_Animator;
    private bool PauseActivated;

    private bool KeysOnce;


    // Start is called before the first frame update
    void Start()
    {
        SubScene_Animator = GetComponent<Animator>();
        Keys_Animator = Keys.GetComponent<Animator>();
        House_Animator = House.GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {

        PauseActivated = Canvas.GetComponent<Pause_Menu>().PauseActivated;

        if (AnimationFinished == true)
        {
            House_Animator.SetInteger("SubScene", 2);
            AnimationFinished = false;
        }

        if ((Input.GetMouseButtonDown(0)) && (PauseActivated == false))
        {
            Vector3 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 CamPos = Camera.main.transform.position;
            Collider2D CurtainsColl = Curtains.GetComponent<Collider2D>();
            Collider2D KeysColl = Keys.GetComponent<Collider2D>();
            Collider2D LampColl = Lamp.GetComponent<Collider2D>();
            Collider2D Curtain1Coll = Curtain1.GetComponent<Collider2D>();
            Collider2D Curtain2Coll = Curtain2.GetComponent<Collider2D>();
            Collider2D StairsColl = Stairs.GetComponent<Collider2D>();

            if (CurtainsColl.OverlapPoint(MousePos))
            {
                SubScene_Animator.SetBool("Curtains_Activated", true);
                House_Animator.SetInteger("SubScene", 1);
            }

            if (KeysColl.OverlapPoint(MousePos))
            {
                Keys_Animator.SetBool("Keys_Activated", true);
                if (KeysOnce == true)
                {
                    FMODUnity.RuntimeManager.PlayOneShot("event:/SFX_Touch/SFX_Keys_Touch", CamPos);
                }
                KeysOnce = true;
            }

            if (LampColl.OverlapPoint(MousePos))
            {
                SubScene_Animator.SetBool("Lamp_Activated", true);
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

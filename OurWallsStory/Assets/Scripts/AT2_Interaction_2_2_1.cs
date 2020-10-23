using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AT2_Interaction_2_2_1 : MonoBehaviour
{
    public GameObject Interaction;
    public GameObject House;
    public GameObject WindowTRIANGLE;
    public GameObject Stairs;
    public GameObject Curtain1;
    public GameObject Curtain2;
    public GameObject Windows;
    public GameObject Keys;
    public GameObject Canvas;

    private Animator Interaction_Animator;
    private Animator House_Animator;
    private bool PauseActivated;

    private Pause_Menu menuPause;

    private Camera cam;

    private Collider2D InteractionColl;
    private Collider2D WindowTriangleColl;
    private Collider2D StairsColl;
    private Collider2D Curtain1Coll;
    private Collider2D Curtain2Coll;
    private Collider2D WindowColl;
    private Collider2D KeysColl;

    private int Holding = Animator.StringToHash("Holding");

    // Start is called before the first frame update
    void Start()
    {
        Interaction_Animator = Interaction.GetComponent<Animator>();
        House_Animator = House.GetComponent<Animator>();
        menuPause = Canvas.GetComponent<Pause_Menu>();
        cam = Camera.main;
        InteractionColl = Interaction.GetComponent<Collider2D>();
        WindowTriangleColl = WindowTRIANGLE.GetComponent<Collider2D>();
        StairsColl = Stairs.GetComponent<Collider2D>();
        Curtain1Coll = Curtain1.GetComponent<Collider2D>();
        Curtain2Coll = Curtain2.GetComponent<Collider2D>();
        WindowColl = Windows.GetComponent<Collider2D>();
        KeysColl = Keys.GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        PauseActivated = menuPause.PauseActivated;
        

        if ((Input.GetMouseButton(0)) && (PauseActivated == false))
        {
            Vector3 MousePos = cam.ScreenToWorldPoint(Input.mousePosition);
            Vector3 CamPos = cam.transform.position;

            if (InteractionColl.OverlapPoint(MousePos))
            {
                Interaction_Animator.SetBool(Holding, true);
            }
        }
        else
        {
            Interaction_Animator.SetBool(Holding, false);
        }

        if ((Input.GetMouseButtonDown(0)) && (PauseActivated == false))
        {
            Vector3 MousePos = cam.ScreenToWorldPoint(Input.mousePosition);
            Vector3 CamPos = cam.transform.position;


            if (WindowTriangleColl.OverlapPoint(MousePos))
            {
                FMODUnity.RuntimeManager.PlayOneShot("event:/SFX_Touch/SFX_Glass", CamPos);

            }

            else if (WindowColl.OverlapPoint(MousePos))
            {
                FMODUnity.RuntimeManager.PlayOneShot("event:/SFX_Touch/SFX_Glass", CamPos);

            }

            else if (StairsColl.OverlapPoint(MousePos))
            {
                FMODUnity.RuntimeManager.PlayOneShot("event:/SFX_Touch/SFX_Stairs_Touch", CamPos);

            }

            else if (Curtain1Coll.OverlapPoint(MousePos))
            {
                FMODUnity.RuntimeManager.PlayOneShot("event:/SFX_Touch/SFX_Curtains_Touch", CamPos);

            }

            else if (Curtain2Coll.OverlapPoint(MousePos))
            {
                FMODUnity.RuntimeManager.PlayOneShot("event:/SFX_Touch/SFX_Curtains_Touch", CamPos);

            }

            else if (KeysColl.OverlapPoint(MousePos))
            {
                FMODUnity.RuntimeManager.PlayOneShot("event:/SFX_Touch/SFX_Keys_Touch", CamPos);

            }

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;

public class LR4_Interaction_3_2_3 : MonoBehaviour
{
    public GameObject Interaction;
    public GameObject House;
    public GameObject Keys;
    public GameObject Curtain1;
    public GameObject Curtain2;
    public GameObject Window;
    public GameObject Canvas;

    private Animator Interaction_Animator;
    private Animator House_Animator;
    private bool PauseActivated;

    private Pause_Menu menuPause;

    private Camera cam;

    private Collider2D Curtain1Coll;
    private Collider2D Curtain2Coll;
    private Collider2D WindowColl;
    private Collider2D KeysColl;
    private Collider2D InteractionColl;

    private int Holding = Animator.StringToHash("Holding");

    public bool Credits;

    // Start is called before the first frame update
    void Start()
    {
        Interaction_Animator = Interaction.GetComponent<Animator>();
        House_Animator = House.GetComponent<Animator>();
        Curtain1Coll = Curtain1.GetComponent<Collider2D>();
        Curtain2Coll = Curtain2.GetComponent<Collider2D>();
        WindowColl = Window.GetComponent<Collider2D>();
        KeysColl = Keys.GetComponent<Collider2D>();
        InteractionColl = Interaction.GetComponent<Collider2D>();
        menuPause = Canvas.GetComponent<Pause_Menu>();
        cam = Camera.main;
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
        } else
        {
            Interaction_Animator.SetBool(Holding, false);
        }

        if ((Input.GetMouseButtonDown(0)) && (PauseActivated == false) && (Credits == false))
        {
            Vector3 MousePos = cam.ScreenToWorldPoint(Input.mousePosition);
            Vector3 CamPos = cam.transform.position;


            if (WindowColl.OverlapPoint(MousePos))
            {
                FMODUnity.RuntimeManager.PlayOneShot("event:/SFX_Touch/SFX_Glass", CamPos);

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

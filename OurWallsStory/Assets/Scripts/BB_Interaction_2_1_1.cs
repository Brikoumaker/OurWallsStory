using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;

public class BB_Interaction_2_1_1 : MonoBehaviour
{
    public GameObject Interaction;
    public GameObject House;
    public GameObject WindowBED;
    public GameObject WindowBATH;
    public GameObject Blanket;
    public GameObject Mirror;
    public GameObject Curtain;
    public GameObject Canvas;

    private Animator Interaction_Animator;
    private Animator House_Animator;
    private bool PauseActivated;

    private Pause_Menu menuPause;

    private Camera cam;

    private int Holding = Animator.StringToHash("Holding");

    private Collider2D InteractionColl;
    private Collider2D WindowBedColl;
    private Collider2D WindowBathColl;
    private Collider2D CurtainColl;
    private Collider2D MirrorColl;
    private Collider2D BlanketColl;

    // Start is called before the first frame update
    void Start()
    {
        Interaction_Animator = Interaction.GetComponent<Animator>();
        House_Animator = House.GetComponent<Animator>();
        menuPause = Canvas.GetComponent<Pause_Menu>();
        cam = Camera.main;
        InteractionColl = Interaction.GetComponent<Collider2D>();
        WindowBedColl = WindowBED.GetComponent<Collider2D>();
        WindowBathColl = WindowBATH.GetComponent<Collider2D>();
        CurtainColl = Curtain.GetComponent<Collider2D>();
        MirrorColl = Mirror.GetComponent<Collider2D>();
        BlanketColl = Blanket.GetComponent<Collider2D>();
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

        if ((Input.GetMouseButtonDown(0)) && (PauseActivated == false))
        {
            Vector3 MousePos = cam.ScreenToWorldPoint(Input.mousePosition);
            Vector3 CamPos = cam.transform.position;


            if (WindowBedColl.OverlapPoint(MousePos))
            {
                FMODUnity.RuntimeManager.PlayOneShot("event:/SFX_Touch/SFX_Glass", CamPos);

            }

            if (WindowBathColl.OverlapPoint(MousePos))
            {
                FMODUnity.RuntimeManager.PlayOneShot("event:/SFX_Touch/SFX_Glass", CamPos);

            }

            if (MirrorColl.OverlapPoint(MousePos))
            {
                FMODUnity.RuntimeManager.PlayOneShot("event:/SFX_Touch/SFX_Glass", CamPos);
            }

            if (BlanketColl.OverlapPoint(MousePos))
            {
                FMODUnity.RuntimeManager.PlayOneShot("event:/SFX_Action/SFX_Blanket", CamPos);
            }

            if (CurtainColl.OverlapPoint(MousePos))
            {
                FMODUnity.RuntimeManager.PlayOneShot("event:/SFX_Touch/SFX_Curtains_Touch", CamPos);
            }

        }
    }
}

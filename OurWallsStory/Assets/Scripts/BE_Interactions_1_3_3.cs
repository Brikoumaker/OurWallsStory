using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BE_Interactions_1_3_3 : MonoBehaviour
{

    public GameObject BedLamp1;
    public GameObject BedLamp2;
    public GameObject Window;
    public GameObject Mirror;
    public GameObject Blanket;
    public GameObject House;
    public GameObject Canvas;
    public bool AnimationFinished;

    private Animator BedLamp1_Animator;
    private Animator BedLamp2_Animator;
    private Animator Window_Animator;
    private Animator House_Animator;
    private bool PauseActivated;

    private Pause_Menu menuPause;

    private Camera cam;

    private int Act = Animator.StringToHash("Act");
    private int Scene = Animator.StringToHash("Scene");
    private int SubScene = Animator.StringToHash("SubScene");
    private int BedLamp1_Activated = Animator.StringToHash("BedLamp1_Activated");
    private int BedLamp2_Activated = Animator.StringToHash("BedLamp2_Activated");
    private int Window_Activated = Animator.StringToHash("Window_Activated");

    private Collider2D BedLamp1Coll;
    private Collider2D BedLamp2Coll;
    private Collider2D WindowColl;
    private Collider2D MirrorColl;
    private Collider2D BlanketColl;


    // Start is called before the first frame update
    void Start()
    {
        BedLamp1_Animator = BedLamp1.GetComponent<Animator>();
        BedLamp2_Animator = BedLamp2.GetComponent<Animator>();
        Window_Animator = Window.GetComponent<Animator>();
        House_Animator = House.GetComponent<Animator>();
        menuPause = Canvas.GetComponent<Pause_Menu>();
        cam = Camera.main;
        BedLamp1Coll = BedLamp1.GetComponent<Collider2D>();
        BedLamp2Coll = BedLamp2.GetComponent<Collider2D>();
        WindowColl = Window.GetComponent<Collider2D>();
        MirrorColl = Mirror.GetComponent<Collider2D>();
        BlanketColl = Blanket.GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {

        PauseActivated = menuPause.PauseActivated;

        if (AnimationFinished == true)
        {
            House_Animator.SetInteger(Act, 2);
            House_Animator.SetInteger(Scene, 1);
            House_Animator.SetInteger(SubScene, 1);
            AnimationFinished = false;
        }


        if ((Input.GetMouseButtonDown(0)) && (PauseActivated == false))
        {
            Vector3 MousePos = cam.ScreenToWorldPoint(Input.mousePosition);
            Vector3 CamPos = cam.transform.position;
            

            if (BedLamp1Coll.OverlapPoint(MousePos))
            {
                BedLamp1_Animator.SetBool(BedLamp1_Activated, true);
            }

            else if (BedLamp2Coll.OverlapPoint(MousePos))
            {
                BedLamp2_Animator.SetBool(BedLamp2_Activated, true);
            }

            else if (WindowColl.OverlapPoint(MousePos))
            {
                Window_Animator.SetBool(Window_Activated, true);

            }

            else if (MirrorColl.OverlapPoint(MousePos))
            {
                FMODUnity.RuntimeManager.PlayOneShot("event:/SFX_Touch/SFX_Glass", CamPos);
            }

            else if (BlanketColl.OverlapPoint(MousePos))
            {
                FMODUnity.RuntimeManager.PlayOneShot("event:/SFX_Action/SFX_Blanket", CamPos);
            }
        }
    }
}

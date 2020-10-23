using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AT_Interactions_1_2_2 : MonoBehaviour
{

    public GameObject Web1;
    public GameObject Web2;
    public GameObject Portrait;
    public GameObject Mannikin;
    public GameObject Window;
    public GameObject House;
    public GameObject Canvas;
    public bool AnimationFinished;

    private Animator Web1_Animator;
    private Animator Web2_Animator;
    private Animator Portrait_Animator;
    private Animator Mannikin_Animator;
    private Animator House_Animator;
    private bool PauseActivated;

    private Pause_Menu menuPause;

    private Camera cam;

    private int SubScene = Animator.StringToHash("SubScene");
    private int Scene = Animator.StringToHash("Scene");
    private int Web1_Activated = Animator.StringToHash("Web1_Activated");
    private int Web2_Activated = Animator.StringToHash("Web2_Activated");
    private int Portrait_Activated = Animator.StringToHash("Portrait_Activated");
    private int Mannikin_Activated = Animator.StringToHash("Mannikin_Activated");

    private Collider2D Web1Coll;
    private Collider2D Web2Coll;
    private Collider2D PortraitColl;
    private Collider2D MannikinColl;
    private Collider2D WindowColl;

    // Start is called before the first frame update
    void Start()
    {
        Web1_Animator = Web1.GetComponent<Animator>();
        Web2_Animator = Web2.GetComponent<Animator>();
        Portrait_Animator = Portrait.GetComponent<Animator>();
        Mannikin_Animator = Mannikin.GetComponent<Animator>();
        House_Animator = House.GetComponent<Animator>();
        menuPause = Canvas.GetComponent<Pause_Menu>();
        cam = Camera.main;
        Web1Coll = Web1.GetComponent<Collider2D>();
        Web2Coll = Web2.GetComponent<Collider2D>();
        PortraitColl = Portrait.GetComponent<Collider2D>();
        MannikinColl = Mannikin.GetComponent<Collider2D>();
        WindowColl = Window.GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        PauseActivated = menuPause.PauseActivated;


        if (AnimationFinished == true)
        {
            House_Animator.SetInteger(Scene, 3);   
            House_Animator.SetInteger(SubScene, 1);
        }

        if ((Input.GetMouseButtonDown(0)) && (PauseActivated == false))
        {
            Vector3 MousePos = cam.ScreenToWorldPoint(Input.mousePosition);
            Vector3 CamPos = cam.transform.position;
            

            if (Web1Coll.OverlapPoint(MousePos))
            {
                Web1_Animator.SetBool(Web1_Activated, true);
            }

            else if (Web2Coll.OverlapPoint(MousePos))
            {
                Web2_Animator.SetBool(Web2_Activated, true);
            }

            else if (PortraitColl.OverlapPoint(MousePos))
            {
                Portrait_Animator.SetBool(Portrait_Activated, true);
            }

            else if (MannikinColl.OverlapPoint(MousePos))
            {
                Mannikin_Animator.SetBool(Mannikin_Activated, true);
            }

            else if (WindowColl.OverlapPoint(MousePos))
            {
                FMODUnity.RuntimeManager.PlayOneShot("event:/SFX_Touch/SFX_Glass", CamPos);
            }


        }
    }
}

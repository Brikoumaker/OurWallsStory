using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BR_Interactions_1_2_1 : MonoBehaviour
{

    public GameObject Bath;
    public GameObject Shower;
    public GameObject Paint;
    public GameObject Mirror;
    public GameObject Machine;
    public GameObject Wall;
    public GameObject Window;
    public GameObject House;
    public GameObject Canvas;
    public bool AnimationFinished;

    private Animator Bath_Animator;
    private Animator Shower_Animator;
    private Animator Plant_Animator;
    private Animator Paint_Animator;
    private Animator Mirror_Animator;
    private Animator Machine_Animator;
    private Animator House_Animator;
    private bool PauseActivated;

    private Pause_Menu menuPause;

    private Camera cam;

    private int SubScene = Animator.StringToHash("SubScene");
    private int Bath_Activated = Animator.StringToHash("Bath_Activated");
    private int Shower_Activated = Animator.StringToHash("Shower_Activated");
    private int Paint_Activated = Animator.StringToHash("Paint_Activated");
    private int Mirror_Activated = Animator.StringToHash("Mirror_Activated");
    private int Machine_Activated = Animator.StringToHash("Machine_Activated");

    private Collider2D BathColl;
    private Collider2D ShowerColl;
    private Collider2D PaintColl;
    private Collider2D MirrorColl;
    private Collider2D MachineColl;
    private Collider2D WindowColl;


    // Start is called before the first frame update
    void Start()
    {
        Bath_Animator = Bath.GetComponent<Animator>();
        Shower_Animator = Shower.GetComponent<Animator>();
        Paint_Animator = Paint.GetComponent<Animator>();
        Mirror_Animator = Mirror.GetComponent<Animator>();
        Machine_Animator = Machine.GetComponent<Animator>();
        House_Animator = House.GetComponent<Animator>();
        menuPause = Canvas.GetComponent<Pause_Menu>();
        cam = Camera.main;
        BathColl = Bath.GetComponent<Collider2D>();
        ShowerColl = Shower.GetComponent<Collider2D>();
        PaintColl = Paint.GetComponent<Collider2D>();
        MirrorColl = Mirror.GetComponent<Collider2D>();
        MachineColl = Machine.GetComponent<Collider2D>();
        WindowColl = Window.GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {

        PauseActivated = menuPause.PauseActivated;

        if (AnimationFinished == true)
        {
            House_Animator.SetInteger(SubScene, 2);
        }

        if ((Input.GetMouseButtonDown(0)) && (PauseActivated == false))
        {
            Vector3 MousePos = cam.ScreenToWorldPoint(Input.mousePosition);
            Vector3 CamPos = cam.transform.position;
            

            if (BathColl.OverlapPoint(MousePos))
            {
                Bath_Animator.SetBool(Bath_Activated, true);
            }

            else if (ShowerColl.OverlapPoint(MousePos))
            {
                Shower_Animator.SetBool(Shower_Activated, true);
            }

            else if (PaintColl.OverlapPoint(MousePos))
            {
                Paint_Animator.SetBool(Paint_Activated, true);
                Wall.SetActive(true);
            }

            else if (MirrorColl.OverlapPoint(MousePos))
            {
                Mirror_Animator.SetBool(Mirror_Activated, true);
            }

            else if (MachineColl.OverlapPoint(MousePos))
            {
                Machine_Animator.SetBool(Machine_Activated, true);
            }

            else if (WindowColl.OverlapPoint(MousePos))
            {
                FMODUnity.RuntimeManager.PlayOneShot("event:/SFX_Touch/SFX_Glass", CamPos);
            }


        }
    }
}

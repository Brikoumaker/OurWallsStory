using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LR3_Interactions_1_3_2 : MonoBehaviour
{

    public GameObject LampNight;
    public GameObject Candle;
    public GameObject TVLight;
    public GameObject DarkRoom;
    public GameObject Stairs;
    public GameObject Curtain;
    public GameObject House;
    public GameObject Canvas;
    public bool AnimationFinished;

    private Animator LampNight_Animator;
    private Animator Candle_Animator;
    private Animator TVLight_Animator;
    private Animator House_Animator;
    private bool PauseActivated;

    private Pause_Menu menuPause;

    private Camera cam;

    private int SubScene = Animator.StringToHash("SubScene");
    private int LampNight_Activated = Animator.StringToHash("LampNight_Activated");
    private int Candle_Activated = Animator.StringToHash("Candle_Activated");
    private int TVLight_Activated = Animator.StringToHash("TVLight_Activated");

    private Collider2D LampNightColl;
    private Collider2D CandleColl;
    private Collider2D TVLightColl;
    private Collider2D CurtainColl;
    private Collider2D StairsColl;


    // Start is called before the first frame update
    void Start()
    {
        LampNight_Animator = LampNight.GetComponent<Animator>();
        Candle_Animator = Candle.GetComponent<Animator>();
        TVLight_Animator = TVLight.GetComponent<Animator>();
        House_Animator = House.GetComponent<Animator>();
        menuPause = Canvas.GetComponent<Pause_Menu>();
        cam = Camera.main;
        LampNightColl = LampNight.GetComponent<Collider2D>();
        CandleColl = Candle.GetComponent<Collider2D>();
        TVLightColl = TVLight.GetComponent<Collider2D>();
        CurtainColl = Curtain.GetComponent<Collider2D>();
        StairsColl = Stairs.GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()

    {

        PauseActivated = menuPause.PauseActivated;

        if (AnimationFinished == true)
        {  
            House_Animator.SetInteger(SubScene, 3);
        }

        if ((Input.GetMouseButtonDown(0)) && (PauseActivated == false))
        {
            Vector3 MousePos = cam.ScreenToWorldPoint(Input.mousePosition);
            Vector3 CamPos = cam.transform.position;
            

            if (LampNightColl.OverlapPoint(MousePos))
            {
                LampNight_Animator.SetBool(LampNight_Activated, true);
                DarkRoom.SetActive(true);
            }

            else if (CandleColl.OverlapPoint(MousePos))
            {
                Candle_Animator.SetBool(Candle_Activated, true);
            }

            else if (TVLightColl.OverlapPoint(MousePos))
            {
                TVLight_Animator.SetBool(TVLight_Activated, true);
                
            }

            else if (CurtainColl.OverlapPoint(MousePos))
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

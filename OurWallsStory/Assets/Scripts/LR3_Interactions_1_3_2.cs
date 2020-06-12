using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LR3_Interactions_1_3_2 : MonoBehaviour
{

    public GameObject LampNight;
    public GameObject Candle;
    public GameObject TVLight;
    public GameObject DarkRoom;
    public GameObject House;
    public GameObject Canvas;
    public bool AnimationFinished;

    private Animator LampNight_Animator;
    private Animator Candle_Animator;
    private Animator TVLight_Animator;
    private Animator House_Animator;
    private bool PauseActivated;

    // Start is called before the first frame update
    void Start()
    {
        LampNight_Animator = LampNight.GetComponent<Animator>();
        Candle_Animator = Candle.GetComponent<Animator>();
        TVLight_Animator = TVLight.GetComponent<Animator>();
        House_Animator = House.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()

    {

        PauseActivated = Canvas.GetComponent<Pause_Menu>().PauseActivated;

        if (AnimationFinished == true)
        {  
            House_Animator.SetInteger("SubScene", 3);
        }

        if ((Input.GetMouseButtonDown(0)) && (PauseActivated == false))
        {
            Vector3 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Collider2D LampNightColl = LampNight.GetComponent<Collider2D>();
            Collider2D CandleColl = Candle.GetComponent<Collider2D>();
            Collider2D TVLightColl = TVLight.GetComponent<Collider2D>();

            if (LampNightColl.OverlapPoint(MousePos))
            {
                LampNight_Animator.SetBool("LampNight_Activated", true);
                DarkRoom.SetActive(true);
            }

            if (CandleColl.OverlapPoint(MousePos))
            {
                Candle_Animator.SetBool("Candle_Activated", true);
            }

            if (TVLightColl.OverlapPoint(MousePos))
            {
                TVLight_Animator.SetBool("TVLight_Activated", true);
                
            }
        }
    }
}

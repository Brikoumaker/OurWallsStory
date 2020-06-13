using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KI_Interactions_1_3_1 : MonoBehaviour
{
    public GameObject Magnet;
    public GameObject Dishes;
    public GameObject Window;
    public GameObject House;
    public GameObject Canvas;
    public bool AnimationFinished;

    private Animator Magnet_Animator;
    private Animator Dishes_Animator;
    private Animator House_Animator;
    private bool PauseActivated;

    // Start is called before the first frame update
    void Start()
    {
        Magnet_Animator = Magnet.GetComponent<Animator>();
        Dishes_Animator = Dishes.GetComponent<Animator>();
        House_Animator = House.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        PauseActivated = Canvas.GetComponent<Pause_Menu>().PauseActivated;


        if ((Input.GetMouseButtonDown(0)) && (PauseActivated == false))
        {
            Vector3 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 CamPos = Camera.main.transform.position;
            Collider2D MagnetColl = Magnet.GetComponent<Collider2D>();
            Collider2D DishesColl = Dishes.GetComponent<Collider2D>();
            Collider2D WindowColl = Window.GetComponent<Collider2D>();

            if (MagnetColl.OverlapPoint(MousePos))
            {
                Magnet_Animator.SetBool("Magnet_Activated", true);
            }

            if (DishesColl.OverlapPoint(MousePos))
            {
                Dishes_Animator.SetBool("Dishes_Activated", true);
            }

            if (WindowColl.OverlapPoint(MousePos))
            {
                FMODUnity.RuntimeManager.PlayOneShot("event:/SFX_Touch/SFX_Glass", CamPos);
            }
        }
    }
        
}

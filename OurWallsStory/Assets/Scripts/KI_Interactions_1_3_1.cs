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

    private Pause_Menu menuPause;

    private Camera cam;

    private int Magnet_Activated = Animator.StringToHash("Magnet_Activated");
    private int Dishes_Activated = Animator.StringToHash("Dishes_Activated");

    private Collider2D MagnetColl;
    private Collider2D DishesColl;
    private Collider2D WindowColl;

    // Start is called before the first frame update
    void Start()
    {
        Magnet_Animator = Magnet.GetComponent<Animator>();
        Dishes_Animator = Dishes.GetComponent<Animator>();
        House_Animator = House.GetComponent<Animator>();
        menuPause = Canvas.GetComponent<Pause_Menu>();
        cam = Camera.main;
        MagnetColl = Magnet.GetComponent<Collider2D>();
        DishesColl = Dishes.GetComponent<Collider2D>();
        WindowColl = Window.GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {

        PauseActivated = menuPause.PauseActivated;


        if ((Input.GetMouseButtonDown(0)) && (PauseActivated == false))
        {
            Vector3 MousePos = cam.ScreenToWorldPoint(Input.mousePosition);
            Vector3 CamPos = cam.transform.position;
            

            if (MagnetColl.OverlapPoint(MousePos))
            {
                Magnet_Animator.SetBool(Magnet_Activated, true);
            }

            else if (DishesColl.OverlapPoint(MousePos))
            {
                Dishes_Animator.SetBool(Dishes_Activated, true);
            }

            else if (WindowColl.OverlapPoint(MousePos))
            {
                FMODUnity.RuntimeManager.PlayOneShot("event:/SFX_Touch/SFX_Glass", CamPos);
            }
        }
    }
        
}

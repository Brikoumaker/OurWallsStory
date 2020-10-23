using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;

public class BR2_Interaction_3_1_2 : MonoBehaviour
{
    public GameObject Interaction;
    public GameObject House;
    public GameObject Window;
    public GameObject Canvas;

    private Animator Interaction_Animator;
    private Animator House_Animator;
    private bool PauseActivated;

    private Pause_Menu menuPause;

    private Camera cam;

    private int Holding = Animator.StringToHash("Holding");

    private Collider2D InteractionColl;
    private Collider2D WindowColl;

    // Start is called before the first frame update
    void Start()
    {
        Interaction_Animator = Interaction.GetComponent<Animator>();
        House_Animator = House.GetComponent<Animator>();
        menuPause = Canvas.GetComponent<Pause_Menu>();
        cam = Camera.main;
        InteractionColl = Interaction.GetComponent<Collider2D>();
        WindowColl = Window.GetComponent<Collider2D>();
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
            

            if (WindowColl.OverlapPoint(MousePos))
            {
                FMODUnity.RuntimeManager.PlayOneShot("event:/SFX_Touch/SFX_Glass", CamPos);

            }

        }

    }
}

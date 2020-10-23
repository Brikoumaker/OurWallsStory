using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KID_Interaction_3_2_1 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Interaction;
    public GameObject House;
    public GameObject Window;
    public GameObject Canvas;
    public GameObject Flora;
    public GameObject Dog;

    private Animator Interaction_Animator;
    private Animator House_Animator;
    private Animator Flora_Animator;
    private bool PauseActivated;
    public bool FloraLaunch;

    private Pause_Menu menuPause;

    private Camera cam;

    private int Holding = Animator.StringToHash("Holding");
    private int Launch = Animator.StringToHash("Launch");

    private Collider2D InteractionColl;
    private Collider2D WindowColl;
    private Collider2D DogColl;

    void Start()
    {
        Interaction_Animator = Interaction.GetComponent<Animator>();
        House_Animator = House.GetComponent<Animator>();
        Flora_Animator = Flora.GetComponent<Animator>();
        menuPause = Canvas.GetComponent<Pause_Menu>();
        cam = Camera.main;
        InteractionColl = Interaction.GetComponent<Collider2D>();
        WindowColl = Window.GetComponent<Collider2D>();
        DogColl = Dog.GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (FloraLaunch == true)
        {
            Flora_Animator.SetBool(Launch, true);
            FloraLaunch = false;
        }

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

            else if (DogColl.OverlapPoint(MousePos))
            {
                FMODUnity.RuntimeManager.PlayOneShot("event:/SFX_Touch/SFX_Dog_Pet", CamPos);

            }

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class END_screen : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Canvas;
    public GameObject Boombox;
    public GameObject Stairs;
    public GameObject Curtain1;
    public GameObject Curtain2;
    public GameObject Window;
    public GameObject ChouquetteTROMIMI;
    private bool PauseActivated;

    private Pause_Menu menuPause;
    private Camera cam;

    private Collider2D BoomboxColl;
    private Collider2D StairsColl;
    private Collider2D Curtain1Coll;
    private Collider2D Curtain2Coll;
    private Collider2D WindowColl;
    private Collider2D DogColl;


    void Start()
    {
        menuPause = Canvas.GetComponent<Pause_Menu>();
        cam = Camera.main;
        BoomboxColl = Boombox.GetComponent<Collider2D>();
        StairsColl = Stairs.GetComponent<Collider2D>();
        Curtain1Coll = Curtain1.GetComponent<Collider2D>();
        Curtain2Coll = Curtain2.GetComponent<Collider2D>();
        WindowColl = Window.GetComponent<Collider2D>();
        DogColl = ChouquetteTROMIMI.GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        PauseActivated = menuPause.PauseActivated;


        if ((Input.GetMouseButtonDown(0)) && (PauseActivated == false))
        {
            Vector3 MousePos = cam.ScreenToWorldPoint(Input.mousePosition);
            Vector3 CamPos = cam.transform.position;
            

            if (BoomboxColl.OverlapPoint(MousePos))
            {
                menuPause.PauseGame();
            }

            else if (WindowColl.OverlapPoint(MousePos))
            {
                FMODUnity.RuntimeManager.PlayOneShot("event:/SFX_Touch/SFX_Glass", CamPos);

            }

            else if (StairsColl.OverlapPoint(MousePos))
            {
                FMODUnity.RuntimeManager.PlayOneShot("event:/SFX_Touch/SFX_Stairs_Touch", CamPos);

            }

            else if (Curtain1Coll.OverlapPoint(MousePos))
            {
                FMODUnity.RuntimeManager.PlayOneShot("event:/SFX_Touch/SFX_Curtains_Touch", CamPos);

            }

            else if (Curtain2Coll.OverlapPoint(MousePos))
            {
                FMODUnity.RuntimeManager.PlayOneShot("event:/SFX_Touch/SFX_Curtains_Touch", CamPos);

            }

            else if (DogColl.OverlapPoint(MousePos))
            {
                FMODUnity.RuntimeManager.PlayOneShot("event:/SFX_Touch/SFX_Dog_Pet", CamPos);

            }

        }
    }
}

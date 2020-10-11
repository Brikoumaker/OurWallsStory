using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class END_screen : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Canvas;
    public GameObject Boombox;
    private bool PauseActivated;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PauseActivated = Canvas.GetComponent<Pause_Menu>().PauseActivated;

        
        if ((Input.GetMouseButtonDown(0)) && (PauseActivated == false))
        {
            Vector3 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 CamPos = Camera.main.transform.position;
            Collider2D BoomboxColl = Boombox.GetComponent<Collider2D>();

            if (BoomboxColl.OverlapPoint(MousePos))
            {
                Canvas.GetComponent<Pause_Menu>().PauseGame();
            }

        }
    }
}

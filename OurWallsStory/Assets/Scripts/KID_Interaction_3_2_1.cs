﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KID_Interaction_3_2_1 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Interaction;
    public GameObject House;
    public GameObject Canvas;
    public GameObject Flora;

    private Animator Interaction_Animator;
    private Animator House_Animator;
    private Animator Flora_Animator;
    private bool PauseActivated;
    public bool FloraLaunch;

    void Start()
    {
        Interaction_Animator = Interaction.GetComponent<Animator>();
        House_Animator = House.GetComponent<Animator>();
        Flora_Animator = Flora.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (FloraLaunch == true)
        {
            Flora_Animator.SetBool("Launch", true);
            FloraLaunch = false;
        }
        
        PauseActivated = Canvas.GetComponent<Pause_Menu>().PauseActivated;
        Vector3 CamPos = Camera.main.transform.position;

        if ((Input.GetMouseButton(0)) && (PauseActivated == false))
        {
            Vector3 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Collider2D InteractionColl = Interaction.GetComponent<Collider2D>();

            if (InteractionColl.OverlapPoint(MousePos))
            {
                Interaction_Animator.SetBool("Holding", true);
            }
        }
        else
        {
            Interaction_Animator.SetBool("Holding", false);
        }
    }
}
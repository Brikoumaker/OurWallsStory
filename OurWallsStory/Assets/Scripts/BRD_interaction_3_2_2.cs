﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BRD_interaction_3_2_2 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Interaction;
    public GameObject House;
    public GameObject Canvas;

    private Animator Interaction_Animator;
    private Animator House_Animator;
    private bool PauseActivated;
    void Start()
    {
        Interaction_Animator = Interaction.GetComponent<Animator>();
        House_Animator = House.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
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
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KI_Interactions_1_3_1 : MonoBehaviour
{
    public GameObject Magnet;
    public GameObject Dishes;
    public GameObject House;
    public bool AnimationFinished;

    private Animator Magnet_Animator;
    private Animator Dishes_Animator;
    private Animator House_Animator;

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
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Collider2D MagnetColl = Magnet.GetComponent<Collider2D>();
            Collider2D DishesColl = Dishes.GetComponent<Collider2D>();

            if (MagnetColl.OverlapPoint(MousePos))
            {
                Magnet_Animator.SetBool("Magnet_Activated", true);
            }

            if (DishesColl.OverlapPoint(MousePos))
            {
                Dishes_Animator.SetBool("Dishes_Activated", true);
            }
        }
    }
        
}

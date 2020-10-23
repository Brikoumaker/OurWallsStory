using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockNextSubscene : MonoBehaviour
{
    public GameObject House;
    public int Act;
    public int Scene;
    public int SubScene;
    public float Interaction_Basse;
    public GameObject MusicAmbienteManager;
    public bool BasseUpdate;

    private Animator House_Animator;
    private MusikAmbientManager ambientManager;

    // Start is called before the first frame update
    void Start()
    {
        House_Animator = House.GetComponent<Animator>();
        if (MusicAmbienteManager != null)
            ambientManager = MusicAmbienteManager.GetComponent<MusikAmbientManager>();
    }

    // Update is called once per frame
    void Update()
    {

        if (BasseUpdate == true)
        {
            //if (ambientManager != null)
                ambientManager.Basse = Interaction_Basse;
        }
    }

    public void SetNext()
    {
        House_Animator.SetInteger("Act", Act);
        House_Animator.SetInteger("Scene", Scene);
        House_Animator.SetInteger("SubScene", SubScene);
    }
}

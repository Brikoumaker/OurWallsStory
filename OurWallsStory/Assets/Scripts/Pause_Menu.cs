﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pause_Menu : MonoBehaviour
{

    public GameObject House;
    public GameObject PauseMenu;
    public GameObject Label1;
    public GameObject Label2;
    public GameObject MessageQuit;
    public GameObject MessageRestart;
    public GameObject MusicAmbienteManager;


    public Image TapeUp;
    public Image Icon1;
    public Image Icon2;
    public Image Icon3;
    public Text Text1;
    public Text Text2;
    public Text Text3;
    public Image TapeDown;
    public Image LogoA;
    public Image LogoB;
    public Image LabelA;
    public Image LabelB;
    public Image Circle1;
    public Image Circle2;


    public Button Continue;
    public Button Quit;
    public Button Restart;
    public Button Yes;
    public Button No;

    public bool PauseActivated;
    public int State;

    private bool AnimationFinished;
    private Animator PauseMenu_Animator;
    private Animator House_Animator;

    private Color DarkColor;
    private Color LightColor;
    private Color SecondaryColor;

    private float SceneNumber;
    private int Act;
    private int Scene;
    private int SubScene;
    private int Act2SubScene;

    private Camera cam;

    private PauseAnimation animationPause;
    private MusikAmbientManager ambientManager;

    Vector3 CamPos;

    // Start is called before the first frame update
    void Start()
    {
        Continue.GetComponent<Button>().onClick.AddListener(ClickContinue);
        Quit.GetComponent<Button>().onClick.AddListener(ClickQuit);
        Restart.GetComponent<Button>().onClick.AddListener(ClickRestart);
        Yes.GetComponent<Button>().onClick.AddListener(ClickYes);
        No.GetComponent<Button>().onClick.AddListener(ClickNo);
        PauseMenu_Animator = PauseMenu.GetComponent<Animator>();
        House_Animator = House.GetComponent<Animator>();
        cam = Camera.main;
        animationPause = PauseMenu.GetComponent<PauseAnimation>();
        ambientManager = MusicAmbienteManager.GetComponent<MusikAmbientManager>();
    }

    // Update is called once per frame
    void Update()

    {

        AnimationFinished = animationPause.AnimationFinished;
        Vector3 CamPos = cam.transform.position;

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (PauseActivated == false) { PauseGame(); }
            else if (State == 1) { ClickQuit(); }
            else if (State == 2) { ClickYes(); }
            else if (State == 3) { ClickNo(); }
        }

        if ((State == 6) && (AnimationFinished == true))
        {
            ResumeGame();
        }

        if ((State == 4) && (AnimationFinished == true))
        {
            Application.Quit();
        }

        if ((State == 5) && (AnimationFinished == true))
        {
            Time.timeScale = 1;
            ambientManager.StopAllPlayerEvents();
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        PauseActivated = true;
        UI_Update();
        PauseMenu.SetActive(true);
        ambientManager.Pause();
        State = 1;
        PauseMenu_Animator.SetInteger("PauseMenu_State", 1);
    }

    void ResumeGame ()
    {
        Time.timeScale = 1;
        ambientManager.Resume();
        PauseActivated = false;
        PauseMenu.SetActive(false);
    }

    void ClickContinue ()
    {
        State = 6;
        PauseMenu_Animator.SetInteger("PauseMenu_State", 6);
        FMODUnity.RuntimeManager.PlayOneShot("event:/UI/Menu_Button", CamPos);
    }

    void ClickQuit()
    {
        if (State == 1)
        {
            State = 2;
            Label1.SetActive(false);
            Label2.SetActive(true);
            MessageQuit.SetActive(true);
            MessageRestart.SetActive(false);
            FMODUnity.RuntimeManager.PlayOneShot("event:/UI/Menu_Button", CamPos);
        }
        
    }

    void ClickRestart()
    {
        if (State ==1)
        {
            State = 3;
            Label1.SetActive(false);
            Label2.SetActive(true);
            MessageQuit.SetActive(false);
            MessageRestart.SetActive(true);
            FMODUnity.RuntimeManager.PlayOneShot("event:/UI/Menu_Button", CamPos);
        }
        
    }

    void ClickYes()
    {
        if (State == 2)
        {
            State = 4;
            PauseMenu_Animator.SetInteger("PauseMenu_State", 4);
            FMODUnity.RuntimeManager.PlayOneShot("event:/UI/Menu_Button", CamPos);
        }

        if (State == 3)
        {
            State = 5;
            PauseMenu_Animator.SetInteger("PauseMenu_State", 5);
            FMODUnity.RuntimeManager.PlayOneShot("event:/UI/Menu_Button", CamPos);
        }
    }

    void ClickNo()
    {
        if ((State == 2) || (State == 3))
        {
            Label1.SetActive(true);
            Label2.SetActive(false);
            State = 1;
            FMODUnity.RuntimeManager.PlayOneShot("event:/UI/Menu_Button", CamPos);
        }
        
    }

    void UI_Update()
    {
        Act = House_Animator.GetInteger("Act");
        Scene = House_Animator.GetInteger("Scene");
        SubScene = House_Animator.GetInteger("SubScene");
        Act2SubScene = House.GetComponent<Act2Scenes>().SubScene;

        if ((Act == 1) && (Scene == 1) && (SubScene == 0))
        {
            DarkColor = new Color32(56, 79, 136 ,255);
            LightColor = new Color32(255, 255, 231, 255);
            SecondaryColor = new Color32(197, 101, 127, 255);
            SceneNumber = 0;
        }

        if ((Act == 1) && (Scene == 1) && (SubScene == 1))
        {
            DarkColor = new Color32(108, 148, 200, 255);
            LightColor = new Color32(255, 255, 231, 255);
            SecondaryColor = new Color32(197, 101, 127, 255);
            SceneNumber = 1;
        }

        if ((Act == 1) && (Scene == 1) && (SubScene == 2))
        {
            DarkColor = new Color32(114, 167, 175, 255);
            LightColor = new Color32(255, 255, 195, 255);
            SecondaryColor = new Color32(172, 96, 64, 255);
            SceneNumber = 2;
        }

        if ((Act == 1) && (Scene == 2) && (SubScene == 1))
        {
            DarkColor = new Color32(120, 203, 187, 255);
            LightColor = new Color32(255, 255, 235, 255);
            SecondaryColor = new Color32(226, 170, 183, 255);
            SceneNumber = 3;
        }

        if ((Act == 1) && (Scene == 2) && (SubScene == 2))
        {
            DarkColor = new Color32(177, 121, 64, 255);
            LightColor = new Color32(255, 255, 243, 255);
            SecondaryColor = new Color32(204, 104, 114, 255);
            SceneNumber = 4;
        }

        if ((Act == 1) && (Scene == 3) && (SubScene == 1))
        {
            DarkColor = new Color32(109, 147, 110, 255);
            LightColor = new Color32(255, 254, 223, 255);
            SecondaryColor = new Color32(203, 161, 163, 255);
            SceneNumber = 5;
        }

        if ((Act == 1) && (Scene == 3) && (SubScene == 2))
        {
            DarkColor = new Color32(78, 102, 88, 255);
            LightColor = new Color32(255, 255, 227, 255);
            SecondaryColor = new Color32(130, 48, 70, 255);
            SceneNumber = 6;
        }

        if ((Act == 1) && (Scene == 3) && (SubScene == 3))
        {
            DarkColor = new Color32(163, 113, 198, 255);
            LightColor = new Color32(255, 255, 207, 255);
            SecondaryColor = new Color32(142, 23, 127, 255);
            SceneNumber = 7;
        }

        if ((Act == 2) && (Scene == 1) && (SubScene == 1))
        {
            DarkColor = new Color32(36, 80, 235, 255);
            LightColor = new Color32(254, 224, 232, 255);
            SecondaryColor = new Color32(247, 8, 92, 255);
            SceneNumber = 9;
        }
        if ((Act == 2) && (Scene == 1) && (SubScene == 2))
        {
            DarkColor = new Color32(100, 170, 40, 255);
            LightColor = new Color32(230, 240, 150, 255);
            SecondaryColor = new Color32(200, 50, 30, 255);
            SceneNumber = 10;
        }

        if ((Act == 2) && (Scene == 2) && (SubScene == 1))
        {
            DarkColor = new Color32(205, 0, 23, 255);
            LightColor = new Color32(250, 220, 220, 255);
            SecondaryColor = new Color32(250, 170, 30, 255);
            SceneNumber = 11;
        }

        if ((Act == 2) && (Scene == 2) && (SubScene == 2))
        {
            
            if (Act2SubScene == 0)
            {
                DarkColor = new Color32(205, 0, 23, 255);
                LightColor = new Color32(250, 220, 220, 255);
                SecondaryColor = new Color32(250, 170, 30, 255);
                SceneNumber = 12;
            }

            if (Act2SubScene == 1)
            {
                DarkColor = new Color32(50, 85, 140, 255);
                LightColor = new Color32(200, 200, 220, 255);
                SecondaryColor = new Color32(255, 112, 138, 255);
                SceneNumber = 13;
            }

            if (Act2SubScene == 2)
            {
                DarkColor = new Color32(190, 140, 80, 255);
                LightColor = new Color32(250, 240, 230, 255);
                SecondaryColor = new Color32(215, 100, 90, 255);
                SceneNumber = 14;
            }

            if (Act2SubScene == 3)
            {
                DarkColor = new Color32(120, 203, 187, 255);
                LightColor = new Color32(255, 255, 235, 255);
                SecondaryColor = new Color32(226, 170, 183, 255);
                SceneNumber = 15;
            }

            


        }

        if ((Act == 3) && (Scene == 2) && (SubScene == 1))
        {
            DarkColor = new Color32(121, 132, 155, 255);
            LightColor = new Color32(236, 231, 202, 255);
            SecondaryColor = new Color32(157, 188, 176, 255);
            SceneNumber = 16;
        }

        if ((Act == 3) && (Scene == 2) && (SubScene == 2))
        {
            DarkColor = new Color32(141, 115, 158, 255);
            LightColor = new Color32(250, 235, 230, 255);
            SecondaryColor = new Color32(210, 188, 209, 255);
            SceneNumber = 17;
        }

        if ((Act == 3) && (Scene == 2) && (SubScene == 3))
        {
            DarkColor = new Color32(170, 190, 80, 255);
            LightColor = new Color32(230, 250, 250, 255);
            SecondaryColor = new Color32(200, 160, 70, 255);
            SceneNumber = 18;
        }

        if ((Act == 4) && (Scene == 0) && (SubScene == 0))
        {
            DarkColor = new Color32(170, 190, 80, 255);
            LightColor = new Color32(230, 250, 250, 255);
            SecondaryColor = new Color32(200, 160, 70, 255);
            SceneNumber = 19;
        }

        if ((Act == 5) && (Scene == 0) && (SubScene == 0))
        {
            DarkColor = new Color32(70, 90, 135, 255);
            LightColor = new Color32(213, 255, 251, 255);
            SecondaryColor = new Color32(100, 228, 160, 255);
            SceneNumber = 20;
        }




        TapeUp.GetComponent<Image>().color = DarkColor;
        Icon1.GetComponent<Image>().color = DarkColor;
        Icon2.GetComponent<Image>().color = DarkColor;
        Icon3.GetComponent<Image>().color = DarkColor;
        Text1.GetComponent<Text>().color = DarkColor;
        Text2.GetComponent<Text>().color = DarkColor;
        Text3.GetComponent<Text>().color = DarkColor;
        LogoA.GetComponent<Image>().color = LightColor;
        LogoB.GetComponent<Image>().color = LightColor;
        LabelA.GetComponent<Image>().color = LightColor;
        LabelB.GetComponent<Image>().color = LightColor;
        TapeDown.GetComponent<Image>().color = SecondaryColor;
        Circle1.rectTransform.localScale = new Vector2(1 - SceneNumber*0.02f, 1 - SceneNumber*0.02f);
        Circle2.rectTransform.localScale = new Vector2(0.6f + SceneNumber * 0.02f, 0.6f + SceneNumber * 0.02f);
    }
}

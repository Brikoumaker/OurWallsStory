using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusikAmbientManager : MonoBehaviour
{
    public bool Play_Music_Act1;
    public bool Play_Ambiente1;
    public bool Stop_Ambiente1;
    public bool Play_Water;
    public bool Stop_Water;
    public bool Play_Music_Act2_1;
    public bool Play_Music_Act2_2;
    public bool Play_Music_Act2_3;
    public float Basse;

    FMOD.Studio.EventInstance Music_Act1;
    FMOD.Studio.EventInstance Ambiente1;
    FMOD.Studio.EventInstance Music_Act2;
    FMOD.Studio.EventInstance Water;

    // Start is called before the first frame update
    void Start()
    {
        Music_Act1 = FMODUnity.RuntimeManager.CreateInstance("event:/Musique/Musique_Acte1_Court");
        Music_Act2 = FMODUnity.RuntimeManager.CreateInstance("event:/Musique/Musique_Acte2");
        Ambiente1 = FMODUnity.RuntimeManager.CreateInstance("event:/AMB/Amb_Entrance_Empty");
        Water = FMODUnity.RuntimeManager.CreateInstance("event:/SFX_Action/SFX_WaterFaucet_On");
        //
    }

    // Update is called once per frame
    void Update()
    {
        if (Play_Music_Act1 == true)
        {
            Music_Act1.start();
            Play_Music_Act1 = false;
        }

        if (Play_Ambiente1 == true)
        {
            Ambiente1.start();
            Play_Ambiente1 = false;
        }

        if (Stop_Ambiente1 == true)
        {
            Ambiente1.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
            Stop_Ambiente1 = false;
        }

        if (Play_Water == true)
        {
            Water.start();
            Play_Water = false;
        }

        if (Stop_Water == true)
        {
            Water.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
            Stop_Water = false;
        }

        if (Play_Music_Act2_1 == true)
        {
            Music_Act2.setParameterByName("MusiqueActe2", 1);
            Music_Act2.start();
            Play_Music_Act2_1 = false;
        }

        if (Play_Music_Act2_2 == true)
        {
            Music_Act2.setParameterByName("MusiqueActe2", 2);
            Play_Music_Act2_2 = false;
        }

        if (Play_Music_Act2_3 == true)
        {
            Music_Act2.setParameterByName("MusiqueActe2", 3);
            Play_Music_Act2_3 = false;
        }

        Music_Act2.setParameterByName("Basse Melody", Basse);



    }

    public void Pause()
    {
        Music_Act1.setPaused(true);
        Music_Act2.setPaused(true);
        Ambiente1.setPaused(true);
        Water.setPaused(true);
    }

    public void Resume()
    {
        Music_Act1.setPaused(false);
        Music_Act2.setPaused(false);
        Ambiente1.setPaused(false);
        Water.setPaused(false);
    }

    public void StopAllPlayerEvents()
    {
        Music_Act1.stop(FMOD.Studio.STOP_MODE.IMMEDIATE);
        Music_Act2.stop(FMOD.Studio.STOP_MODE.IMMEDIATE);
        Ambiente1.stop(FMOD.Studio.STOP_MODE.IMMEDIATE);
        Water.stop(FMOD.Studio.STOP_MODE.IMMEDIATE);
    }
}

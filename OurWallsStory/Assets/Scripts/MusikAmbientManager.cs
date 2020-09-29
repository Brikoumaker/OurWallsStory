using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusikAmbientManager : MonoBehaviour
{
    public bool Play_Music_Act1;
    public bool Play_Music_Act3_1;
    public bool Play_Music_Act3_2;
    public bool Play_Music_Act3_3;
    public bool Play_Ambiente1;
    public bool Stop_Ambiente1;
    public bool Play_Water;
    public bool Stop_Water;
    public bool Play_TV;
    public bool Stop_TV;
    public bool Play_Music_Act2_1;
    public bool Play_Music_Act2_2;
    public bool Play_Music_Act2_3;
    public bool Play_Music_Act2_4;
    public bool Stop_Music_Act2;
    public bool Play_Ambiente2;
    public bool Stop_Ambiente2;
    public bool Ambiente211;
    public bool Ambiente212;
    public bool Ambiente221;
    public bool Ambiente222;
    public bool Ambiente311;
    public bool Play_Vaccum;
    public bool Stop_Vaccum;
    public bool Play_Kettle;
    public bool Stop_Kettle;
    public bool ShutAllAmbientes;
    public float Basse;

    FMOD.Studio.EventInstance Music_Act1;
    FMOD.Studio.EventInstance Ambiente1;
    FMOD.Studio.EventInstance Ambiente2;
    FMOD.Studio.EventInstance Ambiente3;
    FMOD.Studio.EventInstance Ambiente4;
    FMOD.Studio.EventInstance Ambiente5;
    FMOD.Studio.EventInstance Ambiente6;
    FMOD.Studio.EventInstance Music_Act2;
    FMOD.Studio.EventInstance Music_Act3;
    FMOD.Studio.EventInstance Water;
    FMOD.Studio.EventInstance Vaccum;
    FMOD.Studio.EventInstance Kettle;
    FMOD.Studio.EventInstance TV;
    FMOD.Studio.PLAYBACK_STATE state;

    // Start is called before the first frame update
    void Start()
    {
        Music_Act1 = FMODUnity.RuntimeManager.CreateInstance("event:/Musique/Musique_Acte1_Normal");
        Music_Act2 = FMODUnity.RuntimeManager.CreateInstance("event:/Musique/Musique_Acte2");
        Music_Act3 = FMODUnity.RuntimeManager.CreateInstance("event:/Musique/Musique_Acte3");
        Ambiente1 = FMODUnity.RuntimeManager.CreateInstance("event:/AMB/Amb_Entrance_Empty");
        Ambiente2 = FMODUnity.RuntimeManager.CreateInstance("event:/AMB/Amb_Night_FullHouse");
        Ambiente3 = FMODUnity.RuntimeManager.CreateInstance("event:/AMB/Amb_BedRoom_BathRoom");
        Ambiente4 = FMODUnity.RuntimeManager.CreateInstance("event:/AMB/Amb_Kitchen_LivingRoom");
        Ambiente5 = FMODUnity.RuntimeManager.CreateInstance("event:/AMB/Amb_Attic");
        Ambiente6 = FMODUnity.RuntimeManager.CreateInstance("event:/AMB/Amb_LivingRoom");
        Water = FMODUnity.RuntimeManager.CreateInstance("event:/SFX_Action/SFX_WaterFaucet_On");
        Vaccum = FMODUnity.RuntimeManager.CreateInstance("event:/SFX_Animation/SFX_VacuumCleaner");
        Kettle = FMODUnity.RuntimeManager.CreateInstance("event:/SFX_Animation/SFX_Kettle");
        TV = FMODUnity.RuntimeManager.CreateInstance("event:/SFX_Animation/SFX_TVMusic");
        
        //
    }

    // Update is called once per frame
    void Update()
    {


        if (Play_Music_Act1 == true)
        {
            Music_Act1.start();
            Music_Act1.getPlaybackState(out state);
            if (state != FMOD.Studio.PLAYBACK_STATE.STOPPED)
            {
                Play_Music_Act1 = false;
            }
            
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

        if (Play_Ambiente2 == true)
        {
            Ambiente2.start();
            Play_Ambiente2 = false;
        }

        if (Stop_Ambiente2 == true)
        {
            Ambiente2.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
            Stop_Ambiente2 = false;
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
        if (Play_TV == true)
        {
            TV.start();
            Play_TV = false;
        }

        if (Stop_TV == true)
        {
            TV.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
            Stop_TV = false;
        }


        if (Play_Music_Act2_1 == true)
        {
            Music_Act2.setParameterByName("MusiqueActe2", 1);
            Music_Act2.start();
            Music_Act2.getPlaybackState(out state);
            if (state != FMOD.Studio.PLAYBACK_STATE.STOPPED)
            {
                Play_Music_Act2_1 = false;
            }
            
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

        if (Play_Music_Act2_4 == true)
        {
            Music_Act2.setParameterByName("MusiqueActe2", 4);
            Play_Music_Act2_4 = false;
        }

        if (Stop_Music_Act2 == true)
        {
            Music_Act2.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
            Stop_Music_Act2 = false;
        }

        if (Play_Music_Act3_1 == true)
        {
            Music_Act3.setParameterByName("MusiqueActe3", 0);
            Music_Act3.start();
            Music_Act3.getPlaybackState(out state);
            if (state != FMOD.Studio.PLAYBACK_STATE.STOPPED)
            {
                Play_Music_Act3_1 = false;
            }
            
        }

        if (Play_Music_Act3_2 == true)
        {
            Music_Act3.setParameterByName("MusiqueActe3", 1);
            Play_Music_Act3_2 = false;
        }

        if (Play_Music_Act3_3 == true)
        {
            Music_Act3.setParameterByName("MusiqueActe3", 2);
            Play_Music_Act3_3 = false;
        }

        if (Ambiente211 == true)
        {
            Ambiente3.start();
            Ambiente3.setParameterByName("BedBath", 0.5f);
            Ambiente211 = false;
        }

        if (Ambiente212 == true)
        {
            Ambiente4.start();
            Ambiente4.setParameterByName("KitchLiving", 0.5f);
            Ambiente3.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
            Ambiente212 = false;
        }

        if (Ambiente221 == true)
        {
            Ambiente5.start();
            Ambiente4.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
            Ambiente221 = false;
        }

        if (Ambiente222 == true)
        {
            Ambiente6.start();
            Ambiente6.setParameterByName("LivingRoom", 2);
            Ambiente5.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
            Ambiente222 = false;
        }

        if (Ambiente311 == true)
        {
            
            Ambiente6.setParameterByName("LivingRoom", 0);
            
            Ambiente311 = false;
        }

        if (Play_Vaccum == true)
        {
            Vaccum.start();
            Play_Vaccum = false;
        }

        if (Stop_Vaccum == true)
        {
            Vaccum.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
            Stop_Vaccum = false;
        }

        if (Play_Kettle == true)
        {
            Kettle.start();
            Play_Kettle = false;
        }

        if (Stop_Kettle == true)
        {
            Kettle.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
            Stop_Kettle = false;
        }

        if (ShutAllAmbientes == true)
        {
            Ambiente1.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
            Ambiente2.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
            Ambiente3.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
            Ambiente4.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
            Ambiente5.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
            Ambiente6.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
            ShutAllAmbientes = false;
        }

        Music_Act2.setParameterByName("Basse Melody", Basse);



    }

    public void Pause()
    {
        Music_Act1.setPaused(true);
        Music_Act2.setPaused(true);
        Music_Act3.setPaused(true);
        Ambiente1.setPaused(true);
        Ambiente2.setPaused(true);
        Ambiente3.setPaused(true);
        Ambiente4.setPaused(true);
        Ambiente5.setPaused(true);
        Ambiente6.setPaused(true);
        Water.setPaused(true);
        Vaccum.setPaused(true);
        Kettle.setPaused(true);
        TV.setPaused(true);
    }

    public void Resume()
    {
        Music_Act1.setPaused(false);
        Music_Act2.setPaused(false);
        Music_Act3.setPaused(false);
        Ambiente1.setPaused(false);
        Ambiente2.setPaused(false);
        Ambiente3.setPaused(false);
        Ambiente4.setPaused(false);
        Ambiente5.setPaused(false);
        Ambiente6.setPaused(false);
        Water.setPaused(false);
        Vaccum.setPaused(false);
        Kettle.setPaused(false);
        TV.setPaused(false);
    }

    public void StopAllPlayerEvents()
    {
        Music_Act1.stop(FMOD.Studio.STOP_MODE.IMMEDIATE);
        Music_Act2.stop(FMOD.Studio.STOP_MODE.IMMEDIATE);
        Music_Act3.stop(FMOD.Studio.STOP_MODE.IMMEDIATE);
        Ambiente1.stop(FMOD.Studio.STOP_MODE.IMMEDIATE);
        Ambiente2.stop(FMOD.Studio.STOP_MODE.IMMEDIATE);
        Ambiente3.stop(FMOD.Studio.STOP_MODE.IMMEDIATE);
        Ambiente4.stop(FMOD.Studio.STOP_MODE.IMMEDIATE);
        Ambiente5.stop(FMOD.Studio.STOP_MODE.IMMEDIATE);
        Ambiente6.stop(FMOD.Studio.STOP_MODE.IMMEDIATE);
        Water.stop(FMOD.Studio.STOP_MODE.IMMEDIATE);
        Vaccum.stop(FMOD.Studio.STOP_MODE.IMMEDIATE);
        Kettle.stop(FMOD.Studio.STOP_MODE.IMMEDIATE);
        TV.stop(FMOD.Studio.STOP_MODE.IMMEDIATE);
    }
}

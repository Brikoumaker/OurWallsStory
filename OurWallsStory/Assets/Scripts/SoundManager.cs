using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public GameObject MusicAmbienteManager;
    Vector3 CamPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CamPos = Camera.main.transform.position;
    }

    void SparklesSound()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/SFX_Action/SFX_Sparkles", CamPos);
    }

    void KeysInteraction()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/SFX_Action/SFX_Keys_Stored", CamPos);
    }

    void CurtainsInteraction()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/SFX_Action/SFX_Curtains_Open", CamPos);
    }

    void LampInteraction()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/SFX_Action/SFX_LightBulb_On", CamPos);
    }

    void WaterInteraction()
    {
        MusicAmbienteManager.GetComponent<MusikAmbientManager>().Play_Water = true;
        //FMODUnity.RuntimeManager.PlayOneShot("event:/SFX_Action/SFX_WaterFaucet_On", CamPos);
    }

    void CardboardInteraction()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/SFX_Action/SFX_Cardboard_Transform", CamPos);
    }

    void LampShadeInteraction()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/SFX_Action/SFX_Lampshade_Place", CamPos);
    }

    void PlantInteraction()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/SFX_Action/SFX_Plant_Place", CamPos);
    }

    void DoorOpen()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/SFX_Animation/SFX_FrontDoor_Open", CamPos);
    }

    void DoorClose()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/SFX_Animation/SFX_FrontDoor_Shut", CamPos);
    }

    void Miouzik()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/Musique/Musique_Acte1_Court", CamPos);
    }

    void BigWave()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/SFX_Animation/SFX_BigWave", CamPos);
    }

    void Flash()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/SFX_Animation/SFX_Photo_Flash", CamPos);
    }

    void BathInteraction()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/SFX_Action/SFX_SpongeScrub", CamPos);
    }

    void DustInteraction()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/SFX_Action/SFX_DustCleaner", CamPos);
    }

    void PaintInteraction()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/SFX_Action/SFX_PaintBucket", CamPos);
    }

    void MagnetInteraction()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/SFX_Action/SFX_Magnet", CamPos);
    }

    void DishesInteraction()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/SFX_Action/SFX_Dishes", CamPos);
    }

    void PortraitInteraction()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/SFX_Action/SFX_ScribblePainting", CamPos);
    }

    void Splash()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/SFX_Animation/SFX_BathSplash", CamPos);
    }

    void CandleInteraction()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/SFX_Action/SFX_CandleLit", CamPos);
    }

    void LampOffInteraction()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/SFX_Action/SFX_Lamp_Off", CamPos);
    }

    void TVInteraction()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/SFX_Action/SFX_TV_On", CamPos);
    }

    void FailBasse()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/Musique/Musique_BassePain", CamPos);
    }

    void UI_Pause()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/UI/Menu_Pause", CamPos);
    }

    void UI_Resume()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/UI/Menu_Continue", CamPos);
    }

    void UI_Quit()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/UI/Menu_Quit", CamPos);
    }

    void UI_Restart()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/UI/Menu_Restart", CamPos);
    }

    void UI_Tooltip()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/UI/Menu_Tooltip", CamPos);
    }

    void Hold_Act2()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/SFX_Action/SFX_Sparkles_HoldLong", CamPos);
    }

    void Hold_Success()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/SFX_Action/SFX_Sparkles_HoldSuccess", CamPos);
    }

    void Hold_Fail()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/SFX_Action/SFX_Sparkles_HoldFail", CamPos);
    }

    void Fold()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/SFX_Action/SFX_Clothes_Fold", CamPos);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

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
        FMODUnity.RuntimeManager.PlayOneShot("event:/SFX_Action/SFX_WaterFaucet_On", CamPos);
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
}

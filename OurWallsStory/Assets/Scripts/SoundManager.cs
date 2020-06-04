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
}

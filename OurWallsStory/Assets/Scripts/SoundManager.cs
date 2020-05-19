using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    Vector3 MousePos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    void SparklesSound()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/SFX_Action/SFX_Sparkles", MousePos);
    }

    void KeysInteraction()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/SFX_Action/SFX_Keys_Stored", MousePos);
    }

    void CurtainsInteraction()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/SFX_Action/SFX_Curtains_Open", MousePos);
    }

    void LampInteraction()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/SFX_Action/SFX_LightBulb_On", MousePos);
    }

    void WaterInteraction()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/SFX_Action/SFX_WaterFaucet_On", MousePos);
    }

    void CardboardInteraction()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/SFX_Action/SFX_Cardboard_Transform", MousePos);
    }

    void LampShadeInteraction()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/SFX_Action/SFX_Lampshade_Place", MousePos);
    }

    void PlantInteraction()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/SFX_Action/SFX_Plant_Place", MousePos);
    }

    void DoorOpen()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/SFX_Animation/SFX_FrontDoor_Open", MousePos);
    }

    void DoorClose()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/SFX_Animation/SFX_FrontDoor_Shut", MousePos);
    }

    void Miouzik()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/Musique/Musique_Acte1", MousePos);
    }
}

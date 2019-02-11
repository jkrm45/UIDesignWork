using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Btmmanger : MonoBehaviour
{
    public UISlider Sound;
    public UISlider EffectSound;
    public AudioSource Music;
    public AudioSource EffectMusic;
    
    public GameObject Myscorebg;
    public GameObject SoundOptionbg;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Music.volume = Sound.value;
        EffectMusic.volume = EffectSound.value;

    }
    public void MyscoreOn()
    {
        Myscorebg.transform.position= new Vector3(0, 0, 0);
    }
    public void SoundOptionOn()
    {
        Sound.value = PlayerPrefs.GetFloat("SaveSound");
        EffectSound.value = PlayerPrefs.GetFloat("SaveEffectSound");
        SoundOptionbg.transform.position = new Vector3(0, 0, 0);
    }
    public void Myscoreoff()
    {
        Myscorebg.transform.position = new Vector3(4, 0, 0);
    }
    public void SoundOptionoff()
    {
        SoundOptionbg.transform.position = new Vector3(0, 4, 0);
    }
    public void Playstart()
    {

    }
    public void SoundCancle()
    {
        Sound.value = PlayerPrefs.GetFloat("SaveSound");
        EffectSound.value = PlayerPrefs.GetFloat("SaveEffectSound");
    }
    public void SoundOk()
    {
        PlayerPrefs.SetFloat("SaveSound", Sound.value);
        PlayerPrefs.SetFloat("SaveEffectSound", EffectSound.value);
    }
}

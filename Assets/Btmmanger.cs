using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Btmmanger : MonoBehaviour
{
    public GameObject Myscorebg;
    public GameObject SoundOptionbg;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MyscoreOn()
    {
        Myscorebg.transform.position= new Vector3(0, 0, 0);
    }
    public void SoundOptionOn()
    {
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
}

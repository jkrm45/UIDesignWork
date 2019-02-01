using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadingScript : MonoBehaviour
{
    public UIProgressBar Loading;
    public UITexture LoadingTexture;
    public UILabel LoadingText;
    public GameObject LoadingPannel;
    public List<Texture> LoadTexture;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ChangeText());
        //if (RandomTexture() == 0)
        //{
        //    LoadingTexture.mainTexture = LoadTexture[0];
        //}
        //if (RandomTexture() == 1)
        //{
        //    LoadingTexture.mainTexture = LoadTexture[1];
        //}
    }

    // Update is called once per frame
    void Update()
    {
    
        Loading.value = Loading.value + Time.deltaTime * 0.1f;
        if (Loading.value <0.5)
        {
            LoadingTexture.mainTexture = LoadTexture[0];
            //LoadingPannel.SetActive(false);
        }
        if (Loading.value >= 0.5 && Loading.value < 1)
        {
            LoadingTexture.mainTexture = LoadTexture[1];
            //LoadingPannel.SetActive(false);
        }
        if (Loading.value == 1)
        {
            //LoadingTexture.mainTexture = LoadTexture[1];
            LoadingPannel.SetActive(false);
        }
    }

    IEnumerator ChangeText()
    {
        LoadingText.text = "Now Loading.";
        yield return new WaitForSeconds(1);
        LoadingText.text = "Now Loading..";
        yield return new WaitForSeconds(1);
        LoadingText.text = "Now Loading...";
        yield return new WaitForSeconds(1);
        LoadingText.text = "Now Loading.";
        yield return new WaitForSeconds(1);
        LoadingText.text = "Now Loading..";
        yield return new WaitForSeconds(1);
        LoadingText.text = "Now Loading...";
        yield return new WaitForSeconds(1);
        LoadingText.text = "Now Loading";
        yield return new WaitForSeconds(1);
        LoadingText.text = "Now Loading.";
        yield return new WaitForSeconds(1);
        LoadingText.text = "Now Loading..";
        yield return new WaitForSeconds(1);
        LoadingText.text = "Now Loading...";
        yield return new WaitForSeconds(1);
        LoadingText.text = "Now Loading";
        yield return new WaitForSeconds(1);
        LoadingText.text = "Now Loading.";
        yield return new WaitForSeconds(1);
    }

    int RandomTexture()
    {
        int v;
        v = Random.Range(0, 2);
        return v;
    }
}

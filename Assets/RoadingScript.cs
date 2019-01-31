using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadingScript : MonoBehaviour
{
    public UIProgressBar Loading;
    public UITexture LoadingTexture;
    public UILabel LoadingText;
    public List<Texture> LoadTexture;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ChangeText());
        if (RandomTexture() == 0)
        {
            LoadingTexture.mainTexture = LoadTexture[0];
        }
        if (RandomTexture() == 1)
        {
            LoadingTexture.mainTexture = LoadTexture[1];
        }
    }

    // Update is called once per frame
    void Update()
    {
    
        Loading.value = Loading.value + Time.deltaTime * 0.1f;
        if (Loading.value == 1)
        {
            LoadingTexture.GetComponent<GameObject>().SetActive(false);
        }
    }

    IEnumerator ChangeText()
    {
        LoadingText.text = "Now Roading.";
        yield return new WaitForSeconds(1);
        LoadingText.text = "Now Roading..";
        yield return new WaitForSeconds(1);
        LoadingText.text = "Now Roading...";
        yield return new WaitForSeconds(1);
        LoadingText.text = "Now Roading.";
        yield return new WaitForSeconds(1);
        LoadingText.text = "Now Roading..";
        yield return new WaitForSeconds(1);
        LoadingText.text = "Now Roading...";
        yield return new WaitForSeconds(1);
        LoadingText.text = "Now Roading";
        yield return new WaitForSeconds(1);
        LoadingText.text = "Now Roading.";
        yield return new WaitForSeconds(1);
        LoadingText.text = "Now Roading..";
        yield return new WaitForSeconds(1);
        LoadingText.text = "Now Roading...";
        yield return new WaitForSeconds(1);
        LoadingText.text = "Now Roading";
        yield return new WaitForSeconds(1);
        LoadingText.text = "Now Roading.";
        yield return new WaitForSeconds(1);
    }

    int RandomTexture()
    {
        int v;
        v = Random.Range(0, 2);
        return v;
    }
}

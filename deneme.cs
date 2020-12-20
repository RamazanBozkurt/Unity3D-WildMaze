using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class deneme : MonoBehaviour {

    public AudioSource source;
    public AudioClip girisSarkisi;
    public bool isMenu;

    void Start()
    {
        source = GetComponent<AudioSource>();
        source.clip = girisSarkisi;    
    }

    
    public void oyunaGecis2()
    {
        StartCoroutine(oyunaGecis());
    }
    IEnumerator oyunaGecis()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("DENEME");
    }
    
}

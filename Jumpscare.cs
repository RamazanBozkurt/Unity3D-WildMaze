using UnityEngine;
using System.Collections;

public class Jumpscare : MonoBehaviour {

    public AudioSource source;
    public AudioClip ses1;
	void Start () {
        source = GetComponent<AudioSource>();
        source.clip = ses1;
	}

    void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            StartCoroutine(ses1Oynat());          
        }
    }
    IEnumerator ses1Oynat()
    {
        source.Play();
        yield return new WaitForSeconds(3);
        Destroy(gameObject);
    }
}

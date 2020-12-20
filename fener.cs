using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class fener : MonoBehaviour {

    //FENER
    public Light isik;
    public bool acik;
    //ENERJİ VE PİL GÖSTERGESİ
    public float enerji;
    public Slider pilGostergesi;

	void Update () {
        pilGostergesi.value = enerji;
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            acik = !acik;
        }
        if (acik)
        {
            isik.enabled = true;
            enerji -= 1 * Time.deltaTime;
        }
        else
        {
            isik.enabled = false;
        }
        if (enerji <= 0)
        {
            isik.enabled = false;
            enerji = 0;
        }
        if(enerji >= 100)
        {
            enerji = 100;
        }
	}
    public void pilEleAlma()
    {
        enerji += 20;
    }
    
}

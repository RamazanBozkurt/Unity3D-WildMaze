using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EleAlma : MonoBehaviour {

    public float mesafe;
    //PİL
    public GameObject pil;
    public fener a;
    //CROSSHAİR
    public Image crosshair;
    //KAPI AÇMA
    public Animation kapi_1;
    public bool isOpen;

	void Update () {
        Vector3 ileri = transform.TransformDirection(Vector3.forward);
        RaycastHit hit;
        crosshair.color = Color.white;

        if (Physics.Raycast(transform.position,ileri,out hit, mesafe))
        {
            //PİL ALMA SİSTEMİ
            if(hit.distance <= mesafe && hit.collider.gameObject.tag == "pil")
            {
                crosshair.color = Color.red;        //CROSSHAİR REGİNİ İMLECE BAKTIĞINDA KIRMIZI YAPAR
                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    pil.SetActive(true);
                    Destroy(hit.collider.gameObject);
                    a.pilEleAlma();                   
                }

            }
            //KAPI AÇMA KAPAMA SİSTEMİ
            if (hit.distance <= mesafe && hit.collider.gameObject.tag == "kapi1")
            {
                crosshair.color = Color.red;
                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    if (isOpen)
                    {
                        kapi_1.Play("kapi_1Acma");
                        isOpen = false;
                    }
                    else
                    {
                        kapi_1.Play("kapi_1Kapama");
                        isOpen = true;
                    }
                }

            }

        }
	
	}
}

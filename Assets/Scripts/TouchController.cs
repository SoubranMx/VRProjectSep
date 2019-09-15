using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetTouch(0).phase == 0)
        {
            // raycast
            RaycastHit touched;

            Physics.Raycast(Camera.main.ScreenPointToRay(Input.GetTouch(0).position),out touched);//Guarda en el apuntador touched mediante out, es como si hicieras touched = blablabla(getTouch)
            //Deshabilitar objeto CON COLLIDER.
            //touched.collider.gameObject.SetActive(false);

            //Box Collider
            touched.collider.gameObject.SetActive(false);

            //Cambiar material
            //var renderer = touched.collider.gameObject.GetComponent<MeshRenderer>();
            //renderer.material.color = new Color32((byte)211,(byte)28, (byte)28, (byte)255);


        }
    }
}

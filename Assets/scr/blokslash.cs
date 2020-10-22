using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blokslash : MonoBehaviour
{
    public GameObject cub, slcub,cuboriginal;
    public float speed;
    

    
    void Update()
    {
        cuboriginal.transform.Translate(new Vector3(0,0,-1)*speed*Time.deltaTime);
    }

    void OnTriggerEnter(Collider collider)
    {
        cub.SetActive(false);
        slcub.SetActive(true);
    }
}

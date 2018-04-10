using UnityEngine;
using System.Collections;

public class _sim_light : MonoBehaviour {

    GameObject pocisk;
    public Animator cc;

   void Start()
    {
        pocisk = GameObject.Find("kula");
    }

    void FixedUpdate()
    {      
            cc.SetFloat("wysokosc", pocisk.transform.localPosition.y);
    }
}

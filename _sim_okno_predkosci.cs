using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class _sim_okno_predkosci : MonoBehaviour {

    public Rigidbody pocisk;
    Text velocity;
     public Text vx;
     public Text vy;
     public Text vz;
	void Start () {
        velocity = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (pocisk.velocity.x > 3)
        {
            vx.text = "PO X: " + pocisk.velocity.x.ToString();
            vy.text = "PO Y: " + pocisk.velocity.y.ToString();
            vz.text = "PO Z: " + pocisk.velocity.z.ToString();
            velocity.text = "WEKTOR : " + Mathf.Sqrt(Mathf.Pow(pocisk.velocity.x, 2) + Mathf.Pow(pocisk.velocity.y, 2) + Mathf.Pow(pocisk.velocity.z, 2)).ToString();

        }
        else
        {
            if (pocisk.velocity.x > 1)
                Destroy(this);
            vx.text = "PO X: 0";
            vy.text = "PO Y: 0";
            vz.text = "PO Z: 0";
            velocity.text = "WEKTOR : 0";

        }
        
    }
}

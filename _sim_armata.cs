using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class _sim_armata : MonoBehaviour {

    public Text kats;
    public Transform pocisk;
    float kat;
    Transform armata;

	void Start ()   {
        armata = GetComponent<Transform>();
    }
    
        public void Updated ()
    {
        float.TryParse(kats.text, out kat);
        armata.eulerAngles = new Vector3(0, 0, kat);
    }
}

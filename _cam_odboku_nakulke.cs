using UnityEngine;
using System.Collections;

public class _cam_odboku_nakulke : MonoBehaviour {

    GameObject pocisk;
    Transform pozycja;
	// Use this for initialization
	void Start () {
        pocisk = GameObject.Find("kula");
        pozycja = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void LateUpdate () {
        pozycja.localPosition = new Vector3(pocisk.transform.localPosition.x, pocisk.transform.localPosition.y, pocisk.transform.localPosition.z -200);
	}
}

using UnityEngine;
using System.Collections;

public class _cam_odgory_nakulke : MonoBehaviour {

    GameObject pocisk;
    Transform pozycja;
	void Start () {
        pocisk =  GameObject.Find("kula");
        pozycja = GetComponent<Transform>();
	}

    
      
	void LateUpdate () {
        pozycja.transform.localPosition = new Vector3(pocisk.transform.localPosition.x, pocisk.transform.localPosition.y + 25, pocisk.transform.localPosition.z);
    }
}

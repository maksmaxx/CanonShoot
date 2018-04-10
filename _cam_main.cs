using UnityEngine;
using System.Collections;

public class _cam_main : MonoBehaviour {

    GameObject pocisk;
    Transform pozycja;
	void Start () {
        pocisk = GameObject.Find("kula");
        pozycja = GetComponent<Transform>();
    }
	

	// Update is called once per frame
	void LateUpdate () {
        pozycja.localPosition = new Vector3(pocisk.transform.position.x -16, pocisk.transform.position.y + 9, pocisk.transform.position.z -26);
	    
	}

   public  void destroycamerasteering()
    { Destroy(this);
    }

}

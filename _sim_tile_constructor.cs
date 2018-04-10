using UnityEngine;
using System.Collections;

public class _sim_tile_constructor : MonoBehaviour {

    public GameObject prefab;
    public GameObject prefab2;
    public GameObject pocisk;
    Vector3 odniesienie = new Vector3(-10,0,0);
    Vector3 odniesienie2 = new Vector3(10, 0.05f , 0);
    float ostatnio = 5;

    void nowyrzad()
    {
        int ile_w_poprzek = Random.Range(2, 10);
        odniesienie.x += 10;
        odniesienie.z = ile_w_poprzek * 10 * (-1);

        for (  int i = 0; i <ile_w_poprzek*2; i++)
        {
            Instantiate(prefab, odniesienie, Quaternion.identity);
            odniesienie.z += 10;
        }
    }


	void Start () {
        nowyrzad();
	}
	

	void FixedUpdate () {
            if (ostatnio < pocisk.transform.localPosition.x)
            {
                nowyrzad();
                Instantiate(prefab2, odniesienie2, Quaternion.identity);
                ostatnio += 10;
                odniesienie2.x += 10;
            }
 
	}
}

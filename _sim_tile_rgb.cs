using UnityEngine;
using System.Collections;

public class _sim_tile_rgb : MonoBehaviour {
    Renderer rnd;
    int los = 0;
    [Range(50, 1000)]
    public int dolosu;
    void Start()
    {
        rnd = GetComponent<Renderer>();
    }
	void Update()
    {
        los = Random.Range(0,dolosu);
        if( los == 0)
        {
            rnd.material.color = Color.black;
        }
        if (los == 1)
        {
            rnd.material.color = Color.green;
        }
        if (los == 2)
        {
            rnd.material.color = Color.red;
        }
        if (los == 3)
        {
            rnd.material.color = Color.white;
        }
        if (los == 4)
        {
            rnd.material.color = Color.yellow;
        }
    }
}

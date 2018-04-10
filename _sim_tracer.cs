using UnityEngine;
using System.Collections;

public class _sim_tracer : MonoBehaviour {

	  public void _detacharmata()
    {
        transform.DetachChildren();
        Destroy(this);
    }
	
}

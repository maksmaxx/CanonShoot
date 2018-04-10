using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class _sim_prefabkropki : MonoBehaviour {
    Renderer rnd;
    GameObject tekst;
    TextMesh Tm;
    string posx;
    string posy;

    private void Start()
    {
        rnd = GetComponent<Renderer>();
        tekst = GameObject.Find("New Text");
        Tm = tekst.GetComponent<TextMesh>();
    }

    private void OnMouseDown()
    {
        rnd.material.color = Color.black;
        posx = transform.position.x.ToString();
        posy = transform.position.y.ToString();
        tekst.transform.position = transform.position + new Vector3(5,5,0);
        Tm.text = posx + " , " + posy;
        
    }
}

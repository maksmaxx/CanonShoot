using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class _sim_button_controller : MonoBehaviour
{
    public GameObject armata;
    public Rigidbody pocisk;
    InputField zerowanieinputa;

    public Text masa;
    public Text srednica;
    public Text kierunekwiatr;
    public Text wiatr;
    public Text kat;
    public Text wymuszenie;

    public GameObject kameraprefab;
    public GameObject kameraprefab2;
    public GameObject wybuchprefab;

    public TrailRenderer trailrenderer;

    public void usunkafelik()
    {
        foreach(GameObject serw in GameObject.FindGameObjectsWithTag("tile"))
        {
            Destroy(serw);
        }
        Destroy(armata);

    }
    public void wylacz()
    {
        Application.Quit();
    }
    public void _zmien_trailrenderer()
    {
        float a;
        float.TryParse(srednica.text, out a);
        trailrenderer.startWidth = a/2;
    }

    public void _wlaczkamery()
    {
        GameObject.Instantiate(kameraprefab);
        GameObject.Instantiate(kameraprefab2); 
    }

    public void _wczytajjeszczeraz()
    {
        Application.LoadLevel(1);
        foreach (GameObject apropo in GameObject.FindGameObjectsWithTag("kamerapomocnicza"))
        {
            Destroy(apropo);
        }
    }
    public void _zmienwartosc_masa(string pozdro)
    {
        zerowanieinputa = GameObject.Find("Masa").GetComponent<InputField>();
        zerowanieinputa.text = "";
        masa.text = pozdro;
    }
    public void _zmienwartosc_srednica(string pozdro)
    {
        zerowanieinputa = GameObject.Find("Srednica").GetComponent<InputField>();
        zerowanieinputa.text = "";
        srednica.text = pozdro;
    }
    public void _zmienwartosc_kierunekwiatr(string pozdro)
    {
        zerowanieinputa = GameObject.Find("Kierunek wiatru").GetComponent<InputField>();
        zerowanieinputa.text = "";
        kierunekwiatr.text = pozdro;
    }
    public void _zmienwartosc_wiatr(string pozdro)
    {
        zerowanieinputa = GameObject.Find("Sila wiatru").GetComponent<InputField>();
        zerowanieinputa.text = "";
        wiatr.text = pozdro;
    }
    public void _zmienwartosc_kat(string pozdro)
    {
        zerowanieinputa = GameObject.Find("Kat nachylenia").GetComponent<InputField>();
        zerowanieinputa.text = "";
        kat.text = pozdro;
    }
    public void _zmienwartosc_wymuszenie(string pozdro)
    {
        zerowanieinputa = GameObject.Find("Wymuszenie").GetComponent<InputField>();
        zerowanieinputa.text = "";
        wymuszenie.text = pozdro;
    }

    public void _dodajsile()
    {
        float wsp_kat;
        float wsp_wymuszenie;
        float wsp_radius;
        float wsp_wiatr;

        float.TryParse(wiatr.text, out wsp_wiatr);
        float.TryParse(kat.text, out wsp_kat);
        float.TryParse(wymuszenie.text, out wsp_wymuszenie);
        float.TryParse(srednica.text, out wsp_radius);
        Instantiate(wybuchprefab, pocisk.transform.position, Quaternion.identity);
        pocisk.AddForce( wsp_wymuszenie * Mathf.Cos(wsp_kat * (Mathf.PI / 180)) , wsp_wymuszenie * Mathf.Sin(wsp_kat * (Mathf.PI / 180)), wsp_wiatr, ForceMode.Impulse);
   
        pocisk.useGravity = true;
        
        
       
    }

}

          
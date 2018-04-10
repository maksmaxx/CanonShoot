using UnityEngine;
using System.Collections.Generic;
public class _sim_scripter : MonoBehaviour {

    public GameObject prefabkropki;
    public GameObject mainkamera;
    GameObject pocisk;
    public Rigidbody pocisk_rb;
    Vector3 aktualne_polozenie;
    public List<Vector3> lista_polozenie = new List<Vector3>();
     public List<Vector3> lista_predkosc = new List<Vector3>();


    void Start() {
        pocisk = GameObject.Find("kula");
    }

    void Update()
    {
        if (Input.mouseScrollDelta.y > 0 || Input.GetKey(KeyCode.KeypadPlus))
            mainkamera.transform.localPosition += new Vector3(0, 0, 10);
        if (Input.mouseScrollDelta.y < 0 || Input.GetKey(KeyCode.KeypadMinus)) 
            mainkamera.transform.localPosition += new Vector3(0, 0, -10);
    }

    float timer = 0;
    void FixedUpdate()
    {
        if (pocisk_rb.velocity.x > 3)
        {

            lista_polozenie.Add(pocisk.transform.position);
         
                timer += Time.deltaTime;
                lista_predkosc.Add(new Vector3(pocisk_rb.velocity.x, pocisk_rb.velocity.y, timer));
            
        }

    }

    void OnGUI()
    {
        if (GUI.Button(new Rect(Screen.width / 22, Screen.height / 3 +50, 50, 50), " LEWO ") || Input.GetKey(KeyCode.LeftArrow))
        {
            mainkamera.transform.localPosition += new Vector3(-1, 0, 0);
        }
        if (GUI.Button(new Rect(Screen.width / 22 + 50, Screen.height / 3 , 50, 50), " GORA ") || Input.GetKey(KeyCode.UpArrow))
        {
            mainkamera.transform.localPosition += new Vector3(0, 1, 0);
        }
        if (GUI.Button(new Rect(Screen.width / 22 + 50, Screen.height / 3 + 50, 50, 50), " DOL ") || Input.GetKey(KeyCode.DownArrow))
        {
            mainkamera.transform.localPosition += new Vector3(0, -1, 0);
        }
        if (GUI.Button(new Rect(Screen.width / 22 + 100, Screen.height / 3 + 50, 50, 50), " PRAWO ") || Input.GetKey(KeyCode.RightArrow))
        {
            mainkamera.transform.localPosition += new Vector3(1, 0, 0);
        }

    }
    GameObject pomocniczy;
    public void tworzeniewykresu()
    {
        string path = Application.dataPath;
        System.IO.StreamWriter file_mvm = new System.IO.StreamWriter(path + "/wykresy/polozenie.txt");
        //file_mvm.WriteLine("# POLOZENIE W PRZESTRZENI X Y Z");
        file_mvm.Close();
        file_mvm =  new System.IO.StreamWriter(path + "/wykresy/polozenie.txt", true);

        System.IO.StreamWriter file_vx = new System.IO.StreamWriter(path + "/wykresy/vx.txt");
        //file_vx.WriteLine("# PREDKOSC VX OD T");
        file_vx.Close();
        file_vx = new System.IO.StreamWriter(path + "/wykresy/vx.txt", true);

        System.IO.StreamWriter file_vy = new System.IO.StreamWriter(path + "/wykresy/vy.txt");
       // file_vy.WriteLine("#PREDKOSC VY OD T");
        file_vy.Close();
        file_vy = new System.IO.StreamWriter(path + "/wykresy/vy.txt", true);


        mainkamera.transform.position = new Vector3(20, 40, lista_polozenie[lista_polozenie.Count-1].z - lista_polozenie[lista_polozenie.Count - 1].x/2);
        mainkamera.transform.eulerAngles = new Vector3(0, 0, 0);
        foreach (GameObject apropo in GameObject.FindGameObjectsWithTag("kamerapomocnicza"))
        {
            Destroy(apropo);
        }

        foreach (GameObject apropo in GameObject.FindGameObjectsWithTag("arrow"))
        {
           apropo.transform.position += new Vector3(5000,0,0);
        }

        for (int i = 0; i < lista_polozenie.Count; i++)
        {
            Instantiate(prefabkropki, lista_polozenie[i], Quaternion.identity);
            if(i == lista_polozenie.Count/2)
            {
                pomocniczy = GameObject.Find("wykres_polozeniaa");
                pomocniczy.transform.position = lista_polozenie[i] + new Vector3(0,20,0);
            }
             file_mvm.WriteLine(lista_polozenie[i].x.ToString() + " " + lista_polozenie[i].y.ToString());
        }             
            
        for (int i = 0; i < lista_predkosc.Count; i++)
        {
            
            Instantiate(prefabkropki, new Vector3(lista_predkosc[i].z, lista_predkosc[i].x, 100), Quaternion.identity);
            if (i == lista_predkosc.Count / 2)
            {
                pomocniczy = GameObject.Find("wykres_predkosci_vx");
                pomocniczy.transform.position = lista_predkosc[i] + new Vector3(0, 20, 100);

            }
            file_vx.WriteLine(lista_predkosc[i].z.ToString() +" "+lista_predkosc[i].x.ToString());
        }

        for (int i = 0; i < lista_predkosc.Count; i++)
        {
           
            Instantiate(prefabkropki, new Vector3(lista_predkosc[i].z, lista_predkosc[i].y, 200), Quaternion.identity);
                file_vy.WriteLine(lista_predkosc[i].z.ToString() +" " + lista_predkosc[i].y.ToString());
            if (i == lista_predkosc.Count / 2)
            {
                pomocniczy = GameObject.Find("wykres_predkosci_vy");
                pomocniczy.transform.position = lista_predkosc[i] + new Vector3(0, 20, 200);

            }
        }
        file_mvm.Close();
        file_vx.Close();
        file_vy.Close();

    }
}

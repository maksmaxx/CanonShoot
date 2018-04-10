using UnityEngine;
using System.Collections;

public class _menu_button_controller : MonoBehaviour {

     public void _controler_nastepna_scena(int kk)
    {
        Application.LoadLevel(kk);
    }

    public void _controler_poprostu_zakoncz()
    {
        Application.Quit();
    }
}

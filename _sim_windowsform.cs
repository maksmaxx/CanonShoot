using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;
using System.IO;

    // GameObject.Find("_scripter").GetComponent<_sim_scripter>().lista_polozenie
public class _sim_windowsform : MonoBehaviour {
    string path;
    string wykres1path;
    string wykres2path;
    string wykres3path;

    private void Start()
    {
        path = Application.dataPath;
        wykres1path = path + "/wykresy/polozenie.txt";
        wykres2path = path + "/wykresy/vx.txt";
        wykres3path = path + "/wykresy/vy.txt";
    }

    public void UltraStart()
    {
        Process gnuplotproces = new Process();
        gnuplotproces.StartInfo.UseShellExecute = false;
        gnuplotproces.StartInfo.CreateNoWindow = true;
        gnuplotproces.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
        gnuplotproces.StartInfo.RedirectStandardInput = true;
        gnuplotproces.StartInfo.RedirectStandardOutput = true;
        gnuplotproces.StartInfo = new ProcessStartInfo(path + "/gnuplot/bin/gnuplot.exe");
        gnuplotproces.Start();

        
    } 

}

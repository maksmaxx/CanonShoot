using UnityEngine;
using UnityEngine.UI;

public class _sim_kula : MonoBehaviour {

    Rigidbody kula;
    public Text pobierany_promien;
    public Text ponierana_masa;
    float promien;
    float masa;
    public Transform odniesienie;
    void Start()
    {
        kula = GetComponent<Rigidbody>();
    }

 
    public void przenies_mnie_do_lufy()
    {
        transform.localPosition = odniesienie.localPosition;
    }

    void FixedUpdate()
    {
        float.TryParse(pobierany_promien.text, out promien);
        float.TryParse(ponierana_masa.text, out masa);
        transform.localScale = new Vector3(promien, promien, promien);
        kula.mass = masa;

        if (kula.velocity.x < 3)
        {
            kula.velocity = new Vector3(0, 0, 0);
        }
    }
	
}

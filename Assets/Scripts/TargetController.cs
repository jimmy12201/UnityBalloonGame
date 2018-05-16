using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour {

    // Use this for initialization
    public GameObject target;
    public int StartingHP;
    int CurrentHP;
    TextMesh text;



    void Start () {
        text = target.GetComponentInChildren<TextMesh>();
        CurrentHP = StartingHP;
        text.text = StartingHP.ToString();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Pistol_Bullet")
        {
            CurrentHP = int.Parse(text.text);
            CurrentHP -= 1;
        }
        if (CurrentHP == 0)
        {
            print("Destroying");
            Destroy(target);
        }
        else
        {
            text.text = CurrentHP.ToString();
        }
    }
}

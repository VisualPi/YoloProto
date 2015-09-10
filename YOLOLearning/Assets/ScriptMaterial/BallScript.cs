using UnityEngine;
using System.Collections;

public class BallScript : MonoBehaviour {

    [SerializeField]
    Rigidbody rb;

    Vector3 initPos;

	// Use this for initialization
	void Start () {
        initPos = transform.position;
        rb.AddForce(new Vector3(-150, 0, 0), ForceMode.Force);
	}
	
	// Update is called once per frame
	void Update () {
	   
	}


    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Character")
        {
            
                print("CONTACT BALL !");
                transform.position = initPos;
                rb.AddForce(new Vector3(-150, 0, 0), ForceMode.Force);
            
        }
    }
}

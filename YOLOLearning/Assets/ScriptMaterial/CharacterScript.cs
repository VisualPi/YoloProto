using UnityEngine;
using System.Collections;

public class CharacterScript : MonoBehaviour {

    int count = 0;
    int countT = 0;
    int forceY;
    int tailleRayCast;
    [SerializeField]
    Rigidbody rb;

    Vector3 initPos;
    // Use this for initialization
	void Start () {
        initPos = transform.position;
        forceY = 3;
        tailleRayCast = 3;
	}
	
	// Update is called once per frame
	void Update () {
        Debug.DrawRay(transform.position, new Vector3(3, 0, 0),Color.green);
        if (Physics.Raycast(transform.position, Vector3.right, 3))
        {
                countT++;
                if (countT == 1)
                {
                    print("JE SAUTE !");
                    rb.AddForce(new Vector3(0, forceY, 0), ForceMode.Impulse);
                }    
        }
	}

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Sphere")
        {
                count++;
                if(count==1)
                {
                    forceY+=1;
                }
                print("CONTACT !");
                transform.position = initPos;
                rb.AddForce(new Vector3(0, 0, 0), ForceMode.Impulse);
            
        }
        if (col.gameObject.name == "Ground")
        {
            countT = 0;
            count = 0;
            print("GROUND CONTACT");
        }
    }
}

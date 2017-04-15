using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class playercontroller : MonoBehaviour {
    public Text countText;
    private Rigidbody rb;
    private int count;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        count = 0;
        setcountText();


    }
	
	// Update is called once per frame
	void FixedUpdate () {
        float movehorizontal = Input.GetAxis("Horizontal");
        float movevertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(movehorizontal, 0.0f, movevertical);
        rb.AddForce(movement);
	}
    void OnTriggerEnter(Collider other)
    {if (other.gameObject.CompareTag("pick")) ;
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            setcountText();
        }
    }
    void setcountText() {
        
    }
}

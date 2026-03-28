using UnityEngine;

public class PortalScript : MonoBehaviour
{
    public GameObject portaL1;
    public GameObject portaL2;
    public GameObject PlayeR;
    public bool allClear = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //print(portaL2.transform.position);
        // print(PlayeR.transform.position+ "player");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (this.tag == "portal1")
        {
            if (other.transform.position.y >= this.transform.position.y)
            {
                allClear = false;
                PlayeR.GetComponent<Rigidbody>().linearVelocity = PlayeR.GetComponent<playerMotioncontrol>().reversemomentum;

                print("going up");
            }
            if (other.tag == "Player")
            {
                PlayeR.transform.position = portaL2.transform.position;                
            }
        }
        if (this.tag == "portal2")
        {
            if (other.transform.position.y >= this.transform.position.y)
            {
                allClear = false;
                PlayeR.GetComponent<Rigidbody>().linearVelocity = PlayeR.GetComponent<playerMotioncontrol>().reversemomentum;

                print("going up");
            }
            if (other.tag == "Player")
            {
                PlayeR.transform.position = portaL1.transform.position;
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {

        allClear = true;
    }
}



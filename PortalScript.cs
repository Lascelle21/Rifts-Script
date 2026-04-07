using System.Collections;
using UnityEngine;

public class PortalScript : MonoBehaviour
{
    public GameObject portaL1;
    public GameObject portaL2;
    public GameObject PlayeR;
    public bool allClear = true;
    WaitForSeconds shifTing;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        shifTing = new WaitForSeconds(0.1f); 
    }

    // Update is called once per frame
    void Update()
    {
        //print(PlayeR.transform.position);

        //print(portaL2.transform.position);
        // print(PlayeR.transform.position+ "player");
        //RaycastHit hit;
        //Physics.Raycast(portaL1.transform.position, portaL1.transform.forward, out hit);
        //Quaternion.LookRotation(hit.normal);
    }
    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(portaldelaY());
        if (tag == "portal1")
        {
            if (other.tag == "Player" && other.transform.position.y >= this.transform.position.y)
            {
                allClear = false;
                PlayeR.GetComponent<Rigidbody>().linearVelocity = PlayeR.GetComponent<playerMotioncontrol>().reversemomentum;
                PlayeR.transform.position = portaL2.transform.position;
                portaL2.GetComponent<MeshCollider>().enabled = false;
                portaldelaY();
            }
        }
        if (tag == "portal2")
        {
            if (other.tag == "Player" && other.transform.position.y >= this.transform.position.y)
            {
                allClear = false;
                PlayeR.GetComponent<Rigidbody>().linearVelocity = PlayeR.GetComponent<playerMotioncontrol>().reversemomentum;
                portaL1.GetComponent<MeshCollider>().enabled = false;
                PlayeR.transform.position = portaL1.transform.position;
                portaldelaY();
            }
        }
    }
    IEnumerator portaldelaY()
    {
        yield return shifTing;
        print("past");
        portaL1.GetComponent<MeshCollider>().enabled = true;
        portaL2.GetComponent<MeshCollider>().enabled = true;
        allClear = true;
    }



    private void OnTriggerExit(Collider other)
    {

        
    }
}



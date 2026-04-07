using UnityEngine;
using UnityEngine.Rendering.UI;
using UnityEngine.UIElements;

public class playerMotioncontrol : MonoBehaviour
{
    public Vector3 reversemomentum;
    public GameObject[] portalS;
    GameObject exitportal;
    Rigidbody rb;    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        
        reversemomentum = this.GetComponent<Rigidbody>().linearVelocity;
        print(reversemomentum + "rev");
        //transform.rotation = new Quaternion(transform.rotation.x, exitportal.transform.rotation.y, transform.rotation.z, transform.rotation.w);
        if (portalS[0].GetComponentInParent<PortalScript>().allClear == true && portalS[1].GetComponentInParent<PortalScript>().allClear == true)
        {
            //have fun with this one.
            reversemomentum.x = -35;
            reversemomentum = reversemomentum*-1;
            
        }


        
        //print(this.GetComponent<Rigidbody>().linearVelocity + "damping");
        //GetComponent<Rigidbody>().linearVelocity = Vector3.up*2;
        //GetComponent<Rigidbody>().AddForce(-2 * Physics.gravity, ForceMode.Acceleration);
        // transform.Translate(Vector3.right*4 * Time.deltaTime);

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "portal1")
        {
            exitportal = portalS[0];
        }
        if (other.gameObject.tag == "portal2")
        {
            exitportal = portalS[1];
        }
    }
}

using UnityEngine;
using UnityEngine.UIElements;

public class playerMotioncontrol : MonoBehaviour
{
    public Vector3 reversemomentum;
    public GameObject[] portalS;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        reversemomentum = this.GetComponent<Rigidbody>().linearVelocity;
        print(reversemomentum + "rev");
        if (portalS[0].GetComponentInParent<PortalScript>().allClear == true && portalS[1].GetComponentInParent<PortalScript>().allClear == true)
        {
            reversemomentum.y = -reversemomentum.y;
        }
        //print(this.GetComponent<Rigidbody>().linearVelocity + "damping");
        //GetComponent<Rigidbody>().linearVelocity = Vector3.up*2;
        //GetComponent<Rigidbody>().AddForce(-2 * Physics.gravity, ForceMode.Acceleration);
        // transform.Translate(Vector3.right*4 * Time.deltaTime);

    }
}

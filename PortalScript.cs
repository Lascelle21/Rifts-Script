using UnityEngine;

public class PortalScript : MonoBehaviour
{
    public GameObject portaL1;
    public GameObject portaL2;
    public GameObject[] PlayeRComponents;
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
            if (other.tag == "Player")
            {
                PlayeRComponents[0].transform.position = portaL2.transform.position;
                PlayeRComponents[1].transform.position = portaL2.transform.position;
                PlayeRComponents[2].transform.position = portaL2.transform.position;
                PlayeRComponents[3].transform.localPosition = portaL2.transform.position;

            }
        }
        //
    }
}

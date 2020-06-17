using UnityEngine;

public class Button5 : MonoBehaviour
{
    public GameObject gameObject;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            gameObject.GetComponent<AudioSource>().Play(0);
            gameObject.GetComponent<Animation>().Play("Button5Press");

            if (Global.isTimeInterval)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().ChangeNumber("5");
            }
            if (Global.isGPSARPIpAddress)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().ChangeNumber("5");
            }
            if (Global.isPgmConfigNetworkInterfaceEthernetAddressIP)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().ChangeNumber("5");
            }
            if (Global.isPgmConfigNetworkInterfacePPPAddressIP)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().ChangeNumber("5");
            }
            if (Global.isPgmConfigNetworkInterfacePPPAddressSubnet)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().ChangeNumber("5");
            }
            if (Global.isPgmConfigNetworkInterfacePPPAddressGetaway)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().ChangeNumber("5");
            }
            if (Global.isPgmConfigNetworkInterfaceWirelessAddressIP)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().ChangeNumber("5");
            }
            if (Global.isPgmConfigNetworkInterfaceWirelessAddressSubnet)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().ChangeNumber("5");
            }
            if (Global.isPgmConfigNetworkProtocolSNMPTrapAddress)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().ChangeNumber("9");
            }
        }
    }
}

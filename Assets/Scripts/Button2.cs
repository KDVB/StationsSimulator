using UnityEngine;

public class Button2 : MonoBehaviour
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
            gameObject.GetComponent<Animation>().Play("Button2Press");

            if (Global.isTimeInterval)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().ChangeNumber("2");
            }
            if (Global.isGPSARPIpAddress)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().ChangeNumber("2");
            }
            if (Global.isPgmConfigNetworkInterfaceEthernetAddressIP)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().ChangeNumber("2");
            }
            if (Global.isPgmConfigNetworkInterfacePPPAddressIP)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().ChangeNumber("2");
            }
            if (Global.isPgmConfigNetworkInterfacePPPAddressSubnet)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().ChangeNumber("2");
            }
            if (Global.isPgmConfigNetworkInterfacePPPAddressGetaway)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().ChangeNumber("2");
            }
            if (Global.isPgmConfigNetworkInterfaceWirelessAddressIP)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().ChangeNumber("2");
            }
            if (Global.isPgmConfigNetworkInterfaceWirelessAddressSubnet)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().ChangeNumber("2");
            }
            if (Global.isPgmConfigNetworkProtocolSNMPTrapAddress)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().ChangeNumber("2");
            }
        }
    }
}

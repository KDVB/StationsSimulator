using UnityEngine;

public class Button0 : MonoBehaviour
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
            gameObject.GetComponent<Animation>().Play("Button0Press");

            if (Global.isTimeInterval )
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().ChangeNumber("0");
            }
            if (Global.isGPSARPIpAddress)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().ChangeNumber("0");
            }
            if (Global.isPgmConfigNetworkInterfaceEthernetAddressIP)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().ChangeNumber("0");
            }
            if (Global.isPgmConfigNetworkInterfacePPPAddressIP)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().ChangeNumber("0");
            }
            if (Global.isPgmConfigNetworkInterfacePPPAddressSubnet)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().ChangeNumber("0");
            }
            if (Global.isPgmConfigNetworkInterfacePPPAddressGetaway)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().ChangeNumber("0");
            }
            if (Global.isPgmConfigNetworkInterfaceWirelessAddressIP)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().ChangeNumber("0");
            }
            if (Global.isPgmConfigNetworkInterfaceWirelessAddressSubnet)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().ChangeNumber("0");
            }
            if (Global.isPgmConfigNetworkProtocolSNMPTrapAddress)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().ChangeNumber("9");
            }
        }
    }
}

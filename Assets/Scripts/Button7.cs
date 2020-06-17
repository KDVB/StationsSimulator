using UnityEngine;

public class Button7 : MonoBehaviour
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
            gameObject.GetComponent<Animation>().Play("Button7Press");

            if (Global.isTimeInterval)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().ChangeNumber("7");
            }
            else if (Global.isGPSARPIpAddress)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().ChangeNumber("7");
            }
            else if (Global.isPgmConfigNetworkInterfaceEthernetAddressIP)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().ChangeNumber("7");
            }
            else if (Global.isPgmConfigNetworkInterfacePPPAddressIP)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().ChangeNumber("7");
            }
            else if (Global.isPgmConfigNetworkInterfacePPPAddressSubnet)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().ChangeNumber("7");
            }
            else if (Global.isPgmConfigNetworkInterfacePPPAddressGetaway)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().ChangeNumber("7");
            }
            else if (Global.isPgmConfigNetworkInterfaceWirelessAddressIP)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().ChangeNumber("7");
            }
            else if (Global.isPgmConfigNetworkInterfaceWirelessAddressSubnet)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().ChangeNumber("7");
            }
            else if (Global.isPgmConfigNetworkProtocolSNMPTrapAddress)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().ChangeNumber("9");
            }
            else if (Global.isLoad && !Global.isEightPress)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().DisableLoadMenu();
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().settingMenu[0].SetActive(true);
                Global.currentOption = "tod";
                Global.inSettingMenu = true;
                Global.isSevenPress = true;
            }
        }
    }
}

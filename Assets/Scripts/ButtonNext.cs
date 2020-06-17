using UnityEngine;

public class ButtonNext : MonoBehaviour
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
            gameObject.GetComponent<Animation>().Play("ButtonNextPress");
            if (Global.inSettingMenu)
            {
                if (Global.currentMenuItem == 4)
                {
                    GameObject.Find("GameGlobalVariables").GetComponent<Global>().settingMenu[0].SetActive(false);
                    GameObject.Find("GameGlobalVariables").GetComponent<Global>().settingMenu[1].SetActive(true);
                }
                if (Global.currentMenuItem == 6)
                {
                    GameObject.Find("GameGlobalVariables").GetComponent<Global>().settingMenu[0].SetActive(true);
                    GameObject.Find("GameGlobalVariables").GetComponent<Global>().settingMenu[1].SetActive(false);
                }
                if (Global.currentMenuItem != 6)
                {
                    GameObject.Find("GameGlobalVariables").GetComponent<Global>().ChangeColor(GameObject.Find("GameGlobalVariables").GetComponent<Global>().menuImages[Global.currentMenuItem],
                                                                                            GameObject.Find("GameGlobalVariables").GetComponent<Global>().menuItems[Global.currentMenuItem],
                                                                                            GameObject.Find("GameGlobalVariables").GetComponent<Global>().menuImages[Global.currentMenuItem + 1],
                                                                                            GameObject.Find("GameGlobalVariables").GetComponent<Global>().menuItems[Global.currentMenuItem + 1]);
                    Global.currentMenuItem++;
                }
                else
                {
                    GameObject.Find("GameGlobalVariables").GetComponent<Global>().ChangeColor(GameObject.Find("GameGlobalVariables").GetComponent<Global>().menuImages[Global.currentMenuItem],
                                                                                            GameObject.Find("GameGlobalVariables").GetComponent<Global>().menuItems[Global.currentMenuItem],
                                                                                            GameObject.Find("GameGlobalVariables").GetComponent<Global>().menuImages[0],
                                                                                            GameObject.Find("GameGlobalVariables").GetComponent<Global>().menuItems[0]);
                    Global.currentMenuItem = 0;
                }

            }
            if (Global.isARP)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().ArpChangeNext();
            }
            if (Global.isTest)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().TestChangeNext();
            }

            if (Global.isPgm)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().NextPgmMenuItem();
            }
            if (Global.isPgmComsec)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().NextPgmComsecMenu();
            }
            if(Global.isPgmComsecKeys)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().NextPgmComsecKeys();
            }
            if (Global.isPgmConfig)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().NextPgmConfigMenu();
            }
            if (Global.isPgmConfigPorts)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().NextPgmConfigPortMenu();
            }
            if (Global.isTimeInterval)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().NextTimeIntervalNumber();
            }
            if (Global.isGPSARPIpAddress)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().NextGPSARPIPAddressNumber();
            }
            if (Global.isPgmConfigNetwork)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().NextPgmConfigNetworkMenu();
            }
            if (Global.isPgmConfigNetworkInterface)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().NextPgmConfigNetworkInterfaceMenu();
            }
            if (Global.isPgmConfigNetworkInterfaceEthernet)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().NextPgmConfigNetworkInterfaceEthernetMenu();
            }
            if(Global.isPgmConfigNetworkInterfaceEthernetAddressIP)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().NextPgmConfigNetworkInterfaceEthernetAddressNumber();
            }
            if (Global.isPgmConfigNetworkInterfacePPP)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().NextPgmConfigNetworkInterfacePPPMenu();
            }
            if (Global.isPgmConfigNetworkInterfacePPPAddressIP)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().NextPgmConfigNetworkInterfacePPPAddressIPNumber();
            }
            if (Global.isPgmConfigNetworkInterfacePPPAddressSubnet)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().NextPgmConfigNetworkInterfacePPPAddressSubnetNumber();
            }
            if (Global.isPgmConfigNetworkInterfacePPPAddressGetaway)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().NextPgmConfigNetworkInterfacePPPAddressGetawayNumber();
            }
            if (Global.isPgmConfigNetworkInterfaceWireless)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().NextPgmConfigNetworkInterfaceWirelessMenu();
            }
            if (Global.isPgmConfigNetworkInterfaceWirelessAddressIP)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().NextPgmConfigNetworkInterfaceWirelessAddressIPNumber();
            }
            if (Global.isPgmConfigNetworkInterfaceWirelessAddressSubnet)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().NextPgmConfigNetworkInterfaceWirelessAddressSubnetNumber();
            }
            if (Global.isPgmConfigNetworkProtocolSNMPTrapAddress)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().NextPgmConfigNetworkProtocolSNMPTrapAddressNumber();
            }
            if (Global.isPgmConfigSMS)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().NextPgmConfigSMSMenu();
            }
        }
    }
}

using UnityEngine;

public class ButtonPrev : MonoBehaviour
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
            gameObject.GetComponent<Animation>().Play("ButtonPrevPress");
            if (Global.inSettingMenu)
            {
                if (Global.currentMenuItem == 0)
                {
                    GameObject.Find("GameGlobalVariables").GetComponent<Global>().settingMenu[0].SetActive(false);
                    GameObject.Find("GameGlobalVariables").GetComponent<Global>().settingMenu[1].SetActive(true);
                }
                if (Global.currentMenuItem == 5)
                {
                    GameObject.Find("GameGlobalVariables").GetComponent<Global>().settingMenu[0].SetActive(true);
                    GameObject.Find("GameGlobalVariables").GetComponent<Global>().settingMenu[1].SetActive(false);
                }
                if (Global.currentMenuItem != 0)
                {
                    GameObject.Find("GameGlobalVariables").GetComponent<Global>().ChangeColor(GameObject.Find("GameGlobalVariables").GetComponent<Global>().menuImages[Global.currentMenuItem],
                                                                                            GameObject.Find("GameGlobalVariables").GetComponent<Global>().menuItems[Global.currentMenuItem],
                                                                                            GameObject.Find("GameGlobalVariables").GetComponent<Global>().menuImages[Global.currentMenuItem - 1],
                                                                                            GameObject.Find("GameGlobalVariables").GetComponent<Global>().menuItems[Global.currentMenuItem - 1]);
                    Global.currentMenuItem--;
                }
                else
                {
                    GameObject.Find("GameGlobalVariables").GetComponent<Global>().ChangeColor(GameObject.Find("GameGlobalVariables").GetComponent<Global>().menuImages[Global.currentMenuItem],
                                                                                            GameObject.Find("GameGlobalVariables").GetComponent<Global>().menuItems[Global.currentMenuItem],
                                                                                            GameObject.Find("GameGlobalVariables").GetComponent<Global>().menuImages[6],
                                                                                            GameObject.Find("GameGlobalVariables").GetComponent<Global>().menuItems[6]);
                    Global.currentMenuItem = 6;
                }
            }
            if (Global.isARP)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().ArpChangePrev();
            }
            if (Global.isTest)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().TestChangePrev();
            }

            if(Global.isPgm)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().PrevPgmMenuItem();
            }
            if(Global.isPgmComsec)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().PrevPgmComsecMenu();
            }
            if (Global.isPgmComsecKeys)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().PrevPgmComsecKeys();
            }
            if(Global.isPgmConfig)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().PrevPgmConfigMenu();
            }
            if(Global.isPgmConfigPorts)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().PrevPgmConfigPortMenu();
            }
            if(Global.isTimeInterval)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().PrevTimeIntervalNumber();
            }
            if (Global.isGPSARPIpAddress)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().PrevGPSARPIPAddressNumber();
            }
            if(Global.isPgmConfigNetwork)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().PrevPgmConfigNetworkMenu();
            }
            if(Global.isPgmConfigNetworkInterface)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().PrevPgmConfigNetworkInterfaceMenu();
            }
            if (Global.isPgmConfigNetworkInterfaceEthernet)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().PrevPgmConfigNetworkInterfaceEthernetMenu();
            }
            if (Global.isPgmConfigNetworkInterfaceEthernetAddressIP)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().PrevPgmConfigNetworkInterfaceEthernetAddressNumber();
            }
            if (Global.isPgmConfigNetworkInterfacePPP)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().PrevPgmConfigNetworkInterfacePPPMenu();
            }
            if (Global.isPgmConfigNetworkInterfacePPPAddressIP)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().PrevPgmConfigNetworkInterfacePPPAddressIPNumber();
            }
            if (Global.isPgmConfigNetworkInterfacePPPAddressSubnet)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().PrevPgmConfigNetworkInterfacePPPAddressSubnetNumber();
            }
            if (Global.isPgmConfigNetworkInterfacePPPAddressGetaway)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().PrevPgmConfigNetworkInterfacePPPAddressGetawayNumber();
            }
            if(Global.isPgmConfigNetworkInterfaceWireless)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().PrevPgmConfigNetworkInterfaceWirelessMenu();
            }
            if (Global.isPgmConfigNetworkInterfaceWirelessAddressIP)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().PrevPgmConfigNetworkInterfaceWirelessAddressIPNumber();
            }
            if (Global.isPgmConfigNetworkInterfaceWirelessAddressSubnet)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().PrevPgmConfigNetworkInterfaceWirelessAddressSubnetNumber();
            }
            if(Global.isPgmConfigNetworkProtocolSNMPTrapAddress)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().PrevPgmConfigNetworkProtocolSNMPTrapAddressNumber();
            }
            if(Global.isPgmConfigSMS)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().PrevPgmConfigSMSMenu();
            }
        }
    }
}

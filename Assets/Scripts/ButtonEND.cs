using UnityEngine;

public class ButtonEND : MonoBehaviour
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
            gameObject.GetComponent<Animation>().Play("ButtonENDPress");
            if (Global.inSettingMenu)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().EnterSettings();
                Global.inSettingMenu = false;
            }
            else
            {
                if (Global.isTod)
                {
                    GameObject.Find("GameGlobalVariables").GetComponent<Global>().DisableLoadMenu();
                    GameObject.Find("GameGlobalVariables").GetComponent<Global>().settingMenu[0].SetActive(true);
                    Global.inSettingMenu = true;
                }
                else if (Global.isRadio)
                {
                    GameObject.Find("GameGlobalVariables").GetComponent<Global>().RadioSetting();
                }
                else if (Global.isScan)
                {
                    GameObject.Find("GameGlobalVariables").GetComponent<Global>().DisableLoadMenu();
                    GameObject.Find("GameGlobalVariables").GetComponent<Global>().settingMenu[0].SetActive(true);
                    Global.inSettingMenu = true;
                }
                else if (Global.isARP)
                {
                    if (!Global.arpConfig && !Global.arpView)
                    {
                        GameObject.Find("GameGlobalVariables").GetComponent<Global>().ArpEnter();
                    }
                    else
                    {
                        if (Global.arpView)
                        {
                            GameObject.Find("GameGlobalVariables").GetComponent<Global>().ArpViewChange();
                        }
                        else if (Global.arpConfig)
                        {
                            GameObject.Find("GameGlobalVariables").GetComponent<Global>().ArpConfigChange();
                        }
                    }

                }
                else if (Global.isAcc)
                {
                    GameObject.Find("GameGlobalVariables").GetComponent<Global>().AccSettings();
                }
                else if (Global.isTest)
                {
                    if (Global.isBit)
                    {
                        GameObject.Find("GameGlobalVariables").GetComponent<Global>().TestPassed();
                    }
                    else
                        GameObject.Find("GameGlobalVariables").GetComponent<Global>().EnterTestSetting();

                }
            }
            if (Global.isPgm)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().EnterPgmMenu();
            }
            else if (Global.isPgmComsec)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().EnterPgmComsecMenu();
            }
            else if (Global.isPgmComsecCam)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().EnterPgmComsecCam();
            }
            else if (Global.isPgmComsecID)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().EnterPgmComsecId();
            }
            else if (Global.isPgmComsecKeys)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().DisableLoadMenu();
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().EnterPgmComsecKeys();
            }
            else if (Global.isPgmComsecKeysEnter || Global.isPgmComsecKeysErase || Global.isPgmComsecKeysUpdate)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().DisableLoadMenu();
                Global.isPgmComsec = true;
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().comsecMenu.SetActive(true);
            }
            else if (Global.isPgmConfig)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().EnterPgmConfigMenu();
            }
            else if (Global.isPgmConfigRadio)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().EnterPgmConfigRadio();
            }
            else if (Global.isPgmConfigPorts)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().EnterPgmConfigPortMenu();
            }
            else if (Global.isPgmConfigPortsData)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().EnterPgmConfigPortData();
            }
            else if (Global.isPgmConfigPortsAscii)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().EnterPgmConfigPortAscii();
            }
            else if (Global.isPgmConfigAudio)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().EnterPgmConfigAudio();
            }
            else if (Global.isPgmConfigMessage)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().EnterPgmConfigMessage();
            }
            else if (Global.isPgmConfigLPC)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().EnterPgmConfigLPC();
            }
            else if (Global.isPgmConfigGPS)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().EnterPgmConfigGPS();
            }
            else if (Global.isPgmConfigGPSAPR)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().EnterPgmConfigGPSARP();
            }
            else if (Global.isPgmConfigAccessory)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().EnterPgmConfigAccessory();
            }
            else if (Global.isPgmConfigNetwork)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().EnterPgmConfigNetwork();
            }
            else if (Global.isPgmConfigNetworkInterface)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().EnterPgmConfigNetworkInterface();
            }
            else if (Global.isPgmConfigNetworkInterfaceEthernet)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().EnterPgmConfigNetworkInterfaceEthernet();
            }
            else if (Global.isPgmConfigNetworkInterfaceEthernetAddress)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().EnterPgmConfigNetworkInterfaceEthernetAddress();
            }
            else if (Global.isPgmConfigNetworkInterfaceEthernetStatus)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().EnterPgmConfigNetworkInterfaceEthernetStatus();
            }
            else if (Global.isPgmConfigNetworkInterfacePPP)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().EnterPgmConfigNetworkInterfacePPP();
            }
            else if (Global.isPgmConfigNetworkInterfacePPPAddress)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().EnterPgmConfigNetworkInterfacePPPAddress();
            }
            else if (Global.isPgmConfigNetworkInterfacePPPStatus)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().EnterPgmConfigNetworkInterfacePPPStatus();
            }
            else if (Global.isPgmConfigNetworkInterfacePPPPortSetting)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().EnterPgmConfigNetworkInterfacePPPPortSetting();
            }
            else if (Global.isPgmConfigNetworkInterfaceWireless)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().EnterPgmConfigNetworkInterfaceWireless();
            }
            else if (Global.isPgmConfigNetworkInterfaceWirelessAddress)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().EnterPgmConfigNetworkInterfaceWirelessAddress();
            }
            else if (Global.isPgmConfigNetworkInterfaceWirelessStatus)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().EnterPgmConfigNetworkInterfaceWirelessStatus();
            }
            else if (Global.isPgmConfigNetworkProtocol)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().EnterPgmConfigNetworkProtocol();
            }
            else if (Global.isPgmConfigNetworkProtocolSNMP)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().EnterPgmConfigNetworkProtocolSNMP();
            }
            else if (Global.isPgmConfigARQ)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().EnterPgmConfigARQ();
            }
            else if (Global.isPgmConfigLDV)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().EnterPgmConfigLDV();
            }
            else if (Global.isPgmConfigSMS)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().EnterPgmConfigSMS();
            }
            else if(Global.isPgmConfigSMSSetting)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().EnterPgmConfigSMSSetting();
            }
        }
    }
}

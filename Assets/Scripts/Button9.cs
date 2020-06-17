using UnityEngine;

public class Button9 : MonoBehaviour
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
            gameObject.GetComponent<Animation>().Play("Button9Press");
            if (Global.isRadio)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().RadioChangeDown();
            }
            if (Global.isScan)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().ScanChangeDown();
            }
            if (Global.arpConfig)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().ArpConfigChangeDown();
            }
            if (Global.isTest && Global.currentTestItem == 0)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().TestBitSettingDown();
            }
            if (Global.isPgmConfigRadio)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().PgmConfigRadioDown();
            }
            if (Global.isPgmConfigPortsData)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().PgmConfigPortDataDown();
            }
            if (Global.isPgmConfigPortsAscii)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().PgmConfigPortAsciiDown();
            }
            if (Global.isPgmConfigAudio)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().PgmConfigAudioDown();
            }
            if (Global.isPgmConfigMessage)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().PgmConfigMessageDown();
            }
            if (Global.isPgmConfigLPC)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().PgmConfigLPCDown();
            }
            if (Global.isPgmConfigGPS)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().PgmConfigGPSDown();
            }
            if (Global.isPgmConfigGPSAPR)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().PgmConfigGPSARPDown();
            }
            if (Global.isTimeInterval)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().ChangeNumber("9");
            }
            if (Global.isGPSARPIpAddress)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().ChangeNumber("9");
            }
            if (Global.isPgmConfigAccessory)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().PgmConfigAccessoryDown();
            }
            if (Global.isPgmConfigNetworkInterfaceEthernetAddress)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().PgmConfigNetworkInterfaceEthernetAddressDown();
            }
            if (Global.isPgmConfigNetworkInterfaceEthernetAddressIP)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().ChangeNumber("9");
            }
            if (Global.isPgmConfigNetworkInterfacePPPAddressIP)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().ChangeNumber("9");
            }
            if (Global.isPgmConfigNetworkInterfacePPPAddressSubnet)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().ChangeNumber("9");
            }
            if (Global.isPgmConfigNetworkInterfacePPPAddressGetaway)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().ChangeNumber("9");
            }
            if (Global.isPgmConfigNetworkInterfacePPPAddress)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().PgmConfigNetworkInterfacePPPAddressDown();
            }
            if (Global.isPgmConfigNetworkInterfacePPPPortSetting)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().PgmConfigNetworkInterfacePPPPortSettingDown();
            }
            if (Global.isPgmConfigNetworkInterfaceWirelessAddressIP)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().ChangeNumber("9");
            }
            if (Global.isPgmConfigNetworkInterfaceWirelessAddressSubnet)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().ChangeNumber("9");
            }
            if (Global.isPgmConfigNetworkInterfaceWirelessAddress)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().PgmConfigNetworkInterfaceWirelessAddressDown();
            }
            if (Global.isPgmConfigNetworkProtocolSNMPTrapAddress)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().ChangeNumber("9");
            }
            if (Global.isPgmConfigNetworkProtocolSNMP)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().PgmConfigNetworkProtocolSNMPDown();
            }
            if (Global.isPgmConfigARQ)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().PgmConfigARQDown();
            }
            if (Global.isPgmConfigLDV)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().PgmConfigLDVDown();
            }
            if (Global.isPgmConfigSMSSetting)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().PgmConfigSMSSettingDown();
            }
        }
    }
}

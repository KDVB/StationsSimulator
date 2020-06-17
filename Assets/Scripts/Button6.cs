using UnityEngine;

public class Button6 : MonoBehaviour
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
            gameObject.GetComponent<Animation>().Play("Button6Press");
            if (Global.isRadio)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().RadioChangeUp();
            }
            if (Global.isScan)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().ScanChangeUp();
            }
            if (Global.arpConfig)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().ArpConfigChangeUp();
            }
            if (Global.isTest && Global.currentTestItem == 0)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().TestBitSettingUp();
            }
            if(Global.isPgmConfigRadio)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().PgmConfigRadioUp();
            }
            if(Global.isPgmConfigPortsData)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().PgmConfigPortDataUp();
            }
            if (Global.isPgmConfigPortsAscii)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().PgmConfigPortAsciiUp();
            }
            if (Global.isPgmConfigAudio)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().PgmConfigAudioUp();
            }
            if (Global.isPgmConfigMessage)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().PgmConfigMessageUp();
            }
            if (Global.isPgmConfigLPC)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().PgmConfigLPCUp();
            }
            if (Global.isPgmConfigGPS)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().PgmConfigGPSUp();
            }
            if (Global.isPgmConfigGPSAPR)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().PgmConfigGPSARPUp();
            }
            if (Global.isTimeInterval)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().ChangeNumber("6");
            }
            if (Global.isGPSARPIpAddress)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().ChangeNumber("6");
            }
            if (Global.isPgmConfigAccessory)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().PgmConfigAccessoryUp();
            }
            if(Global.isPgmConfigNetworkInterfaceEthernetAddress)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().PgmConfigNetworkInterfaceEthernetAddressUp();
            }
            if(Global.isPgmConfigNetworkInterfaceEthernetAddressIP)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().ChangeNumber("6");
            }
            if (Global.isPgmConfigNetworkInterfacePPPAddressIP)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().ChangeNumber("6");
            }
            if (Global.isPgmConfigNetworkInterfacePPPAddressSubnet)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().ChangeNumber("6");
            }
            if (Global.isPgmConfigNetworkInterfacePPPAddressGetaway)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().ChangeNumber("6");
            }
            if(Global.isPgmConfigNetworkInterfacePPPAddress)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().PgmConfigNetworkInterfacePPPAddressUp();
            }
            if(Global.isPgmConfigNetworkInterfacePPPPortSetting)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().PgmConfigNetworkInterfacePPPPortSettingUp();
            }
            if (Global.isPgmConfigNetworkInterfaceWirelessAddressIP)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().ChangeNumber("6");
            }
            if (Global.isPgmConfigNetworkInterfaceWirelessAddressSubnet)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().ChangeNumber("6");
            }
            if(Global.isPgmConfigNetworkInterfaceWirelessAddress)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().PgmConfigNetworkInterfaceWirelessAddressUp();
            }
            if (Global.isPgmConfigNetworkProtocolSNMPTrapAddress)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().ChangeNumber("6");
            }
            if(Global.isPgmConfigNetworkProtocolSNMP)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().PgmConfigNetworkProtocolSNMPUp();
            }
            if(Global.isPgmConfigARQ)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().PgmConfigARQUp();
            }
            if (Global.isPgmConfigLDV)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().PgmConfigLDVUp();
            }
            if (Global.isPgmConfigSMSSetting)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().PgmConfigSMSSettingUp();
            }
        }
    }
}

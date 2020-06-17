using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Global : MonoBehaviour
{
    
    public static bool isLesson = false;    //перевіряє чи користувач знаходиться у меню, чи проходить урок
    public static int currentTask = 0;  //індекс поточного завдання з уроку, яке потрібно виконати

    public static string path = @"\Documentation\Harris RF-7800";
    public static string testPath = @"\Documentation\Tests";

    public static string currentOption = "";    //зміна для перевірки вибраного елементу стрілками вверх та вниз (використовується для зміни відображення підсказок)

    public static Dictionary<string, string> keyValues = new Dictionary<string, string>();  //словник змінних та відповідних їм написам, які будуть відображатись при виконанні завдання
    public static Dictionary<string, string> currentTasks = new Dictionary<string, string>();   //словник для зміних та значеннями, які потрібно досягти для виконання уроку

    public static GameObject taskArrow;     //ігровий обьект стрілки, яка відображає поточне завдання на виконання
    public static float arrowPosition;  //позиція стрілки
    public static bool isCouplerIn = false;     //перевірка підключення антени

    public static int currentStation = 0;   //індекс для переключення станцій
    public GameObject[] stations;   //масив колайдерів розташованих навколо моделей станцій
    public GameObject[] stationsModel;  //масив моделей станцій

    public static string currentMode = "";  //поточний режим роботи Harris 7800
    public static bool modeSwitch = false;  //включення станції
    public static bool isLoad = false;  //завантаження станції
    public static bool inSettingMenu = false;   //натиснення кнопки 7 та перехід у меню налаштувань
    public static bool isTurn = false;  
    public static bool exitAcc = false;   //вихід з меню Acc-Ext  

    public static bool isTod = false;   //перехід у меню GPS-TOD
    public static bool isRadio = false; //перехід у меню Radio
    public static bool isScan = false;  //перехід у меню Scan
    public static bool isARP = false;   //перехід у меню ARP
    public static bool isAcc = false;   //перехід у меню ACC-EXT
    public static bool arpView = false; //перехід у меню Arp View
    public static bool arpConfig = false;   //перехід у меню Arp Config
    public static bool isTest = false;  //перехід у меню Test
    public static bool isBit = false;   //перехід у меню BIT Test

    public static string txLevel = "";  //Значення Radio TX Level
    public static string squelchLevel = ""; //Значення Radio Squelch Level
    public static string fm = "";           //Значення Radio FM
    public static string internalCoupler = "";  //Значення Radio Internal
    public static string radioSilence = ""; //Значення Radio silence
    public static string bfo = "";  //Значення Radio BFO
    public static string rxNoise = "";  //Значення Radio RX Noise
    public static string radioLock = "";    //Значення Radio Lock

    public static List<TextMeshProUGUI> tasks = new List<TextMeshProUGUI>(); //масив текстових полів для відображення на інтерфейсі завдань поточного уроку

    public static float timeLoad = 0f;  //для симуляції завантаження Harris 7800

    public GameObject[] loadMenu = new GameObject[4];   //Вікна для завантаження станції

    public GameObject[] settingMenu = new GameObject[2];    //вікна для меню кнопки 7
    public TextMeshProUGUI[] menuItems = new TextMeshProUGUI[7];    //текстові поля вікон кнопки номер 7
    public Image[] menuImages = new Image[7];   //картинки вікон кнопки номер 7

    public GameObject Gps;  //вікно для відображення меню GPS-TOD
    public GameObject[] radioSettings = new GameObject[9];  //вікно для відображення меню Radio
    public GameObject scanSetting;  //вікно для відображення меню Scan
    public GameObject arpSetting;   //вікно для відображення меню ARP
    public Image[] arpMenuImage = new Image[2]; //картинки вікон меню ARP
    public TextMeshProUGUI[] arpMenuText = new TextMeshProUGUI[2];  //текстові поля вікон меню ARP
    public GameObject[] arpViewSettings = new GameObject[4];   //вікно для відображення меню ARP View 
    public GameObject arpConfigSetting;     //вікно для відображення меню ARP config
    public GameObject[] extSetting = new GameObject[4]; //вікно для відображення меню Acc-Ext

    public GameObject[] arpConfigImage = new GameObject[2];  //картинки вікон меню ARP config

    public GameObject[] firstRadioImage = new GameObject[3];    //картинки для вибору значення поточної властивості у меню Radio
    public GameObject[] secondRadioImage = new GameObject[3];   //картинки для вибору значення поточної властивості у меню Radio
    public GameObject[] thirdRadioImage = new GameObject[2];    //картинки для вибору значення поточної властивості у меню Radio
    public GameObject[] fourthRadioImage = new GameObject[2];   //картинки для вибору значення поточної властивості у меню Radio
    public GameObject[] fifthRadioImage = new GameObject[2];    //картинки для вибору значення поточної властивості у меню Radio
    public GameObject[] sithRadioImage = new GameObject[3];     //картинки для вибору значення поточної властивості у меню Radio
    public GameObject[] seventhRadioImage = new GameObject[2];  //картинки для вибору значення поточної властивості у меню Radio
    public GameObject[] eigthRadioImage = new GameObject[2];    //картинки для вибору значення поточної властивості у меню Radio

    public GameObject[] scanImage = new GameObject[2];  //вікно для відображення меню Scan

    public GameObject testSetting;  //вікно для відображення меню Test
    public Image[] testSettingMenuImage = new Image[6]; //картинки вікон меню Test
    public TextMeshProUGUI[] testSettingMenuText = new TextMeshProUGUI[6];  //текстові поля вікон меню Test

    public GameObject bitTest;
    public GameObject[] bitTestMode = new GameObject[7];
    public GameObject[] testInProgress = new GameObject[3];

    public GameObject[] pgmMenu = new GameObject[2];
    public TextMeshProUGUI[] pgmMenuItems = new TextMeshProUGUI[6];
    public Image[] pgmMenuImages = new Image[6];

    public GameObject comsecMenu = new GameObject();
    public TextMeshProUGUI[] comsecMenuItems = new TextMeshProUGUI[5];
    public Image[] comsecMenuImages = new Image[5];

    public GameObject[] camMenu = new GameObject[2];

    public GameObject[] idMenu = new GameObject[2];

    public GameObject keysMenu = new GameObject();
    public TextMeshProUGUI[] keysMenuItems = new TextMeshProUGUI[3];
    public Image[] keysMenuImages = new Image[3];

    public GameObject keysEnterMenu = new GameObject();
    public GameObject[] keysEnterMenuItems = new GameObject[3];

    public GameObject keysUpdateMenu = new GameObject();
    public GameObject[] keysUpdateMenuItems = new GameObject[3];

    public GameObject keysEraseMenu = new GameObject();
    public GameObject[] keysEraseMenuItems = new GameObject[3];

    public GameObject[] pgmConfigMenu = new GameObject[3];
    public TextMeshProUGUI[] pgmConfigMenuItems = new TextMeshProUGUI[14];
    public Image[] pgmConfigMenuImages = new Image[14];

    public GameObject[] pgmConfigRadioScreens = new GameObject[13];

    public GameObject[] firstScreenPgmRadioItems = new GameObject[3];
    public GameObject[] secondScreenPgmRadioItems = new GameObject[2];
    public GameObject[] thirdScreenPgmRadioItems = new GameObject[3];
    public GameObject[] fourthScreenPgmRadioItems = new GameObject[2];
    public GameObject[] fifthScreenPgmRadioItems = new GameObject[2];
    public GameObject[] sixthScreenPgmRadioItems = new GameObject[2];
    public GameObject[] seventhScreenPgmRadioItems = new GameObject[2];
    public GameObject[] eighthScreenPgmRadioItems = new GameObject[6];
    public GameObject[] ninethScreenPgmRadioItems = new GameObject[2];
    public GameObject[] tenthScreenPgmRadioItems = new GameObject[2];
    public GameObject[] eleventhScreenPgmRadioItems = new GameObject[2];
    public GameObject[] thirdteenthScreenPgmRadioItems = new GameObject[2];

    public GameObject pgmConfigPortsMenu = new GameObject();
    public TextMeshProUGUI[] pgmConfigPortsMenuItems = new TextMeshProUGUI[2];
    public Image[] pgmConfigPortsMenuImages = new Image[2];

    public GameObject[] pgmConfigPortsDataMenu = new GameObject[11];
    public GameObject[] firstScreenPgmConfigPortsDataItems = new GameObject[8];
    public GameObject[] secondScreenPgmConfigPortsDataItems = new GameObject[4];
    public GameObject[] thirdScreenPgmConfigPortsDataItems = new GameObject[2];
    public GameObject[] fourthScreenPgmConfigPortsDataItems = new GameObject[3];
    public GameObject[] fifthScreenPgmConfigPortsDataItems = new GameObject[3];
    public GameObject[] sixthScreenPgmConfigPortsDataItems = new GameObject[2];
    public GameObject[] seventhScreenPgmConfigPortsDataItems = new GameObject[1];
    public GameObject[] eighthScreenPgmConfigPortsDataItems = new GameObject[2];
    public GameObject[] ninethScreenPgmConfigPortsDataItems = new GameObject[2];
    public GameObject[] tenthScreenPgmConfigPortsDataItems = new GameObject[2];
    public GameObject[] eleventhScreenPgmConfigPortsDataItems = new GameObject[2];

    public GameObject[] pgmConfigPortsAsciiMenu = new GameObject[6];
    public GameObject[] firstScreenPgmConfigPortsAsciiItems = new GameObject[2];
    public GameObject[] secondScreenPgmConfigPortsAsciiItems = new GameObject[2];
    public GameObject[] thirdScreenPgmConfigPortsAsciiItems = new GameObject[2];
    public GameObject[] fourthScreenPgmConfigPortsAsciiItems = new GameObject[3];
    public GameObject[] fifthScreenPgmConfigPortsAsciiItems = new GameObject[2];
    public GameObject[] sixScreenPgmConfigPortsAsciiItems = new GameObject[2];

    public GameObject[] pgmConfigAudioMenu = new GameObject[2];
    public GameObject[] firstScreenPgmConfigAudioItems = new GameObject[2];
    public GameObject[] secondScreenPgmConfigAudioItems = new GameObject[2];

    public GameObject[] pgmConfigMessageMenu = new GameObject[5];
    public GameObject[] firstScreenPgmConfigMessageItems = new GameObject[3];
    public GameObject[] secondScreenPgmConfigMessageItems = new GameObject[3];
    public GameObject[] thirdScreenPgmConfigMessageItems = new GameObject[2];
    public GameObject[] fourthScreenPgmConfigMessageItems = new GameObject[2];
    public GameObject[] fifthScreenPgmConfigMessageItems = new GameObject[2];

    public GameObject[] pgmConfigLpcMenu = new GameObject[1];
    public GameObject[] firstScreenPgmConfigLpcItems = new GameObject[2];

    public GameObject[] pgmConfigGPSMenu = new GameObject[6];
    public GameObject[] firstScreenPgmConfigGPSItems = new GameObject[6];
    public GameObject[] secondScreenPgmConfigGPSItems = new GameObject[7];
    public GameObject[] secondScreenPgmConfigGPSTexts = new GameObject[7];
    public GameObject[] thirdScreenPgmConfigGPSItems = new GameObject[3];
    public GameObject[] fourthScreenPgmConfigGPSItems = new GameObject[2];
    public GameObject[] fifthScreenPgmConfigGPSItems = new GameObject[6];
    public GameObject[] sixScreenPgmConfigGPSItems = new GameObject[7];

    public GameObject[] pgmConfigGPSARPMenu = new GameObject[6];
    public GameObject[] firstScreenPgmConfigGPSARPItems = new GameObject[2];
    public Image[] secondScreenPgmConfigGPSARPImages = new Image[6];
    public TextMeshProUGUI[] secondScreenPgmConfigGPSARPTexts = new TextMeshProUGUI[6];
    public GameObject[] thirdScreenPgmConfigGPSARPItems = new GameObject[2];
    public GameObject[] fourthScreenPgmConfigGPSARPItems = new GameObject[2];
    public Image[] fifthScreenPgmConfigGPSARPImages = new Image[12];
    public TextMeshProUGUI[] fifthScreenPgmConfigGPSARPTexts = new TextMeshProUGUI[12];
    public GameObject[] sixScreenPgmConfigGPSARPItems = new GameObject[2];

    public GameObject[] pgmConfigAccessoryMenu = new GameObject[7];
    public GameObject[] firstScreenPgmConfigAccessoryItems = new GameObject[2];
    public GameObject[] secondScreenPgmConfigAccessoryItems = new GameObject[2];
    public GameObject[] thirdScreenPgmConfigAccessoryItems = new GameObject[2];
    public GameObject[] fourthScreenPgmConfigAccessoryItems = new GameObject[2];
    public GameObject[] fifthScreenPgmConfigAccessoryItems = new GameObject[2];
    public GameObject[] sixScreenPgmConfigAccessoryItems = new GameObject[2];
    public GameObject[] seventhScreenPgmConfigAccessoryItems = new GameObject[2];

    public GameObject pgmConfigNetworkMenu = new GameObject();
    public TextMeshProUGUI[] pgmConfigNetworkMenuItems = new TextMeshProUGUI[3];
    public Image[] pgmConfigNetworkMenuImages = new Image[3];

    public GameObject pgmConfigNetworkInterfaceMenu = new GameObject();
    public TextMeshProUGUI[] pgmConfigNetworkInterfaceMenuItems = new TextMeshProUGUI[3];
    public Image[] pgmConfigNetworkInterfaceMenuImages = new Image[3];

    public GameObject pgmConfigNetworkInterfaceEthernetMenu = new GameObject();
    public TextMeshProUGUI[] pgmConfigNetworkInterfaceEthernetMenuItems = new TextMeshProUGUI[2];
    public Image[] pgmConfigNetworkInterfaceEthernetMenuImages = new Image[2];

    public GameObject[] pgmConfigNetworkInterfaceEthernetAddressMenu = new GameObject[3];
    public GameObject[] firstScreenPgmConfigNetworkInterfaceEthernetAddressItems = new GameObject[2];
    public GameObject[] secondScreenPgmConfigNetworkInterfaceEthernetAddressItems = new GameObject[2];
    public Image[] thirdScreenPgmConfigNetworkInterfaceEthernetAddressImages = new Image[12];
    public TextMeshProUGUI[] thirdScreenPgmConfigNetworkInterfaceEthernetAddressTexts = new TextMeshProUGUI[12];

    public GameObject pgmConfigNetworkInterfaceEthernetStatusMenu = new GameObject();

    public GameObject pgmConfigNetworkInterfacePPPMenu = new GameObject();
    public TextMeshProUGUI[] pgmConfigNetworkInterfacePPPMenuItems = new TextMeshProUGUI[3];
    public Image[] pgmConfigNetworkInterfacePPPMenuImages = new Image[3];

    public GameObject[] pgmConfigNetworkInterfacePPPAddressMenu = new GameObject[7];
    public GameObject[] firstScreenPgmConfigNetworkInterfacePPPAddressItems = new GameObject[2];
    public Image[] secondScreenPgmConfigNetworkInterfacePPPAddressImages = new Image[12];
    public TextMeshProUGUI[] secondScreenPgmConfigNetworkInterfacePPPAddressTexts = new TextMeshProUGUI[12];
    public GameObject[] thirdScreenPgmConfigNetworkInterfacePPPAddressItems = new GameObject[2];
    public GameObject[] fourthScreenPgmConfigNetworkInterfacePPPAddressItems = new GameObject[2];
    public Image[] fifthScreenPgmConfigNetworkInterfacePPPAddressImages = new Image[12];
    public TextMeshProUGUI[] fifthScreenPgmConfigNetworkInterfacePPPAddressTexts = new TextMeshProUGUI[12];
    public GameObject[] sixthScreenPgmConfigNetworkInterfacePPPAddressItems = new GameObject[2];
    public Image[] seventhScreenPgmConfigNetworkInterfacePPPAddressImages = new Image[12];
    public TextMeshProUGUI[] seventhScreenPgmConfigNetworkInterfacePPPAddressTexts = new TextMeshProUGUI[12];

    public GameObject[] pgmConfigNetworkInterfacePPPStatusMenu = new GameObject[4];

    public GameObject[] pgmConfigNetworkInterfacePPPPortSettingMenu = new GameObject[6];
    public GameObject[] firstScreenPgmConfigNetworkInterfacePPPPortSettingItems = new GameObject[4];

    public GameObject pgmConfigNetworkInterfaceWirelessMenu = new GameObject();
    public TextMeshProUGUI[] pgmConfigNetworkInterfaceWirelessMenuItems = new TextMeshProUGUI[2];
    public Image[] pgmConfigNetworkInterfaceWirelessMenuImages = new Image[2];

    public GameObject[] pgmConfigNetworkInterfaceWirelessAddressMenu = new GameObject[5];
    public GameObject[] firstScreenPgmConfigNetworkInterfaceWirelessAddressItems = new GameObject[2];
    public Image[] secondScreenPgmConfigNetworkInterfaceWirelessAddressImages = new Image[12];
    public TextMeshProUGUI[] secondScreenPgmConfigNetworkInterfaceWirelessAddressTexts = new TextMeshProUGUI[12];
    public Image[] thirdScreenPgmConfigNetworkInterfaceWirelessAddressImages = new Image[12];
    public TextMeshProUGUI[] thirdScreenPgmConfigNetworkInterfaceWirelessAddressTexts = new TextMeshProUGUI[12];
    public GameObject[] fourthScreenPgmConfigNetworkInterfaceWirelessAddressItems = new GameObject[2];
    public GameObject[] fifthScreenPgmConfigNetworkInterfaceWirelessAddressItems = new GameObject[3];

    public GameObject pgmConfigNetworkInterfaceWirelessStatusMenu = new GameObject();

    public GameObject pgmConfigNetworkProtocolMenu = new GameObject();

    public GameObject[] pgmConfigNetworkProtocolSNMPMenu = new GameObject[2];
    public GameObject[] firstScreenPgmConfigNetworkProtocolSNMPItems = new GameObject[3];
    public Image[] secondScreenPgmConfigNetworkProtocolSNMPImages = new Image[12];
    public TextMeshProUGUI[] secondScreenPgmConfigNetworkProtocolSNMPTexts = new TextMeshProUGUI[12];

    public GameObject pgmConfigNetworkRoutesMenu = new GameObject();
    public TextMeshProUGUI[] pgmConfigNetworkRoutesMenuItems = new TextMeshProUGUI[2];
    public Image[] pgmConfigNetworkRoutesMenuImages = new Image[2];

    public GameObject pgmConfigNetworkRoutesIndividualMenu = new GameObject();
    public TextMeshProUGUI[] pgmConfigNetworkRoutesIndividualMenuItems = new TextMeshProUGUI[4];
    public Image[] pgmConfigNetworkRoutesIndividualMenuImages = new Image[4];

    public GameObject[] pgmConfigNetworkRoutesIndividualAddMenu = new GameObject[5];
    public GameObject[] firstScreenPgmConfigNetworkRoutesIndividualAddItems = new GameObject[12];
    public GameObject[] secondScreenPgmConfigNetworkRoutesIndividualAddItems = new GameObject[12];
    public GameObject[] thirdScreenPgmConfigNetworkRoutesIndividualAddItems = new GameObject[12];
    public GameObject[] fourthScreenPgmConfigNetworkRoutesIndividualAddItems = new GameObject[3];
    public GameObject[] fifthScreenPgmConfigNetworkRoutesIndividualAddItems = new GameObject[2];

    public GameObject pgmConfigNetworkRoutesIndividualEditMenu = new GameObject();

    public GameObject[] pgmConfigARQMenu = new GameObject[3];
    public GameObject[] firstScreenPgmConfigARQItems = new GameObject[2];
    public GameObject[] secondScreenPgmConfigARQItems = new GameObject[7];
    public GameObject[] thirdScreenPgmConfigARQItems = new GameObject[2];

    public GameObject[] pgmConfigLDVMenu = new GameObject[3];
    public GameObject[] firstScreenPgmConfigLDVItems = new GameObject[2];
    public GameObject[] secondScreenPgmConfigLDVItems = new GameObject[2];
    public GameObject[] thirdScreenPgmConfigLDVItems = new GameObject[4];

    public GameObject pgmConfigSMSMenu = new GameObject();
    public TextMeshProUGUI[] pgmConfigSMSMenuItems = new TextMeshProUGUI[2];
    public Image[] pgmConfigSMSMenuImages = new Image[2];

    public GameObject[] pgmConfigSMSSettingMenu = new GameObject[10];
    public GameObject[] firstScreenPgmConfigSMSSettingItems = new GameObject[2];
    public GameObject[] secondScreenPgmConfigSMSSettingItems = new GameObject[2];
    public GameObject[] thirdScreenPgmConfigSMSSettingItems = new GameObject[2];
    public GameObject[] fourthScreenPgmConfigSMSSettingItems = new GameObject[2];
    public GameObject[] fifthScreenPgmConfigSMSSettingItems = new GameObject[2];
    public GameObject[] sixthScreenPgmConfigSMSSettingItems = new GameObject[2];
    public GameObject[] seventhScreenPgmConfigSMSSettingItems = new GameObject[3];
    public GameObject[] eighthScreenPgmConfigSMSSettingItems = new GameObject[3];
    public GameObject[] ninethScreenPgmConfigSMSSettingItems = new GameObject[2];
    public GameObject[] tenthScreenPgmConfigSMSSettingItems = new GameObject[2];

    public static bool isPgm = false;
    public static bool isPgmComsec = false;
    public static bool isPgmConfig = false;
    public static bool isPgmMode = false;
    public static bool isPgmMaintenance = false;
    public static bool isPgmInstall = false;
    public static bool isPgmScred = false;

    public static bool isPgmComsecCam = false;
    public static bool isPgmComsecID = false;
    public static bool isPgmComsecKeys = false;
    public static bool isPgmComsecMI = false;
    public static bool isPgmComsecAKS = false;

    public static bool isPgmComsecKeysEnter = false;
    public static bool isPgmComsecKeysUpdate = false;
    public static bool isPgmComsecKeysErase = false;
    
    public static int currentPgmItem = 0;
    public static int currentPgmComsecItem = 0;
    public static int currentPgmComsecCam = 0;
    public static int currentPgmComsecId = 0;
    public static int currentPgmComsecKeys = 0;

    public static bool isPgmConfigRadio = false;
    public static bool isPgmConfigPorts = false;
    public static bool isPgmConfigAudio = false;
    public static bool isPgmConfigTod = false;
    public static bool isPgmConfigMessage = false;
    public static bool isPgmConfigLPC = false;
    public static bool isPgmConfigGPS = false;
    public static bool isPgmConfigGPSAPR = false;
    public static bool isPgmConfigAccessory = false;
    public static bool isPgmConfigNetwork = false;
    public static bool isPgmConfigARQ = false;
    public static bool isPgmConfigLDV = false;
    public static bool isPgmConfigRestore = false;
    public static bool isPgmConfigSMS = false;

    public static bool isPgmConfigPortsData = false;
    public static bool isPgmConfigPortsAscii = false;

    public static int currentPgmConfigItem = 0;
    public static int currentPgmConfigRadio = 0;
    public static int currentPgmConfigRadioScreenItem = 0;

    public static int currentPgmConfigPort = 0;
    public static int currentPgmConfigPortData = 0;
    public static int currentPgmConfigPortDataScreenItem = 0;
    public static int currentPgmConfigPortAscii = 0;
    public static int currentPgmConfigPortAsciiScreenItem = 0;

    public static int currentPgmConfigAudio = 0;
    public static int currentPgmConfigAudioitem = 0;

    public static int currentPgmConfigMessage = 0;
    public static int currentPgmConfigMessageitem = 0;

    public static int currentPgmConfigLPC = 0;
    public static int currentPgmConfigLPCitem = 0;

    public static int currentPgmConfigGPS = 0;
    public static int currentPgmConfigGPSitem = 0;

    public static int currentPgmConfigGPSARP = 0;
    public static int currentPgmConfigGPSARPitem = 0;
    public static bool isTimeInterval = false;
    public static bool isGPSARPIpAddress = false;
    public static int currentNumb = 0;

    public static bool isEightPress = false;
    public static bool isSevenPress = false;

    public static int currentPgmConfigAccessory = 0;
    public static int currentPgmConfigAccessoryItem = 0;

    public static bool isPgmConfigNetworkInterface = false;
    public static bool isPgmConfigNetworkProtocol = false;
    public static bool isPgmConfigNetworkRoutes = false;

    public static int currentPgmConfigNetwork = 0;

    public static bool isPgmConfigNetworkInterfaceEthernet = false;
    public static bool isPgmConfigNetworkInterfacePPP = false;
    public static bool isPgmConfigNetworkInterfaceWireless = false;

    public static int currentPgmConfigNetworkInterface = 0;

    public static bool isPgmConfigNetworkInterfaceEthernetAddress = false;
    public static bool isPgmConfigNetworkInterfaceEthernetStatus = false;

    public static int currentPgmConfigNetworkInterfaceEthernet = 0;

    public static int currentPgmConfigNetworkInterfaceEthernetAddress = 0;
    public static int currentPgmConfigNetworkInterfaceEthernetAddressItem = 0;
    public static bool isPgmConfigNetworkInterfaceEthernetAddressIP = false;

    public static int currentPgmConfigNetworkInterfaceEthernetStatus = 0;

    public static bool isPgmConfigNetworkInterfacePPPAddress = false;
    public static bool isPgmConfigNetworkInterfacePPPStatus = false;
    public static bool isPgmConfigNetworkInterfacePPPPortSetting = false;

    public static int currentPgmConfigNetworkInterfacePPP = 0;

    public static bool isPgmConfigNetworkInterfacePPPAddressIP = false;
    public static bool isPgmConfigNetworkInterfacePPPAddressSubnet = false;
    public static bool isPgmConfigNetworkInterfacePPPAddressGetaway = false;

    public static int currentPgmConfigNetworkInterfacePPPAddress = 0;
    public static int currentPgmConfigNetworkInterfacePPPAddressItem = 0;

    public static int currentPgmConfigNetworkInterfacePPPStatus = 0;

    public static int currentPgmConfigNetworkInterfacePPPPortSetting = 0;
    public static int currentPgmConfigNetworkInterfacePPPPortSettingItem = 0;

    public static bool isPgmConfigNetworkInterfaceWirelessAddress = false;
    public static bool isPgmConfigNetworkInterfaceWirelessStatus = false;

    public static int currentPgmConfigNetworkInterfaceWireless = 0;

    public static bool isPgmConfigNetworkInterfaceWirelessAddressIP = false;
    public static bool isPgmConfigNetworkInterfaceWirelessAddressSubnet = false;

    public static int currentPgmConfigNetworkInterfaceWirelessAddress = 0;
    public static int currentPgmConfigNetworkInterfaceWirelessAddressItem = 0;

    public static bool isPgmConfigNetworkProtocolSNMP = false;

    public static bool isPgmConfigNetworkProtocolSNMPTrapAddress = false;

    public static int currentPgmConfigNetworkProtocolSNMP = 0;
    public static int currentPgmConfigNetworkProtocolSNMPItem = 0;

    public static int currentPgmConfigARQ = 0;
    public static int currentPgmConfigARQItem = 0;

    public static int currentPgmConfigLDV = 0;
    public static int currentPgmConfigLDVItem = 0;

    public static bool isPgmConfigSMSSetting = false;
    public static int currentPgmConfigSMS = 0;

    public static int currentPgmConfigSMSSetting = 0;
    public static int currentPgmConfigSMSSEttingItem = 0;

    public static string pgmConfigRadioTxLevel = "";
    public static string pgmConfigRadioSquelch = "";
    public static string pgmConfigRadioSquelchLevel = ""; 
    public static string pgmConfigRadioFMSquelchType = "";           
    public static string pgmConfigRadioCoupler = ""; 
    public static string pgmConfigRadioRadioSilence = ""; 
    public static string pgmConfigRadioRXNoiseBlanking = "";  
    public static string pgmConfigRadioFMDeviation = "";  
    public static string pgmConfigRadioBatteryModel = "";
    public static string pgmConfigRadioCWOffset = "";
    public static string pgmConfigRadioCompression = "";
    public static string pgmConfigRadioErrorBeeps = "";

    public static string pgmConfigLPCNoiseCancellation = "";

    //Індекси для відповідних пунктів меню
    public static int currentAccWindow = 0;
    public static int currentTestBitItem = 0;
    public static int currentTestItem = 0;
    public static int currentArpItem = 0;
    public static int currentViewItem = 0;
    public int currentScanImage = 0;
    public int currentRadioImage = 0;
    public static int currentRadioItem = 0;
    public static int currentMenuItem = 0;

    //кольори для фонів та текстів
    public Color32 greenLight = new Color32(136, 196, 0, 255);
    public Color32 blackLight = new Color32(40, 40, 40, 255);
    public static Color32 currentTaskColor = new Color32(158, 231, 74, 255);
    public static Color32 finishedTaskColor = new Color32(130, 130, 130, 255);

    void Start()
    {
        currentMode = "OFF";
        keyValues.Add("isCouplerIn", "Підключити антену");
        keyValues.Add("isTurn", "Ввімкнути станцію");
        keyValues.Add("currentMode", "Вибрати режим");
        keyValues.Add("inSettingMenu", "Натиснути кнопку OPTIONS");
        keyValues.Add("isRadio", "Перейти у пункт меню RADIO");
        keyValues.Add("txLevel", "Вибрати потужність передачі");
        keyValues.Add("squelchLevel", "Вибрати рівень шумоподавлення");
        keyValues.Add("fm", "Вибрати вид шумоподавлення в FM");
        keyValues.Add("internalCoupler", "Вбудований антенно-узгоджуючий пристрій");
        keyValues.Add("radioSilence", "Вибрати режим радіомовчання");
        keyValues.Add("bfo", "Вибрати зміщення частоти гетеродину телеграфу");
        keyValues.Add("rxNoise", "Вибрати придушення вхідних шумів");
        keyValues.Add("radioLock", "Вибрати блокування радіостанції");
        keyValues.Add("isAcc", "Перейти у пункт меню EXT-ACC");
        keyValues.Add("exitAcc", "Переглянути підключені зовнішні пристрої");
        keyValues.Add("isPgm", "Натиснути кнопку PGM");
        keyValues.Add("isPgmConfig", "Перейти у пункт меню CONFIG");
        keyValues.Add("isPgmConfigRadio", "Перейти у пункт меню RADIO");
        keyValues.Add("pgmConfigRadioTxLevel", "Вибрати потужність передачі");
        keyValues.Add("pgmConfigRadioSquelch", "Шумоподавлення");
        keyValues.Add("pgmConfigRadioSquelchLevel", "Вибрати рівень шумоподавлення");
        keyValues.Add("pgmConfigRadioFMSquelchType", "Вибрати тип шумоподавлення");
        keyValues.Add("pgmConfigRadioRadioSilence", "Вибрати режим радіомовчання");
        keyValues.Add("pgmConfigRadioCoupler", "Вбудований антенно-узгоджуючий пристрій");
        keyValues.Add("pgmConfigRadioRXNoiseBlanking", "Придушення вхідних шумів");
        keyValues.Add("pgmConfigRadioFMDeviation", "Вибрати відхилення при FM");
        keyValues.Add("pgmConfigRadioBatteryModel", "Вибрати модель батареї");
        keyValues.Add("pgmConfigRadioCWOffset", "Вибрати зміщення частоти в CW");
        keyValues.Add("pgmConfigRadioCompression", "Вибрати стискання");
        keyValues.Add("pgmConfigRadioErrorBeeps", "Вибрати виведення сигналів помилок");
        keyValues.Add("isPgmConfigLPC", "Перейти у пункт меню LPC");
        keyValues.Add("pgmConfigLPCNoiseCancellation", "Блокування шумів ");
    }


    public void EnterPgmConfigSMSSetting()
    {
        if (currentPgmConfigSMSSetting != pgmConfigSMSSettingMenu.Length - 1)
        {
            pgmConfigSMSSettingMenu[currentPgmConfigSMSSetting].SetActive(false);
            pgmConfigSMSSettingMenu[currentPgmConfigSMSSetting + 1].SetActive(true);
            currentPgmConfigSMSSetting++;
            currentPgmConfigSMSSEttingItem = 0;
        }
        else
        {
            DisableLoadMenu();
            isPgmConfig = true;
            pgmConfigMenu[0].SetActive(true);
        }
    }

    public void PgmConfigSMSSettingUp()
    {
        switch (currentPgmConfigSMSSetting)
        {
            case 0:
                if (currentPgmConfigSMSSEttingItem != firstScreenPgmConfigSMSSettingItems.Length - 1)
                {
                    firstScreenPgmConfigSMSSettingItems[currentPgmConfigSMSSEttingItem].SetActive(false);
                    firstScreenPgmConfigSMSSettingItems[currentPgmConfigSMSSEttingItem + 1].SetActive(true);
                    currentPgmConfigSMSSEttingItem++;
                }
                else
                {
                    firstScreenPgmConfigSMSSettingItems[currentPgmConfigSMSSEttingItem].SetActive(false);
                    firstScreenPgmConfigSMSSettingItems[0].SetActive(true);
                    currentPgmConfigSMSSEttingItem = 0;
                }
                break;
            case 1:
                if (currentPgmConfigSMSSEttingItem != secondScreenPgmConfigSMSSettingItems.Length - 1)
                {
                    secondScreenPgmConfigSMSSettingItems[currentPgmConfigSMSSEttingItem].SetActive(false);
                    secondScreenPgmConfigSMSSettingItems[currentPgmConfigSMSSEttingItem + 1].SetActive(true);
                    currentPgmConfigSMSSEttingItem++;
                }
                else
                {
                    secondScreenPgmConfigSMSSettingItems[currentPgmConfigSMSSEttingItem].SetActive(false);
                    secondScreenPgmConfigSMSSettingItems[0].SetActive(true);
                    currentPgmConfigSMSSEttingItem = 0;
                }
                break;
            case 2:
                if (currentPgmConfigSMSSEttingItem != thirdScreenPgmConfigSMSSettingItems.Length - 1)
                {
                    thirdScreenPgmConfigSMSSettingItems[currentPgmConfigSMSSEttingItem].SetActive(false);
                    thirdScreenPgmConfigSMSSettingItems[currentPgmConfigSMSSEttingItem + 1].SetActive(true);
                    currentPgmConfigSMSSEttingItem++;
                }
                else
                {
                    thirdScreenPgmConfigSMSSettingItems[currentPgmConfigSMSSEttingItem].SetActive(false);
                    thirdScreenPgmConfigSMSSettingItems[0].SetActive(true);
                    currentPgmConfigSMSSEttingItem = 0;
                }
                break;
            case 3:
                if (currentPgmConfigSMSSEttingItem != fourthScreenPgmConfigSMSSettingItems.Length - 1)
                {
                    fourthScreenPgmConfigSMSSettingItems[currentPgmConfigSMSSEttingItem].SetActive(false);
                    fourthScreenPgmConfigSMSSettingItems[currentPgmConfigSMSSEttingItem + 1].SetActive(true);
                    currentPgmConfigSMSSEttingItem++;
                }
                else
                {
                    fourthScreenPgmConfigSMSSettingItems[currentPgmConfigSMSSEttingItem].SetActive(false);
                    fourthScreenPgmConfigSMSSettingItems[0].SetActive(true);
                    currentPgmConfigSMSSEttingItem = 0;
                }
                break;
            case 4:
                if (currentPgmConfigSMSSEttingItem != fifthScreenPgmConfigSMSSettingItems.Length - 1)
                {
                    fifthScreenPgmConfigSMSSettingItems[currentPgmConfigSMSSEttingItem].SetActive(false);
                    fifthScreenPgmConfigSMSSettingItems[currentPgmConfigSMSSEttingItem + 1].SetActive(true);
                    currentPgmConfigSMSSEttingItem++;
                }
                else
                {
                    fifthScreenPgmConfigSMSSettingItems[currentPgmConfigSMSSEttingItem].SetActive(false);
                    fifthScreenPgmConfigSMSSettingItems[0].SetActive(true);
                    currentPgmConfigSMSSEttingItem = 0;
                }
                break;
            case 5:
                if (currentPgmConfigSMSSEttingItem != sixthScreenPgmConfigSMSSettingItems.Length - 1)
                {
                    sixthScreenPgmConfigSMSSettingItems[currentPgmConfigSMSSEttingItem].SetActive(false);
                    sixthScreenPgmConfigSMSSettingItems[currentPgmConfigSMSSEttingItem + 1].SetActive(true);
                    currentPgmConfigSMSSEttingItem++;
                }
                else
                {
                    sixthScreenPgmConfigSMSSettingItems[currentPgmConfigSMSSEttingItem].SetActive(false);
                    sixthScreenPgmConfigSMSSettingItems[0].SetActive(true);
                    currentPgmConfigSMSSEttingItem = 0;
                }
                break;
            case 6:
                if (currentPgmConfigSMSSEttingItem != seventhScreenPgmConfigSMSSettingItems.Length - 1)
                {
                    seventhScreenPgmConfigSMSSettingItems[currentPgmConfigSMSSEttingItem].SetActive(false);
                    seventhScreenPgmConfigSMSSettingItems[currentPgmConfigSMSSEttingItem + 1].SetActive(true);
                    currentPgmConfigSMSSEttingItem++;
                }
                else
                {
                    seventhScreenPgmConfigSMSSettingItems[currentPgmConfigSMSSEttingItem].SetActive(false);
                    seventhScreenPgmConfigSMSSettingItems[0].SetActive(true);
                    currentPgmConfigSMSSEttingItem = 0;
                }
                break;
            case 7:
                if (currentPgmConfigSMSSEttingItem != eighthScreenPgmConfigSMSSettingItems.Length - 1)
                {
                    eighthScreenPgmConfigSMSSettingItems[currentPgmConfigSMSSEttingItem].SetActive(false);
                    eighthScreenPgmConfigSMSSettingItems[currentPgmConfigSMSSEttingItem + 1].SetActive(true);
                    currentPgmConfigSMSSEttingItem++;
                }
                else
                {
                    eighthScreenPgmConfigSMSSettingItems[currentPgmConfigSMSSEttingItem].SetActive(false);
                    eighthScreenPgmConfigSMSSettingItems[0].SetActive(true);
                    currentPgmConfigSMSSEttingItem = 0;
                }
                break;
            case 8:
                if (currentPgmConfigSMSSEttingItem != ninethScreenPgmConfigSMSSettingItems.Length - 1)
                {
                    ninethScreenPgmConfigSMSSettingItems[currentPgmConfigSMSSEttingItem].SetActive(false);
                    ninethScreenPgmConfigSMSSettingItems[currentPgmConfigSMSSEttingItem + 1].SetActive(true);
                    currentPgmConfigSMSSEttingItem++;
                }
                else
                {
                    ninethScreenPgmConfigSMSSettingItems[currentPgmConfigSMSSEttingItem].SetActive(false);
                    ninethScreenPgmConfigSMSSettingItems[0].SetActive(true);
                    currentPgmConfigSMSSEttingItem = 0;
                }
                break;
            case 9:
                if (currentPgmConfigSMSSEttingItem != tenthScreenPgmConfigSMSSettingItems.Length - 1)
                {
                    tenthScreenPgmConfigSMSSettingItems[currentPgmConfigSMSSEttingItem].SetActive(false);
                    tenthScreenPgmConfigSMSSettingItems[currentPgmConfigSMSSEttingItem + 1].SetActive(true);
                    currentPgmConfigSMSSEttingItem++;
                }
                else
                {
                    tenthScreenPgmConfigSMSSettingItems[currentPgmConfigSMSSEttingItem].SetActive(false);
                    tenthScreenPgmConfigSMSSettingItems[0].SetActive(true);
                    currentPgmConfigSMSSEttingItem = 0;
                }
                break;
        }
    }

    public void PgmConfigSMSSettingDown()
    {
        switch (currentPgmConfigSMSSetting)
        {
            case 0:
                if (currentPgmConfigSMSSEttingItem != 0)
                {
                    firstScreenPgmConfigSMSSettingItems[currentPgmConfigSMSSEttingItem].SetActive(false);
                    firstScreenPgmConfigSMSSettingItems[currentPgmConfigSMSSEttingItem - 1].SetActive(true);
                    currentPgmConfigSMSSEttingItem--;
                }
                else
                {
                    firstScreenPgmConfigSMSSettingItems[currentPgmConfigSMSSEttingItem].SetActive(false);
                    firstScreenPgmConfigSMSSettingItems[firstScreenPgmConfigSMSSettingItems.Length - 1].SetActive(true);
                    currentPgmConfigSMSSEttingItem = firstScreenPgmConfigSMSSettingItems.Length - 1;
                }
                break;
            case 1:
                if (currentPgmConfigSMSSEttingItem != 0)
                {
                    secondScreenPgmConfigSMSSettingItems[currentPgmConfigSMSSEttingItem].SetActive(false);
                    secondScreenPgmConfigSMSSettingItems[currentPgmConfigSMSSEttingItem - 1].SetActive(true);
                    currentPgmConfigSMSSEttingItem--;
                }
                else
                {
                    secondScreenPgmConfigSMSSettingItems[currentPgmConfigSMSSEttingItem].SetActive(false);
                    secondScreenPgmConfigSMSSettingItems[secondScreenPgmConfigSMSSettingItems.Length - 1].SetActive(true);
                    currentPgmConfigSMSSEttingItem = secondScreenPgmConfigSMSSettingItems.Length - 1;
                }
                break;
            case 2:
                if (currentPgmConfigSMSSEttingItem != 0)
                {
                    thirdScreenPgmConfigSMSSettingItems[currentPgmConfigSMSSEttingItem].SetActive(false);
                    thirdScreenPgmConfigSMSSettingItems[currentPgmConfigSMSSEttingItem - 1].SetActive(true);
                    currentPgmConfigSMSSEttingItem--;
                }
                else
                {
                    thirdScreenPgmConfigSMSSettingItems[currentPgmConfigSMSSEttingItem].SetActive(false);
                    thirdScreenPgmConfigSMSSettingItems[thirdScreenPgmConfigSMSSettingItems.Length - 1].SetActive(true);
                    currentPgmConfigSMSSEttingItem = thirdScreenPgmConfigSMSSettingItems.Length - 1;
                }
                break;
            case 3:
                if (currentPgmConfigSMSSEttingItem != 0)
                {
                    fourthScreenPgmConfigSMSSettingItems[currentPgmConfigSMSSEttingItem].SetActive(false);
                    fourthScreenPgmConfigSMSSettingItems[currentPgmConfigSMSSEttingItem - 1].SetActive(true);
                    currentPgmConfigSMSSEttingItem--;
                }
                else
                {
                    fourthScreenPgmConfigSMSSettingItems[currentPgmConfigSMSSEttingItem].SetActive(false);
                    fourthScreenPgmConfigSMSSettingItems[fourthScreenPgmConfigSMSSettingItems.Length - 1].SetActive(true);
                    currentPgmConfigSMSSEttingItem = fourthScreenPgmConfigSMSSettingItems.Length - 1;
                }
                break;
            case 4:
                if (currentPgmConfigSMSSEttingItem != 0)
                {
                    fifthScreenPgmConfigSMSSettingItems[currentPgmConfigSMSSEttingItem].SetActive(false);
                    fifthScreenPgmConfigSMSSettingItems[currentPgmConfigSMSSEttingItem - 1].SetActive(true);
                    currentPgmConfigSMSSEttingItem--;
                }
                else
                {
                    fifthScreenPgmConfigSMSSettingItems[currentPgmConfigSMSSEttingItem].SetActive(false);
                    fifthScreenPgmConfigSMSSettingItems[fifthScreenPgmConfigSMSSettingItems.Length - 1].SetActive(true);
                    currentPgmConfigSMSSEttingItem = fifthScreenPgmConfigSMSSettingItems.Length - 1;
                }
                break;
            case 5:
                if (currentPgmConfigSMSSEttingItem != 0)
                {
                    sixthScreenPgmConfigSMSSettingItems[currentPgmConfigSMSSEttingItem].SetActive(false);
                    sixthScreenPgmConfigSMSSettingItems[currentPgmConfigSMSSEttingItem - 1].SetActive(true);
                    currentPgmConfigSMSSEttingItem--;
                }
                else
                {
                    sixthScreenPgmConfigSMSSettingItems[currentPgmConfigSMSSEttingItem].SetActive(false);
                    sixthScreenPgmConfigSMSSettingItems[sixthScreenPgmConfigSMSSettingItems.Length - 1].SetActive(true);
                    currentPgmConfigSMSSEttingItem = sixthScreenPgmConfigSMSSettingItems.Length - 1;
                }
                break;
            case 6:
                if (currentPgmConfigSMSSEttingItem != 0)
                {
                    seventhScreenPgmConfigSMSSettingItems[currentPgmConfigSMSSEttingItem].SetActive(false);
                    seventhScreenPgmConfigSMSSettingItems[currentPgmConfigSMSSEttingItem - 1].SetActive(true);
                    currentPgmConfigSMSSEttingItem--;
                }
                else
                {
                    seventhScreenPgmConfigSMSSettingItems[currentPgmConfigSMSSEttingItem].SetActive(false);
                    seventhScreenPgmConfigSMSSettingItems[seventhScreenPgmConfigSMSSettingItems.Length - 1].SetActive(true);
                    currentPgmConfigSMSSEttingItem = seventhScreenPgmConfigSMSSettingItems.Length - 1;
                }
                break;
            case 7:
                if (currentPgmConfigSMSSEttingItem != 0)
                {
                    eighthScreenPgmConfigSMSSettingItems[currentPgmConfigSMSSEttingItem].SetActive(false);
                    eighthScreenPgmConfigSMSSettingItems[currentPgmConfigSMSSEttingItem - 1].SetActive(true);
                    currentPgmConfigSMSSEttingItem--;
                }
                else
                {
                    eighthScreenPgmConfigSMSSettingItems[currentPgmConfigSMSSEttingItem].SetActive(false);
                    eighthScreenPgmConfigSMSSettingItems[eighthScreenPgmConfigSMSSettingItems.Length - 1].SetActive(true);
                    currentPgmConfigSMSSEttingItem = eighthScreenPgmConfigSMSSettingItems.Length - 1;
                }
                break;
            case 8:
                if (currentPgmConfigSMSSEttingItem != 0)
                {
                    ninethScreenPgmConfigSMSSettingItems[currentPgmConfigSMSSEttingItem].SetActive(false);
                    ninethScreenPgmConfigSMSSettingItems[currentPgmConfigSMSSEttingItem - 1].SetActive(true);
                    currentPgmConfigSMSSEttingItem--;
                }
                else
                {
                    ninethScreenPgmConfigSMSSettingItems[currentPgmConfigSMSSEttingItem].SetActive(false);
                    ninethScreenPgmConfigSMSSettingItems[ninethScreenPgmConfigSMSSettingItems.Length - 1].SetActive(true);
                    currentPgmConfigSMSSEttingItem = ninethScreenPgmConfigSMSSettingItems.Length - 1;
                }
                break;
            case 9:
                if (currentPgmConfigSMSSEttingItem != 0)
                {
                    tenthScreenPgmConfigSMSSettingItems[currentPgmConfigSMSSEttingItem].SetActive(false);
                    tenthScreenPgmConfigSMSSettingItems[currentPgmConfigSMSSEttingItem - 1].SetActive(true);
                    currentPgmConfigSMSSEttingItem--;
                }
                else
                {
                    tenthScreenPgmConfigSMSSettingItems[currentPgmConfigSMSSEttingItem].SetActive(false);
                    tenthScreenPgmConfigSMSSettingItems[tenthScreenPgmConfigSMSSettingItems.Length - 1].SetActive(true);
                    currentPgmConfigSMSSEttingItem = tenthScreenPgmConfigSMSSettingItems.Length - 1;
                }
                break;
        }
    }


    public void EnterPgmConfigSMS()
    {
        switch (currentPgmConfigSMS)
        {    
            case 1:
                isPgmConfigSMSSetting = true;
                pgmConfigSMSSettingMenu[0].SetActive(true);
                break;
        }
    }

    public void NextPgmConfigSMSMenu()
    {
        if (currentPgmConfigSMS != pgmConfigNetworkInterfacePPPMenuImages.Length - 1)
        {
            ChangeColor(pgmConfigSMSMenuImages[currentPgmConfigSMS], pgmConfigSMSMenuItems[currentPgmConfigSMS], pgmConfigSMSMenuImages[currentPgmConfigSMS + 1], pgmConfigSMSMenuItems[currentPgmConfigSMS + 1]);
            currentPgmConfigSMS++;
        }
        else
        {
            ChangeColor(pgmConfigSMSMenuImages[currentPgmConfigSMS], pgmConfigSMSMenuItems[currentPgmConfigSMS], pgmConfigSMSMenuImages[0], pgmConfigSMSMenuItems[0]);
            currentPgmConfigSMS = 0;
        }
    }

    public void PrevPgmConfigSMSMenu()
    {
        if (currentPgmConfigSMS != 0)
        {
            ChangeColor(pgmConfigSMSMenuImages[currentPgmConfigSMS], pgmConfigSMSMenuItems[currentPgmConfigSMS], pgmConfigSMSMenuImages[currentPgmConfigSMS - 1], pgmConfigSMSMenuItems[currentPgmConfigSMS - 1]);
            currentPgmConfigSMS--;
        }
        else
        {
            ChangeColor(pgmConfigSMSMenuImages[currentPgmConfigSMS], pgmConfigSMSMenuItems[currentPgmConfigSMS], pgmConfigSMSMenuImages[pgmConfigSMSMenuImages.Length - 1], pgmConfigSMSMenuItems[pgmConfigSMSMenuImages.Length - 1]);
            currentPgmConfigSMS = pgmConfigSMSMenuImages.Length - 1;
        }
    }


    public void EnterPgmConfigLDV()
    {
        if (currentPgmConfigLDV != pgmConfigLDVMenu.Length - 1)
        {
            pgmConfigLDVMenu[currentPgmConfigLDV].SetActive(false);
            pgmConfigLDVMenu[currentPgmConfigLDV + 1].SetActive(true);
            currentPgmConfigLDV++;
            currentPgmConfigLDVItem = 0;
        }
        else
        {
            DisableLoadMenu();
            isPgmConfig = true;
            pgmConfigMenu[0].SetActive(true);
        }
    }

    public void PgmConfigLDVUp()
    {
        switch (currentPgmConfigLDV)
        {
            case 0:
                if (currentPgmConfigLDVItem != firstScreenPgmConfigLDVItems.Length - 1)
                {
                    firstScreenPgmConfigLDVItems[currentPgmConfigLDVItem].SetActive(false);
                    firstScreenPgmConfigLDVItems[currentPgmConfigLDVItem + 1].SetActive(true);
                    currentPgmConfigLDVItem++;
                }
                else
                {
                    firstScreenPgmConfigLDVItems[currentPgmConfigLDVItem].SetActive(false);
                    firstScreenPgmConfigLDVItems[0].SetActive(true);
                    currentPgmConfigLDVItem = 0;
                }
                break;
            case 1:
                if (currentPgmConfigLDVItem != secondScreenPgmConfigLDVItems.Length - 1)
                {
                    secondScreenPgmConfigLDVItems[currentPgmConfigLDVItem].SetActive(false);
                    secondScreenPgmConfigLDVItems[currentPgmConfigLDVItem + 1].SetActive(true);
                    currentPgmConfigLDVItem++;
                }
                else
                {
                    secondScreenPgmConfigLDVItems[currentPgmConfigLDVItem].SetActive(false);
                    secondScreenPgmConfigLDVItems[0].SetActive(true);
                    currentPgmConfigLDVItem = 0;
                }
                break;
            case 2:
                if (currentPgmConfigLDVItem != thirdScreenPgmConfigLDVItems.Length - 1)
                {
                    thirdScreenPgmConfigLDVItems[currentPgmConfigLDVItem].SetActive(false);
                    thirdScreenPgmConfigLDVItems[currentPgmConfigLDVItem + 1].SetActive(true);
                    currentPgmConfigLDVItem++;
                }
                else
                {
                    thirdScreenPgmConfigLDVItems[currentPgmConfigLDVItem].SetActive(false);
                    thirdScreenPgmConfigLDVItems[0].SetActive(true);
                    currentPgmConfigLDVItem = 0;
                }
                break;
        }
    }

    public void PgmConfigLDVDown()
    {
        switch (currentPgmConfigLDV)
        {
            case 0:
                if (currentPgmConfigLDVItem != 0)
                {
                    firstScreenPgmConfigLDVItems[currentPgmConfigLDVItem].SetActive(false);
                    firstScreenPgmConfigLDVItems[currentPgmConfigLDVItem - 1].SetActive(true);
                    currentPgmConfigLDVItem--;
                }
                else
                {
                    firstScreenPgmConfigLDVItems[currentPgmConfigLDVItem].SetActive(false);
                    firstScreenPgmConfigLDVItems[firstScreenPgmConfigLDVItems.Length - 1].SetActive(true);
                    currentPgmConfigLDVItem = firstScreenPgmConfigLDVItems.Length - 1;
                }
                break;
            case 1:
                if (currentPgmConfigLDVItem != 0)
                {
                    secondScreenPgmConfigLDVItems[currentPgmConfigLDVItem].SetActive(false);
                    secondScreenPgmConfigLDVItems[currentPgmConfigLDVItem - 1].SetActive(true);
                    currentPgmConfigLDVItem--;
                }
                else
                {
                    secondScreenPgmConfigLDVItems[currentPgmConfigLDVItem].SetActive(false);
                    secondScreenPgmConfigLDVItems[secondScreenPgmConfigLDVItems.Length - 1].SetActive(true);
                    currentPgmConfigLDVItem = secondScreenPgmConfigLDVItems.Length - 1;
                }
                break;
            case 2:
                if (currentPgmConfigLDVItem != 0)
                {
                    thirdScreenPgmConfigLDVItems[currentPgmConfigLDVItem].SetActive(false);
                    thirdScreenPgmConfigLDVItems[currentPgmConfigLDVItem - 1].SetActive(true);
                    currentPgmConfigLDVItem--;
                }
                else
                {
                    thirdScreenPgmConfigLDVItems[currentPgmConfigLDVItem].SetActive(false);
                    thirdScreenPgmConfigLDVItems[thirdScreenPgmConfigLDVItems.Length - 1].SetActive(true);
                    currentPgmConfigLDVItem = thirdScreenPgmConfigLDVItems.Length - 1;
                }
                break;
        }
    }

    public void EnterPgmConfigARQ()
    {
        if (currentPgmConfigARQ != pgmConfigARQMenu.Length - 1)
        {
            pgmConfigARQMenu[currentPgmConfigARQ].SetActive(false);
            pgmConfigARQMenu[currentPgmConfigARQ + 1].SetActive(true);
            currentPgmConfigARQ++;
            currentPgmConfigARQItem = 0;
        }
        else
        {
            DisableLoadMenu();
            isPgmConfig = true;
            pgmConfigMenu[0].SetActive(true);
        }
    }

    public void PgmConfigARQUp()
    {
        switch (currentPgmConfigARQ)
        {
            case 0:
                if (currentPgmConfigARQItem != firstScreenPgmConfigARQItems.Length - 1)
                {
                    firstScreenPgmConfigARQItems[currentPgmConfigARQItem].SetActive(false);
                    firstScreenPgmConfigARQItems[currentPgmConfigARQItem + 1].SetActive(true);
                    currentPgmConfigARQItem++;
                }
                else
                {
                    firstScreenPgmConfigARQItems[currentPgmConfigARQItem].SetActive(false);
                    firstScreenPgmConfigARQItems[0].SetActive(true);
                    currentPgmConfigARQItem = 0;
                }
                break;
            case 1:
                if (currentPgmConfigARQItem != secondScreenPgmConfigARQItems.Length - 1)
                {
                    secondScreenPgmConfigARQItems[currentPgmConfigARQItem].SetActive(false);
                    secondScreenPgmConfigARQItems[currentPgmConfigARQItem + 1].SetActive(true);
                    currentPgmConfigARQItem++;
                }
                else
                {
                    secondScreenPgmConfigARQItems[currentPgmConfigARQItem].SetActive(false);
                    secondScreenPgmConfigARQItems[0].SetActive(true);
                    currentPgmConfigARQItem = 0;
                }
                break;
            case 2:
                if (currentPgmConfigARQItem != thirdScreenPgmConfigARQItems.Length - 1)
                {
                    thirdScreenPgmConfigARQItems[currentPgmConfigARQItem].SetActive(false);
                    thirdScreenPgmConfigARQItems[currentPgmConfigARQItem + 1].SetActive(true);
                    currentPgmConfigARQItem++;
                }
                else
                {
                    thirdScreenPgmConfigARQItems[currentPgmConfigARQItem].SetActive(false);
                    thirdScreenPgmConfigARQItems[0].SetActive(true);
                    currentPgmConfigARQItem = 0;
                }
                break;
        }
    }

    public void PgmConfigARQDown()
    {
        switch (currentPgmConfigARQ)
        {
            case 0:
                if (currentPgmConfigARQItem != 0)
                {
                    firstScreenPgmConfigARQItems[currentPgmConfigARQItem].SetActive(false);
                    firstScreenPgmConfigARQItems[currentPgmConfigARQItem - 1].SetActive(true);
                    currentPgmConfigARQItem--;
                }
                else
                {
                    firstScreenPgmConfigARQItems[currentPgmConfigARQItem].SetActive(false);
                    firstScreenPgmConfigARQItems[firstScreenPgmConfigARQItems.Length - 1].SetActive(true);
                    currentPgmConfigARQItem = firstScreenPgmConfigARQItems.Length - 1;
                }
                break;
            case 1:
                if (currentPgmConfigARQItem != 0)
                {
                    secondScreenPgmConfigARQItems[currentPgmConfigARQItem].SetActive(false);
                    secondScreenPgmConfigARQItems[currentPgmConfigARQItem - 1].SetActive(true);
                    currentPgmConfigARQItem--;
                }
                else
                {
                    secondScreenPgmConfigARQItems[currentPgmConfigARQItem].SetActive(false);
                    secondScreenPgmConfigARQItems[secondScreenPgmConfigARQItems.Length - 1].SetActive(true);
                    currentPgmConfigARQItem = secondScreenPgmConfigARQItems.Length - 1;
                }
                break;
            case 2:
                if (currentPgmConfigARQItem != 0)
                {
                    thirdScreenPgmConfigARQItems[currentPgmConfigARQItem].SetActive(false);
                    thirdScreenPgmConfigARQItems[currentPgmConfigARQItem - 1].SetActive(true);
                    currentPgmConfigARQItem--;
                }
                else
                {
                    thirdScreenPgmConfigARQItems[currentPgmConfigARQItem].SetActive(false);
                    thirdScreenPgmConfigARQItems[thirdScreenPgmConfigARQItems.Length - 1].SetActive(true);
                    currentPgmConfigARQItem = thirdScreenPgmConfigARQItems.Length - 1;
                }
                break;
        }
    }

    public void EnterPgmConfigNetworkProtocolSNMP()
    {
        if (currentPgmConfigNetworkProtocolSNMP != pgmConfigNetworkProtocolSNMPMenu.Length - 1)
        {
            pgmConfigNetworkProtocolSNMPMenu[currentPgmConfigNetworkProtocolSNMP].SetActive(false);
            pgmConfigNetworkProtocolSNMPMenu[currentPgmConfigNetworkProtocolSNMP + 1].SetActive(true);
            currentPgmConfigNetworkProtocolSNMP++;
            currentPgmConfigNetworkProtocolSNMPItem = 0;
            isPgmConfigNetworkProtocolSNMPTrapAddress = false;
            currentNumb = 0;
            if (currentPgmConfigNetworkProtocolSNMP == 1)
            {
                isPgmConfigNetworkProtocolSNMPTrapAddress = true;
            }
        }
        else
        {
            DisableLoadMenu();
            isPgmConfig = true;
            pgmConfigMenu[0].SetActive(true);
        }
    }

    public void PgmConfigNetworkProtocolSNMPUp()
    {
        switch (currentPgmConfigNetworkProtocolSNMP)
        {
            case 0:
                if (currentPgmConfigNetworkProtocolSNMPItem != firstScreenPgmConfigNetworkProtocolSNMPItems.Length - 1)
                {
                    firstScreenPgmConfigNetworkProtocolSNMPItems[currentPgmConfigNetworkProtocolSNMPItem].SetActive(false);
                    firstScreenPgmConfigNetworkProtocolSNMPItems[currentPgmConfigNetworkProtocolSNMPItem + 1].SetActive(true);
                    currentPgmConfigNetworkProtocolSNMPItem++;
                }
                else
                {
                    firstScreenPgmConfigNetworkProtocolSNMPItems[currentPgmConfigNetworkProtocolSNMPItem].SetActive(false);
                    firstScreenPgmConfigNetworkProtocolSNMPItems[0].SetActive(true);
                    currentPgmConfigNetworkProtocolSNMPItem = 0;
                }
                break;
        }
    }

    public void PgmConfigNetworkProtocolSNMPDown()
    {
        switch (currentPgmConfigNetworkProtocolSNMP)
        {
            case 0:
                if (currentPgmConfigNetworkProtocolSNMPItem != 0)
                {
                    firstScreenPgmConfigNetworkProtocolSNMPItems[currentPgmConfigNetworkProtocolSNMPItem].SetActive(false);
                    firstScreenPgmConfigNetworkProtocolSNMPItems[currentPgmConfigNetworkProtocolSNMPItem - 1].SetActive(true);
                    currentPgmConfigNetworkProtocolSNMPItem--;
                }
                else
                {
                    firstScreenPgmConfigNetworkProtocolSNMPItems[currentPgmConfigNetworkProtocolSNMPItem].SetActive(false);
                    firstScreenPgmConfigNetworkProtocolSNMPItems[firstScreenPgmConfigNetworkProtocolSNMPItems.Length - 1].SetActive(true);
                    currentPgmConfigNetworkProtocolSNMPItem = firstScreenPgmConfigNetworkProtocolSNMPItems.Length - 1;
                }
                break;
        }
    }

    public void NextPgmConfigNetworkProtocolSNMPTrapAddressNumber()
    {
        if (currentNumb != secondScreenPgmConfigNetworkProtocolSNMPImages.Length - 1)
        {
            ChangeColor(secondScreenPgmConfigNetworkProtocolSNMPImages[currentNumb], secondScreenPgmConfigNetworkProtocolSNMPTexts[currentNumb], secondScreenPgmConfigNetworkProtocolSNMPImages[currentNumb + 1], secondScreenPgmConfigNetworkProtocolSNMPTexts[currentNumb + 1]);
            currentNumb++;
        }
        else
        {
            ChangeColor(secondScreenPgmConfigNetworkProtocolSNMPImages[currentNumb], secondScreenPgmConfigNetworkProtocolSNMPTexts[currentNumb], secondScreenPgmConfigNetworkProtocolSNMPImages[0], secondScreenPgmConfigNetworkProtocolSNMPTexts[0]);
            currentNumb = 0;
        }
    }

    public void PrevPgmConfigNetworkProtocolSNMPTrapAddressNumber()
    {
        if (currentNumb != 0)
        {
            ChangeColor(secondScreenPgmConfigNetworkProtocolSNMPImages[currentNumb], secondScreenPgmConfigNetworkProtocolSNMPTexts[currentNumb], secondScreenPgmConfigNetworkProtocolSNMPImages[currentNumb - 1], secondScreenPgmConfigNetworkProtocolSNMPTexts[currentNumb - 1]);
            currentNumb--;
        }
        else
        {
            ChangeColor(secondScreenPgmConfigNetworkProtocolSNMPImages[currentNumb], secondScreenPgmConfigNetworkProtocolSNMPTexts[currentNumb], secondScreenPgmConfigNetworkProtocolSNMPImages[secondScreenPgmConfigNetworkProtocolSNMPImages.Length - 1], secondScreenPgmConfigNetworkProtocolSNMPTexts[secondScreenPgmConfigNetworkProtocolSNMPImages.Length - 1]);
            currentNumb = secondScreenPgmConfigNetworkProtocolSNMPImages.Length - 1;
        }
    }

    public void EnterPgmConfigNetworkProtocol()
    {
        DisableLoadMenu();
        isPgmConfigNetworkProtocolSNMP = true;
        pgmConfigNetworkProtocolSNMPMenu[0].SetActive(true);
    }

    public void EnterPgmConfigNetworkInterfaceWirelessStatus()
    {
        DisableLoadMenu();
        isPgmConfig = true;
        pgmConfigMenu[0].SetActive(true);
    }

    public void EnterPgmConfigNetworkInterfaceWirelessAddress()
    {
        if (currentPgmConfigNetworkInterfaceWirelessAddress != pgmConfigNetworkInterfaceWirelessAddressMenu.Length - 1)
        {
            pgmConfigNetworkInterfaceWirelessAddressMenu[currentPgmConfigNetworkInterfaceWirelessAddress].SetActive(false);
            pgmConfigNetworkInterfaceWirelessAddressMenu[currentPgmConfigNetworkInterfaceWirelessAddress + 1].SetActive(true);
            currentPgmConfigNetworkInterfaceWirelessAddress++;
            currentPgmConfigNetworkInterfaceWirelessAddressItem = 0;
            isPgmConfigNetworkInterfacePPPAddressIP = false;
            isPgmConfigNetworkInterfacePPPAddressSubnet = false;
            currentNumb = 0;
            if (currentPgmConfigNetworkInterfaceWirelessAddress == 1)
            {
                isPgmConfigNetworkInterfaceWirelessAddressIP = true;
            }
            if (currentPgmConfigNetworkInterfaceWirelessAddress == 2)
            {
                isPgmConfigNetworkInterfaceWirelessAddressSubnet = true;
            }
        }
        else
        {
            DisableLoadMenu();
            isPgmConfig = true;
            pgmConfigMenu[0].SetActive(true);
        }
    }

    public void NextPgmConfigNetworkInterfaceWirelessAddressSubnetNumber()
    {
        if (currentNumb != thirdScreenPgmConfigNetworkInterfaceWirelessAddressImages.Length - 1)
        {
            ChangeColor(thirdScreenPgmConfigNetworkInterfaceWirelessAddressImages[currentNumb], thirdScreenPgmConfigNetworkInterfaceWirelessAddressTexts[currentNumb], thirdScreenPgmConfigNetworkInterfaceWirelessAddressImages[currentNumb + 1], thirdScreenPgmConfigNetworkInterfaceWirelessAddressTexts[currentNumb + 1]);
            currentNumb++;
        }
        else
        {
            ChangeColor(thirdScreenPgmConfigNetworkInterfaceWirelessAddressImages[currentNumb], thirdScreenPgmConfigNetworkInterfaceWirelessAddressTexts[currentNumb], thirdScreenPgmConfigNetworkInterfaceWirelessAddressImages[0], thirdScreenPgmConfigNetworkInterfaceWirelessAddressTexts[0]);
            currentNumb = 0;
        }
    }

    public void PrevPgmConfigNetworkInterfaceWirelessAddressSubnetNumber()
    {
        if (currentNumb != 0)
        {
            ChangeColor(thirdScreenPgmConfigNetworkInterfaceWirelessAddressImages[currentNumb], thirdScreenPgmConfigNetworkInterfaceWirelessAddressTexts[currentNumb], thirdScreenPgmConfigNetworkInterfaceWirelessAddressImages[currentNumb - 1], thirdScreenPgmConfigNetworkInterfaceWirelessAddressTexts[currentNumb - 1]);
            currentNumb--;
        }
        else
        {
            ChangeColor(thirdScreenPgmConfigNetworkInterfaceWirelessAddressImages[currentNumb], thirdScreenPgmConfigNetworkInterfaceWirelessAddressTexts[currentNumb], thirdScreenPgmConfigNetworkInterfaceWirelessAddressImages[thirdScreenPgmConfigNetworkInterfaceWirelessAddressImages.Length - 1], thirdScreenPgmConfigNetworkInterfaceWirelessAddressTexts[thirdScreenPgmConfigNetworkInterfaceWirelessAddressImages.Length - 1]);
            currentNumb = thirdScreenPgmConfigNetworkInterfaceWirelessAddressImages.Length - 1;
        }
    }

    public void NextPgmConfigNetworkInterfaceWirelessAddressIPNumber()
    {
        if (currentNumb != secondScreenPgmConfigNetworkInterfaceWirelessAddressImages.Length - 1)
        {
            ChangeColor(secondScreenPgmConfigNetworkInterfaceWirelessAddressImages[currentNumb], secondScreenPgmConfigNetworkInterfaceWirelessAddressTexts[currentNumb], secondScreenPgmConfigNetworkInterfaceWirelessAddressImages[currentNumb + 1], secondScreenPgmConfigNetworkInterfaceWirelessAddressTexts[currentNumb + 1]);
            currentNumb++;
        }
        else
        {
            ChangeColor(secondScreenPgmConfigNetworkInterfaceWirelessAddressImages[currentNumb], secondScreenPgmConfigNetworkInterfaceWirelessAddressTexts[currentNumb], secondScreenPgmConfigNetworkInterfaceWirelessAddressImages[0], secondScreenPgmConfigNetworkInterfaceWirelessAddressTexts[0]);
            currentNumb = 0;
        }
    }

    public void PrevPgmConfigNetworkInterfaceWirelessAddressIPNumber()
    {
        if (currentNumb != 0)
        {
            ChangeColor(secondScreenPgmConfigNetworkInterfaceWirelessAddressImages[currentNumb], secondScreenPgmConfigNetworkInterfaceWirelessAddressTexts[currentNumb], secondScreenPgmConfigNetworkInterfaceWirelessAddressImages[currentNumb - 1], secondScreenPgmConfigNetworkInterfaceWirelessAddressTexts[currentNumb - 1]);
            currentNumb--;
        }
        else
        {
            ChangeColor(secondScreenPgmConfigNetworkInterfaceWirelessAddressImages[currentNumb], secondScreenPgmConfigNetworkInterfaceWirelessAddressTexts[currentNumb], secondScreenPgmConfigNetworkInterfaceWirelessAddressImages[secondScreenPgmConfigNetworkInterfaceWirelessAddressImages.Length - 1], secondScreenPgmConfigNetworkInterfaceWirelessAddressTexts[secondScreenPgmConfigNetworkInterfaceWirelessAddressImages.Length - 1]);
            currentNumb = secondScreenPgmConfigNetworkInterfaceWirelessAddressImages.Length - 1;
        }
    }

    public void PgmConfigNetworkInterfaceWirelessAddressUp()
    {
        switch (currentPgmConfigNetworkInterfaceWirelessAddress)
        {
            case 0:
                if (currentPgmConfigNetworkInterfaceWirelessAddressItem != firstScreenPgmConfigNetworkInterfaceWirelessAddressItems.Length - 1)
                {
                    firstScreenPgmConfigNetworkInterfaceWirelessAddressItems[currentPgmConfigNetworkInterfaceWirelessAddressItem].SetActive(false);
                    firstScreenPgmConfigNetworkInterfaceWirelessAddressItems[currentPgmConfigNetworkInterfaceWirelessAddressItem + 1].SetActive(true);
                    currentPgmConfigNetworkInterfaceWirelessAddressItem++;
                }
                else
                {
                    firstScreenPgmConfigNetworkInterfaceWirelessAddressItems[currentPgmConfigNetworkInterfaceWirelessAddressItem].SetActive(false);
                    firstScreenPgmConfigNetworkInterfaceWirelessAddressItems[0].SetActive(true);
                    currentPgmConfigNetworkInterfaceWirelessAddressItem = 0;
                }
                break;
            case 3:
                if (currentPgmConfigNetworkInterfaceWirelessAddressItem != fourthScreenPgmConfigNetworkInterfaceWirelessAddressItems.Length - 1)
                {
                    fourthScreenPgmConfigNetworkInterfaceWirelessAddressItems[currentPgmConfigNetworkInterfaceWirelessAddressItem].SetActive(false);
                    fourthScreenPgmConfigNetworkInterfaceWirelessAddressItems[currentPgmConfigNetworkInterfaceWirelessAddressItem + 1].SetActive(true);
                    currentPgmConfigNetworkInterfaceWirelessAddressItem++;
                }
                else
                {
                    fourthScreenPgmConfigNetworkInterfaceWirelessAddressItems[currentPgmConfigNetworkInterfaceWirelessAddressItem].SetActive(false);
                    fourthScreenPgmConfigNetworkInterfaceWirelessAddressItems[0].SetActive(true);
                    currentPgmConfigNetworkInterfaceWirelessAddressItem = 0;
                }
                break;
            case 4:
                if (currentPgmConfigNetworkInterfaceWirelessAddressItem != fifthScreenPgmConfigNetworkInterfaceWirelessAddressItems.Length - 1)
                {
                    fifthScreenPgmConfigNetworkInterfaceWirelessAddressItems[currentPgmConfigNetworkInterfaceWirelessAddressItem].SetActive(false);
                    fifthScreenPgmConfigNetworkInterfaceWirelessAddressItems[currentPgmConfigNetworkInterfaceWirelessAddressItem + 1].SetActive(true);
                    currentPgmConfigNetworkInterfaceWirelessAddressItem++;
                }
                else
                {
                    fifthScreenPgmConfigNetworkInterfaceWirelessAddressItems[currentPgmConfigNetworkInterfaceWirelessAddressItem].SetActive(false);
                    fifthScreenPgmConfigNetworkInterfaceWirelessAddressItems[0].SetActive(true);
                    currentPgmConfigNetworkInterfaceWirelessAddressItem = 0;
                }
                break;
        }
    }

    public void PgmConfigNetworkInterfaceWirelessAddressDown()
    {
        switch (currentPgmConfigNetworkInterfaceWirelessAddress)
        {
            case 0:
                if (currentPgmConfigNetworkInterfaceWirelessAddressItem != 0)
                {
                    firstScreenPgmConfigNetworkInterfaceWirelessAddressItems[currentPgmConfigNetworkInterfaceWirelessAddressItem].SetActive(false);
                    firstScreenPgmConfigNetworkInterfaceWirelessAddressItems[currentPgmConfigNetworkInterfaceWirelessAddressItem - 1].SetActive(true);
                    currentPgmConfigNetworkInterfaceWirelessAddressItem--;
                }
                else
                {
                    firstScreenPgmConfigNetworkInterfaceWirelessAddressItems[currentPgmConfigNetworkInterfaceWirelessAddressItem].SetActive(false);
                    firstScreenPgmConfigNetworkInterfaceWirelessAddressItems[firstScreenPgmConfigNetworkInterfaceWirelessAddressItems.Length - 1].SetActive(true);
                    currentPgmConfigNetworkInterfaceWirelessAddressItem = firstScreenPgmConfigNetworkInterfaceWirelessAddressItems.Length - 1;
                }
                break;
            case 3:
                if (currentPgmConfigNetworkInterfaceWirelessAddressItem != 0)
                {
                    fourthScreenPgmConfigNetworkInterfaceWirelessAddressItems[currentPgmConfigNetworkInterfaceWirelessAddressItem].SetActive(false);
                    fourthScreenPgmConfigNetworkInterfaceWirelessAddressItems[currentPgmConfigNetworkInterfaceWirelessAddressItem - 1].SetActive(true);
                    currentPgmConfigNetworkInterfaceWirelessAddressItem--;
                }
                else
                {
                    fourthScreenPgmConfigNetworkInterfaceWirelessAddressItems[currentPgmConfigNetworkInterfaceWirelessAddressItem].SetActive(false);
                    fourthScreenPgmConfigNetworkInterfaceWirelessAddressItems[fourthScreenPgmConfigNetworkInterfaceWirelessAddressItems.Length - 1].SetActive(true);
                    currentPgmConfigNetworkInterfaceWirelessAddressItem = fourthScreenPgmConfigNetworkInterfaceWirelessAddressItems.Length - 1;
                }
                break;
            case 4:
                if (currentPgmConfigNetworkInterfaceWirelessAddressItem != 0)
                {
                    fifthScreenPgmConfigNetworkInterfaceWirelessAddressItems[currentPgmConfigNetworkInterfaceWirelessAddressItem].SetActive(false);
                    fifthScreenPgmConfigNetworkInterfaceWirelessAddressItems[currentPgmConfigNetworkInterfaceWirelessAddressItem - 1].SetActive(true);
                    currentPgmConfigNetworkInterfaceWirelessAddressItem--;
                }
                else
                {
                    fifthScreenPgmConfigNetworkInterfaceWirelessAddressItems[currentPgmConfigNetworkInterfaceWirelessAddressItem].SetActive(false);
                    fifthScreenPgmConfigNetworkInterfaceWirelessAddressItems[fifthScreenPgmConfigNetworkInterfaceWirelessAddressItems.Length - 1].SetActive(true);
                    currentPgmConfigNetworkInterfaceWirelessAddressItem = fifthScreenPgmConfigNetworkInterfaceWirelessAddressItems.Length - 1;
                }
                break;
        }
    }

    public void EnterPgmConfigNetworkInterfaceWireless()
    {
        switch (currentPgmConfigNetworkInterfaceWireless)
        {
            case 0:
                DisableLoadMenu();
                isPgmConfigNetworkInterfaceWirelessAddress = true;
                pgmConfigNetworkInterfaceWirelessAddressMenu[0].SetActive(true);
                break;
            case 1:
                isPgmConfigNetworkInterfaceWirelessStatus = true;
                pgmConfigNetworkInterfaceWirelessStatusMenu.SetActive(true);
                break;
        }
    }

    public void NextPgmConfigNetworkInterfaceWirelessMenu()
    {
        if (currentPgmConfigNetworkInterfaceWireless != pgmConfigNetworkInterfaceWirelessMenuImages.Length - 1)
        {
            ChangeColor(pgmConfigNetworkInterfaceWirelessMenuImages[currentPgmConfigNetworkInterfaceWireless], pgmConfigNetworkInterfaceWirelessMenuItems[currentPgmConfigNetworkInterfaceWireless], pgmConfigNetworkInterfaceWirelessMenuImages[currentPgmConfigNetworkInterfaceWireless + 1], pgmConfigNetworkInterfaceWirelessMenuItems[currentPgmConfigNetworkInterfaceWireless + 1]);
            currentPgmConfigNetworkInterfaceWireless++;
        }
        else
        {
            ChangeColor(pgmConfigNetworkInterfaceWirelessMenuImages[currentPgmConfigNetworkInterfacePPP], pgmConfigNetworkInterfaceWirelessMenuItems[currentPgmConfigNetworkInterfaceWireless], pgmConfigNetworkInterfaceWirelessMenuImages[0], pgmConfigNetworkInterfaceWirelessMenuItems[0]);
            currentPgmConfigNetworkInterfacePPP = 0;
        }
    }

    public void PrevPgmConfigNetworkInterfaceWirelessMenu()
    {
        if (currentPgmConfigNetworkInterfaceWireless != 0)
        {
            ChangeColor(pgmConfigNetworkInterfaceWirelessMenuImages[currentPgmConfigNetworkInterfaceWireless], pgmConfigNetworkInterfaceWirelessMenuItems[currentPgmConfigNetworkInterfaceWireless], pgmConfigNetworkInterfaceWirelessMenuImages[currentPgmConfigNetworkInterfaceWireless - 1], pgmConfigNetworkInterfaceWirelessMenuItems[currentPgmConfigNetworkInterfaceWireless - 1]);
            currentPgmConfigNetworkInterfaceWireless--;
        }
        else
        {
            ChangeColor(pgmConfigNetworkInterfaceWirelessMenuImages[currentPgmConfigNetworkInterfaceWireless], pgmConfigNetworkInterfaceWirelessMenuItems[currentPgmConfigNetworkInterfaceWireless], pgmConfigNetworkInterfaceWirelessMenuImages[pgmConfigNetworkInterfaceWirelessMenuImages.Length - 1], pgmConfigNetworkInterfaceWirelessMenuItems[pgmConfigNetworkInterfaceWirelessMenuImages.Length - 1]);
            currentPgmConfigNetworkInterfaceWireless = pgmConfigNetworkInterfaceWirelessMenuImages.Length - 1;
        }
    }

    public void EnterPgmConfigNetworkInterfacePPPPortSetting()
    {
        if (currentPgmConfigNetworkInterfacePPPPortSetting != pgmConfigNetworkInterfacePPPPortSettingMenu.Length - 1)
        {
            pgmConfigNetworkInterfacePPPPortSettingMenu[currentPgmConfigNetworkInterfacePPPPortSetting].SetActive(false);
            pgmConfigNetworkInterfacePPPPortSettingMenu[currentPgmConfigNetworkInterfacePPPPortSetting + 1].SetActive(true);
            currentPgmConfigNetworkInterfacePPPPortSetting++;
            currentPgmConfigNetworkInterfacePPPPortSettingItem = 0;
        }
        else
        {
            DisableLoadMenu();
            isPgmConfig = true;
            pgmConfigMenu[0].SetActive(true);
        }
    }

    public void PgmConfigNetworkInterfacePPPPortSettingUp()
    {
        switch (currentPgmConfigNetworkInterfacePPPPortSetting)
        {
            case 0:
                if (currentPgmConfigNetworkInterfacePPPPortSettingItem != firstScreenPgmConfigNetworkInterfacePPPPortSettingItems.Length - 1)
                {
                    firstScreenPgmConfigNetworkInterfacePPPPortSettingItems[currentPgmConfigNetworkInterfacePPPPortSettingItem].SetActive(false);
                    firstScreenPgmConfigNetworkInterfacePPPPortSettingItems[currentPgmConfigNetworkInterfacePPPPortSettingItem + 1].SetActive(true);
                    currentPgmConfigNetworkInterfacePPPPortSettingItem++;
                }
                else
                {
                    firstScreenPgmConfigNetworkInterfacePPPPortSettingItems[currentPgmConfigNetworkInterfacePPPPortSettingItem].SetActive(false);
                    firstScreenPgmConfigNetworkInterfacePPPPortSettingItems[0].SetActive(true);
                    currentPgmConfigNetworkInterfacePPPPortSettingItem = 0;
                }
                break;
        }
    }

    public void PgmConfigNetworkInterfacePPPPortSettingDown()
    {
        switch (currentPgmConfigNetworkInterfacePPPPortSetting)
        {
            case 0:
                if (currentPgmConfigNetworkInterfacePPPPortSettingItem != 0)
                {
                    firstScreenPgmConfigNetworkInterfacePPPPortSettingItems[currentPgmConfigNetworkInterfacePPPPortSettingItem].SetActive(false);
                    firstScreenPgmConfigNetworkInterfacePPPPortSettingItems[currentPgmConfigNetworkInterfacePPPPortSettingItem - 1].SetActive(true);
                    currentPgmConfigNetworkInterfacePPPPortSettingItem--;
                }
                else
                {
                    firstScreenPgmConfigNetworkInterfacePPPPortSettingItems[currentPgmConfigNetworkInterfacePPPPortSettingItem].SetActive(false);
                    firstScreenPgmConfigNetworkInterfacePPPPortSettingItems[firstScreenPgmConfigNetworkInterfacePPPPortSettingItems.Length - 1].SetActive(true);
                    currentPgmConfigNetworkInterfacePPPPortSettingItem = firstScreenPgmConfigNetworkInterfacePPPPortSettingItems.Length - 1;
                }
                break;
        }
    }

    public void EnterPgmConfigNetworkInterfacePPPStatus()
    {
        if (currentPgmConfigNetworkInterfacePPPStatus != pgmConfigNetworkInterfacePPPStatusMenu.Length - 1)
        {
            pgmConfigNetworkInterfacePPPStatusMenu[currentPgmConfigNetworkInterfacePPPStatus].SetActive(false);
            pgmConfigNetworkInterfacePPPStatusMenu[currentPgmConfigNetworkInterfacePPPStatus + 1].SetActive(true);
            currentPgmConfigNetworkInterfacePPPStatus++;
        }
        else
        {
            DisableLoadMenu();
            isPgmConfig = true;
            pgmConfigMenu[0].SetActive(true);
        }
    }

    public void EnterPgmConfigNetworkInterfacePPPAddress()
    {
        if (currentPgmConfigNetworkInterfacePPPAddress != pgmConfigNetworkInterfacePPPAddressMenu.Length - 1)
        {
            pgmConfigNetworkInterfacePPPAddressMenu[currentPgmConfigNetworkInterfacePPPAddress].SetActive(false);
            pgmConfigNetworkInterfacePPPAddressMenu[currentPgmConfigNetworkInterfacePPPAddress + 1].SetActive(true);
            currentPgmConfigNetworkInterfacePPPAddress++;
            currentPgmConfigNetworkInterfacePPPAddressItem = 0;
            isPgmConfigNetworkInterfacePPPAddressIP = false;
            isPgmConfigNetworkInterfacePPPAddressSubnet = false;
            isPgmConfigNetworkInterfacePPPAddressGetaway = false;
            currentNumb = 0;
            if (currentPgmConfigNetworkInterfacePPPAddress == 1)
            {
                isPgmConfigNetworkInterfacePPPAddressIP = true;
            }
            if(currentPgmConfigNetworkInterfacePPPAddress == 4)
            {
                isPgmConfigNetworkInterfacePPPAddressSubnet = true;
            }
            if (currentPgmConfigNetworkInterfacePPPAddress == 6)
            {
                isPgmConfigNetworkInterfacePPPAddressGetaway = true;
            }
        }
        else
        {
            DisableLoadMenu();
            isPgmConfig = true;
            pgmConfigMenu[0].SetActive(true);
        }
    }

    public void NextPgmConfigNetworkInterfacePPPAddressGetawayNumber()
    {
        if (currentNumb != seventhScreenPgmConfigNetworkInterfacePPPAddressImages.Length - 1)
        {
            ChangeColor(seventhScreenPgmConfigNetworkInterfacePPPAddressImages[currentNumb], seventhScreenPgmConfigNetworkInterfacePPPAddressTexts[currentNumb], seventhScreenPgmConfigNetworkInterfacePPPAddressImages[currentNumb + 1], seventhScreenPgmConfigNetworkInterfacePPPAddressTexts[currentNumb + 1]);
            currentNumb++;
        }
        else
        {
            ChangeColor(seventhScreenPgmConfigNetworkInterfacePPPAddressImages[currentNumb], seventhScreenPgmConfigNetworkInterfacePPPAddressTexts[currentNumb], seventhScreenPgmConfigNetworkInterfacePPPAddressImages[0], seventhScreenPgmConfigNetworkInterfacePPPAddressTexts[0]);
            currentNumb = 0;
        }
    }

    public void PrevPgmConfigNetworkInterfacePPPAddressGetawayNumber()
    {
        if (currentNumb != 0)
        {
            ChangeColor(seventhScreenPgmConfigNetworkInterfacePPPAddressImages[currentNumb], seventhScreenPgmConfigNetworkInterfacePPPAddressTexts[currentNumb], seventhScreenPgmConfigNetworkInterfacePPPAddressImages[currentNumb - 1], seventhScreenPgmConfigNetworkInterfacePPPAddressTexts[currentNumb - 1]);
            currentNumb--;
        }
        else
        {
            ChangeColor(seventhScreenPgmConfigNetworkInterfacePPPAddressImages[currentNumb], seventhScreenPgmConfigNetworkInterfacePPPAddressTexts[currentNumb], seventhScreenPgmConfigNetworkInterfacePPPAddressImages[seventhScreenPgmConfigNetworkInterfacePPPAddressImages.Length - 1], seventhScreenPgmConfigNetworkInterfacePPPAddressTexts[seventhScreenPgmConfigNetworkInterfacePPPAddressImages.Length - 1]);
            currentNumb = seventhScreenPgmConfigNetworkInterfacePPPAddressImages.Length - 1;
        }
    }

    public void NextPgmConfigNetworkInterfacePPPAddressSubnetNumber()
    {
        if (currentNumb != fifthScreenPgmConfigNetworkInterfacePPPAddressImages.Length - 1)
        {
            ChangeColor(fifthScreenPgmConfigNetworkInterfacePPPAddressImages[currentNumb], fifthScreenPgmConfigNetworkInterfacePPPAddressTexts[currentNumb], fifthScreenPgmConfigNetworkInterfacePPPAddressImages[currentNumb + 1], fifthScreenPgmConfigNetworkInterfacePPPAddressTexts[currentNumb + 1]);
            currentNumb++;
        }
        else
        {
            ChangeColor(fifthScreenPgmConfigNetworkInterfacePPPAddressImages[currentNumb], fifthScreenPgmConfigNetworkInterfacePPPAddressTexts[currentNumb], fifthScreenPgmConfigNetworkInterfacePPPAddressImages[0], fifthScreenPgmConfigNetworkInterfacePPPAddressTexts[0]);
            currentNumb = 0;
        }
    }

    public void PrevPgmConfigNetworkInterfacePPPAddressSubnetNumber()
    {
        if (currentNumb != 0)
        {
            ChangeColor(fifthScreenPgmConfigNetworkInterfacePPPAddressImages[currentNumb], fifthScreenPgmConfigNetworkInterfacePPPAddressTexts[currentNumb], fifthScreenPgmConfigNetworkInterfacePPPAddressImages[currentNumb - 1], fifthScreenPgmConfigNetworkInterfacePPPAddressTexts[currentNumb - 1]);
            currentNumb--;
        }
        else
        {
            ChangeColor(fifthScreenPgmConfigNetworkInterfacePPPAddressImages[currentNumb], fifthScreenPgmConfigNetworkInterfacePPPAddressTexts[currentNumb], fifthScreenPgmConfigNetworkInterfacePPPAddressImages[fifthScreenPgmConfigNetworkInterfacePPPAddressImages.Length - 1], fifthScreenPgmConfigNetworkInterfacePPPAddressTexts[fifthScreenPgmConfigNetworkInterfacePPPAddressImages.Length - 1]);
            currentNumb = fifthScreenPgmConfigNetworkInterfacePPPAddressImages.Length - 1;
        }
    }

    public void NextPgmConfigNetworkInterfacePPPAddressIPNumber()
    {
        if (currentNumb != secondScreenPgmConfigNetworkInterfacePPPAddressImages.Length - 1)
        {
            ChangeColor(secondScreenPgmConfigNetworkInterfacePPPAddressImages[currentNumb], secondScreenPgmConfigNetworkInterfacePPPAddressTexts[currentNumb], secondScreenPgmConfigNetworkInterfacePPPAddressImages[currentNumb + 1], secondScreenPgmConfigNetworkInterfacePPPAddressTexts[currentNumb + 1]);
            currentNumb++;
        }
        else
        {
            ChangeColor(secondScreenPgmConfigNetworkInterfacePPPAddressImages[currentNumb], secondScreenPgmConfigNetworkInterfacePPPAddressTexts[currentNumb], secondScreenPgmConfigNetworkInterfacePPPAddressImages[0], secondScreenPgmConfigNetworkInterfacePPPAddressTexts[0]);
            currentNumb = 0;
        }
    }

    public void PrevPgmConfigNetworkInterfacePPPAddressIPNumber()
    {
        if (currentNumb != 0)
        {
            ChangeColor(secondScreenPgmConfigNetworkInterfacePPPAddressImages[currentNumb], secondScreenPgmConfigNetworkInterfacePPPAddressTexts[currentNumb], secondScreenPgmConfigNetworkInterfacePPPAddressImages[currentNumb - 1], secondScreenPgmConfigNetworkInterfacePPPAddressTexts[currentNumb - 1]);
            currentNumb--;
        }
        else
        {
            ChangeColor(secondScreenPgmConfigNetworkInterfacePPPAddressImages[currentNumb], secondScreenPgmConfigNetworkInterfacePPPAddressTexts[currentNumb], secondScreenPgmConfigNetworkInterfacePPPAddressImages[secondScreenPgmConfigNetworkInterfacePPPAddressImages.Length - 1], secondScreenPgmConfigNetworkInterfacePPPAddressTexts[secondScreenPgmConfigNetworkInterfacePPPAddressImages.Length - 1]);
            currentNumb = secondScreenPgmConfigNetworkInterfacePPPAddressImages.Length - 1;
        }
    }

    public void PgmConfigNetworkInterfacePPPAddressUp()
    {
        switch (currentPgmConfigNetworkInterfacePPPAddress)
        {
            case 0:
                if (currentPgmConfigNetworkInterfacePPPAddressItem != firstScreenPgmConfigNetworkInterfacePPPAddressItems.Length - 1)
                {
                    firstScreenPgmConfigNetworkInterfacePPPAddressItems[currentPgmConfigNetworkInterfacePPPAddressItem].SetActive(false);
                    firstScreenPgmConfigNetworkInterfacePPPAddressItems[currentPgmConfigNetworkInterfacePPPAddressItem + 1].SetActive(true);
                    currentPgmConfigNetworkInterfacePPPAddressItem++;
                }
                else
                {
                    firstScreenPgmConfigNetworkInterfacePPPAddressItems[currentPgmConfigNetworkInterfacePPPAddressItem].SetActive(false);
                    firstScreenPgmConfigNetworkInterfacePPPAddressItems[0].SetActive(true);
                    currentPgmConfigNetworkInterfacePPPAddressItem = 0;
                }
                break;
            case 2:
                if (currentPgmConfigNetworkInterfacePPPAddressItem != thirdScreenPgmConfigNetworkInterfacePPPAddressItems.Length - 1)
                {
                    thirdScreenPgmConfigNetworkInterfacePPPAddressItems[currentPgmConfigNetworkInterfacePPPAddressItem].SetActive(false);
                    thirdScreenPgmConfigNetworkInterfacePPPAddressItems[currentPgmConfigNetworkInterfacePPPAddressItem + 1].SetActive(true);
                    currentPgmConfigNetworkInterfacePPPAddressItem++;
                }
                else
                {
                    thirdScreenPgmConfigNetworkInterfacePPPAddressItems[currentPgmConfigNetworkInterfacePPPAddressItem].SetActive(false);
                    thirdScreenPgmConfigNetworkInterfacePPPAddressItems[0].SetActive(true);
                    currentPgmConfigNetworkInterfacePPPAddressItem = 0;
                }
                break;
            case 3:
                if (currentPgmConfigNetworkInterfacePPPAddressItem != fourthScreenPgmConfigNetworkInterfacePPPAddressItems.Length - 1)
                {
                    fourthScreenPgmConfigNetworkInterfacePPPAddressItems[currentPgmConfigNetworkInterfacePPPAddressItem].SetActive(false);
                    fourthScreenPgmConfigNetworkInterfacePPPAddressItems[currentPgmConfigNetworkInterfacePPPAddressItem + 1].SetActive(true);
                    currentPgmConfigNetworkInterfacePPPAddressItem++;
                }
                else
                {
                    fourthScreenPgmConfigNetworkInterfacePPPAddressItems[currentPgmConfigNetworkInterfacePPPAddressItem].SetActive(false);
                    fourthScreenPgmConfigNetworkInterfacePPPAddressItems[0].SetActive(true);
                    currentPgmConfigNetworkInterfacePPPAddressItem = 0;
                }
                break;
            case 5:
                if (currentPgmConfigNetworkInterfacePPPAddressItem != sixthScreenPgmConfigNetworkInterfacePPPAddressItems.Length - 1)
                {
                    sixthScreenPgmConfigNetworkInterfacePPPAddressItems[currentPgmConfigNetworkInterfacePPPAddressItem].SetActive(false);
                    sixthScreenPgmConfigNetworkInterfacePPPAddressItems[currentPgmConfigNetworkInterfacePPPAddressItem + 1].SetActive(true);
                    currentPgmConfigNetworkInterfacePPPAddressItem++;
                }
                else
                {
                    sixthScreenPgmConfigNetworkInterfacePPPAddressItems[currentPgmConfigNetworkInterfacePPPAddressItem].SetActive(false);
                    sixthScreenPgmConfigNetworkInterfacePPPAddressItems[0].SetActive(true);
                    currentPgmConfigNetworkInterfacePPPAddressItem = 0;
                }
                break;
        }
    }

    public void PgmConfigNetworkInterfacePPPAddressDown()
    {
        switch (currentPgmConfigNetworkInterfacePPPAddress)
        {
            case 0:
                if (currentPgmConfigNetworkInterfacePPPAddressItem != 0)
                {
                    firstScreenPgmConfigNetworkInterfacePPPAddressItems[currentPgmConfigNetworkInterfacePPPAddressItem].SetActive(false);
                    firstScreenPgmConfigNetworkInterfacePPPAddressItems[currentPgmConfigNetworkInterfacePPPAddressItem - 1].SetActive(true);
                    currentPgmConfigNetworkInterfacePPPAddressItem--;
                }
                else
                {
                    firstScreenPgmConfigNetworkInterfacePPPAddressItems[currentPgmConfigNetworkInterfacePPPAddressItem].SetActive(false);
                    firstScreenPgmConfigNetworkInterfacePPPAddressItems[firstScreenPgmConfigNetworkInterfacePPPAddressItems.Length - 1].SetActive(true);
                    currentPgmConfigNetworkInterfacePPPAddressItem = firstScreenPgmConfigNetworkInterfacePPPAddressItems.Length - 1;
                }
                break;
            case 2:
                if (currentPgmConfigNetworkInterfacePPPAddressItem != 0)
                {
                    thirdScreenPgmConfigNetworkInterfacePPPAddressItems[currentPgmConfigNetworkInterfacePPPAddressItem].SetActive(false);
                    thirdScreenPgmConfigNetworkInterfacePPPAddressItems[currentPgmConfigNetworkInterfacePPPAddressItem - 1].SetActive(true);
                    currentPgmConfigNetworkInterfacePPPAddressItem--;
                }
                else
                {
                    thirdScreenPgmConfigNetworkInterfacePPPAddressItems[currentPgmConfigNetworkInterfacePPPAddressItem].SetActive(false);
                    thirdScreenPgmConfigNetworkInterfacePPPAddressItems[thirdScreenPgmConfigNetworkInterfacePPPAddressItems.Length - 1].SetActive(true);
                    currentPgmConfigNetworkInterfacePPPAddressItem = thirdScreenPgmConfigNetworkInterfacePPPAddressItems.Length - 1;
                }
                break;
            case 3:
                if (currentPgmConfigNetworkInterfacePPPAddressItem != 0)
                {
                    fourthScreenPgmConfigNetworkInterfacePPPAddressItems[currentPgmConfigNetworkInterfacePPPAddressItem].SetActive(false);
                    fourthScreenPgmConfigNetworkInterfacePPPAddressItems[currentPgmConfigNetworkInterfacePPPAddressItem - 1].SetActive(true);
                    currentPgmConfigNetworkInterfacePPPAddressItem--;
                }
                else
                {
                    fourthScreenPgmConfigNetworkInterfacePPPAddressItems[currentPgmConfigNetworkInterfacePPPAddressItem].SetActive(false);
                    fourthScreenPgmConfigNetworkInterfacePPPAddressItems[fourthScreenPgmConfigNetworkInterfacePPPAddressItems.Length - 1].SetActive(true);
                    currentPgmConfigNetworkInterfacePPPAddressItem = fourthScreenPgmConfigNetworkInterfacePPPAddressItems.Length - 1;
                }
                break;
            case 5:
                if (currentPgmConfigNetworkInterfacePPPAddressItem != 0)
                {
                    sixthScreenPgmConfigNetworkInterfacePPPAddressItems[currentPgmConfigNetworkInterfacePPPAddressItem].SetActive(false);
                    sixthScreenPgmConfigNetworkInterfacePPPAddressItems[currentPgmConfigNetworkInterfacePPPAddressItem - 1].SetActive(true);
                    currentPgmConfigNetworkInterfacePPPAddressItem--;
                }
                else
                {
                    sixthScreenPgmConfigNetworkInterfacePPPAddressItems[currentPgmConfigNetworkInterfacePPPAddressItem].SetActive(false);
                    sixthScreenPgmConfigNetworkInterfacePPPAddressItems[sixthScreenPgmConfigNetworkInterfacePPPAddressItems.Length - 1].SetActive(true);
                    currentPgmConfigNetworkInterfacePPPAddressItem = sixthScreenPgmConfigNetworkInterfacePPPAddressItems.Length - 1;
                }
                break;
        }
    }

    public void EnterPgmConfigNetworkInterfacePPP()
    {
        switch (currentPgmConfigNetworkInterfacePPP)
        {
            case 0:
                DisableLoadMenu();
                isPgmConfigNetworkInterfacePPPAddress = true;
                pgmConfigNetworkInterfacePPPAddressMenu[0].SetActive(true);
                break;
            case 1:
                isPgmConfigNetworkInterfacePPPStatus = true;
                pgmConfigNetworkInterfacePPPStatusMenu[0].SetActive(true);
                break;
            case 2:
                isPgmConfigNetworkInterfacePPPPortSetting = true;
                pgmConfigNetworkInterfacePPPPortSettingMenu[0].SetActive(true);
                break;
        }
    }

    public void NextPgmConfigNetworkInterfacePPPMenu()
    {
        if (currentPgmConfigNetworkInterfacePPP != pgmConfigNetworkInterfacePPPMenuImages.Length - 1)
        {
            ChangeColor(pgmConfigNetworkInterfacePPPMenuImages[currentPgmConfigNetworkInterfacePPP], pgmConfigNetworkInterfacePPPMenuItems[currentPgmConfigNetworkInterfacePPP], pgmConfigNetworkInterfacePPPMenuImages[currentPgmConfigNetworkInterfacePPP + 1], pgmConfigNetworkInterfacePPPMenuItems[currentPgmConfigNetworkInterfacePPP + 1]);
            currentPgmConfigNetworkInterfacePPP++;
        }
        else
        {
            ChangeColor(pgmConfigNetworkInterfacePPPMenuImages[currentPgmConfigNetworkInterfacePPP], pgmConfigNetworkInterfacePPPMenuItems[currentPgmConfigNetworkInterfacePPP], pgmConfigNetworkInterfacePPPMenuImages[0], pgmConfigNetworkInterfacePPPMenuItems[0]);
            currentPgmConfigNetworkInterfacePPP = 0;
        }
    }

    public void PrevPgmConfigNetworkInterfacePPPMenu()
    {
        if (currentPgmConfigNetworkInterfacePPP != 0)
        {
            ChangeColor(pgmConfigNetworkInterfacePPPMenuImages[currentPgmConfigNetworkInterfacePPP], pgmConfigNetworkInterfacePPPMenuItems[currentPgmConfigNetworkInterfacePPP], pgmConfigNetworkInterfacePPPMenuImages[currentPgmConfigNetworkInterfacePPP - 1], pgmConfigNetworkInterfacePPPMenuItems[currentPgmConfigNetworkInterfacePPP - 1]);
            currentPgmConfigNetworkInterfacePPP--;
        }
        else
        {
            ChangeColor(pgmConfigNetworkInterfacePPPMenuImages[currentPgmConfigNetworkInterfaceEthernet], pgmConfigNetworkInterfacePPPMenuItems[currentPgmConfigNetworkInterfaceEthernet], pgmConfigNetworkInterfacePPPMenuImages[pgmConfigNetworkInterfacePPPMenuImages.Length - 1], pgmConfigNetworkInterfacePPPMenuItems[pgmConfigNetworkInterfacePPPMenuImages.Length - 1]);
            currentPgmConfigNetworkInterfacePPP = pgmConfigNetworkInterfacePPPMenuImages.Length - 1;
        }
    }

    public void EnterPgmConfigNetworkInterfaceEthernetStatus()
    {
        DisableLoadMenu();
        isPgmConfig = true;
        pgmConfigMenu[0].SetActive(true);
    }

    public void EnterPgmConfigNetworkInterfaceEthernetAddress()
    {
        if (currentPgmConfigNetworkInterfaceEthernetAddress != pgmConfigNetworkInterfaceEthernetAddressMenu.Length - 1)
        {
            pgmConfigNetworkInterfaceEthernetAddressMenu[currentPgmConfigNetworkInterfaceEthernetAddress].SetActive(false);
            pgmConfigNetworkInterfaceEthernetAddressMenu[currentPgmConfigNetworkInterfaceEthernetAddress + 1].SetActive(true);
            currentPgmConfigNetworkInterfaceEthernetAddress++;
            currentPgmConfigNetworkInterfaceEthernetAddressItem = 0;
            isPgmConfigNetworkInterfaceEthernetAddressIP = false;
            currentNumb = 0;
            if (currentPgmConfigNetworkInterfaceEthernetAddress == 2)
            {
                isPgmConfigNetworkInterfaceEthernetAddressIP = true;
            }
        }
        else
        {
            DisableLoadMenu();
            isPgmConfig = true;
            pgmConfigMenu[0].SetActive(true);
        }
    }

    public void NextPgmConfigNetworkInterfaceEthernetAddressNumber()
    {
        if (currentNumb != thirdScreenPgmConfigNetworkInterfaceEthernetAddressImages.Length - 1)
        {
            ChangeColor(thirdScreenPgmConfigNetworkInterfaceEthernetAddressImages[currentNumb], thirdScreenPgmConfigNetworkInterfaceEthernetAddressTexts[currentNumb], thirdScreenPgmConfigNetworkInterfaceEthernetAddressImages[currentNumb + 1], thirdScreenPgmConfigNetworkInterfaceEthernetAddressTexts[currentNumb + 1]);
            currentNumb++;
        }
        else
        {
            ChangeColor(thirdScreenPgmConfigNetworkInterfaceEthernetAddressImages[currentNumb], thirdScreenPgmConfigNetworkInterfaceEthernetAddressTexts[currentNumb], thirdScreenPgmConfigNetworkInterfaceEthernetAddressImages[0], thirdScreenPgmConfigNetworkInterfaceEthernetAddressTexts[0]);
            currentNumb = 0;
        }
    }

    public void PrevPgmConfigNetworkInterfaceEthernetAddressNumber()
    {
        if (currentNumb != 0)
        {
            ChangeColor(thirdScreenPgmConfigNetworkInterfaceEthernetAddressImages[currentNumb], thirdScreenPgmConfigNetworkInterfaceEthernetAddressTexts[currentNumb], thirdScreenPgmConfigNetworkInterfaceEthernetAddressImages[currentNumb - 1], thirdScreenPgmConfigNetworkInterfaceEthernetAddressTexts[currentNumb - 1]);
            currentNumb--;
        }
        else
        {
            ChangeColor(thirdScreenPgmConfigNetworkInterfaceEthernetAddressImages[currentNumb], thirdScreenPgmConfigNetworkInterfaceEthernetAddressTexts[currentNumb], thirdScreenPgmConfigNetworkInterfaceEthernetAddressImages[thirdScreenPgmConfigNetworkInterfaceEthernetAddressImages.Length - 1], thirdScreenPgmConfigNetworkInterfaceEthernetAddressTexts[thirdScreenPgmConfigNetworkInterfaceEthernetAddressImages.Length - 1]);
            currentNumb = thirdScreenPgmConfigNetworkInterfaceEthernetAddressImages.Length - 1;
        }
    }

    public void PgmConfigNetworkInterfaceEthernetAddressUp()
    {
        switch (currentPgmConfigNetworkInterfaceEthernetAddress)
        {
            case 0:
                if (currentPgmConfigNetworkInterfaceEthernetAddressItem != firstScreenPgmConfigNetworkInterfaceEthernetAddressItems.Length - 1)
                {
                    firstScreenPgmConfigNetworkInterfaceEthernetAddressItems[currentPgmConfigNetworkInterfaceEthernetAddressItem].SetActive(false);
                    firstScreenPgmConfigNetworkInterfaceEthernetAddressItems[currentPgmConfigNetworkInterfaceEthernetAddressItem + 1].SetActive(true);
                    currentPgmConfigNetworkInterfaceEthernetAddressItem++;
                }
                else
                {
                    firstScreenPgmConfigNetworkInterfaceEthernetAddressItems[currentPgmConfigNetworkInterfaceEthernetAddressItem].SetActive(false);
                    firstScreenPgmConfigNetworkInterfaceEthernetAddressItems[0].SetActive(true);
                    currentPgmConfigNetworkInterfaceEthernetAddressItem = 0;
                }
                break;
            case 1:
                if (currentPgmConfigNetworkInterfaceEthernetAddressItem != secondScreenPgmConfigNetworkInterfaceEthernetAddressItems.Length - 1)
                {
                    secondScreenPgmConfigNetworkInterfaceEthernetAddressItems[currentPgmConfigNetworkInterfaceEthernetAddressItem].SetActive(false);
                    secondScreenPgmConfigNetworkInterfaceEthernetAddressItems[currentPgmConfigNetworkInterfaceEthernetAddressItem + 1].SetActive(true);
                    currentPgmConfigNetworkInterfaceEthernetAddressItem++;
                }
                else
                {
                    secondScreenPgmConfigNetworkInterfaceEthernetAddressItems[currentPgmConfigNetworkInterfaceEthernetAddressItem].SetActive(false);
                    secondScreenPgmConfigNetworkInterfaceEthernetAddressItems[0].SetActive(true);
                    currentPgmConfigNetworkInterfaceEthernetAddressItem = 0;
                }
                break;
        }
    }

    public void PgmConfigNetworkInterfaceEthernetAddressDown()
    {
        switch (currentPgmConfigNetworkInterfaceEthernetAddress)
        {
            case 0:
                if (currentPgmConfigNetworkInterfaceEthernetAddressItem != 0)
                {
                    firstScreenPgmConfigNetworkInterfaceEthernetAddressItems[currentPgmConfigNetworkInterfaceEthernetAddressItem].SetActive(false);
                    firstScreenPgmConfigNetworkInterfaceEthernetAddressItems[currentPgmConfigNetworkInterfaceEthernetAddressItem - 1].SetActive(true);
                    currentPgmConfigNetworkInterfaceEthernetAddressItem--;
                }
                else
                {
                    firstScreenPgmConfigNetworkInterfaceEthernetAddressItems[currentPgmConfigNetworkInterfaceEthernetAddressItem].SetActive(false);
                    firstScreenPgmConfigNetworkInterfaceEthernetAddressItems[firstScreenPgmConfigNetworkInterfaceEthernetAddressItems.Length - 1].SetActive(true);
                    currentPgmConfigNetworkInterfaceEthernetAddressItem = firstScreenPgmConfigNetworkInterfaceEthernetAddressItems.Length - 1;
                }
                break;
            case 1:
                if (currentPgmConfigNetworkInterfaceEthernetAddressItem != 0)
                {
                    secondScreenPgmConfigNetworkInterfaceEthernetAddressItems[currentPgmConfigNetworkInterfaceEthernetAddressItem].SetActive(false);
                    secondScreenPgmConfigNetworkInterfaceEthernetAddressItems[currentPgmConfigNetworkInterfaceEthernetAddressItem - 1].SetActive(true);
                    currentPgmConfigNetworkInterfaceEthernetAddressItem--;
                }
                else
                {
                    secondScreenPgmConfigNetworkInterfaceEthernetAddressItems[currentPgmConfigNetworkInterfaceEthernetAddressItem].SetActive(false);
                    secondScreenPgmConfigNetworkInterfaceEthernetAddressItems[secondScreenPgmConfigNetworkInterfaceEthernetAddressItems.Length - 1].SetActive(true);
                    currentPgmConfigNetworkInterfaceEthernetAddressItem = secondScreenPgmConfigNetworkInterfaceEthernetAddressItems.Length - 1;
                }
                break;
        }
    }

    public void EnterPgmConfigNetworkInterfaceEthernet()
    {
        switch (currentPgmConfigNetworkInterfaceEthernet)
        {
            case 0:
                DisableLoadMenu();
                isPgmConfigNetworkInterfaceEthernetAddress = true;
                pgmConfigNetworkInterfaceEthernetAddressMenu[0].SetActive(true);
                break;
            case 1:
                isPgmConfigNetworkInterfaceEthernetStatus = true;
                pgmConfigNetworkInterfaceEthernetStatusMenu.SetActive(true);
                break;
        }
    }

    public void NextPgmConfigNetworkInterfaceEthernetMenu()
    {
        if (currentPgmConfigNetworkInterfaceEthernet != pgmConfigNetworkInterfaceEthernetMenuImages.Length - 1)
        {
            ChangeColor(pgmConfigNetworkInterfaceEthernetMenuImages[currentPgmConfigNetworkInterfaceEthernet], pgmConfigNetworkInterfaceEthernetMenuItems[currentPgmConfigNetworkInterfaceEthernet], pgmConfigNetworkInterfaceEthernetMenuImages[currentPgmConfigNetworkInterfaceEthernet + 1], pgmConfigNetworkInterfaceEthernetMenuItems[currentPgmConfigNetworkInterfaceEthernet + 1]);
            currentPgmConfigNetworkInterfaceEthernet++;
        }
        else
        {
            ChangeColor(pgmConfigNetworkInterfaceEthernetMenuImages[currentPgmConfigNetworkInterfaceEthernet], pgmConfigNetworkInterfaceEthernetMenuItems[currentPgmConfigNetworkInterfaceEthernet], pgmConfigNetworkInterfaceEthernetMenuImages[0], pgmConfigNetworkInterfaceEthernetMenuItems[0]);
            currentPgmConfigNetworkInterfaceEthernet = 0;
        }
    }

    public void PrevPgmConfigNetworkInterfaceEthernetMenu()
    {
        if (currentPgmConfigNetworkInterfaceEthernet != 0)
        {
            ChangeColor(pgmConfigNetworkInterfaceEthernetMenuImages[currentPgmConfigNetworkInterfaceEthernet], pgmConfigNetworkInterfaceEthernetMenuItems[currentPgmConfigNetworkInterfaceEthernet], pgmConfigNetworkInterfaceEthernetMenuImages[currentPgmConfigNetworkInterfaceEthernet - 1], pgmConfigNetworkInterfaceEthernetMenuItems[currentPgmConfigNetworkInterfaceEthernet - 1]);
            currentPgmConfigNetworkInterfaceEthernet--;
        }
        else
        {
            ChangeColor(pgmConfigNetworkInterfaceEthernetMenuImages[currentPgmConfigNetworkInterfaceEthernet], pgmConfigNetworkInterfaceEthernetMenuItems[currentPgmConfigNetworkInterfaceEthernet], pgmConfigNetworkInterfaceEthernetMenuImages[pgmConfigNetworkInterfaceEthernetMenuImages.Length - 1], pgmConfigNetworkInterfaceEthernetMenuItems[pgmConfigNetworkInterfaceEthernetMenuImages.Length - 1]);
            currentPgmConfigNetworkInterfaceEthernet = pgmConfigNetworkInterfaceEthernetMenuImages.Length - 1;
        }
    }

    public void EnterPgmConfigNetworkInterface()
    {
        switch (currentPgmConfigNetworkInterface)
        {
            case 0:
                DisableLoadMenu();
                isPgmConfigNetworkInterfaceEthernet = true;
                pgmConfigNetworkInterfaceEthernetMenu.SetActive(true);
                break;
            case 1:
                isPgmConfigNetworkInterfacePPP = true;
                pgmConfigNetworkInterfacePPPMenu.SetActive(true);
                break;
            case 2:
                isPgmConfigNetworkInterfaceWireless = true;
                pgmConfigNetworkInterfaceWirelessMenu.SetActive(true);
                break;
        }
    }

    public void NextPgmConfigNetworkInterfaceMenu()
    {
        if (currentPgmConfigNetworkInterface != pgmConfigNetworkInterfaceMenuImages.Length - 1)
        {
            ChangeColor(pgmConfigNetworkInterfaceMenuImages[currentPgmConfigNetworkInterface], pgmConfigNetworkInterfaceMenuItems[currentPgmConfigNetworkInterface], pgmConfigNetworkInterfaceMenuImages[currentPgmConfigNetworkInterface + 1], pgmConfigNetworkInterfaceMenuItems[currentPgmConfigNetworkInterface + 1]);
            currentPgmConfigNetworkInterface++;
        }
        else
        {
            ChangeColor(pgmConfigNetworkInterfaceMenuImages[currentPgmConfigNetworkInterface], pgmConfigNetworkInterfaceMenuItems[currentPgmConfigNetworkInterface], pgmConfigNetworkInterfaceMenuImages[0], pgmConfigNetworkInterfaceMenuItems[0]);
            currentPgmConfigNetworkInterface = 0;
        }
    }

    public void PrevPgmConfigNetworkInterfaceMenu()
    {
        if (currentPgmConfigNetworkInterface != 0)
        {
            ChangeColor(pgmConfigNetworkInterfaceMenuImages[currentPgmConfigNetworkInterface], pgmConfigNetworkInterfaceMenuItems[currentPgmConfigNetworkInterface], pgmConfigNetworkInterfaceMenuImages[currentPgmConfigNetworkInterface - 1], pgmConfigNetworkInterfaceMenuItems[currentPgmConfigNetworkInterface - 1]);
            currentPgmConfigNetworkInterface--;
        }
        else
        {
            ChangeColor(pgmConfigNetworkInterfaceMenuImages[currentPgmConfigNetworkInterface], pgmConfigNetworkInterfaceMenuItems[currentPgmConfigNetworkInterface], pgmConfigNetworkInterfaceMenuImages[pgmConfigNetworkInterfaceMenuImages.Length - 1], pgmConfigNetworkInterfaceMenuItems[pgmConfigNetworkInterfaceMenuImages.Length - 1]);
            currentPgmConfigNetworkInterface = pgmConfigNetworkInterfaceMenuImages.Length - 1;
        }
    }

    public void EnterPgmConfigNetwork()
    {
        switch(currentPgmConfigNetwork)
        {
            case 0:
                DisableLoadMenu();
                isPgmConfigNetworkInterface = true;
                pgmConfigNetworkInterfaceMenu.SetActive(true);
                break;
            case 1:
                isPgmConfigNetworkProtocol = true;
                pgmConfigNetworkProtocolMenu.SetActive(true); 
                break;
            case 2:
                isPgmConfigNetworkRoutes = true;
                pgmConfigNetworkRoutesMenu.SetActive(true);
                break;
        }
    }

    public void NextPgmConfigNetworkMenu()
    {
        if (currentPgmConfigNetwork != pgmConfigNetworkMenuImages.Length - 1)
        {
            ChangeColor(pgmConfigNetworkMenuImages[currentPgmConfigNetwork], pgmConfigNetworkMenuItems[currentPgmConfigNetwork], pgmConfigNetworkMenuImages[currentPgmConfigNetwork + 1], pgmConfigNetworkMenuItems[currentPgmConfigNetwork + 1]);
            currentPgmConfigNetwork++;
        }
        else
        {
            ChangeColor(pgmConfigNetworkMenuImages[currentPgmConfigNetwork], pgmConfigNetworkMenuItems[currentPgmConfigNetwork], pgmConfigNetworkMenuImages[0], pgmConfigNetworkMenuItems[0]);
            currentPgmConfigNetwork = 0;
        }
    }

    public void PrevPgmConfigNetworkMenu()
    {
        if (currentPgmConfigNetwork != 0)
        {
            ChangeColor(pgmConfigNetworkMenuImages[currentPgmConfigNetwork], pgmConfigNetworkMenuItems[currentPgmConfigNetwork], pgmConfigNetworkMenuImages[currentPgmConfigNetwork - 1], pgmConfigNetworkMenuItems[currentPgmConfigNetwork - 1]);
            currentPgmConfigNetwork--;
        }
        else
        {
            ChangeColor(pgmConfigNetworkMenuImages[currentPgmConfigNetwork], pgmConfigNetworkMenuItems[currentPgmConfigNetwork], pgmConfigNetworkMenuImages[pgmConfigNetworkInterfaceMenuImages.Length - 1], pgmConfigNetworkMenuItems[pgmConfigNetworkInterfaceMenuImages.Length - 1]);
            currentPgmConfigNetwork = pgmConfigNetworkMenuImages.Length - 1;
        }
    }

    public void EnterPgmConfigAccessory()
    {
        if (currentPgmConfigAccessory != pgmConfigAccessoryMenu.Length - 1)
        {
            pgmConfigAccessoryMenu[currentPgmConfigAccessory].SetActive(false);
            pgmConfigAccessoryMenu[currentPgmConfigAccessory + 1].SetActive(true);
            currentPgmConfigAccessory++;
            currentPgmConfigAccessoryItem = 0;
        }
        else
        {
            DisableLoadMenu();
            isPgmConfig = true;
            pgmConfigMenu[0].SetActive(true);
        }
    }

    public void PgmConfigAccessoryUp()
    {
        switch (currentPgmConfigAccessory)
        {
            case 0:
                if (currentPgmConfigAccessoryItem != firstScreenPgmConfigAccessoryItems.Length - 1)
                {
                    firstScreenPgmConfigAccessoryItems[currentPgmConfigAccessoryItem].SetActive(false);
                    firstScreenPgmConfigAccessoryItems[currentPgmConfigAccessoryItem + 1].SetActive(true);
                    currentPgmConfigAccessoryItem++;
                }
                else
                {
                    firstScreenPgmConfigAccessoryItems[currentPgmConfigAccessoryItem].SetActive(false);
                    firstScreenPgmConfigAccessoryItems[0].SetActive(true);
                    currentPgmConfigAccessoryItem = 0;
                }
                break;
            case 1:
                if (currentPgmConfigAccessoryItem != secondScreenPgmConfigAccessoryItems.Length - 1)
                {
                    secondScreenPgmConfigAccessoryItems[currentPgmConfigAccessoryItem].SetActive(false);
                    secondScreenPgmConfigAccessoryItems[currentPgmConfigAccessoryItem + 1].SetActive(true);
                    currentPgmConfigAccessoryItem++;
                }
                else
                {
                    secondScreenPgmConfigAccessoryItems[currentPgmConfigAccessoryItem].SetActive(false);
                    secondScreenPgmConfigAccessoryItems[0].SetActive(true);
                    currentPgmConfigAccessoryItem = 0;
                }
                break;
            case 2:
                if (currentPgmConfigAccessoryItem != thirdScreenPgmConfigAccessoryItems.Length - 1)
                {
                    thirdScreenPgmConfigAccessoryItems[currentPgmConfigAccessoryItem].SetActive(false);
                    thirdScreenPgmConfigAccessoryItems[currentPgmConfigAccessoryItem + 1].SetActive(true);
                    currentPgmConfigAccessoryItem++;
                }
                else
                {
                    thirdScreenPgmConfigAccessoryItems[currentPgmConfigAccessoryItem].SetActive(false);
                    thirdScreenPgmConfigAccessoryItems[0].SetActive(true);
                    currentPgmConfigAccessoryItem = 0;
                }
                break;
            case 3:
                if (currentPgmConfigAccessoryItem != fourthScreenPgmConfigAccessoryItems.Length - 1)
                {
                    fourthScreenPgmConfigAccessoryItems[currentPgmConfigAccessoryItem].SetActive(false);
                    fourthScreenPgmConfigAccessoryItems[currentPgmConfigAccessoryItem + 1].SetActive(true);
                    currentPgmConfigAccessoryItem++;
                }
                else
                {
                    fourthScreenPgmConfigAccessoryItems[currentPgmConfigAccessoryItem].SetActive(false);
                    fourthScreenPgmConfigAccessoryItems[0].SetActive(true);
                    currentPgmConfigAccessoryItem = 0;
                }
                break;
            case 4:
                if (currentPgmConfigAccessoryItem != fifthScreenPgmConfigAccessoryItems.Length - 1)
                {
                    fifthScreenPgmConfigAccessoryItems[currentPgmConfigAccessoryItem].SetActive(false);
                    fifthScreenPgmConfigAccessoryItems[currentPgmConfigAccessoryItem + 1].SetActive(true);
                    currentPgmConfigAccessoryItem++;
                }
                else
                {
                    fifthScreenPgmConfigAccessoryItems[currentPgmConfigAccessoryItem].SetActive(false);
                    fifthScreenPgmConfigAccessoryItems[0].SetActive(true);
                    currentPgmConfigAccessoryItem = 0;
                }
                break;
            case 5:
                if (currentPgmConfigAccessoryItem != sixScreenPgmConfigAccessoryItems.Length - 1)
                {
                    sixScreenPgmConfigAccessoryItems[currentPgmConfigAccessoryItem].SetActive(false);
                    sixScreenPgmConfigAccessoryItems[currentPgmConfigAccessoryItem + 1].SetActive(true);
                    currentPgmConfigAccessoryItem++;
                }
                else
                {
                    sixScreenPgmConfigAccessoryItems[currentPgmConfigAccessoryItem].SetActive(false);
                    sixScreenPgmConfigAccessoryItems[0].SetActive(true);
                    currentPgmConfigAccessoryItem = 0;
                }
                break;
            case 6:
                if (currentPgmConfigAccessoryItem != seventhScreenPgmConfigAccessoryItems.Length - 1)
                {
                    seventhScreenPgmConfigAccessoryItems[currentPgmConfigAccessoryItem].SetActive(false);
                    seventhScreenPgmConfigAccessoryItems[currentPgmConfigAccessoryItem + 1].SetActive(true);
                    currentPgmConfigAccessoryItem++;
                }
                else
                {
                    seventhScreenPgmConfigAccessoryItems[currentPgmConfigAccessoryItem].SetActive(false);
                    seventhScreenPgmConfigAccessoryItems[0].SetActive(true);
                    currentPgmConfigAccessoryItem = 0;
                }
                break;
        }
    }

    public void PgmConfigAccessoryDown()
    {
        switch (currentPgmConfigAccessory)
        {
            case 0:
                if (currentPgmConfigAccessoryItem != 0)
                {
                    firstScreenPgmConfigAccessoryItems[currentPgmConfigAccessoryItem].SetActive(false);
                    firstScreenPgmConfigAccessoryItems[currentPgmConfigAccessoryItem - 1].SetActive(true);
                    currentPgmConfigAccessoryItem--;
                }
                else
                {
                    firstScreenPgmConfigAccessoryItems[currentPgmConfigAccessoryItem].SetActive(false);
                    firstScreenPgmConfigAccessoryItems[firstScreenPgmConfigAccessoryItems.Length - 1].SetActive(true);
                    currentPgmConfigAccessoryItem = firstScreenPgmConfigAccessoryItems.Length - 1;
                }
                break;
            case 1:
                if (currentPgmConfigAccessoryItem != 0)
                {
                    secondScreenPgmConfigAccessoryItems[currentPgmConfigAccessoryItem].SetActive(false);
                    secondScreenPgmConfigAccessoryItems[currentPgmConfigAccessoryItem - 1].SetActive(true);
                    currentPgmConfigGPSitem--;
                }
                else
                {
                    secondScreenPgmConfigAccessoryItems[currentPgmConfigAccessoryItem].SetActive(false);
                    secondScreenPgmConfigAccessoryItems[secondScreenPgmConfigAccessoryItems.Length - 1].SetActive(true);
                    currentPgmConfigAccessoryItem = secondScreenPgmConfigAccessoryItems.Length - 1;
                }
                break;
            case 2:
                if (currentPgmConfigAccessoryItem != 0)
                {
                    thirdScreenPgmConfigAccessoryItems[currentPgmConfigAccessoryItem].SetActive(false);
                    thirdScreenPgmConfigAccessoryItems[currentPgmConfigAccessoryItem - 1].SetActive(true);
                    currentPgmConfigAccessoryItem--;
                }
                else
                {
                    thirdScreenPgmConfigAccessoryItems[currentPgmConfigAccessoryItem].SetActive(false);
                    thirdScreenPgmConfigAccessoryItems[thirdScreenPgmConfigAccessoryItems.Length - 1].SetActive(true);
                    currentPgmConfigAccessoryItem = thirdScreenPgmConfigAccessoryItems.Length - 1;
                }
                break;
            case 3:
                if (currentPgmConfigAccessoryItem != 0)
                {
                    fourthScreenPgmConfigAccessoryItems[currentPgmConfigAccessoryItem].SetActive(false);
                    fourthScreenPgmConfigAccessoryItems[currentPgmConfigAccessoryItem - 1].SetActive(true);
                    currentPgmConfigAccessoryItem--;
                }
                else
                {
                    fourthScreenPgmConfigAccessoryItems[currentPgmConfigAccessoryItem].SetActive(false);
                    fourthScreenPgmConfigAccessoryItems[fourthScreenPgmConfigAccessoryItems.Length - 1].SetActive(true);
                    currentPgmConfigAccessoryItem = fourthScreenPgmConfigAccessoryItems.Length - 1;
                }
                break;
            case 4:
                if (currentPgmConfigAccessoryItem != 0)
                {
                    fifthScreenPgmConfigAccessoryItems[currentPgmConfigAccessoryItem].SetActive(false);
                    fifthScreenPgmConfigAccessoryItems[currentPgmConfigAccessoryItem - 1].SetActive(true);
                    currentPgmConfigAccessoryItem--;
                }
                else
                {
                    fifthScreenPgmConfigAccessoryItems[currentPgmConfigAccessoryItem].SetActive(false);
                    fifthScreenPgmConfigAccessoryItems[fifthScreenPgmConfigAccessoryItems.Length - 1].SetActive(true);
                    currentPgmConfigAccessoryItem = fifthScreenPgmConfigAccessoryItems.Length - 1;
                }
                break;
            case 5:
                if (currentPgmConfigAccessoryItem != 0)
                {
                    sixScreenPgmConfigAccessoryItems[currentPgmConfigAccessoryItem].SetActive(false);
                    sixScreenPgmConfigAccessoryItems[currentPgmConfigAccessoryItem - 1].SetActive(true);
                    currentPgmConfigAccessoryItem--;
                }
                else
                {
                    sixScreenPgmConfigAccessoryItems[currentPgmConfigAccessoryItem].SetActive(false);
                    sixScreenPgmConfigAccessoryItems[sixScreenPgmConfigAccessoryItems.Length - 1].SetActive(true);
                    currentPgmConfigAccessoryItem = sixScreenPgmConfigAccessoryItems.Length - 1;
                }
                break;
            case 6:
                if (currentPgmConfigAccessoryItem != 0)
                {
                    seventhScreenPgmConfigAccessoryItems[currentPgmConfigAccessoryItem].SetActive(false);
                    seventhScreenPgmConfigAccessoryItems[currentPgmConfigAccessoryItem - 1].SetActive(true);
                    currentPgmConfigAccessoryItem--;
                }
                else
                {
                    seventhScreenPgmConfigAccessoryItems[currentPgmConfigAccessoryItem].SetActive(false);
                    seventhScreenPgmConfigAccessoryItems[seventhScreenPgmConfigAccessoryItems.Length - 1].SetActive(true);
                    currentPgmConfigAccessoryItem = seventhScreenPgmConfigAccessoryItems.Length - 1;
                }
                break;
        }
    }

    public void ChangeNumber(string newNumb)
    {
        if(isTimeInterval)
        {
            secondScreenPgmConfigGPSARPTexts[currentNumb].text = newNumb;
        }
        if(isGPSARPIpAddress)
        {
            fifthScreenPgmConfigGPSARPTexts[currentNumb].text = newNumb;
        }
        if(isPgmConfigNetworkInterfaceEthernetAddressIP)
        {
            thirdScreenPgmConfigNetworkInterfaceEthernetAddressTexts[currentNumb].text = newNumb;
        }
        if(isPgmConfigNetworkInterfacePPPAddressIP)
        {
            secondScreenPgmConfigNetworkInterfacePPPAddressTexts[currentNumb].text = newNumb;
        }
        if(isPgmConfigNetworkInterfacePPPAddressSubnet)
        {
            fifthScreenPgmConfigNetworkInterfacePPPAddressTexts[currentNumb].text = newNumb;
        }
        if(isPgmConfigNetworkInterfacePPPAddressGetaway)
        {
            seventhScreenPgmConfigNetworkInterfacePPPAddressTexts[currentNumb].text = newNumb;
        }
        if(isPgmConfigNetworkInterfaceWirelessAddressIP)
        {
            secondScreenPgmConfigNetworkInterfaceWirelessAddressTexts[currentNumb].text = newNumb;
        }
        if (isPgmConfigNetworkInterfaceWirelessAddressSubnet)
        {
            thirdScreenPgmConfigNetworkInterfaceWirelessAddressTexts[currentNumb].text = newNumb;
        }
        if(isPgmConfigNetworkProtocolSNMPTrapAddress)
        {
            secondScreenPgmConfigNetworkProtocolSNMPTexts[currentNumb].text = newNumb;
        }
    }

    public void EnterPgmConfigGPSARP()
    {
        if (currentPgmConfigGPSARP != pgmConfigGPSARPMenu.Length - 1)
        {
            pgmConfigGPSARPMenu[currentPgmConfigGPSARP].SetActive(false);
            pgmConfigGPSARPMenu[currentPgmConfigGPSARP + 1].SetActive(true);
            currentPgmConfigGPSARP++;
            currentPgmConfigGPSARPitem = 0;
            isTimeInterval = false;
            isGPSARPIpAddress = false;
            currentNumb = 0;
            if (currentPgmConfigGPSARP == 1)
            {
                isTimeInterval = true;
            }
            if (currentPgmConfigGPSARP == 4)
            {
                isGPSARPIpAddress = true;
            }
        }
        else
        {
            DisableLoadMenu();
            isPgmConfig = true;
            pgmConfigMenu[0].SetActive(true);
        }
    }

    public void NextGPSARPIPAddressNumber()
    {
        if (currentNumb != fifthScreenPgmConfigGPSARPImages.Length - 1)
        {
            ChangeColor(fifthScreenPgmConfigGPSARPImages[currentNumb], fifthScreenPgmConfigGPSARPTexts[currentNumb], fifthScreenPgmConfigGPSARPImages[currentNumb + 1], fifthScreenPgmConfigGPSARPTexts[currentNumb + 1]);
            currentNumb++;
        }
        else
        {
            ChangeColor(fifthScreenPgmConfigGPSARPImages[currentNumb], fifthScreenPgmConfigGPSARPTexts[currentNumb], fifthScreenPgmConfigGPSARPImages[0], fifthScreenPgmConfigGPSARPTexts[0]);
            currentNumb = 0;
        }
    }

    public void PrevGPSARPIPAddressNumber()
    {
        if (currentNumb != 0)
        {
            ChangeColor(fifthScreenPgmConfigGPSARPImages[currentNumb], fifthScreenPgmConfigGPSARPTexts[currentNumb], fifthScreenPgmConfigGPSARPImages[currentNumb - 1], fifthScreenPgmConfigGPSARPTexts[currentNumb - 1]);
            currentNumb--;
        }
        else
        {
            ChangeColor(fifthScreenPgmConfigGPSARPImages[currentNumb], fifthScreenPgmConfigGPSARPTexts[currentNumb], fifthScreenPgmConfigGPSARPImages[fifthScreenPgmConfigGPSARPImages.Length - 1], fifthScreenPgmConfigGPSARPTexts[fifthScreenPgmConfigGPSARPImages.Length - 1]);
            currentNumb = fifthScreenPgmConfigGPSARPImages.Length - 1;
        }
    }

    public void NextTimeIntervalNumber()
    {
        if (currentNumb != secondScreenPgmConfigGPSARPImages.Length - 1)
        {
            ChangeColor(secondScreenPgmConfigGPSARPImages[currentNumb], secondScreenPgmConfigGPSARPTexts[currentNumb], secondScreenPgmConfigGPSARPImages[currentNumb + 1], secondScreenPgmConfigGPSARPTexts[currentNumb + 1]);
            currentNumb++;
        }
        else
        {
            ChangeColor(secondScreenPgmConfigGPSARPImages[currentNumb], secondScreenPgmConfigGPSARPTexts[currentNumb], secondScreenPgmConfigGPSARPImages[0], secondScreenPgmConfigGPSARPTexts[0]);
            currentNumb = 0;
        }
    }

    public void PrevTimeIntervalNumber()
    {
        if (currentNumb != 0)
        {
            ChangeColor(secondScreenPgmConfigGPSARPImages[currentNumb], secondScreenPgmConfigGPSARPTexts[currentNumb], secondScreenPgmConfigGPSARPImages[currentNumb - 1], secondScreenPgmConfigGPSARPTexts[currentNumb - 1]);
            currentNumb--;
        }
        else
        {
            ChangeColor(secondScreenPgmConfigGPSARPImages[currentNumb], secondScreenPgmConfigGPSARPTexts[currentNumb], secondScreenPgmConfigGPSARPImages[secondScreenPgmConfigGPSARPImages.Length - 1], secondScreenPgmConfigGPSARPTexts[secondScreenPgmConfigGPSARPImages.Length - 1]);
            currentNumb = secondScreenPgmConfigGPSARPImages.Length - 1;
        }
    }

    

    public void PgmConfigGPSARPUp()
    {
        switch (currentPgmConfigGPSARP)
        {
            case 0:
                if (currentPgmConfigGPSARPitem != firstScreenPgmConfigGPSARPItems.Length - 1)
                {
                    firstScreenPgmConfigGPSARPItems[currentPgmConfigGPSARPitem].SetActive(false);
                    firstScreenPgmConfigGPSARPItems[currentPgmConfigGPSARPitem + 1].SetActive(true);
                    currentPgmConfigGPSARPitem++;
                }
                else
                {
                    firstScreenPgmConfigGPSARPItems[currentPgmConfigGPSARPitem].SetActive(false);
                    firstScreenPgmConfigGPSARPItems[0].SetActive(true);
                    currentPgmConfigGPSARPitem = 0;
                }
                break;
            case 2:
                if (currentPgmConfigGPSARPitem != thirdScreenPgmConfigGPSARPItems.Length - 1)
                {
                    thirdScreenPgmConfigGPSARPItems[currentPgmConfigGPSARPitem].SetActive(false);
                    thirdScreenPgmConfigGPSARPItems[currentPgmConfigGPSARPitem + 1].SetActive(true);
                    currentPgmConfigGPSARPitem++;
                }
                else
                {
                    thirdScreenPgmConfigGPSARPItems[currentPgmConfigGPSARPitem].SetActive(false);
                    thirdScreenPgmConfigGPSARPItems[0].SetActive(true);
                    currentPgmConfigGPSARPitem = 0;
                }
                break;
            case 3:
                if (currentPgmConfigGPSARPitem != fourthScreenPgmConfigGPSARPItems.Length - 1)
                {
                    fourthScreenPgmConfigGPSARPItems[currentPgmConfigGPSARPitem].SetActive(false);
                    fourthScreenPgmConfigGPSARPItems[currentPgmConfigGPSARPitem + 1].SetActive(true);
                    currentPgmConfigGPSARPitem++;
                }
                else
                {
                    fourthScreenPgmConfigGPSARPItems[currentPgmConfigGPSARPitem].SetActive(false);
                    fourthScreenPgmConfigGPSARPItems[0].SetActive(true);
                    currentPgmConfigGPSARPitem = 0;
                }
                break;
            case 5:
                if (currentPgmConfigGPSARPitem != sixScreenPgmConfigGPSARPItems.Length - 1)
                {
                    sixScreenPgmConfigGPSARPItems[currentPgmConfigGPSARPitem].SetActive(false);
                    sixScreenPgmConfigGPSARPItems[currentPgmConfigGPSARPitem + 1].SetActive(true);
                    currentPgmConfigGPSARPitem++;
                }
                else
                {
                    sixScreenPgmConfigGPSARPItems[currentPgmConfigGPSARPitem].SetActive(false);
                    sixScreenPgmConfigGPSARPItems[0].SetActive(true);
                    currentPgmConfigGPSARPitem = 0;
                }
                break;
        }
    }

    public void PgmConfigGPSARPDown()
    {
        switch (currentPgmConfigGPSARP)
        {
            case 0:
                if (currentPgmConfigGPSARPitem != 0)
                {
                    firstScreenPgmConfigGPSARPItems[currentPgmConfigGPSARPitem].SetActive(false);
                    firstScreenPgmConfigGPSARPItems[currentPgmConfigGPSARPitem - 1].SetActive(true);
                    currentPgmConfigGPSARPitem--;
                }
                else
                {
                    firstScreenPgmConfigGPSARPItems[currentPgmConfigGPSARPitem].SetActive(false);
                    firstScreenPgmConfigGPSARPItems[firstScreenPgmConfigGPSARPItems.Length - 1].SetActive(true);
                    currentPgmConfigGPSARPitem = firstScreenPgmConfigGPSARPItems.Length - 1;
                }
                break;
            case 2:
                if (currentPgmConfigGPSARPitem != 0)
                {
                    thirdScreenPgmConfigGPSARPItems[currentPgmConfigGPSARPitem].SetActive(false);
                    thirdScreenPgmConfigGPSARPItems[currentPgmConfigGPSARPitem - 1].SetActive(true);
                    currentPgmConfigGPSARPitem--;
                }
                else
                {
                    thirdScreenPgmConfigGPSARPItems[currentPgmConfigGPSARPitem].SetActive(false);
                    thirdScreenPgmConfigGPSARPItems[thirdScreenPgmConfigGPSARPItems.Length - 1].SetActive(true);
                    currentPgmConfigGPSARPitem = thirdScreenPgmConfigGPSARPItems.Length - 1;
                }
                break;
            case 3:
                if (currentPgmConfigGPSARPitem != 0)
                {
                    fourthScreenPgmConfigGPSARPItems[currentPgmConfigGPSARPitem].SetActive(false);
                    fourthScreenPgmConfigGPSARPItems[currentPgmConfigGPSARPitem - 1].SetActive(true);
                    currentPgmConfigGPSARPitem--;
                }
                else
                {
                    fourthScreenPgmConfigGPSARPItems[currentPgmConfigGPSARPitem].SetActive(false);
                    fourthScreenPgmConfigGPSARPItems[fourthScreenPgmConfigGPSARPItems.Length - 1].SetActive(true);
                    currentPgmConfigGPSARPitem = fourthScreenPgmConfigGPSARPItems.Length - 1;
                }
                break;
            case 5:
                if (currentPgmConfigGPSARPitem != 0)
                {
                    sixScreenPgmConfigGPSARPItems[currentPgmConfigGPSARPitem].SetActive(false);
                    sixScreenPgmConfigGPSARPItems[currentPgmConfigGPSARPitem - 1].SetActive(true);
                    currentPgmConfigGPSitem--;
                }
                else
                {
                    sixScreenPgmConfigGPSARPItems[currentPgmConfigGPSARPitem].SetActive(false);
                    sixScreenPgmConfigGPSARPItems[sixScreenPgmConfigGPSARPItems.Length - 1].SetActive(true);
                    currentPgmConfigGPSARPitem = sixScreenPgmConfigGPSARPItems.Length - 1;
                }
                break;
        }
    }

    public void EnterPgmConfigGPS()
    {
        if (currentPgmConfigGPS != pgmConfigGPSMenu.Length - 1)
        {
            pgmConfigGPSMenu[currentPgmConfigGPS].SetActive(false);
            pgmConfigGPSMenu[currentPgmConfigGPS + 1].SetActive(true);
            currentPgmConfigGPS++;
            currentPgmConfigGPSitem = 0;
        }
        else
        {
            DisableLoadMenu();
            isPgmConfig = true;
            pgmConfigMenu[0].SetActive(true);
        }
    }

    public void PgmConfigGPSUp()
    {
        switch (currentPgmConfigGPS)
        {
            case 0:
                if (currentPgmConfigGPSitem != firstScreenPgmConfigGPSItems.Length - 1)
                {
                    firstScreenPgmConfigGPSItems[currentPgmConfigGPSitem].SetActive(false);
                    firstScreenPgmConfigGPSItems[currentPgmConfigGPSitem + 1].SetActive(true);
                    currentPgmConfigGPSitem++;
                }
                else
                {
                    firstScreenPgmConfigGPSItems[currentPgmConfigGPSitem].SetActive(false);
                    firstScreenPgmConfigGPSItems[0].SetActive(true);
                    currentPgmConfigGPSitem = 0;
                }
                break;
            case 1:
                if (currentPgmConfigGPSitem != secondScreenPgmConfigGPSItems.Length - 1)
                {
                    secondScreenPgmConfigGPSItems[currentPgmConfigGPSitem].SetActive(false);
                    secondScreenPgmConfigGPSItems[currentPgmConfigGPSitem + 1].SetActive(true);
                    secondScreenPgmConfigGPSTexts[currentPgmConfigGPSitem].SetActive(false);
                    secondScreenPgmConfigGPSTexts[currentPgmConfigGPSitem + 1].SetActive(true);
                    currentPgmConfigGPSitem++;
                }
                else
                {
                    secondScreenPgmConfigGPSItems[currentPgmConfigGPSitem].SetActive(false);
                    secondScreenPgmConfigGPSItems[0].SetActive(true);
                    secondScreenPgmConfigGPSTexts[currentPgmConfigGPSitem].SetActive(false);
                    secondScreenPgmConfigGPSTexts[0].SetActive(true);
                    currentPgmConfigGPSitem = 0;
                }
                break;
            case 2:
                if (currentPgmConfigGPSitem != thirdScreenPgmConfigGPSItems.Length - 1)
                {
                    thirdScreenPgmConfigGPSItems[currentPgmConfigGPSitem].SetActive(false);
                    thirdScreenPgmConfigGPSItems[currentPgmConfigGPSitem + 1].SetActive(true);
                    currentPgmConfigGPSitem++;
                }
                else
                {
                    thirdScreenPgmConfigGPSItems[currentPgmConfigGPSitem].SetActive(false);
                    thirdScreenPgmConfigGPSItems[0].SetActive(true);
                    currentPgmConfigGPSitem = 0;
                }
                break;
            case 3:
                if (currentPgmConfigGPSitem != fourthScreenPgmConfigGPSItems.Length - 1)
                {
                    fourthScreenPgmConfigGPSItems[currentPgmConfigGPSitem].SetActive(false);
                    fourthScreenPgmConfigGPSItems[currentPgmConfigGPSitem + 1].SetActive(true);
                    currentPgmConfigGPSitem++;
                }
                else
                {
                    fourthScreenPgmConfigGPSItems[currentPgmConfigGPSitem].SetActive(false);
                    fourthScreenPgmConfigGPSItems[0].SetActive(true);
                    currentPgmConfigGPSitem = 0;
                }
                break;
            case 4:
                if (currentPgmConfigGPSitem != fifthScreenPgmConfigGPSItems.Length - 1)
                {
                    fifthScreenPgmConfigGPSItems[currentPgmConfigGPSitem].SetActive(false);
                    fifthScreenPgmConfigGPSItems[currentPgmConfigGPSitem + 1].SetActive(true);
                    currentPgmConfigGPSitem++;
                }
                else
                {
                    fifthScreenPgmConfigGPSItems[currentPgmConfigGPSitem].SetActive(false);
                    fifthScreenPgmConfigGPSItems[0].SetActive(true);
                    currentPgmConfigGPSitem = 0;
                }
                break;
            case 5:
                if (currentPgmConfigGPSitem != sixScreenPgmConfigGPSItems.Length - 1)
                {
                    sixScreenPgmConfigGPSItems[currentPgmConfigGPSitem].SetActive(false);
                    sixScreenPgmConfigGPSItems[currentPgmConfigGPSitem + 1].SetActive(true);
                    currentPgmConfigGPSitem++;
                }
                else
                {
                    sixScreenPgmConfigGPSItems[currentPgmConfigGPSitem].SetActive(false);
                    sixScreenPgmConfigGPSItems[0].SetActive(true);
                    currentPgmConfigGPSitem = 0;
                }
                break;
        }
    }

    public void PgmConfigGPSDown()
    {
        switch (currentPgmConfigGPS)
        {
            case 0:
                if (currentPgmConfigGPSitem != 0)
                {
                    firstScreenPgmConfigGPSItems[currentPgmConfigGPSitem].SetActive(false);
                    firstScreenPgmConfigGPSItems[currentPgmConfigGPSitem - 1].SetActive(true);
                    currentPgmConfigGPSitem--;
                }
                else
                {
                    firstScreenPgmConfigGPSItems[currentPgmConfigGPSitem].SetActive(false);
                    firstScreenPgmConfigGPSItems[firstScreenPgmConfigGPSItems.Length - 1].SetActive(true);
                    currentPgmConfigGPSitem = firstScreenPgmConfigGPSItems.Length - 1;
                }
                break;
            case 1:
                if (currentPgmConfigGPSitem != 0)
                {
                    secondScreenPgmConfigGPSItems[currentPgmConfigGPSitem].SetActive(false);
                    secondScreenPgmConfigGPSItems[currentPgmConfigGPSitem - 1].SetActive(true);
                    secondScreenPgmConfigGPSTexts[currentPgmConfigGPSitem].SetActive(false);
                    secondScreenPgmConfigGPSTexts[currentPgmConfigGPSitem - 1].SetActive(true);
                    currentPgmConfigGPSitem--;
                }
                else
                {
                    secondScreenPgmConfigGPSItems[currentPgmConfigGPSitem].SetActive(false);
                    secondScreenPgmConfigGPSItems[secondScreenPgmConfigGPSItems.Length - 1].SetActive(true);
                    secondScreenPgmConfigGPSTexts[currentPgmConfigGPSitem].SetActive(false);
                    secondScreenPgmConfigGPSTexts[secondScreenPgmConfigGPSTexts.Length - 1].SetActive(true);
                    currentPgmConfigGPSitem = secondScreenPgmConfigGPSItems.Length - 1;
                }
                break;
            case 2:
                if (currentPgmConfigGPSitem != 0)
                {
                    thirdScreenPgmConfigGPSItems[currentPgmConfigGPSitem].SetActive(false);
                    thirdScreenPgmConfigGPSItems[currentPgmConfigGPSitem - 1].SetActive(true);
                    currentPgmConfigGPSitem--;
                }
                else
                {
                    thirdScreenPgmConfigGPSItems[currentPgmConfigGPSitem].SetActive(false);
                    thirdScreenPgmConfigGPSItems[thirdScreenPgmConfigGPSItems.Length - 1].SetActive(true);
                    currentPgmConfigGPSitem = thirdScreenPgmConfigGPSItems.Length - 1;
                }
                break;
            case 3:
                if (currentPgmConfigGPSitem != 0)
                {
                    fourthScreenPgmConfigGPSItems[currentPgmConfigGPSitem].SetActive(false);
                    fourthScreenPgmConfigGPSItems[currentPgmConfigGPSitem - 1].SetActive(true);
                    currentPgmConfigGPSitem--;
                }
                else
                {
                    fourthScreenPgmConfigGPSItems[currentPgmConfigGPSitem].SetActive(false);
                    fourthScreenPgmConfigGPSItems[fourthScreenPgmConfigGPSItems.Length - 1].SetActive(true);
                    currentPgmConfigGPSitem = fourthScreenPgmConfigGPSItems.Length - 1;
                }
                break;
            case 4:
                if (currentPgmConfigGPSitem != 0)
                {
                    fifthScreenPgmConfigGPSItems[currentPgmConfigGPSitem].SetActive(false);
                    fifthScreenPgmConfigGPSItems[currentPgmConfigGPSitem - 1].SetActive(true);
                    currentPgmConfigGPSitem--;
                }
                else
                {
                    fifthScreenPgmConfigGPSItems[currentPgmConfigGPSitem].SetActive(false);
                    fifthScreenPgmConfigGPSItems[fifthScreenPgmConfigGPSItems.Length - 1].SetActive(true);
                    currentPgmConfigGPSitem = fifthScreenPgmConfigGPSItems.Length - 1;
                }
                break;
            case 5:
                if (currentPgmConfigGPSitem != 0)
                {
                    sixScreenPgmConfigGPSItems[currentPgmConfigGPSitem].SetActive(false);
                    sixScreenPgmConfigGPSItems[currentPgmConfigGPSitem - 1].SetActive(true);
                    currentPgmConfigGPSitem--;
                }
                else
                {
                    sixScreenPgmConfigGPSItems[currentPgmConfigGPSitem].SetActive(false);
                    sixScreenPgmConfigGPSItems[sixScreenPgmConfigGPSItems.Length - 1].SetActive(true);
                    currentPgmConfigGPSitem = sixScreenPgmConfigGPSItems.Length - 1;
                }
                break;
        }
    }

    public void EnterPgmConfigLPC()
    {
        if (currentPgmConfigLPC != pgmConfigLpcMenu.Length - 1)
        {
            pgmConfigLpcMenu[currentPgmConfigLPC].SetActive(false);
            pgmConfigLpcMenu[currentPgmConfigLPC + 1].SetActive(true);
            
            switch(currentPgmConfigLPC)
            {
                case 0:
                    pgmConfigLPCNoiseCancellation = firstScreenPgmConfigLpcItems[currentPgmConfigLPCitem].GetComponentInChildren<TextMeshProUGUI>().text;
                    break;
            }

            currentPgmConfigLPC++;
            currentPgmConfigLPCitem = 0;
        }
        else
        {
            DisableLoadMenu();
            isPgmConfig = true;
            pgmConfigMenu[0].SetActive(true);
        }
    }

    public void PgmConfigLPCUp()
    {
        switch (currentPgmConfigLPC)
        {
            case 0:
                if (currentPgmConfigLPCitem != firstScreenPgmConfigLpcItems.Length - 1)
                {
                    firstScreenPgmConfigLpcItems[currentPgmConfigLPCitem].SetActive(false);
                    firstScreenPgmConfigLpcItems[currentPgmConfigLPCitem + 1].SetActive(true);
                    currentPgmConfigLPCitem++;
                }
                else
                {
                    firstScreenPgmConfigLpcItems[currentPgmConfigLPCitem].SetActive(false);
                    firstScreenPgmConfigLpcItems[0].SetActive(true);
                    currentPgmConfigLPCitem = 0;
                }
                break;
        }
    }

    public void PgmConfigLPCDown()
    {
        switch (currentPgmConfigLPC)
        {
            case 0:
                if (currentPgmConfigLPCitem != 0)
                {
                    firstScreenPgmConfigLpcItems[currentPgmConfigLPCitem].SetActive(false);
                    firstScreenPgmConfigLpcItems[currentPgmConfigLPCitem - 1].SetActive(true);
                    currentPgmConfigAudioitem--;
                }
                else
                {
                    firstScreenPgmConfigLpcItems[currentPgmConfigLPCitem].SetActive(false);
                    firstScreenPgmConfigLpcItems[firstScreenPgmConfigLpcItems.Length - 1].SetActive(true);
                    currentPgmConfigLPCitem = firstScreenPgmConfigLpcItems.Length - 1;
                }
                break;           
        }
    }

    public void EnterPgmConfigMessage()
    {
        if (currentPgmConfigMessage != pgmConfigMessageMenu.Length - 1)
        {
            pgmConfigMessageMenu[currentPgmConfigMessage].SetActive(false);
            pgmConfigMessageMenu[currentPgmConfigMessage + 1].SetActive(true);
            currentPgmConfigMessage++;
            currentPgmConfigMessageitem = 0;
        }
        else
        {
            DisableLoadMenu();
            isPgmConfig = true;
            pgmConfigMenu[0].SetActive(true);
        }
    }

    public void PgmConfigMessageUp()
    {
        switch (currentPgmConfigMessage)
        {
            case 0:
                if (currentPgmConfigMessageitem != firstScreenPgmConfigMessageItems.Length - 1)
                {
                    firstScreenPgmConfigMessageItems[currentPgmConfigMessageitem].SetActive(false);
                    firstScreenPgmConfigMessageItems[currentPgmConfigMessageitem + 1].SetActive(true);
                    currentPgmConfigAudioitem++;
                }
                else
                {
                    firstScreenPgmConfigMessageItems[currentPgmConfigMessageitem].SetActive(false);
                    firstScreenPgmConfigMessageItems[0].SetActive(true);
                    currentPgmConfigMessageitem = 0;
                }
                break;
            case 1:
                if (currentPgmConfigMessageitem != secondScreenPgmConfigMessageItems.Length - 1)
                {
                    secondScreenPgmConfigMessageItems[currentPgmConfigMessageitem].SetActive(false);
                    secondScreenPgmConfigMessageItems[currentPgmConfigMessageitem + 1].SetActive(true);
                    currentPgmConfigMessageitem++;
                }
                else
                {
                    secondScreenPgmConfigMessageItems[currentPgmConfigMessageitem].SetActive(false);
                    secondScreenPgmConfigMessageItems[0].SetActive(true);
                    currentPgmConfigMessageitem = 0;
                }
                break;
            case 2:
                if (currentPgmConfigMessageitem != thirdScreenPgmConfigMessageItems.Length - 1)
                {
                    thirdScreenPgmConfigMessageItems[currentPgmConfigMessageitem].SetActive(false);
                    thirdScreenPgmConfigMessageItems[currentPgmConfigMessageitem + 1].SetActive(true);
                    currentPgmConfigMessageitem++;
                }
                else
                {
                    thirdScreenPgmConfigMessageItems[currentPgmConfigMessageitem].SetActive(false);
                    thirdScreenPgmConfigMessageItems[0].SetActive(true);
                    currentPgmConfigMessageitem = 0;
                }
                break;
            case 3:
                if (currentPgmConfigMessageitem != fourthScreenPgmConfigMessageItems.Length - 1)
                {
                    fourthScreenPgmConfigMessageItems[currentPgmConfigMessageitem].SetActive(false);
                    fourthScreenPgmConfigMessageItems[currentPgmConfigMessageitem + 1].SetActive(true);
                    currentPgmConfigMessageitem++;
                }
                else
                {
                    fourthScreenPgmConfigMessageItems[currentPgmConfigMessageitem].SetActive(false);
                    fourthScreenPgmConfigMessageItems[0].SetActive(true);
                    currentPgmConfigMessageitem = 0;
                }
                break;
            case 4:
                if (currentPgmConfigMessageitem != fifthScreenPgmConfigMessageItems.Length - 1)
                {
                    fifthScreenPgmConfigMessageItems[currentPgmConfigMessageitem].SetActive(false);
                    fifthScreenPgmConfigMessageItems[currentPgmConfigMessageitem + 1].SetActive(true);
                    currentPgmConfigMessageitem++;
                }
                else
                {
                    fifthScreenPgmConfigMessageItems[currentPgmConfigMessageitem].SetActive(false);
                    fifthScreenPgmConfigMessageItems[0].SetActive(true);
                    currentPgmConfigMessageitem = 0;
                }
                break;
        }
    }

    public void PgmConfigMessageDown()
    {
        switch (currentPgmConfigMessage)
        {
            case 0:
                if (currentPgmConfigMessageitem != 0)
                {
                    firstScreenPgmConfigMessageItems[currentPgmConfigMessageitem].SetActive(false);
                    firstScreenPgmConfigMessageItems[currentPgmConfigMessageitem - 1].SetActive(true);
                    currentPgmConfigAudioitem--;
                }
                else
                {
                    firstScreenPgmConfigMessageItems[currentPgmConfigMessageitem].SetActive(false);
                    firstScreenPgmConfigMessageItems[firstScreenPgmConfigMessageItems.Length - 1].SetActive(true);
                    currentPgmConfigMessageitem = firstScreenPgmConfigMessageItems.Length - 1;
                }
                break;
            case 1:
                if (currentPgmConfigMessageitem != 0)
                {
                    secondScreenPgmConfigMessageItems[currentPgmConfigMessageitem].SetActive(false);
                    secondScreenPgmConfigMessageItems[currentPgmConfigMessageitem - 1].SetActive(true);
                    currentPgmConfigAudioitem--;
                }
                else
                {
                    secondScreenPgmConfigMessageItems[currentPgmConfigMessageitem].SetActive(false);
                    secondScreenPgmConfigMessageItems[secondScreenPgmConfigMessageItems.Length - 1].SetActive(true);
                    currentPgmConfigMessageitem = secondScreenPgmConfigMessageItems.Length - 1;
                }
                break;
            case 2:
                if (currentPgmConfigMessageitem != 0)
                {
                    thirdScreenPgmConfigMessageItems[currentPgmConfigMessageitem].SetActive(false);
                    thirdScreenPgmConfigMessageItems[currentPgmConfigMessageitem - 1].SetActive(true);
                    currentPgmConfigAudioitem--;
                }
                else
                {
                    thirdScreenPgmConfigMessageItems[currentPgmConfigMessageitem].SetActive(false);
                    thirdScreenPgmConfigMessageItems[thirdScreenPgmConfigMessageItems.Length - 1].SetActive(true);
                    currentPgmConfigMessageitem = thirdScreenPgmConfigMessageItems.Length - 1;
                }
                break;
            case 3:
                if (currentPgmConfigMessageitem != 0)
                {
                    fourthScreenPgmConfigMessageItems[currentPgmConfigMessageitem].SetActive(false);
                    fourthScreenPgmConfigMessageItems[currentPgmConfigMessageitem - 1].SetActive(true);
                    currentPgmConfigAudioitem--;
                }
                else
                {
                    fourthScreenPgmConfigMessageItems[currentPgmConfigMessageitem].SetActive(false);
                    fourthScreenPgmConfigMessageItems[fourthScreenPgmConfigMessageItems.Length - 1].SetActive(true);
                    currentPgmConfigMessageitem = fourthScreenPgmConfigMessageItems.Length - 1;
                }
                break;
            case 4:
                if (currentPgmConfigMessageitem != 0)
                {
                    fifthScreenPgmConfigMessageItems[currentPgmConfigMessageitem].SetActive(false);
                    fifthScreenPgmConfigMessageItems[currentPgmConfigMessageitem - 1].SetActive(true);
                    currentPgmConfigAudioitem--;
                }
                else
                {
                    fifthScreenPgmConfigMessageItems[currentPgmConfigMessageitem].SetActive(false);
                    fifthScreenPgmConfigMessageItems[fifthScreenPgmConfigMessageItems.Length - 1].SetActive(true);
                    currentPgmConfigMessageitem = fifthScreenPgmConfigMessageItems.Length - 1;
                }
                break;
        }
    }

    public void EnterPgmConfigPortData()
    {
        if (currentPgmConfigPortData != pgmConfigPortsDataMenu.Length - 1)
        {
            pgmConfigPortsDataMenu[currentPgmConfigPortData].SetActive(false);
            pgmConfigPortsDataMenu[currentPgmConfigPortData + 1].SetActive(true);
            currentPgmConfigPortData++;
            currentPgmConfigPortDataScreenItem = 0;
        }
        else
        {
            DisableLoadMenu();
            isPgmConfig = true;
            pgmConfigMenu[0].SetActive(true);
        }
    }

    public void PgmConfigPortDataUp()
    {
        switch (currentPgmConfigPortData)
        {
            case 0:
                if (currentPgmConfigPortDataScreenItem != firstScreenPgmConfigPortsDataItems.Length - 1)
                {
                    firstScreenPgmConfigPortsDataItems[currentPgmConfigPortDataScreenItem].SetActive(false);
                    firstScreenPgmConfigPortsDataItems[currentPgmConfigPortDataScreenItem + 1].SetActive(true);
                    currentPgmConfigPortDataScreenItem++;
                }
                else
                {
                    firstScreenPgmConfigPortsDataItems[currentPgmConfigPortDataScreenItem].SetActive(false);
                    firstScreenPgmConfigPortsDataItems[0].SetActive(true);
                    currentPgmConfigPortDataScreenItem = 0;
                }
                break;
            case 1:
                if (currentPgmConfigPortDataScreenItem != secondScreenPgmConfigPortsDataItems.Length - 1)
                {
                    secondScreenPgmConfigPortsDataItems[currentPgmConfigPortDataScreenItem].SetActive(false);
                    secondScreenPgmConfigPortsDataItems[currentPgmConfigPortDataScreenItem + 1].SetActive(true);
                    currentPgmConfigPortDataScreenItem++;
                }
                else
                {
                    secondScreenPgmConfigPortsDataItems[currentPgmConfigPortDataScreenItem].SetActive(false);
                    secondScreenPgmConfigPortsDataItems[0].SetActive(true);
                    currentPgmConfigPortDataScreenItem = 0;
                }
                break;
            case 2:
                if (currentPgmConfigPortDataScreenItem != thirdScreenPgmConfigPortsDataItems.Length - 1)
                {
                    thirdScreenPgmConfigPortsDataItems[currentPgmConfigPortDataScreenItem].SetActive(false);
                    thirdScreenPgmConfigPortsDataItems[currentPgmConfigPortDataScreenItem + 1].SetActive(true);
                    currentPgmConfigPortDataScreenItem++;
                }
                else
                {
                    thirdScreenPgmConfigPortsDataItems[currentPgmConfigPortDataScreenItem].SetActive(false);
                    thirdScreenPgmConfigPortsDataItems[0].SetActive(true);
                    currentPgmConfigPortDataScreenItem = 0;
                }
                break;
            case 3:
                if (currentPgmConfigPortDataScreenItem != fourthScreenPgmConfigPortsDataItems.Length - 1)
                {
                    fourthScreenPgmConfigPortsDataItems[currentPgmConfigPortDataScreenItem].SetActive(false);
                    fourthScreenPgmConfigPortsDataItems[currentPgmConfigPortDataScreenItem + 1].SetActive(true);
                    currentPgmConfigPortDataScreenItem++;
                }
                else
                {
                    fourthScreenPgmConfigPortsDataItems[currentPgmConfigPortDataScreenItem].SetActive(false);
                    fourthScreenPgmConfigPortsDataItems[0].SetActive(true);
                    currentPgmConfigPortDataScreenItem = 0;
                }
                break;
            case 4:
                if (currentPgmConfigPortDataScreenItem != fifthScreenPgmConfigPortsDataItems.Length - 1)
                {
                    fifthScreenPgmConfigPortsDataItems[currentPgmConfigPortDataScreenItem].SetActive(false);
                    fifthScreenPgmConfigPortsDataItems[currentPgmConfigPortDataScreenItem + 1].SetActive(true);
                    currentPgmConfigPortDataScreenItem++;
                }
                else
                {
                    fifthScreenPgmConfigPortsDataItems[currentPgmConfigPortDataScreenItem].SetActive(false);
                    fifthScreenPgmConfigPortsDataItems[0].SetActive(true);
                    currentPgmConfigPortDataScreenItem = 0;
                }
                break;
            case 5:
                if (currentPgmConfigPortDataScreenItem != sixthScreenPgmConfigPortsDataItems.Length - 1)
                {
                    sixthScreenPgmConfigPortsDataItems[currentPgmConfigPortDataScreenItem].SetActive(false);
                    sixthScreenPgmConfigPortsDataItems[currentPgmConfigPortDataScreenItem + 1].SetActive(true);
                    currentPgmConfigPortDataScreenItem++;
                }
                else
                {
                    sixthScreenPgmConfigPortsDataItems[currentPgmConfigPortDataScreenItem].SetActive(false);
                    sixthScreenPgmConfigPortsDataItems[0].SetActive(true);
                    currentPgmConfigPortDataScreenItem = 0;
                }
                break;
            case 6:
                if (currentPgmConfigPortDataScreenItem != seventhScreenPgmConfigPortsDataItems.Length - 1)
                {
                    seventhScreenPgmConfigPortsDataItems[currentPgmConfigPortDataScreenItem].SetActive(false);
                    seventhScreenPgmConfigPortsDataItems[currentPgmConfigPortDataScreenItem + 1].SetActive(true);
                    currentPgmConfigPortDataScreenItem++;
                }
                else
                {
                    seventhScreenPgmConfigPortsDataItems[currentPgmConfigPortDataScreenItem].SetActive(false);
                    seventhScreenPgmConfigPortsDataItems[0].SetActive(true);
                    currentPgmConfigPortDataScreenItem = 0;
                }
                break;
            case 7:
                if (currentPgmConfigPortDataScreenItem != eighthScreenPgmConfigPortsDataItems.Length - 1)
                {
                    eighthScreenPgmConfigPortsDataItems[currentPgmConfigPortDataScreenItem].SetActive(false);
                    eighthScreenPgmConfigPortsDataItems[currentPgmConfigPortDataScreenItem + 1].SetActive(true);
                    currentPgmConfigPortDataScreenItem++;
                }
                else
                {
                    eighthScreenPgmConfigPortsDataItems[currentPgmConfigPortDataScreenItem].SetActive(false);
                    eighthScreenPgmConfigPortsDataItems[0].SetActive(true);
                    currentPgmConfigPortDataScreenItem = 0;
                }
                break;
            case 8:
                if (currentPgmConfigPortDataScreenItem != ninethScreenPgmConfigPortsDataItems.Length - 1)
                {
                    ninethScreenPgmConfigPortsDataItems[currentPgmConfigPortDataScreenItem].SetActive(false);
                    ninethScreenPgmConfigPortsDataItems[currentPgmConfigPortDataScreenItem + 1].SetActive(true);
                    currentPgmConfigPortDataScreenItem++;
                }
                else
                {
                    ninethScreenPgmConfigPortsDataItems[currentPgmConfigPortDataScreenItem].SetActive(false);
                    ninethScreenPgmConfigPortsDataItems[0].SetActive(true);
                    currentPgmConfigPortDataScreenItem = 0;
                }
                break;
            case 9:
                if (currentPgmConfigPortDataScreenItem != tenthScreenPgmConfigPortsDataItems.Length - 1)
                {
                    tenthScreenPgmConfigPortsDataItems[currentPgmConfigPortDataScreenItem].SetActive(false);
                    tenthScreenPgmConfigPortsDataItems[currentPgmConfigPortDataScreenItem + 1].SetActive(true);
                    currentPgmConfigPortDataScreenItem++;
                }
                else
                {
                    tenthScreenPgmConfigPortsDataItems[currentPgmConfigPortDataScreenItem].SetActive(false);
                    tenthScreenPgmConfigPortsDataItems[0].SetActive(true);
                    currentPgmConfigPortDataScreenItem = 0;
                }
                break;
            case 10:
                if (currentPgmConfigPortDataScreenItem != eleventhScreenPgmConfigPortsDataItems.Length - 1)
                {
                    eleventhScreenPgmConfigPortsDataItems[currentPgmConfigPortDataScreenItem].SetActive(false);
                    eleventhScreenPgmConfigPortsDataItems[currentPgmConfigPortDataScreenItem + 1].SetActive(true);
                    currentPgmConfigPortDataScreenItem++;
                }
                else
                {
                    eleventhScreenPgmConfigPortsDataItems[currentPgmConfigPortDataScreenItem].SetActive(false);
                    eleventhScreenPgmConfigPortsDataItems[0].SetActive(true);
                    currentPgmConfigPortDataScreenItem = 0;
                }
                break;
        }
    }

    public void PgmConfigPortDataDown()
    {
        switch (currentPgmConfigPortData)
        {
            case 0:
                if (currentPgmConfigPortDataScreenItem != 0)
                {
                    firstScreenPgmConfigPortsDataItems[currentPgmConfigPortDataScreenItem].SetActive(false);
                    firstScreenPgmConfigPortsDataItems[currentPgmConfigPortDataScreenItem - 1].SetActive(true);
                    currentPgmConfigPortDataScreenItem--;
                }
                else
                {
                    firstScreenPgmConfigPortsDataItems[currentPgmConfigPortDataScreenItem].SetActive(false);
                    firstScreenPgmConfigPortsDataItems[firstScreenPgmConfigPortsDataItems.Length - 1].SetActive(true);
                    currentPgmConfigPortDataScreenItem = firstScreenPgmConfigPortsDataItems.Length - 1;
                }
                break;
            case 1:
                if (currentPgmConfigPortDataScreenItem != 0)
                {
                    secondScreenPgmConfigPortsDataItems[currentPgmConfigPortDataScreenItem].SetActive(false);
                    secondScreenPgmConfigPortsDataItems[currentPgmConfigPortDataScreenItem - 1].SetActive(true);
                    currentPgmConfigPortDataScreenItem--;
                }
                else
                {
                    secondScreenPgmConfigPortsDataItems[currentPgmConfigPortDataScreenItem].SetActive(false);
                    secondScreenPgmConfigPortsDataItems[secondScreenPgmConfigPortsDataItems.Length - 1].SetActive(true);
                    currentPgmConfigPortDataScreenItem = secondScreenPgmConfigPortsDataItems.Length - 1;
                }
                break;
            case 2:
                if (currentPgmConfigPortDataScreenItem != 0)
                {
                    thirdScreenPgmConfigPortsDataItems[currentPgmConfigPortDataScreenItem].SetActive(false);
                    thirdScreenPgmConfigPortsDataItems[currentPgmConfigPortDataScreenItem - 1].SetActive(true);
                    currentPgmConfigPortDataScreenItem--;
                }
                else
                {
                    thirdScreenPgmConfigPortsDataItems[currentPgmConfigPortDataScreenItem].SetActive(false);
                    thirdScreenPgmConfigPortsDataItems[thirdScreenPgmConfigPortsDataItems.Length - 1].SetActive(true);
                    currentPgmConfigPortDataScreenItem = thirdScreenPgmConfigPortsDataItems.Length - 1;
                }
                break;
            case 3:
                if (currentPgmConfigPortDataScreenItem != 0)
                {
                    fourthScreenPgmConfigPortsDataItems[currentPgmConfigPortDataScreenItem].SetActive(false);
                    fourthScreenPgmConfigPortsDataItems[currentPgmConfigPortDataScreenItem - 1].SetActive(true);
                    currentPgmConfigPortDataScreenItem--;
                }
                else
                {
                    fourthScreenPgmConfigPortsDataItems[currentPgmConfigPortDataScreenItem].SetActive(false);
                    fourthScreenPgmConfigPortsDataItems[fourthScreenPgmConfigPortsDataItems.Length - 1].SetActive(true);
                    currentPgmConfigPortDataScreenItem = fourthScreenPgmConfigPortsDataItems.Length - 1;
                }
                break;
            case 4:
                if (currentPgmConfigPortDataScreenItem != 0)
                {
                    fifthScreenPgmConfigPortsDataItems[currentPgmConfigPortDataScreenItem].SetActive(false);
                    fifthScreenPgmConfigPortsDataItems[currentPgmConfigPortDataScreenItem - 1].SetActive(true);
                    currentPgmConfigPortDataScreenItem--;
                }
                else
                {
                    fifthScreenPgmConfigPortsDataItems[currentPgmConfigPortDataScreenItem].SetActive(false);
                    fifthScreenPgmConfigPortsDataItems[fifthScreenPgmConfigPortsDataItems.Length - 1].SetActive(true);
                    currentPgmConfigPortDataScreenItem = fifthScreenPgmConfigPortsDataItems.Length - 1;
                }
                break;
            case 5:
                if (currentPgmConfigPortDataScreenItem != 0)
                {
                    sixthScreenPgmConfigPortsDataItems[currentPgmConfigPortDataScreenItem].SetActive(false);
                    sixthScreenPgmConfigPortsDataItems[currentPgmConfigPortDataScreenItem - 1].SetActive(true);
                    currentPgmConfigPortDataScreenItem--;
                }
                else
                {
                    sixthScreenPgmConfigPortsDataItems[currentPgmConfigPortDataScreenItem].SetActive(false);
                    sixthScreenPgmConfigPortsDataItems[sixthScreenPgmConfigPortsDataItems.Length - 1].SetActive(true);
                    currentPgmConfigPortDataScreenItem = sixthScreenPgmConfigPortsDataItems.Length - 1;
                }
                break;
            case 6:
                if (currentPgmConfigPortDataScreenItem != 0)
                {
                    seventhScreenPgmConfigPortsDataItems[currentPgmConfigPortDataScreenItem].SetActive(false);
                    seventhScreenPgmConfigPortsDataItems[currentPgmConfigPortDataScreenItem - 1].SetActive(true);
                    currentPgmConfigPortDataScreenItem--;
                }
                else
                {
                    seventhScreenPgmConfigPortsDataItems[currentPgmConfigPortDataScreenItem].SetActive(false);
                    seventhScreenPgmConfigPortsDataItems[seventhScreenPgmConfigPortsDataItems.Length - 1].SetActive(true);
                    currentPgmConfigPortDataScreenItem = seventhScreenPgmConfigPortsDataItems.Length - 1;
                }
                break;
            case 7:
                if (currentPgmConfigPortDataScreenItem != 0)
                {
                    eighthScreenPgmConfigPortsDataItems[currentPgmConfigPortDataScreenItem].SetActive(false);
                    eighthScreenPgmConfigPortsDataItems[currentPgmConfigPortDataScreenItem - 1].SetActive(true);
                    currentPgmConfigPortDataScreenItem--;
                }
                else
                {
                    eighthScreenPgmConfigPortsDataItems[currentPgmConfigPortDataScreenItem].SetActive(false);
                    eighthScreenPgmConfigPortsDataItems[eighthScreenPgmConfigPortsDataItems.Length - 1].SetActive(true);
                    currentPgmConfigPortDataScreenItem = eighthScreenPgmConfigPortsDataItems.Length - 1;
                }
                break;
            case 8:
                if (currentPgmConfigPortDataScreenItem != 0)
                {
                    ninethScreenPgmConfigPortsDataItems[currentPgmConfigPortDataScreenItem].SetActive(false);
                    ninethScreenPgmConfigPortsDataItems[currentPgmConfigPortDataScreenItem - 1].SetActive(true);
                    currentPgmConfigPortDataScreenItem--;
                }
                else
                {
                    ninethScreenPgmConfigPortsDataItems[currentPgmConfigPortDataScreenItem].SetActive(false);
                    ninethScreenPgmConfigPortsDataItems[ninethScreenPgmConfigPortsDataItems.Length - 1].SetActive(true);
                    currentPgmConfigPortDataScreenItem = ninethScreenPgmConfigPortsDataItems.Length - 1;
                }
                break;
            case 9:
                if (currentPgmConfigPortDataScreenItem != 0)
                {
                    tenthScreenPgmConfigPortsDataItems[currentPgmConfigPortDataScreenItem].SetActive(false);
                    tenthScreenPgmConfigPortsDataItems[currentPgmConfigPortDataScreenItem - 1].SetActive(true);
                    currentPgmConfigPortDataScreenItem--;
                }
                else
                {
                    tenthScreenPgmConfigPortsDataItems[currentPgmConfigPortDataScreenItem].SetActive(false);
                    tenthScreenPgmConfigPortsDataItems[tenthScreenPgmConfigPortsDataItems.Length - 1].SetActive(true);
                    currentPgmConfigPortDataScreenItem = tenthScreenPgmConfigPortsDataItems.Length - 1;
                }
                break;
            case 10:
                if (currentPgmConfigPortDataScreenItem != 0)
                {
                    eleventhScreenPgmConfigPortsDataItems[currentPgmConfigPortDataScreenItem].SetActive(false);
                    eleventhScreenPgmConfigPortsDataItems[currentPgmConfigPortDataScreenItem - 1].SetActive(true);
                    currentPgmConfigPortDataScreenItem--;
                }
                else
                {
                    eleventhScreenPgmConfigPortsDataItems[currentPgmConfigPortDataScreenItem].SetActive(false);
                    eleventhScreenPgmConfigPortsDataItems[eleventhScreenPgmConfigPortsDataItems.Length - 1].SetActive(true);
                    currentPgmConfigPortDataScreenItem = eleventhScreenPgmConfigPortsDataItems.Length - 1;
                }
                break;
        }
    }

    public void EnterPgmConfigPortAscii()
    {
        if (currentPgmConfigPortAscii != pgmConfigPortsAsciiMenu.Length - 1)
        {
            pgmConfigPortsAsciiMenu[currentPgmConfigPortAscii].SetActive(false);
            pgmConfigPortsAsciiMenu[currentPgmConfigPortAscii + 1].SetActive(true);
            currentPgmConfigPortAscii++;
            currentPgmConfigPortAsciiScreenItem = 0;
        }
        else
        {
            DisableLoadMenu();
            isPgmConfig = true;
            pgmConfigMenu[0].SetActive(true);
        }
    }

    public void PgmConfigPortAsciiUp()
    {
        switch (currentPgmConfigPortAscii)
        {
            case 0:
                if (currentPgmConfigPortAsciiScreenItem != firstScreenPgmConfigPortsAsciiItems.Length - 1)
                {
                    firstScreenPgmConfigPortsAsciiItems[currentPgmConfigPortAsciiScreenItem].SetActive(false);
                    firstScreenPgmConfigPortsAsciiItems[currentPgmConfigPortAsciiScreenItem + 1].SetActive(true);
                    currentPgmConfigPortAsciiScreenItem++;
                }
                else
                {
                    firstScreenPgmConfigPortsAsciiItems[currentPgmConfigPortAsciiScreenItem].SetActive(false);
                    firstScreenPgmConfigPortsAsciiItems[0].SetActive(true);
                    currentPgmConfigPortAsciiScreenItem = 0;
                }
                break;
            case 1:
                if (currentPgmConfigPortAsciiScreenItem != secondScreenPgmConfigPortsAsciiItems.Length - 1)
                {
                    secondScreenPgmConfigPortsAsciiItems[currentPgmConfigPortAsciiScreenItem].SetActive(false);
                    secondScreenPgmConfigPortsAsciiItems[currentPgmConfigPortAsciiScreenItem + 1].SetActive(true);
                    currentPgmConfigPortAsciiScreenItem++;
                }
                else
                {
                    secondScreenPgmConfigPortsAsciiItems[currentPgmConfigPortAsciiScreenItem].SetActive(false);
                    secondScreenPgmConfigPortsAsciiItems[0].SetActive(true);
                    currentPgmConfigPortAsciiScreenItem = 0;
                }
                break;
            case 2:
                if (currentPgmConfigPortAsciiScreenItem != thirdScreenPgmConfigPortsAsciiItems.Length - 1)
                {
                    thirdScreenPgmConfigPortsAsciiItems[currentPgmConfigPortAsciiScreenItem].SetActive(false);
                    thirdScreenPgmConfigPortsAsciiItems[currentPgmConfigPortAsciiScreenItem + 1].SetActive(true);
                    currentPgmConfigPortAsciiScreenItem++;
                }
                else
                {
                    thirdScreenPgmConfigPortsAsciiItems[currentPgmConfigPortAsciiScreenItem].SetActive(false);
                    thirdScreenPgmConfigPortsAsciiItems[0].SetActive(true);
                    currentPgmConfigPortAsciiScreenItem = 0;
                }
                break;
            case 3:
                if (currentPgmConfigPortAsciiScreenItem != fourthScreenPgmConfigPortsAsciiItems.Length - 1)
                {
                    fourthScreenPgmConfigPortsAsciiItems[currentPgmConfigPortAsciiScreenItem].SetActive(false);
                    fourthScreenPgmConfigPortsAsciiItems[currentPgmConfigPortAsciiScreenItem + 1].SetActive(true);
                    currentPgmConfigPortAsciiScreenItem++;
                }
                else
                {
                    fourthScreenPgmConfigPortsAsciiItems[currentPgmConfigPortAsciiScreenItem].SetActive(false);
                    fourthScreenPgmConfigPortsAsciiItems[0].SetActive(true);
                    currentPgmConfigPortAsciiScreenItem = 0;
                }
                break;
            case 4:
                if (currentPgmConfigPortAsciiScreenItem != fifthScreenPgmConfigPortsAsciiItems.Length - 1)
                {
                    fifthScreenPgmConfigPortsAsciiItems[currentPgmConfigPortAsciiScreenItem].SetActive(false);
                    fifthScreenPgmConfigPortsAsciiItems[currentPgmConfigPortAsciiScreenItem + 1].SetActive(true);
                    currentPgmConfigPortAsciiScreenItem++;
                }
                else
                {
                    fifthScreenPgmConfigPortsAsciiItems[currentPgmConfigPortAsciiScreenItem].SetActive(false);
                    fifthScreenPgmConfigPortsAsciiItems[0].SetActive(true);
                    currentPgmConfigPortAsciiScreenItem = 0;
                }
                break;
            case 5:
                if (currentPgmConfigPortAsciiScreenItem != sixScreenPgmConfigPortsAsciiItems.Length - 1)
                {
                    sixScreenPgmConfigPortsAsciiItems[currentPgmConfigPortAsciiScreenItem].SetActive(false);
                    sixScreenPgmConfigPortsAsciiItems[currentPgmConfigPortAsciiScreenItem + 1].SetActive(true);
                    currentPgmConfigPortAsciiScreenItem++;
                }
                else
                {
                    sixScreenPgmConfigPortsAsciiItems[currentPgmConfigPortAsciiScreenItem].SetActive(false);
                    sixScreenPgmConfigPortsAsciiItems[0].SetActive(true);
                    currentPgmConfigPortAsciiScreenItem = 0;
                }
                break;
        }
    }

    public void PgmConfigPortAsciiDown()
    {
        switch (currentPgmConfigPortAscii)
        {
            case 0:
                if (currentPgmConfigPortAsciiScreenItem != 0)
                {
                    firstScreenPgmConfigPortsAsciiItems[currentPgmConfigPortAsciiScreenItem].SetActive(false);
                    firstScreenPgmConfigPortsAsciiItems[currentPgmConfigPortAsciiScreenItem - 1].SetActive(true);
                    currentPgmConfigPortAsciiScreenItem--;
                }
                else
                {
                    firstScreenPgmConfigPortsAsciiItems[currentPgmConfigPortAsciiScreenItem].SetActive(false);
                    firstScreenPgmConfigPortsAsciiItems[firstScreenPgmConfigPortsAsciiItems.Length - 1].SetActive(true);
                    currentPgmConfigPortAsciiScreenItem = firstScreenPgmConfigPortsAsciiItems.Length - 1;
                }
                break;
            case 1:
                if (currentPgmConfigPortAsciiScreenItem != 0)
                {
                    secondScreenPgmConfigPortsAsciiItems[currentPgmConfigPortAsciiScreenItem].SetActive(false);
                    secondScreenPgmConfigPortsAsciiItems[currentPgmConfigPortAsciiScreenItem - 1].SetActive(true);
                    currentPgmConfigPortAsciiScreenItem--;
                }
                else
                {
                    secondScreenPgmConfigPortsAsciiItems[currentPgmConfigPortAsciiScreenItem].SetActive(false);
                    secondScreenPgmConfigPortsAsciiItems[secondScreenPgmConfigPortsAsciiItems.Length - 1].SetActive(true);
                    currentPgmConfigPortAsciiScreenItem = secondScreenPgmConfigPortsAsciiItems.Length - 1;
                }
                break;
            case 2:
                if (currentPgmConfigPortAsciiScreenItem != 0)
                {
                    thirdScreenPgmConfigPortsAsciiItems[currentPgmConfigPortAsciiScreenItem].SetActive(false);
                    thirdScreenPgmConfigPortsAsciiItems[currentPgmConfigPortAsciiScreenItem - 1].SetActive(true);
                    currentPgmConfigPortAsciiScreenItem--;
                }
                else
                {
                    thirdScreenPgmConfigPortsAsciiItems[currentPgmConfigPortAsciiScreenItem].SetActive(false);
                    thirdScreenPgmConfigPortsAsciiItems[thirdScreenPgmConfigPortsAsciiItems.Length - 1].SetActive(true);
                    currentPgmConfigPortAsciiScreenItem = thirdScreenPgmConfigPortsAsciiItems.Length - 1;
                }
                break;
            case 3:
                if (currentPgmConfigPortAsciiScreenItem != 0)
                {
                    fourthScreenPgmConfigPortsAsciiItems[currentPgmConfigPortAsciiScreenItem].SetActive(false);
                    fourthScreenPgmConfigPortsAsciiItems[currentPgmConfigPortAsciiScreenItem - 1].SetActive(true);
                    currentPgmConfigPortAsciiScreenItem--;
                }
                else
                {
                    fourthScreenPgmConfigPortsAsciiItems[currentPgmConfigPortAsciiScreenItem].SetActive(false);
                    fourthScreenPgmConfigPortsAsciiItems[fourthScreenPgmConfigPortsAsciiItems.Length - 1].SetActive(true);
                    currentPgmConfigPortAsciiScreenItem = fourthScreenPgmConfigPortsAsciiItems.Length - 1;
                }
                break;
            case 4:
                if (currentPgmConfigPortAsciiScreenItem != 0)
                {
                    fifthScreenPgmConfigPortsAsciiItems[currentPgmConfigPortAsciiScreenItem].SetActive(false);
                    fifthScreenPgmConfigPortsAsciiItems[currentPgmConfigPortAsciiScreenItem - 1].SetActive(true);
                    currentPgmConfigPortAsciiScreenItem--;
                }
                else
                {
                    fifthScreenPgmConfigPortsAsciiItems[currentPgmConfigPortAsciiScreenItem].SetActive(false);
                    fifthScreenPgmConfigPortsAsciiItems[fifthScreenPgmConfigPortsAsciiItems.Length - 1].SetActive(true);
                    currentPgmConfigPortAsciiScreenItem = fifthScreenPgmConfigPortsAsciiItems.Length - 1;
                }
                break;
            case 5:
                if (currentPgmConfigPortAsciiScreenItem != 0)
                {
                    sixScreenPgmConfigPortsAsciiItems[currentPgmConfigPortAsciiScreenItem].SetActive(false);
                    sixScreenPgmConfigPortsAsciiItems[currentPgmConfigPortAsciiScreenItem - 1].SetActive(true);
                    currentPgmConfigPortAsciiScreenItem--;
                }
                else
                {
                    sixScreenPgmConfigPortsAsciiItems[currentPgmConfigPortAsciiScreenItem].SetActive(false);
                    sixScreenPgmConfigPortsAsciiItems[sixScreenPgmConfigPortsAsciiItems.Length - 1].SetActive(true);
                    currentPgmConfigPortAsciiScreenItem = sixScreenPgmConfigPortsAsciiItems.Length - 1;
                }
                break;            
        }
    }

    public void EnterPgmConfigAudio()
    {
        if (currentPgmConfigAudio != pgmConfigAudioMenu.Length - 1)
        {
            pgmConfigAudioMenu[currentPgmConfigAudio].SetActive(false);
            pgmConfigAudioMenu[currentPgmConfigAudio + 1].SetActive(true);
            currentPgmConfigAudio++;
            currentPgmConfigAudioitem = 0;
        }
        else
        {
            DisableLoadMenu();
            isPgmConfig = true;
            pgmConfigMenu[0].SetActive(true);
        }
    }

    public void PgmConfigAudioUp()
    {
        switch (currentPgmConfigAudio)
        {
            case 0:
                if (currentPgmConfigAudioitem != firstScreenPgmConfigAudioItems.Length - 1)
                {
                    firstScreenPgmConfigAudioItems[currentPgmConfigAudioitem].SetActive(false);
                    firstScreenPgmConfigAudioItems[currentPgmConfigAudioitem + 1].SetActive(true);
                    currentPgmConfigAudioitem++;
                }
                else
                {
                    firstScreenPgmConfigAudioItems[currentPgmConfigAudioitem].SetActive(false);
                    firstScreenPgmConfigAudioItems[0].SetActive(true);
                    currentPgmConfigAudioitem = 0;
                }
                break;
            case 1:
                if (currentPgmConfigAudioitem != secondScreenPgmConfigAudioItems.Length - 1)
                {
                    secondScreenPgmConfigAudioItems[currentPgmConfigAudioitem].SetActive(false);
                    secondScreenPgmConfigAudioItems[currentPgmConfigAudioitem + 1].SetActive(true);
                    currentPgmConfigAudioitem++;
                }
                else
                {
                    secondScreenPgmConfigAudioItems[currentPgmConfigAudioitem].SetActive(false);
                    secondScreenPgmConfigAudioItems[0].SetActive(true);
                    currentPgmConfigAudioitem = 0;
                }
                break;
        }
    }

    public void PgmConfigAudioDown()
    {
        switch (currentPgmConfigAudio)
        {
            case 0:
                if (currentPgmConfigAudioitem != 0)
                {
                    firstScreenPgmConfigAudioItems[currentPgmConfigAudioitem].SetActive(false);
                    firstScreenPgmConfigAudioItems[currentPgmConfigAudioitem - 1].SetActive(true);
                    currentPgmConfigAudioitem--;
                }
                else
                {
                    firstScreenPgmConfigAudioItems[currentPgmConfigAudioitem].SetActive(false);
                    firstScreenPgmConfigAudioItems[firstScreenPgmConfigAudioItems.Length - 1].SetActive(true);
                    currentPgmConfigAudioitem = firstScreenPgmConfigAudioItems.Length - 1;
                }
                break;
            case 1:
                if (currentPgmConfigAudioitem != 0)
                {
                    secondScreenPgmConfigAudioItems[currentPgmConfigAudioitem].SetActive(false);
                    secondScreenPgmConfigAudioItems[currentPgmConfigAudioitem - 1].SetActive(true);
                    currentPgmConfigAudioitem--;
                }
                else
                {
                    secondScreenPgmConfigAudioItems[currentPgmConfigAudioitem].SetActive(false);
                    secondScreenPgmConfigAudioItems[secondScreenPgmConfigAudioItems.Length - 1].SetActive(true);
                    currentPgmConfigAudioitem = secondScreenPgmConfigAudioItems.Length - 1;
                }
                break;
        }
    }

    public void EnterPgmConfigPortMenu()
    {
        switch(currentPgmConfigPort)
        {
            case 0:
                DisableLoadMenu();
                isPgmConfigPortsData = true;
                pgmConfigPortsDataMenu[0].SetActive(true);
                break;
            case 1:
                DisableLoadMenu();
                isPgmConfigPortsAscii = true;
                pgmConfigPortsAsciiMenu[0].SetActive(true);
                break;
        }
    }

    public void NextPgmConfigPortMenu()
    {
        if(currentPgmConfigPort != pgmConfigPortsMenuItems.Length - 1)
        {
            ChangeColor(pgmConfigPortsMenuImages[currentPgmConfigPort], pgmConfigPortsMenuItems[currentPgmConfigPort], pgmConfigPortsMenuImages[currentPgmConfigPort + 1], pgmConfigPortsMenuItems[currentPgmConfigPort + 1]);
            currentPgmConfigPort++;
        }
        else
        {
            ChangeColor(pgmConfigPortsMenuImages[currentPgmConfigPort], pgmConfigPortsMenuItems[currentPgmConfigPort], pgmConfigPortsMenuImages[0], pgmConfigPortsMenuItems[0]);
            currentPgmConfigPort = 0;
        }
    }

    public void PrevPgmConfigPortMenu()
    {
        if (currentPgmConfigPort != 0)
        {
            ChangeColor(pgmConfigPortsMenuImages[currentPgmConfigPort], pgmConfigPortsMenuItems[currentPgmConfigPort], pgmConfigPortsMenuImages[currentPgmConfigPort - 1], pgmConfigPortsMenuItems[currentPgmConfigPort - 1]);
            currentPgmConfigPort--;
        }
        else
        {
            ChangeColor(pgmConfigPortsMenuImages[currentPgmConfigPort], pgmConfigPortsMenuItems[currentPgmConfigPort], pgmConfigPortsMenuImages[pgmConfigPortsMenuImages.Length - 1], pgmConfigPortsMenuItems[pgmConfigPortsMenuImages.Length - 1]);
            currentPgmConfigPort = pgmConfigPortsMenuImages.Length - 1;
        }
    }

    public void EnterPgmConfigMenu()
    {
        switch (currentPgmConfigItem)
        {
            case 0:
                DisableLoadMenu();
                isPgmConfigRadio = true;
                pgmConfigRadioScreens[0].SetActive(true);
                break;
            case 1:
                DisableLoadMenu();
                isPgmConfigPorts = true;
                pgmConfigPortsMenu.SetActive(true);
                break;
            case 2:
                DisableLoadMenu();
                isPgmConfigAudio = true;
                pgmConfigAudioMenu[0].SetActive(true);
                break;
            case 3:
                DisableLoadMenu();
                isPgmConfigTod = true;
                break;
            case 4:
                DisableLoadMenu();
                isPgmConfigMessage = true;
                pgmConfigMessageMenu[0].SetActive(true);
                break;
            case 5:
                DisableLoadMenu();
                isPgmConfigLPC = true;
                pgmConfigLpcMenu[0].SetActive(true);
                break;
            case 6:
                DisableLoadMenu();
                isPgmConfigGPS = true;
                pgmConfigGPSMenu[0].SetActive(true);
                break;
            case 7:
                DisableLoadMenu();
                isPgmConfigGPSAPR = true;
                pgmConfigGPSARPMenu[0].SetActive(true);
                break;
            case 8:
                DisableLoadMenu();
                isPgmConfigAccessory = true;
                pgmConfigAccessoryMenu[0].SetActive(true);
                break;
            case 9:
                DisableLoadMenu();
                isPgmConfigNetwork = true;
                pgmConfigNetworkMenu.SetActive(true);
                break;
            case 10:
                DisableLoadMenu();
                isPgmConfigARQ = true;
                pgmConfigARQMenu[0].SetActive(true);
                break;
            case 11:
                DisableLoadMenu();
                isPgmConfigLDV = true;
                pgmConfigLDVMenu[0].SetActive(true);
                break;
            case 12:
                DisableLoadMenu();
                isPgmConfigRestore = true;
                break;
            case 13:
                DisableLoadMenu();
                isPgmConfigSMS = true;
                pgmConfigSMSMenu.SetActive(true);
                break;
        }
    }

    public void NextPgmConfigMenu()
    {
        if (currentPgmConfigItem == 4)
        {
            pgmConfigMenu[0].SetActive(false);
            pgmConfigMenu[1].SetActive(true);
        }
        if (currentPgmConfigItem == 8)
        {
            pgmConfigMenu[1].SetActive(false);
            pgmConfigMenu[2].SetActive(true);
        }
        if (currentPgmConfigItem == 13)
        {
            pgmConfigMenu[2].SetActive(false);
            pgmConfigMenu[0].SetActive(true);
        }
        if (currentPgmConfigItem != 13)
        {
            ChangeColor(pgmConfigMenuImages[currentPgmConfigItem], pgmConfigMenuItems[currentPgmConfigItem], pgmConfigMenuImages[currentPgmConfigItem + 1], pgmConfigMenuItems[currentPgmConfigItem + 1]);
            currentPgmConfigItem++;
        }
        else
        {
            ChangeColor(pgmConfigMenuImages[currentPgmConfigItem], pgmConfigMenuItems[currentPgmConfigItem], pgmConfigMenuImages[0], pgmConfigMenuItems[0]);
            currentPgmConfigItem = 0;
        }
    }

    public void PrevPgmConfigMenu()
    {
        if (currentPgmConfigItem == 5)
        {
            pgmConfigMenu[1].SetActive(false);
            pgmConfigMenu[0].SetActive(true);
        }
        if (currentPgmConfigItem == 9)
        {
            pgmConfigMenu[2].SetActive(false);
            pgmConfigMenu[1].SetActive(true);
        }
        if (currentPgmConfigItem == 0)
        {
            pgmConfigMenu[0].SetActive(false);
            pgmConfigMenu[2].SetActive(true);
        }
        if (currentPgmConfigItem != 0)
        {
            ChangeColor(pgmConfigMenuImages[currentPgmConfigItem], pgmConfigMenuItems[currentPgmConfigItem], pgmConfigMenuImages[currentPgmConfigItem - 1], pgmConfigMenuItems[currentPgmConfigItem - 1]);
            currentPgmConfigItem--;
        }
        else
        {
            ChangeColor(pgmConfigMenuImages[currentPgmConfigItem], pgmConfigMenuItems[currentPgmConfigItem], pgmConfigMenuImages[pgmConfigMenuImages.Length - 1], pgmConfigMenuItems[pgmConfigMenuImages.Length - 1]);
            currentPgmConfigItem = pgmConfigMenuImages.Length - 1;
        }
    }

    public void EnterPgmConfigRadio()
    {
        if(currentPgmConfigRadio != pgmConfigRadioScreens.Length - 1)
        {

            pgmConfigRadioScreens[currentPgmConfigRadio].SetActive(false);
            pgmConfigRadioScreens[currentPgmConfigRadio + 1].SetActive(true);
            switch(currentPgmConfigRadio)
            {
                case 0:
                    pgmConfigRadioTxLevel = firstScreenPgmRadioItems[currentPgmConfigRadioScreenItem].GetComponentInChildren<TextMeshProUGUI>().text;
                    break;
                case 1:
                    pgmConfigRadioSquelch = secondScreenPgmRadioItems[currentPgmConfigRadioScreenItem].GetComponentInChildren<TextMeshProUGUI>().text;
                    break;
                case 2:
                    pgmConfigRadioSquelchLevel = thirdScreenPgmRadioItems[currentPgmConfigRadioScreenItem].GetComponentInChildren<TextMeshProUGUI>().text;
                    break;
                case 3:
                    pgmConfigRadioFMSquelchType = fourthScreenPgmRadioItems[currentPgmConfigRadioScreenItem].GetComponentInChildren<TextMeshProUGUI>().text;
                    break;
                case 4:
                    pgmConfigRadioRadioSilence = fifthScreenPgmRadioItems[currentPgmConfigRadioScreenItem].GetComponentInChildren<TextMeshProUGUI>().text;
                    break;
                case 5:
                    pgmConfigRadioCoupler = sixthScreenPgmRadioItems[currentPgmConfigRadioScreenItem].GetComponentInChildren<TextMeshProUGUI>().text;
                    break;
                case 6:
                    pgmConfigRadioFMDeviation = seventhScreenPgmRadioItems[currentPgmConfigRadioScreenItem].GetComponentInChildren<TextMeshProUGUI>().text;
                    break;
                case 7:
                    pgmConfigRadioBatteryModel = eighthScreenPgmRadioItems[currentPgmConfigRadioScreenItem].GetComponentInChildren<TextMeshProUGUI>().text;
                    break;
                case 8:
                    pgmConfigRadioCWOffset = ninethScreenPgmRadioItems[currentPgmConfigRadioScreenItem].GetComponentInChildren<TextMeshProUGUI>().text;
                    break;
                case 9:
                    pgmConfigRadioRXNoiseBlanking = tenthScreenPgmRadioItems[currentPgmConfigRadioScreenItem].GetComponentInChildren<TextMeshProUGUI>().text;
                    break;
                case 10:
                    pgmConfigRadioCompression = eleventhScreenPgmRadioItems[currentPgmConfigRadioScreenItem].GetComponentInChildren<TextMeshProUGUI>().text;
                    break;
                case 12:
                    pgmConfigRadioErrorBeeps = thirdteenthScreenPgmRadioItems[currentPgmConfigRadioScreenItem].GetComponentInChildren<TextMeshProUGUI>().text;
                    break;
            }
            currentPgmConfigRadio++;
            currentPgmConfigRadioScreenItem = 0;
        }
        else
        {
            DisableLoadMenu();
            isPgmConfig = true;
            pgmConfigMenu[0].SetActive(true);
        }
    }

    public void PgmConfigRadioUp()
    {
        switch (currentPgmConfigRadio)
        {
            case 0:
                if (currentPgmConfigRadioScreenItem != firstScreenPgmRadioItems.Length - 1)
                {
                    firstScreenPgmRadioItems[currentPgmConfigRadioScreenItem].SetActive(false);
                    firstScreenPgmRadioItems[currentPgmConfigRadioScreenItem + 1].SetActive(true);
                    currentPgmConfigRadioScreenItem++;
                }
                else 
                {
                    firstScreenPgmRadioItems[currentPgmConfigRadioScreenItem].SetActive(false);
                    firstScreenPgmRadioItems[0].SetActive(true);
                    currentPgmConfigRadioScreenItem = 0;
                }
                break;
            case 1:
                if (currentPgmConfigRadioScreenItem != secondScreenPgmRadioItems.Length - 1)
                {
                    secondScreenPgmRadioItems[currentPgmConfigRadioScreenItem].SetActive(false);
                    secondScreenPgmRadioItems[currentPgmConfigRadioScreenItem + 1].SetActive(true);
                    currentPgmConfigRadioScreenItem++;
                }
                else
                {
                    secondScreenPgmRadioItems[currentPgmConfigRadioScreenItem].SetActive(false);
                    secondScreenPgmRadioItems[0].SetActive(true);
                    currentPgmConfigRadioScreenItem = 0;
                }
                break;
            case 2:
                if (currentPgmConfigRadioScreenItem != thirdScreenPgmRadioItems.Length - 1)
                {
                    thirdScreenPgmRadioItems[currentPgmConfigRadioScreenItem].SetActive(false);
                    thirdScreenPgmRadioItems[currentPgmConfigRadioScreenItem + 1].SetActive(true);
                    currentPgmConfigRadioScreenItem++;
                }
                else
                {
                    thirdScreenPgmRadioItems[currentPgmConfigRadioScreenItem].SetActive(false);
                    thirdScreenPgmRadioItems[0].SetActive(true);
                    currentPgmConfigRadioScreenItem = 0;
                }
                break;
            case 3:
                if (currentPgmConfigRadioScreenItem != fourthScreenPgmRadioItems.Length - 1)
                {
                    fourthScreenPgmRadioItems[currentPgmConfigRadioScreenItem].SetActive(false);
                    fourthScreenPgmRadioItems[currentPgmConfigRadioScreenItem + 1].SetActive(true);
                    currentPgmConfigRadioScreenItem++;
                }
                else
                {
                    fourthScreenPgmRadioItems[currentPgmConfigRadioScreenItem].SetActive(false);
                    fourthScreenPgmRadioItems[0].SetActive(true);
                    currentPgmConfigRadioScreenItem = 0;
                }
                break;
            case 4:
                if (currentPgmConfigRadioScreenItem != fifthScreenPgmRadioItems.Length - 1)
                {
                    fifthScreenPgmRadioItems[currentPgmConfigRadioScreenItem].SetActive(false);
                    fifthScreenPgmRadioItems[currentPgmConfigRadioScreenItem + 1].SetActive(true);
                    currentPgmConfigRadioScreenItem++;
                }
                else
                {
                    fifthScreenPgmRadioItems[currentPgmConfigRadioScreenItem].SetActive(false);
                    fifthScreenPgmRadioItems[0].SetActive(true);
                    currentPgmConfigRadioScreenItem = 0;
                }
                break;
            case 5:
                if (currentPgmConfigRadioScreenItem != sixthScreenPgmRadioItems.Length - 1)
                {
                    sixthScreenPgmRadioItems[currentPgmConfigRadioScreenItem].SetActive(false);
                    sixthScreenPgmRadioItems[currentPgmConfigRadioScreenItem + 1].SetActive(true);
                    currentPgmConfigRadioScreenItem++;
                }
                else
                {
                    sixthScreenPgmRadioItems[currentPgmConfigRadioScreenItem].SetActive(false);
                    sixthScreenPgmRadioItems[0].SetActive(true);
                    currentPgmConfigRadioScreenItem = 0;
                }
                break;
            case 6:
                if (currentPgmConfigRadioScreenItem != seventhScreenPgmRadioItems.Length - 1)
                {
                    seventhScreenPgmRadioItems[currentPgmConfigRadioScreenItem].SetActive(false);
                    seventhScreenPgmRadioItems[currentPgmConfigRadioScreenItem + 1].SetActive(true);
                    currentPgmConfigRadioScreenItem++;
                }
                else
                {
                    seventhScreenPgmRadioItems[currentPgmConfigRadioScreenItem].SetActive(false);
                    seventhScreenPgmRadioItems[0].SetActive(true);
                    currentPgmConfigRadioScreenItem = 0;
                }
                break;
            case 7:
                if (currentPgmConfigRadioScreenItem != eighthScreenPgmRadioItems.Length - 1)
                {
                    eighthScreenPgmRadioItems[currentPgmConfigRadioScreenItem].SetActive(false);
                    eighthScreenPgmRadioItems[currentPgmConfigRadioScreenItem + 1].SetActive(true);
                    currentPgmConfigRadioScreenItem++;
                }
                else
                {
                    eighthScreenPgmRadioItems[currentPgmConfigRadioScreenItem].SetActive(false);
                    eighthScreenPgmRadioItems[0].SetActive(true);
                    currentPgmConfigRadioScreenItem = 0;
                }
                break;
            case 8:
                if (currentPgmConfigRadioScreenItem != ninethScreenPgmRadioItems.Length - 1)
                {
                    ninethScreenPgmRadioItems[currentPgmConfigRadioScreenItem].SetActive(false);
                    ninethScreenPgmRadioItems[currentPgmConfigRadioScreenItem + 1].SetActive(true);
                    currentPgmConfigRadioScreenItem++;
                }
                else
                {
                    ninethScreenPgmRadioItems[currentPgmConfigRadioScreenItem].SetActive(false);
                    ninethScreenPgmRadioItems[0].SetActive(true);
                    currentPgmConfigRadioScreenItem = 0;
                }
                break;
            case 9:
                if (currentPgmConfigRadioScreenItem != tenthScreenPgmRadioItems.Length - 1)
                {
                    tenthScreenPgmRadioItems[currentPgmConfigRadioScreenItem].SetActive(false);
                    tenthScreenPgmRadioItems[currentPgmConfigRadioScreenItem + 1].SetActive(true);
                    currentPgmConfigRadioScreenItem++;
                }
                else
                {
                    tenthScreenPgmRadioItems[currentPgmConfigRadioScreenItem].SetActive(false);
                    tenthScreenPgmRadioItems[0].SetActive(true);
                    currentPgmConfigRadioScreenItem = 0;
                }
                break;
            case 10:
                if (currentPgmConfigRadioScreenItem != eleventhScreenPgmRadioItems.Length - 1)
                {
                    eleventhScreenPgmRadioItems[currentPgmConfigRadioScreenItem].SetActive(false);
                    eleventhScreenPgmRadioItems[currentPgmConfigRadioScreenItem + 1].SetActive(true);
                    currentPgmConfigRadioScreenItem++;
                }
                else
                {
                    eleventhScreenPgmRadioItems[currentPgmConfigRadioScreenItem].SetActive(false);
                    eleventhScreenPgmRadioItems[0].SetActive(true);
                    currentPgmConfigRadioScreenItem = 0;
                }
                break;
            case 12:
                if (currentPgmConfigRadioScreenItem != thirdteenthScreenPgmRadioItems.Length - 1)
                {
                    thirdteenthScreenPgmRadioItems[currentPgmConfigRadioScreenItem].SetActive(false);
                    thirdteenthScreenPgmRadioItems[currentPgmConfigRadioScreenItem + 1].SetActive(true);
                    currentPgmConfigRadioScreenItem++;
                }
                else
                {
                    thirdteenthScreenPgmRadioItems[currentPgmConfigRadioScreenItem].SetActive(false);
                    thirdteenthScreenPgmRadioItems[0].SetActive(true);
                    currentPgmConfigRadioScreenItem = 0;
                }
                break;
        }
    }

    public void PgmConfigRadioDown()
    {
        switch (currentPgmConfigRadio)
        {
            case 0:
                if (currentPgmConfigRadioScreenItem != 0)
                {
                    firstScreenPgmRadioItems[currentPgmConfigRadioScreenItem].SetActive(false);
                    firstScreenPgmRadioItems[currentPgmConfigRadioScreenItem - 1].SetActive(true);
                    currentPgmConfigRadioScreenItem--;
                }
                else
                {
                    firstScreenPgmRadioItems[currentPgmConfigRadioScreenItem].SetActive(false);
                    firstScreenPgmRadioItems[firstScreenPgmRadioItems.Length - 1].SetActive(true);
                    currentPgmConfigRadioScreenItem = firstScreenPgmRadioItems.Length - 1;
                }
                break;
            case 1:
                if (currentPgmConfigRadioScreenItem != 0)
                {
                    secondScreenPgmRadioItems[currentPgmConfigRadioScreenItem].SetActive(false);
                    secondScreenPgmRadioItems[currentPgmConfigRadioScreenItem - 1].SetActive(true);
                    currentPgmConfigRadioScreenItem--;
                }
                else
                {
                    secondScreenPgmRadioItems[currentPgmConfigRadioScreenItem].SetActive(false);
                    secondScreenPgmRadioItems[secondScreenPgmRadioItems.Length - 1].SetActive(true);
                    currentPgmConfigRadioScreenItem = secondScreenPgmRadioItems.Length - 1;
                }
                break;
            case 2:
                if (currentPgmConfigRadioScreenItem != 0)
                {
                    thirdScreenPgmRadioItems[currentPgmConfigRadioScreenItem].SetActive(false);
                    thirdScreenPgmRadioItems[currentPgmConfigRadioScreenItem - 1].SetActive(true);
                    currentPgmConfigRadioScreenItem--;
                }
                else
                {
                    thirdScreenPgmRadioItems[currentPgmConfigRadioScreenItem].SetActive(false);
                    thirdScreenPgmRadioItems[thirdScreenPgmRadioItems.Length - 1].SetActive(true);
                    currentPgmConfigRadioScreenItem = thirdScreenPgmRadioItems.Length - 1;
                }
                break;
            case 3:
                if (currentPgmConfigRadioScreenItem != 0)
                {
                    fourthScreenPgmRadioItems[currentPgmConfigRadioScreenItem].SetActive(false);
                    fourthScreenPgmRadioItems[currentPgmConfigRadioScreenItem - 1].SetActive(true);
                    currentPgmConfigRadioScreenItem--;
                }
                else
                {
                    fourthScreenPgmRadioItems[currentPgmConfigRadioScreenItem].SetActive(false);
                    fourthScreenPgmRadioItems[fourthScreenPgmRadioItems.Length - 1].SetActive(true);
                    currentPgmConfigRadioScreenItem = fourthScreenPgmRadioItems.Length - 1;
                }
                break;
            case 4:
                if (currentPgmConfigRadioScreenItem != 0)
                {
                    fifthScreenPgmRadioItems[currentPgmConfigRadioScreenItem].SetActive(false);
                    fifthScreenPgmRadioItems[currentPgmConfigRadioScreenItem - 1].SetActive(true);
                    currentPgmConfigRadioScreenItem--;
                }
                else
                {
                    fifthScreenPgmRadioItems[currentPgmConfigRadioScreenItem].SetActive(false);
                    fifthScreenPgmRadioItems[fifthScreenPgmRadioItems.Length - 1].SetActive(true);
                    currentPgmConfigRadioScreenItem = fifthScreenPgmRadioItems.Length - 1;
                }
                break;
            case 5:
                if (currentPgmConfigRadioScreenItem != 0)
                {
                    sixthScreenPgmRadioItems[currentPgmConfigRadioScreenItem].SetActive(false);
                    sixthScreenPgmRadioItems[currentPgmConfigRadioScreenItem - 1].SetActive(true);
                    currentPgmConfigRadioScreenItem--;
                }
                else
                {
                    sixthScreenPgmRadioItems[currentPgmConfigRadioScreenItem].SetActive(false);
                    sixthScreenPgmRadioItems[sixthScreenPgmRadioItems.Length - 1].SetActive(true);
                    currentPgmConfigRadioScreenItem = sixthScreenPgmRadioItems.Length - 1;
                }
                break;
            case 6:
                if (currentPgmConfigRadioScreenItem != 0)
                {
                    seventhScreenPgmRadioItems[currentPgmConfigRadioScreenItem].SetActive(false);
                    seventhScreenPgmRadioItems[currentPgmConfigRadioScreenItem - 1].SetActive(true);
                    currentPgmConfigRadioScreenItem--;
                }
                else
                {
                    seventhScreenPgmRadioItems[currentPgmConfigRadioScreenItem].SetActive(false);
                    seventhScreenPgmRadioItems[seventhScreenPgmRadioItems.Length - 1].SetActive(true);
                    currentPgmConfigRadioScreenItem = seventhScreenPgmRadioItems.Length - 1;
                }
                break;
            case 7:
                if (currentPgmConfigRadioScreenItem != 0)
                {
                    eighthScreenPgmRadioItems[currentPgmConfigRadioScreenItem].SetActive(false);
                    eighthScreenPgmRadioItems[currentPgmConfigRadioScreenItem - 1].SetActive(true);
                    currentPgmConfigRadioScreenItem--;
                }
                else
                {
                    eighthScreenPgmRadioItems[currentPgmConfigRadioScreenItem].SetActive(false);
                    eighthScreenPgmRadioItems[eighthScreenPgmRadioItems.Length - 1].SetActive(true);
                    currentPgmConfigRadioScreenItem = eighthScreenPgmRadioItems.Length - 1;
                }
                break;
            case 8:
                if (currentPgmConfigRadioScreenItem != 0)
                {
                    ninethScreenPgmRadioItems[currentPgmConfigRadioScreenItem].SetActive(false);
                    ninethScreenPgmRadioItems[currentPgmConfigRadioScreenItem - 1].SetActive(true);
                    currentPgmConfigRadioScreenItem--;
                }
                else
                {
                    ninethScreenPgmRadioItems[currentPgmConfigRadioScreenItem].SetActive(false);
                    ninethScreenPgmRadioItems[ninethScreenPgmRadioItems.Length - 1].SetActive(true);
                    currentPgmConfigRadioScreenItem = ninethScreenPgmRadioItems.Length - 1;
                }
                break;
            case 9:
                if (currentPgmConfigRadioScreenItem != 0)
                {
                    tenthScreenPgmRadioItems[currentPgmConfigRadioScreenItem].SetActive(false);
                    tenthScreenPgmRadioItems[currentPgmConfigRadioScreenItem - 1].SetActive(true);
                    currentPgmConfigRadioScreenItem--;
                }
                else
                {
                    tenthScreenPgmRadioItems[currentPgmConfigRadioScreenItem].SetActive(false);
                    tenthScreenPgmRadioItems[tenthScreenPgmRadioItems.Length - 1].SetActive(true);
                    currentPgmConfigRadioScreenItem = tenthScreenPgmRadioItems.Length - 1;
                }
                break;
            case 10:
                if (currentPgmConfigRadioScreenItem != 0)
                {
                    eleventhScreenPgmRadioItems[currentPgmConfigRadioScreenItem].SetActive(false);
                    eleventhScreenPgmRadioItems[currentPgmConfigRadioScreenItem - 1].SetActive(true);
                    currentPgmConfigRadioScreenItem--;
                }
                else
                {
                    eleventhScreenPgmRadioItems[currentPgmConfigRadioScreenItem].SetActive(false);
                    eleventhScreenPgmRadioItems[eleventhScreenPgmRadioItems.Length - 1].SetActive(true);
                    currentPgmConfigRadioScreenItem = eleventhScreenPgmRadioItems.Length - 1;
                }
                break;
            case 12:
                if (currentPgmConfigRadioScreenItem != 0)
                {
                    thirdteenthScreenPgmRadioItems[currentPgmConfigRadioScreenItem].SetActive(false);
                    thirdteenthScreenPgmRadioItems[currentPgmConfigRadioScreenItem - 1].SetActive(true);
                    currentPgmConfigRadioScreenItem--;
                }
                else
                {
                    thirdteenthScreenPgmRadioItems[currentPgmConfigRadioScreenItem].SetActive(false);
                    thirdteenthScreenPgmRadioItems[thirdteenthScreenPgmRadioItems.Length - 1].SetActive(true);
                    currentPgmConfigRadioScreenItem = thirdteenthScreenPgmRadioItems.Length - 1;
                }
                break;
        }
    }

    public void NextStation()
    {
        if (currentStation == stations.Length - 1)
        {
            stations[currentStation].GetComponent<Animation>().Play("StatioOutRight");
            stations[0].GetComponent<Animation>().Play("StatioInLeft");
            stationsModel[currentStation].GetComponent<Animation>().Play("StatioOutRight");
            stationsModel[0].GetComponent<Animation>().Play("StatioInLeft");
            currentStation = 0;
        }
        else
        {
            stations[currentStation].GetComponent<Animation>().Play("StatioOutRight");
            stations[currentStation + 1].GetComponent<Animation>().Play("StatioInLeft");
            stationsModel[currentStation].GetComponent<Animation>().Play("StatioOutRight");
            stationsModel[currentStation + 1].GetComponent<Animation>().Play("StatioInLeft");
            currentStation++;
        }
    }

    public void PrevStation()
    {
        if (currentStation == 0)
        {
            stations[currentStation].GetComponent<Animation>().Play("StatioOutLeft");
            stations[stations.Length - 1].GetComponent<Animation>().Play("StatioInRight");
            stationsModel[currentStation].GetComponent<Animation>().Play("StatioOutLeft");
            stationsModel[stations.Length - 1].GetComponent<Animation>().Play("StatioInRight");
            currentStation = stations.Length - 1;
        }
        else
        {
            stations[currentStation].GetComponent<Animation>().Play("StatioOutLeft");
            stations[currentStation - 1].GetComponent<Animation>().Play("StatioInRight");
            stationsModel[currentStation].GetComponent<Animation>().Play("StatioOutLeft");
            stationsModel[currentStation - 1].GetComponent<Animation>().Play("StatioInRight");
            currentStation--;
        }
    }

    public void AccSettings()
    {
        if(currentAccWindow < extSetting.Length - 1)
        {
            extSetting[currentAccWindow].SetActive(false);
            extSetting[currentAccWindow + 1].SetActive(true);
            currentAccWindow++;
        }
        else
        {
            currentAccWindow = 0;
            DisableLoadMenu();
            settingMenu[0].SetActive(true);
            inSettingMenu = true;
            exitAcc = true;
        }
    }

    public void NextPgmMenuItem()
    {
        if(currentPgmItem == 3)
        {
            pgmMenu[0].SetActive(false);
            pgmMenu[1].SetActive(true);
        }
        if(currentPgmItem == 5)
        {
            pgmMenu[1].SetActive(false);
            pgmMenu[0].SetActive(true);
        }
        if (currentPgmItem != pgmMenuItems.Length - 1)
        {
            ChangeColor(pgmMenuImages[currentPgmItem], pgmMenuItems[currentPgmItem], pgmMenuImages[currentPgmItem + 1], pgmMenuItems[currentPgmItem + 1]);
            currentPgmItem++;
        }
        else
        {
            ChangeColor(pgmMenuImages[currentPgmItem], pgmMenuItems[currentPgmItem], pgmMenuImages[0], pgmMenuItems[0]);
            currentPgmItem = 0;
        }
    }

    public void PrevPgmMenuItem()
    {
        if (currentPgmItem == 0)
        {
            pgmMenu[0].SetActive(false);
            pgmMenu[1].SetActive(true);
        }
        if (currentPgmItem == 4)
        {
            pgmMenu[1].SetActive(false);
            pgmMenu[0].SetActive(true);
        }
        if (currentPgmItem != 0)
        {
            ChangeColor(pgmMenuImages[currentPgmItem], pgmMenuItems[currentPgmItem], pgmMenuImages[currentPgmItem - 1], pgmMenuItems[currentPgmItem - 1]);
            currentPgmItem--;
        }
        else
        {
            ChangeColor(pgmMenuImages[currentPgmItem], pgmMenuItems[currentPgmItem], pgmMenuImages[pgmMenuImages.Length - 1], pgmMenuItems[pgmMenuImages.Length - 1]);
            currentPgmItem = pgmMenuImages.Length - 1;
        }
    }

    public void NextPgmComsecMenu()
    {
        if(currentPgmComsecItem != 4)
        {
            ChangeColor(comsecMenuImages[currentPgmComsecItem], comsecMenuItems[currentPgmComsecItem], comsecMenuImages[currentPgmComsecItem + 1], comsecMenuItems[currentPgmComsecItem + 1]);
            currentPgmComsecItem++;
        }
        else
        {
            ChangeColor(comsecMenuImages[currentPgmComsecItem], comsecMenuItems[currentPgmComsecItem], comsecMenuImages[0], comsecMenuItems[0]);
            currentPgmComsecItem = 0;
        }
    }

    public void PrevPgmComsecMenu()
    {
        if (currentPgmComsecItem != 0)
        {
            ChangeColor(comsecMenuImages[currentPgmComsecItem], comsecMenuItems[currentPgmComsecItem], comsecMenuImages[currentPgmComsecItem - 1], comsecMenuItems[currentPgmComsecItem - 1]);
            currentPgmComsecItem--;
        }
        else
        {
            ChangeColor(comsecMenuImages[currentPgmComsecItem], comsecMenuItems[currentPgmComsecItem], comsecMenuImages[comsecMenuImages.Length - 1], comsecMenuItems[comsecMenuImages.Length - 1]);
            currentPgmComsecItem = comsecMenuImages.Length - 1;
        }
    }

    public void EnterPgmComsecCam()
    {
        if(currentPgmComsecCam != camMenu.Length - 1)
        {
            camMenu[currentPgmComsecCam].SetActive(false);
            camMenu[currentPgmComsecCam + 1].SetActive(true);
            currentPgmComsecCam++;
        }
        else 
        {
            DisableLoadMenu();
            comsecMenu.SetActive(true);
            isPgmComsec = true;
        }
    }

    public void EnterPgmComsecId()
    {
        if (currentPgmComsecId != idMenu.Length - 1)
        {
            idMenu[currentPgmComsecId].SetActive(false);
            idMenu[currentPgmComsecId + 1].SetActive(true);
            currentPgmComsecId++;
        }
        else
        {
            DisableLoadMenu();
            comsecMenu.SetActive(true);
            isPgmComsec = true;
        }
    }

    public void NextPgmComsecKeys()
    {
        if(currentPgmComsecKeys != keysMenuImages.Length - 1)
        {
            ChangeColor(keysMenuImages[currentPgmComsecKeys], keysMenuItems[currentPgmComsecKeys], keysMenuImages[currentPgmComsecKeys + 1], keysMenuItems[currentPgmComsecKeys + 1]);
            currentPgmComsecKeys++;
        }
        else
        {
            ChangeColor(keysMenuImages[currentPgmComsecKeys], keysMenuItems[currentPgmComsecKeys], keysMenuImages[0], keysMenuItems[0]);
            currentPgmComsecKeys = 0;
        }
    }

    public void PrevPgmComsecKeys()
    {
        if (currentPgmComsecKeys != 0)
        {
            ChangeColor(keysMenuImages[currentPgmComsecKeys], keysMenuItems[currentPgmComsecKeys], keysMenuImages[currentPgmComsecKeys - 1], keysMenuItems[currentPgmComsecKeys - 1]);
            currentPgmComsecKeys--;
        }
        else
        {
            ChangeColor(keysMenuImages[currentPgmComsecKeys], keysMenuItems[currentPgmComsecKeys], keysMenuImages[keysMenuImages.Length - 1], keysMenuItems[keysMenuImages.Length - 1]);
            currentPgmComsecKeys = keysMenuImages.Length - 1;
        }
    }

    public void EnterPgmComsecKeys()
    {
        switch (currentPgmComsecKeys)
        {
            case 0:
                DisableLoadMenu();
                isPgmComsecKeysEnter = true;
                keysEnterMenu.SetActive(true);
                break;
            case 1:
                DisableLoadMenu();
                isPgmComsecKeysUpdate = true;
                keysUpdateMenu.SetActive(true);
                break;
            case 2:
                DisableLoadMenu();
                isPgmComsecKeysErase = true;
                keysEraseMenu.SetActive(true);
                break;
        }

    }

   
    public void EnterPgmComsecMenu()
    {
        switch(currentPgmComsecItem)
        {
            case 0:
                DisableLoadMenu();
                isPgmComsecCam = true;
                camMenu[0].SetActive(true);
                break;
            case 1:
                DisableLoadMenu();
                isPgmComsecID = true;
                idMenu[0].SetActive(true);
                break;
            case 2:
                DisableLoadMenu();
                isPgmComsecKeys = true;
                keysMenu.SetActive(true);
                break;
            case 3:
                DisableLoadMenu();
                isPgmComsecMI = true;   
                break;
            case 4:
                DisableLoadMenu();
                isPgmComsecAKS = true;
                break;
        }
    }

    public void EnterPgmMenu()
    {
        switch(currentPgmItem)
        {
            case 0:
                DisableLoadMenu();
                isPgmComsec = true;
                comsecMenu.SetActive(true);
                break;
            case 1:
                DisableLoadMenu();
                isPgmConfig = true;
                pgmConfigMenu[0].SetActive(true);
                break;
            case 2:
                DisableLoadMenu();
                isPgmMode = true;
                break;
            case 3:
                DisableLoadMenu();
                isPgmMaintenance = true;
                break;
            case 4:
                DisableLoadMenu();
                isPgmInstall = true;
                break;
            case 5:
                DisableLoadMenu();
                isPgmScred = true;
                break;
        }

    }

    // Start is called before the first frame update
   
    // Update is called once per frame
    void Update()
    {

    }

    public void DisableLoadMenu()
    {
        isPgmConfigSMSSetting = false;
        currentPgmConfigSMS = 0;

        currentPgmConfigARQ = 0;
        currentPgmConfigARQItem = 0;

        currentPgmConfigLDV = 0;
        currentPgmConfigLDVItem = 0;

        isPgmConfigNetworkProtocolSNMPTrapAddress = false;

        currentPgmConfigNetworkProtocolSNMP = 0;
        currentPgmConfigNetworkProtocolSNMPItem = 0;

        isPgmConfigNetworkProtocolSNMP = false;

        isPgmConfigNetworkInterfaceWirelessAddressIP = false;
        isPgmConfigNetworkInterfaceWirelessAddressSubnet = false;

        currentPgmConfigNetworkInterfaceWirelessAddress = 0;
        currentPgmConfigNetworkInterfaceWirelessAddressItem = 0;

        isPgmConfigNetworkInterfaceWirelessAddress = false;
        isPgmConfigNetworkInterfaceWirelessStatus = false;

        currentPgmConfigNetworkInterfaceWireless = 0;

        currentPgmConfigNetworkInterfacePPPPortSetting = 0;
        currentPgmConfigNetworkInterfacePPPPortSettingItem = 0;

        currentPgmConfigNetworkInterfacePPPStatus = 0;

        isPgmConfigNetworkInterfacePPPAddressIP = false;
        isPgmConfigNetworkInterfacePPPAddressSubnet = false;
        isPgmConfigNetworkInterfacePPPAddressGetaway = false;

        currentPgmConfigNetworkInterfacePPPAddress = 0;
        currentPgmConfigNetworkInterfacePPPAddressItem = 0;

        isPgmConfigNetworkInterfacePPPAddress = false;
        isPgmConfigNetworkInterfacePPPStatus = false;
        isPgmConfigNetworkInterfacePPPPortSetting = false;

        currentPgmConfigNetworkInterfacePPP = 0;

        isPgmConfigNetworkInterface = false;
        isPgmConfigNetworkProtocol = false;
        isPgmConfigNetworkRoutes = false;

        currentPgmConfigNetwork = 0;

        isPgmConfigNetworkInterfaceEthernet = false;
        isPgmConfigNetworkInterfacePPP = false;
        isPgmConfigNetworkInterfaceWireless = false;

        currentPgmConfigNetworkInterface = 0;

        isPgmConfigNetworkInterfaceEthernetAddress = false;
        isPgmConfigNetworkInterfaceEthernetStatus = false;

        currentPgmConfigNetworkInterfaceEthernet = 0;

        currentPgmConfigNetworkInterfaceEthernetAddress = 0;
        currentPgmConfigNetworkInterfaceEthernetAddressItem = 0;
        isPgmConfigNetworkInterfaceEthernetAddressIP = false;


        currentPgmConfigAccessory = 0;
        currentPgmConfigAccessoryItem = 0;

        currentPgmConfigNetwork = 0;

        currentPgmConfigAudio = 0;
        currentPgmConfigAudioitem = 0;

        currentPgmConfigMessage = 0;
        currentPgmConfigMessageitem = 0;

        currentPgmConfigLPC = 0;
        currentPgmConfigLPCitem = 0;

        currentPgmConfigGPS = 0;
        currentPgmConfigGPSitem = 0;

        currentPgmConfigGPSARP = 0;
        currentPgmConfigGPSARPitem = 0;
        isTimeInterval = false;
        isGPSARPIpAddress = false;

        isPgmConfigNetworkInterface = false;
        isPgmConfigNetworkProtocol = false;
        isPgmConfigNetworkRoutes = false;

        currentPgmConfigPort = 0;

        isPgmConfigPortsData = false;
        isPgmConfigPortsAscii = false;

        isPgmConfigRadio = false;
        isPgmConfigPorts = false;
        isPgmConfigAudio = false;
        isPgmConfigTod = false;
        isPgmConfigMessage = false;
        isPgmConfigLPC = false;
        isPgmConfigGPS = false;
        isPgmConfigGPSAPR = false;
        isPgmConfigAccessory = false;
        isPgmConfigNetwork = false;
        isPgmConfigARQ = false;
        isPgmConfigLDV = false;
        isPgmConfigRestore = false;
        isPgmConfigSMS = false;

        currentPgmConfigItem = 0;

        isPgmComsecKeysEnter = false;
        isPgmComsecKeysUpdate = false;
        isPgmComsecKeysErase = false;

        currentPgmItem = 0;
        currentPgmComsecItem = 0;
        currentPgmComsecCam = 0;
        currentPgmComsecId = 0;
        currentPgmComsecKeys = 0;

        isPgmComsecCam = false;
        isPgmComsecID = false;
        isPgmComsecKeys = false;
        isPgmComsecMI = false;
        isPgmComsecAKS = false;

        currentPgmItem = 0;

        isPgm = false;
        isPgmComsec = false;
        isPgmConfig = false;
        isPgmMode = false;
        isPgmMaintenance = false;
        isPgmInstall = false;
        isPgmScred = false;

        for(int i = 0; i < pgmMenu.Length; i++)
        {
            pgmMenu[i].SetActive(false);
        }

        comsecMenu.SetActive(false);
        for(int i = 0; i < camMenu.Length; i++)
        {
            camMenu[i].SetActive(false);
        }

        for(int i =0; i < idMenu.Length; i++)
        {
            idMenu[i].SetActive(false);
        }

        keysMenu.SetActive(false);

        keysEnterMenu.SetActive(false);

        keysUpdateMenu.SetActive(false);

        keysEraseMenu.SetActive(false);

        for(int i = 0; i< pgmConfigMenu.Length; i++)
        {
            pgmConfigMenu[i].SetActive(false);
        }

        for(int i = 0; i < pgmConfigRadioScreens.Length; i++)
        {
            pgmConfigRadioScreens[i].SetActive(false);
        }

        pgmConfigPortsMenu.SetActive(false);

        for (int i = 0; i < pgmConfigPortsDataMenu.Length; i++)
        {
            pgmConfigPortsDataMenu[i].SetActive(false);
        }

        for(int i = 0; i < pgmConfigPortsAsciiMenu.Length; i++)
        {
            pgmConfigPortsAsciiMenu[i].SetActive(false);
        }

        for(int i = 0; i < pgmConfigAudioMenu.Length; i++)
        {
            pgmConfigAudioMenu[i].SetActive(false);
        }

        for(int i = 0; i < pgmConfigMessageMenu.Length; i++)
        {
            pgmConfigMessageMenu[i].SetActive(false);
        }

        for(int i = 0; i < pgmConfigLpcMenu.Length; i++)
        {
            pgmConfigLpcMenu[i].SetActive(false);
        }

        for(int i = 0; i < pgmConfigGPSMenu.Length; i++)
        {
            pgmConfigGPSMenu[i].SetActive(false);
        }

        for(int i = 0; i < pgmConfigGPSARPMenu.Length;i++)
        {
            pgmConfigGPSARPMenu[i].SetActive(false);
        }

        for(int i = 0; i < pgmConfigAccessoryMenu.Length; i++)
        {
            pgmConfigAccessoryMenu[i].SetActive(false);
        }

        pgmConfigNetworkMenu.SetActive(false);

        pgmConfigNetworkInterfaceMenu.SetActive(false);

        pgmConfigNetworkInterfaceEthernetMenu.SetActive(false);

        for(int i = 0; i< pgmConfigNetworkInterfaceEthernetAddressMenu.Length; i++)
        {
            pgmConfigNetworkInterfaceEthernetAddressMenu[i].SetActive(false);
        }

        pgmConfigNetworkInterfaceEthernetStatusMenu.SetActive(false);

        pgmConfigNetworkInterfacePPPMenu.SetActive(false);

        for(int i = 0; i < pgmConfigNetworkInterfacePPPAddressMenu.Length; i++)
        {
            pgmConfigNetworkInterfacePPPAddressMenu[i].SetActive(false);
        }

        for(int i = 0; i < pgmConfigNetworkInterfacePPPStatusMenu.Length; i++)
        {
            pgmConfigNetworkInterfacePPPStatusMenu[i].SetActive(false);
        }

        for(int i = 0; i < pgmConfigNetworkInterfacePPPPortSettingMenu.Length; i++)
        {
            pgmConfigNetworkInterfacePPPPortSettingMenu[i].SetActive(false);
        }

        pgmConfigNetworkInterfaceWirelessMenu.SetActive(false);

        for(int i = 0; i < pgmConfigNetworkInterfaceWirelessAddressMenu.Length; i++)
        {
            pgmConfigNetworkInterfaceWirelessAddressMenu[i].SetActive(false);
        }

        pgmConfigNetworkInterfaceWirelessStatusMenu.SetActive(false);

        pgmConfigNetworkProtocolMenu.SetActive(false);

        for(int i = 0; i < pgmConfigNetworkProtocolSNMPMenu.Length; i++)
        {
            pgmConfigNetworkProtocolSNMPMenu[i].SetActive(false);
        }

        pgmConfigNetworkRoutesMenu.SetActive(false);

        pgmConfigNetworkRoutesIndividualMenu.SetActive(false);

        for(int i = 0; i < pgmConfigNetworkRoutesIndividualAddMenu.Length; i++)
        {
            pgmConfigNetworkRoutesIndividualAddMenu[i].SetActive(false);
        }

        pgmConfigNetworkRoutesIndividualEditMenu.SetActive(false);

        for(int i = 0; i < pgmConfigARQMenu.Length; i++)
        {
            pgmConfigARQMenu[i].SetActive(false);
        }

        for(int i = 0; i < pgmConfigLDVMenu.Length; i++)
        {
            pgmConfigLDVMenu[i].SetActive(false);
        }

        pgmConfigSMSMenu.SetActive(false);

        for(int i = 0; i < pgmConfigSMSSettingMenu.Length; i++)
        {
            pgmConfigSMSSettingMenu[i].SetActive(false);
        }

        currentOption = "";

        for (int i = 0; i < loadMenu.Length; i++)
        {
            loadMenu[i].SetActive(false);
        }

        for (int i = 0; i < settingMenu.Length; i++)
        {
            settingMenu[i].SetActive(false);
        }

        for (int i = 0; i < radioSettings.Length; i++)
        {
            radioSettings[i].SetActive(false);
        }

        Gps.SetActive(false);

        scanSetting.SetActive(false);

        arpSetting.SetActive(false);

        for (int i = 0; i < arpViewSettings.Length; i++)
        {
            arpViewSettings[i].SetActive(false);
        }

        arpConfigSetting.SetActive(false);

        for (int i = 0; i < extSetting.Length; i++)
        {
            extSetting[i].SetActive(false);
        }

        testSetting.SetActive(false);
        bitTest.SetActive(false);

        currentRadioItem = 0;

        for (int i = 0; i < testInProgress.Length; i++)
        {
            testInProgress[i].SetActive(false);
        }

        arpView = false;
        arpConfig = false;

        isTod = false;
        isRadio = false;
        isScan = false;
        isARP = false;
        isAcc = false;
    }



    public void EnterSettings()
    {
        switch (currentMenuItem)
        {
            case 0:
                DisableLoadMenu();
                Gps.SetActive(true);
                isTod = true;
                break;
            case 2:
                DisableLoadMenu();
                isRadio = true;
                currentOption = firstRadioImage[0].GetComponentInChildren<TextMeshProUGUI>().text;
                radioSettings[0].SetActive(true);
                break;
            case 3:
                DisableLoadMenu();
                isScan = true;
                scanSetting.SetActive(true);
                break;
            case 4:
                DisableLoadMenu();
                isARP = true;
                arpSetting.SetActive(true);
                break;
            case 5:
                DisableLoadMenu();
                currentAccWindow = 0;
                isAcc = true;
                extSetting[0].SetActive(true);
                break;
            case 6:
                DisableLoadMenu();
                isTest = true;
                testSetting.SetActive(true);
                break;
            default:
                break;
        }
    }

    public void RadioSetting()
    {
        if (currentRadioItem != 8)
        {
            radioSettings[currentRadioItem].SetActive(false);
            radioSettings[currentRadioItem + 1].SetActive(true);
            
            switch (currentRadioItem)
            {
                case 0:
                    currentOption = secondRadioImage[0].GetComponentInChildren<TextMeshProUGUI>().text;
                    txLevel = firstRadioImage[currentRadioImage].GetComponentInChildren<TextMeshProUGUI>().text;
                    break;
                case 1:
                    currentOption = thirdRadioImage[0].GetComponentInChildren<TextMeshProUGUI>().text;
                    squelchLevel = secondRadioImage[currentRadioImage].GetComponentInChildren<TextMeshProUGUI>().text;
                    break;
                case 2:
                    currentOption = fourthRadioImage[0].GetComponentInChildren<TextMeshProUGUI>().text;
                    fm = thirdRadioImage[currentRadioImage].GetComponentInChildren<TextMeshProUGUI>().text;
                    break;
                case 3:
                    currentOption = fifthRadioImage[0].GetComponentInChildren<TextMeshProUGUI>().text;
                    internalCoupler = fourthRadioImage[currentRadioImage].GetComponentInChildren<TextMeshProUGUI>().text;
                    break;
                case 4:
                    currentOption = sithRadioImage[0].GetComponentInChildren<TextMeshProUGUI>().text;
                    radioSilence = fifthRadioImage[currentRadioImage].GetComponentInChildren<TextMeshProUGUI>().text;
                    break;
                case 5:
                    currentOption = seventhRadioImage[0].GetComponentInChildren<TextMeshProUGUI>().text;
                    bfo = sithRadioImage[currentRadioImage].GetComponentInChildren<TextMeshProUGUI>().text;
                    break;
                case 6:
                    currentOption = eigthRadioImage[0].GetComponentInChildren<TextMeshProUGUI>().text;
                    rxNoise = seventhRadioImage[currentRadioImage].GetComponentInChildren<TextMeshProUGUI>().text;
                    break;
                case 7:
                    radioLock = eigthRadioImage[currentRadioImage].GetComponentInChildren<TextMeshProUGUI>().text;
                    break;
            }
            currentRadioItem++;
            currentRadioImage = 0;
        }
        else
        {
            currentOption = "";
            DisableLoadMenu();
            currentRadioImage = 0;
            currentRadioItem = 0;
            settingMenu[0].SetActive(true);
            inSettingMenu = true;
        }
    }

    public void ScanChangeUp()
    {
        if (currentScanImage == 0)
        {
            scanImage[currentScanImage].SetActive(false);
            scanImage[scanImage.Length - 1].SetActive(true);
            currentScanImage = scanImage.Length - 1;
        }
        else
        {
            scanImage[currentScanImage].SetActive(false);
            scanImage[currentScanImage - 1].SetActive(true);
            currentScanImage--;
        }
    }

    public void ScanChangeDown()
    {
        if (currentScanImage == scanImage.Length - 1)
        {
            scanImage[currentScanImage].SetActive(false);
            scanImage[0].SetActive(true);
            currentScanImage = 0;
        }
        else
        {
            scanImage[currentScanImage].SetActive(false);
            scanImage[currentScanImage + 1].SetActive(true);
            currentScanImage++;
        }
    }

    public void RadioChangeUp()
    {
        switch (currentRadioItem)
        {
            case 0:
                if (currentRadioImage == 0)
                {
                    firstRadioImage[currentRadioImage].SetActive(false);
                    firstRadioImage[firstRadioImage.Length - 1].SetActive(true);
                    currentOption = firstRadioImage[firstRadioImage.Length - 1].GetComponentInChildren<TextMeshProUGUI>().text;
                    currentRadioImage = firstRadioImage.Length - 1; 
                }
                else
                {
                    firstRadioImage[currentRadioImage].SetActive(false);
                    firstRadioImage[currentRadioImage - 1].SetActive(true);
                    currentOption = firstRadioImage[currentRadioImage - 1].GetComponentInChildren<TextMeshProUGUI>().text;
                    currentRadioImage--; 
                }
                break;
            case 1:
                if (currentRadioImage == 0)
                {
                    secondRadioImage[currentRadioImage].SetActive(false);
                    secondRadioImage[secondRadioImage.Length - 1].SetActive(true);
                    currentOption = secondRadioImage[secondRadioImage.Length - 1].GetComponentInChildren<TextMeshProUGUI>().text;
                    currentRadioImage = secondRadioImage.Length - 1;     
                }
                else
                {
                    secondRadioImage[currentRadioImage].SetActive(false);
                    secondRadioImage[currentRadioImage - 1].SetActive(true);
                    currentOption = secondRadioImage[currentRadioImage - 1].GetComponentInChildren<TextMeshProUGUI>().text;
                    currentRadioImage--;
                }
                break;
            case 2:
                if (currentRadioImage == 0)
                {
                    thirdRadioImage[currentRadioImage].SetActive(false);
                    thirdRadioImage[thirdRadioImage.Length - 1].SetActive(true);
                    currentOption = thirdRadioImage[thirdRadioImage.Length - 1].GetComponentInChildren<TextMeshProUGUI>().text;
                    currentRadioImage = thirdRadioImage.Length - 1;
                }
                else
                {
                    thirdRadioImage[currentRadioImage].SetActive(false);
                    thirdRadioImage[currentRadioImage - 1].SetActive(true);
                    currentOption = thirdRadioImage[currentRadioImage - 1].GetComponentInChildren<TextMeshProUGUI>().text;
                    currentRadioImage--;
                }
                break;
            case 3:
                if (currentRadioImage == 0)
                {
                    fourthRadioImage[currentRadioImage].SetActive(false);
                    fourthRadioImage[fourthRadioImage.Length - 1].SetActive(true);
                    currentOption = fourthRadioImage[fourthRadioImage.Length - 1].GetComponentInChildren<TextMeshProUGUI>().text;
                    currentRadioImage = fourthRadioImage.Length - 1;
                }
                else
                {
                    fourthRadioImage[currentRadioImage].SetActive(false);
                    fourthRadioImage[currentRadioImage - 1].SetActive(true);
                    currentOption = fourthRadioImage[currentRadioImage - 1].GetComponentInChildren<TextMeshProUGUI>().text;
                    currentRadioImage--;
                }
                break;
            case 4:
                if (currentRadioImage == 0)
                {
                    fifthRadioImage[currentRadioImage].SetActive(false);
                    fifthRadioImage[fifthRadioImage.Length - 1].SetActive(true);
                    currentOption = fifthRadioImage[fifthRadioImage.Length - 1].GetComponentInChildren<TextMeshProUGUI>().text;
                    currentRadioImage = fifthRadioImage.Length - 1;
                }
                else
                {
                    fifthRadioImage[currentRadioImage].SetActive(false);
                    fifthRadioImage[currentRadioImage - 1].SetActive(true);
                    currentOption = fifthRadioImage[currentRadioImage - 1].GetComponentInChildren<TextMeshProUGUI>().text;
                    currentRadioImage--;
                }
                break;
            case 5:
                if (currentRadioImage == 0)
                {
                    sithRadioImage[currentRadioImage].SetActive(false);
                    sithRadioImage[sithRadioImage.Length - 1].SetActive(true);
                    currentOption = sithRadioImage[sithRadioImage.Length - 1].GetComponentInChildren<TextMeshProUGUI>().text;
                    currentRadioImage = sithRadioImage.Length - 1;
                }
                else
                {
                    sithRadioImage[currentRadioImage].SetActive(false);
                    sithRadioImage[currentRadioImage - 1].SetActive(true);
                    currentOption = sithRadioImage[currentRadioImage - 1].GetComponentInChildren<TextMeshProUGUI>().text;
                    currentRadioImage--;
                }
                break;
            case 6:
                if (currentRadioImage == 0)
                {
                    seventhRadioImage[currentRadioImage].SetActive(false);
                    seventhRadioImage[seventhRadioImage.Length - 1].SetActive(true);
                    currentOption = seventhRadioImage[seventhRadioImage.Length - 1].GetComponentInChildren<TextMeshProUGUI>().text;
                    currentRadioImage = seventhRadioImage.Length - 1;
                }
                else
                {
                    seventhRadioImage[currentRadioImage].SetActive(false);
                    seventhRadioImage[currentRadioImage - 1].SetActive(true);
                    currentOption = seventhRadioImage[currentRadioImage - 1].GetComponentInChildren<TextMeshProUGUI>().text;
                    currentRadioImage--;
                }
                break;
            case 7:
                if (currentRadioImage == 0)
                {
                    eigthRadioImage[currentRadioImage].SetActive(false);
                    eigthRadioImage[eigthRadioImage.Length - 1].SetActive(true);
                    currentOption = eigthRadioImage[eigthRadioImage.Length - 1].GetComponentInChildren<TextMeshProUGUI>().text;
                    currentRadioImage = eigthRadioImage.Length - 1;
                }
                else
                {
                    eigthRadioImage[currentRadioImage].SetActive(false);
                    eigthRadioImage[currentRadioImage - 1].SetActive(true);
                    currentOption = eigthRadioImage[currentRadioImage - 1].GetComponentInChildren<TextMeshProUGUI>().text;
                    currentRadioImage--;
                }
                break;
            case 8:
                break;
        }
    }

    public void RadioChangeDown()
    {
        switch (currentRadioItem)
        {
            case 0:
                if (currentRadioImage == firstRadioImage.Length - 1)
                {
                    firstRadioImage[currentRadioImage].SetActive(false);
                    firstRadioImage[0].SetActive(true);
                    currentOption = firstRadioImage[0].GetComponentInChildren<TextMeshProUGUI>().text;
                    currentRadioImage = 0;
                }
                else
                {
                    firstRadioImage[currentRadioImage].SetActive(false);
                    firstRadioImage[currentRadioImage + 1].SetActive(true);
                    currentOption = firstRadioImage[currentRadioImage + 1].GetComponentInChildren<TextMeshProUGUI>().text;
                    currentRadioImage++;
                }
                break;
            case 1:
                if (currentRadioImage == secondRadioImage.Length - 1)
                {
                    secondRadioImage[currentRadioImage].SetActive(false);
                    secondRadioImage[0].SetActive(true);
                    currentOption = secondRadioImage[0].GetComponentInChildren<TextMeshProUGUI>().text;
                    currentRadioImage = 0;
                }
                else
                {
                    secondRadioImage[currentRadioImage].SetActive(false);
                    secondRadioImage[currentRadioImage + 1].SetActive(true);
                    currentOption = secondRadioImage[currentRadioImage + 1].GetComponentInChildren<TextMeshProUGUI>().text;
                    currentRadioImage++;
                }
                break;
            case 2:
                if (currentRadioImage == thirdRadioImage.Length - 1)
                {
                    thirdRadioImage[currentRadioImage].SetActive(false);
                    thirdRadioImage[0].SetActive(true);
                    currentOption = thirdRadioImage[0].GetComponentInChildren<TextMeshProUGUI>().text;
                    currentRadioImage = 0;
                }
                else
                {
                    thirdRadioImage[currentRadioImage].SetActive(false);
                    thirdRadioImage[currentRadioImage + 1].SetActive(true);
                    currentOption = thirdRadioImage[currentRadioImage + 1].GetComponentInChildren<TextMeshProUGUI>().text;
                    currentRadioImage++;
                }
                break;
            case 3:
                if (currentRadioImage == fourthRadioImage.Length - 1)
                {
                    fourthRadioImage[currentRadioImage].SetActive(false);
                    fourthRadioImage[0].SetActive(true);
                    currentOption = fourthRadioImage[0].GetComponentInChildren<TextMeshProUGUI>().text;
                    currentRadioImage = 0;
                }
                else
                {
                    fourthRadioImage[currentRadioImage].SetActive(false);
                    fourthRadioImage[currentRadioImage + 1].SetActive(true);
                    currentOption = fourthRadioImage[currentRadioImage + 1].GetComponentInChildren<TextMeshProUGUI>().text;
                    currentRadioImage++;
                }
                break;
            case 4:
                if (currentRadioImage == fifthRadioImage.Length - 1)
                {
                    fifthRadioImage[currentRadioImage].SetActive(false);
                    fifthRadioImage[0].SetActive(true);
                    currentOption = fifthRadioImage[0].GetComponentInChildren<TextMeshProUGUI>().text;
                    currentRadioImage = 0;
                }
                else
                {
                    fifthRadioImage[currentRadioImage].SetActive(false);
                    fifthRadioImage[currentRadioImage + 1].SetActive(true);
                    currentOption = fifthRadioImage[currentRadioImage + 1].GetComponentInChildren<TextMeshProUGUI>().text;
                    currentRadioImage++;
                }
                break;
            case 5:
                if (currentRadioImage == sithRadioImage.Length - 1)
                {
                    sithRadioImage[currentRadioImage].SetActive(false);
                    sithRadioImage[0].SetActive(true);
                    currentOption = sithRadioImage[0].GetComponentInChildren<TextMeshProUGUI>().text;
                    currentRadioImage = 0;
                }
                else
                {
                    sithRadioImage[currentRadioImage].SetActive(false);
                    sithRadioImage[currentRadioImage + 1].SetActive(true);
                    currentOption = sithRadioImage[currentRadioImage + 1].GetComponentInChildren<TextMeshProUGUI>().text;
                    currentRadioImage++;
                }
                break;
            case 6:
                if (currentRadioImage == seventhRadioImage.Length - 1)
                {
                    seventhRadioImage[currentRadioImage].SetActive(false);
                    seventhRadioImage[0].SetActive(true);
                    currentOption = seventhRadioImage[0].GetComponentInChildren<TextMeshProUGUI>().text;
                    currentRadioImage = 0;
                }
                else
                {
                    seventhRadioImage[currentRadioImage].SetActive(false);
                    seventhRadioImage[currentRadioImage + 1].SetActive(true);
                    currentOption = seventhRadioImage[currentRadioImage + 1].GetComponentInChildren<TextMeshProUGUI>().text;
                    currentRadioImage++;
                }
                break;
            case 7:
                if (currentRadioImage == eigthRadioImage.Length - 1)
                {
                    eigthRadioImage[currentRadioImage].SetActive(false);
                    eigthRadioImage[0].SetActive(true);
                    currentOption = eigthRadioImage[0].GetComponentInChildren<TextMeshProUGUI>().text;
                    currentRadioImage = 0;
                }
                else
                {
                    eigthRadioImage[currentRadioImage].SetActive(false);
                    eigthRadioImage[currentRadioImage + 1].SetActive(true);
                    currentOption = eigthRadioImage[currentRadioImage + 1].GetComponentInChildren<TextMeshProUGUI>().text;
                    currentRadioImage++;
                }
                break;
            case 8:
                break;
        }
    }

    public void ArpChangeNext()
    {
        if (currentArpItem == arpMenuImage.Length - 1)
        {
            ChangeColor(arpMenuImage[currentArpItem], arpMenuText[currentArpItem], arpMenuImage[0], arpMenuText[0]);
            currentArpItem = 0;
        }
        else
        {
            ChangeColor(arpMenuImage[currentArpItem], arpMenuText[currentArpItem], arpMenuImage[currentArpItem + 1], arpMenuText[currentArpItem + 1]);
            currentArpItem++;
        }
    }

    public void ArpChangePrev()
    {
        if (currentArpItem == 0)
        {
            ChangeColor(arpMenuImage[currentArpItem], arpMenuText[currentArpItem], arpMenuImage[arpMenuImage.Length - 1], arpMenuText[arpMenuImage.Length - 1]);
            currentArpItem = arpMenuImage.Length - 1;
        }
        else
        {
            ChangeColor(arpMenuImage[currentArpItem], arpMenuText[currentArpItem], arpMenuImage[currentArpItem - 1], arpMenuText[currentArpItem - 1]);
            currentArpItem--;
        }
    }

    public void ArpEnter()
    {
        switch (currentArpItem)
        {
            case 0:
                DisableLoadMenu();
                arpViewSettings[0].SetActive(true);
                isARP = true;
                arpView = true;
                break;
            case 1:
                DisableLoadMenu();
                arpConfigSetting.SetActive(true);
                isARP = true;
                arpConfig = true;
                break;
        }
    }

    public void ArpViewChange()
    {
        if (currentViewItem != 3)
        {
            arpViewSettings[currentViewItem].SetActive(false);
            arpViewSettings[currentViewItem + 1].SetActive(true);
            currentViewItem++;
        }
        else
        {
            DisableLoadMenu();
            currentViewItem = 0;
            settingMenu[0].SetActive(true);
            Global.inSettingMenu = true;
        }
    }

    public void ArpConfigChange()
    {
        DisableLoadMenu();
        currentViewItem = 0;
        settingMenu[0].SetActive(true);
        Global.inSettingMenu = true;
    }

    public void ArpConfigChangeUp()
    {
        if (currentViewItem == 0)
        {
            arpConfigImage[currentViewItem].SetActive(false);
            arpConfigImage[arpConfigImage.Length - 1].SetActive(true);
            currentViewItem = arpConfigImage.Length - 1;
        }
        else
        {
            arpConfigImage[currentViewItem].SetActive(false);
            arpConfigImage[currentViewItem - 1].SetActive(true);
            currentViewItem--;
        }
    }

    public void ArpConfigChangeDown()
    {
        if (currentViewItem == arpConfigImage.Length - 1)
        {
            arpConfigImage[currentViewItem].SetActive(false);
            arpConfigImage[0].SetActive(true);
            currentViewItem = 0;
        }
        else
        {
            arpConfigImage[currentViewItem].SetActive(false);
            arpConfigImage[currentViewItem + 1].SetActive(true);
            currentViewItem++;
        }
    }

    public void CLRPress()
    {
        DisableLoadMenu();
        loadMenu[3].SetActive(true);
    }

    public void TestChangeNext()
    {
        if (currentTestItem == testSettingMenuImage.Length - 1)
        {
            ChangeColor(testSettingMenuImage[currentTestItem], testSettingMenuText[currentTestItem], testSettingMenuImage[0], testSettingMenuText[0]);
            currentTestItem = 0;
        }
        else
        {
            ChangeColor(testSettingMenuImage[currentTestItem], testSettingMenuText[currentTestItem], testSettingMenuImage[currentTestItem + 1], testSettingMenuText[currentTestItem + 1]);
            currentTestItem++;
        }
    }

    public void TestChangePrev()
    {
        if (currentTestItem == 0)
        {
            ChangeColor(testSettingMenuImage[currentTestItem], testSettingMenuText[currentTestItem], testSettingMenuImage[testSettingMenuImage.Length - 1], testSettingMenuText[testSettingMenuImage.Length - 1]);
            currentTestItem = testSettingMenuImage.Length - 1;
        }
        else
        {
            ChangeColor(testSettingMenuImage[currentTestItem], testSettingMenuText[currentTestItem], testSettingMenuImage[currentTestItem - 1], testSettingMenuText[currentTestItem - 1]);
            currentTestItem--;
        }
    }

    public void EnterTestSetting()
    {
        switch (currentTestItem)
        {
            case 0:
                DisableLoadMenu();
                bitTest.SetActive(true);
                isBit = true;
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                break;
        }
    }

    public void TestBitSettingUp()
    {
        if (currentTestBitItem == 0)
        {
            bitTestMode[currentTestBitItem].SetActive(false);
            bitTestMode[bitTestMode.Length - 1].SetActive(true);
            currentTestBitItem = bitTestMode.Length - 1;
        }
        else
        {
            bitTestMode[currentTestBitItem].SetActive(false);
            bitTestMode[currentTestBitItem - 1].SetActive(true);
            currentTestBitItem--;
        }
    }

    public void TestBitSettingDown()
    {
        if (currentTestBitItem == bitTestMode.Length - 1)
        {
            bitTestMode[currentTestBitItem].SetActive(false);
            bitTestMode[0].SetActive(true);
            currentTestBitItem = 0;
        }
        else
        {
            bitTestMode[currentTestBitItem].SetActive(false);
            bitTestMode[currentTestBitItem + 1].SetActive(true);
            currentTestBitItem++;
        }
    }

    public void TestPassed()
    {
        DisableLoadMenu();
        testInProgress[1].SetActive(true);
        isTest = false;
        isBit = false;
        inSettingMenu = true;
    }

    public void ChangeColor(Image currentImage, TextMeshProUGUI currentText, Image nextImage, TextMeshProUGUI nextText)
    {
        currentImage.color = greenLight;
        currentText.color = blackLight;
        nextImage.color = blackLight;
        nextText.color = greenLight;
        currentOption = nextText.text;
        Debug.Log(currentOption);
    }
}

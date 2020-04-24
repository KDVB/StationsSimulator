using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Global : MonoBehaviour
{

    public static bool isLesson = false;
    public static int currentTask = 0;

    public static string path = @"C:\Users\KDVB\Desktop\Harris RF-7800";
    public static string testPath = @"C:\Users\KDVB\Desktop\Tests";

    public static string currentOption = "";

    public static Dictionary<string, string> keyValues = new Dictionary<string, string>();
    public static Dictionary<string, string> currentTasks = new Dictionary<string, string>();

    public static GameObject taskArrow;
    public static float arrowPosition;
    public static bool isCouplerIn = false;

    public static int currentStation = 0;
    public GameObject[] stations;
    public GameObject[] stationsModel;

    public static string currentMode = "";
    public static bool modeSwitch = false;
    public static bool isLoad = false;
    public static bool inSettingMenu = false;
    public static bool isTurn = false;
    public static bool exitAcc = false;

    public static bool isTod = false;
    public static bool isRadio = false;
    public static bool isScan = false;
    public static bool isARP = false;
    public static bool isAcc = false;
    public static bool arpView = false;
    public static bool arpConfig = false;
    public static bool isTest = false;
    public static bool isBit = false;

    public static string txLevel = "";
    public static string squelchLevel = "";
    public static string fm = "";
    public static string internalCoupler = "";
    public static string radioSilence = "";
    public static string bfo = "";
    public static string rxNoise = "";
    public static string radioLock = "";

    public static List<TextMeshProUGUI> tasks = new List<TextMeshProUGUI>(); 

    public static float timeLoad = 0f;

    public GameObject[] loadMenu = new GameObject[4];

    public GameObject[] settingMenu = new GameObject[2];
    public TextMeshProUGUI[] menuItems = new TextMeshProUGUI[7];
    public Image[] menuImages = new Image[7];

    public GameObject Gps;
    public GameObject[] radioSettings = new GameObject[9];
    public GameObject scanSetting;
    public GameObject arpSetting;
    public Image[] arpMenuImage = new Image[2];
    public TextMeshProUGUI[] arpMenuText = new TextMeshProUGUI[2];
    public GameObject[] arpViewSettings = new GameObject[4];
    public GameObject arpConfigSetting;
    public GameObject[] extSetting = new GameObject[4];

    public GameObject[] arpConfigImage = new GameObject[2];

    public GameObject[] firstRadioImage = new GameObject[3];
    public GameObject[] secondRadioImage = new GameObject[3];
    public GameObject[] thirdRadioImage = new GameObject[2];
    public GameObject[] fourthRadioImage = new GameObject[2];
    public GameObject[] fifthRadioImage = new GameObject[2];
    public GameObject[] sithRadioImage = new GameObject[3];
    public GameObject[] seventhRadioImage = new GameObject[2];
    public GameObject[] eigthRadioImage = new GameObject[2];

    public GameObject[] scanImage = new GameObject[2];

    public GameObject testSetting;
    public Image[] testSettingMenuImage = new Image[6];
    public TextMeshProUGUI[] testSettingMenuText = new TextMeshProUGUI[6];

    public GameObject bitTest;
    public GameObject[] bitTestMode = new GameObject[7];
    public GameObject[] testInProgress = new GameObject[3];

    public static int currentAccWindow = 0;
    public static int currentTestBitItem = 0;
    public static int currentTestItem = 0;
    public static int currentArpItem = 0;
    public static int currentViewItem = 0;
    public int currentScanImage = 0;
    public int currentRadioImage = 0;
    public static int currentRadioItem = 0;
    public static int currentMenuItem = 0;

    public Color32 greenLight = new Color32(136, 196, 0, 255);
    public Color32 blackLight = new Color32(40, 40, 40, 255);
    public static Color32 currentTaskColor = new Color32(158, 231, 74, 255);
    public static Color32 finishedTaskColor = new Color32(130, 130, 130, 255);

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


    // Start is called before the first frame update
    void Start()
    {
        currentMode = "OFF";
        keyValues.Add("isCouplerIn", "Підключити антену");
        keyValues.Add("isTurn","Ввімкнути станцію");
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

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void DisableLoadMenu()
    {
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

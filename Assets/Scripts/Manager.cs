using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Manager : MonoBehaviour
{
    [SerializeField] private AudioSource audiosource;
    [SerializeField] private AudioClip HrustClip;
    [SerializeField] private AudioClip sellAudio;
    public int money = 0;
    public int BakedCookied = 0;
    public int IsNewGame;
    public float TimeBake;

    [SerializeField] private bool timeRunning;

    [SerializeField] private int clicks;


    public bool TwoClickAbilka = false;
    public bool AutoClickAbilka = false;

    [SerializeField] private GameObject PanelTimer;

    [SerializeField]public Text bakedcookie;
    [SerializeField] public Text moneybaker;
    [SerializeField] public Text BakeTimeText;
    [SerializeField] public GameObject NewGamePanel;
    [SerializeField] public GameObject Text;
    [SerializeField] public GameObject MainPanel;
    private void Start()
    {
        IsNewGame = PlayerPrefs.GetInt("IsNewGame",1);
        if(IsNewGame == 1)
        {
            NewGamePanel.SetActive(true);
            MainPanel.SetActive(false);
            Text.SetActive(false);
        }
        else
        {
            NewGamePanel.SetActive(false);
            MainPanel.SetActive(true);
            Text.SetActive(true);
        }
        money = PlayerPrefs.GetInt("_money",0); 
        BakedCookied = PlayerPrefs.GetInt("BakedCookied", 0);
        moneybaker.text = "Бюджет:" + money.ToString();
        bakedcookie.text = "Печений приготовлено:" + BakedCookied.ToString();
        DontDestroyOnLoad(this);
    }
    private void Update()
    {
        if(AutoClickAbilka == true)
        {
            StartCoroutine(AutoClick());
            AutoClickAbilka = false;
        }
    }
    public void Sell()
    {
        if(BakedCookied != 0)
        {
            audiosource.PlayOneShot(sellAudio);
            money += BakedCookied;
            BakedCookied -= BakedCookied;
            PlayerPrefs.SetInt("BakedCookied", BakedCookied);
            PlayerPrefs.SetInt("_money", money);
            moneybaker.text = "Бюджет:" + money.ToString();
            bakedcookie.text = "Печений приготовлено:" + BakedCookied.ToString();
        }
    }
    public void BakeCookie()
    {
            audiosource.PlayOneShot(HrustClip);
            if (TwoClickAbilka == false)
            {
                BakedCookied++;
                bakedcookie.text = "Печений приготовлено:" + BakedCookied.ToString();
                PlayerPrefs.SetInt("BakedCookied", BakedCookied);
            }
            if (TwoClickAbilka == true)
            {
                BakedCookied += 2;
                bakedcookie.text = "Печений приготовлено:" + BakedCookied.ToString();
                PlayerPrefs.SetInt("BakedCookied", BakedCookied);
            }
    } 

    public void StartGame()
    {
        IsNewGame = 0;
        NewGamePanel.SetActive(false);
        PlayerPrefs.SetInt("IsNewGame", IsNewGame);
        MainPanel.SetActive(true);
        Text.SetActive(true);
    }
    public void FreeMoney()
    {
    }
    private void OnApplicationPause(bool pause)
    {
        PlayerPrefs.SetInt("BakedCookied", BakedCookied);
        PlayerPrefs.SetInt("_money", money);
    }

    private void OnApplicationQuit()
    {
        PlayerPrefs.SetInt("BakedCookied", BakedCookied);
        PlayerPrefs.SetInt("_money", money);
    }
    public void Rebith()
    {
        money = 0;
        BakedCookied = 0;
        PlayerPrefs.DeleteKey("_money");
        PlayerPrefs.DeleteKey("IsNewGame");
        PlayerPrefs.DeleteKey("BakedCookied");
        moneybaker.text = "Бюджет:" + money.ToString();
        bakedcookie.text = "Печений приготовлено:" + BakedCookied.ToString();
    }

   public IEnumerator AutoClick()
    {
        yield return new WaitForSeconds(1);
        BakedCookied++;
        bakedcookie.text = "Печений приготовлено:" + BakedCookied.ToString();
        PlayerPrefs.SetInt("BakedCookied", BakedCookied);
        yield return new WaitForSeconds(1);
        BakedCookied++;
        bakedcookie.text = "Печений приготовлено:" + BakedCookied.ToString();
        PlayerPrefs.SetInt("BakedCookied", BakedCookied);
        yield return new WaitForSeconds(1);
        BakedCookied++;
        bakedcookie.text = "Печений приготовлено:" + BakedCookied.ToString();
        PlayerPrefs.SetInt("BakedCookied", BakedCookied);
        yield return new WaitForSeconds(1);
        BakedCookied++;
        bakedcookie.text = "Печений приготовлено:" + BakedCookied.ToString();
        PlayerPrefs.SetInt("BakedCookied", BakedCookied);
        yield return new WaitForSeconds(1);
        BakedCookied++;
        bakedcookie.text = "Печений приготовлено:" + BakedCookied.ToString();
        PlayerPrefs.SetInt("BakedCookied", BakedCookied);
        yield return new WaitForSeconds(1);
        BakedCookied++;
        bakedcookie.text = "Печений приготовлено:" + BakedCookied.ToString();
        PlayerPrefs.SetInt("BakedCookied", BakedCookied);
        yield return new WaitForSeconds(1);
        BakedCookied++;
        bakedcookie.text = "Печений приготовлено:" + BakedCookied.ToString();
        PlayerPrefs.SetInt("BakedCookied", BakedCookied);
        yield return new WaitForSeconds(1);
        BakedCookied++;
        bakedcookie.text = "Печений приготовлено:" + BakedCookied.ToString();
        PlayerPrefs.SetInt("BakedCookied", BakedCookied);
        yield return new WaitForSeconds(1);
        BakedCookied++;
        bakedcookie.text = "Печений приготовлено:" + BakedCookied.ToString();
        PlayerPrefs.SetInt("BakedCookied", BakedCookied);
        yield return new WaitForSeconds(1);
        BakedCookied++;
        bakedcookie.text = "Печений приготовлено:" + BakedCookied.ToString();
        PlayerPrefs.SetInt("BakedCookied", BakedCookied);
        yield return new WaitForSeconds(1);
        BakedCookied++;
        bakedcookie.text = "Печений приготовлено:" + BakedCookied.ToString();
        PlayerPrefs.SetInt("BakedCookied", BakedCookied);
        yield return new WaitForSeconds(1);
        BakedCookied++;
        bakedcookie.text = "Печений приготовлено:" + BakedCookied.ToString();
        PlayerPrefs.SetInt("BakedCookied", BakedCookied);
        yield return new WaitForSeconds(1);
        BakedCookied++;
        bakedcookie.text = "Печений приготовлено:" + BakedCookied.ToString();
        PlayerPrefs.SetInt("BakedCookied", BakedCookied);
        yield return new WaitForSeconds(1);
        BakedCookied++;
        bakedcookie.text = "Печений приготовлено:" + BakedCookied.ToString();
        PlayerPrefs.SetInt("BakedCookied", BakedCookied);
        yield return new WaitForSeconds(1);
        BakedCookied++;
        bakedcookie.text = "Печений приготовлено:" + BakedCookied.ToString();
        PlayerPrefs.SetInt("BakedCookied", BakedCookied);
        yield return new WaitForSeconds(1);
        BakedCookied++;
        bakedcookie.text = "Печений приготовлено:" + BakedCookied.ToString();
        PlayerPrefs.SetInt("BakedCookied", BakedCookied);
        yield return new WaitForSeconds(1);
        BakedCookied++;
        bakedcookie.text = "Печений приготовлено:" + BakedCookied.ToString();
        PlayerPrefs.SetInt("BakedCookied", BakedCookied);
        yield return new WaitForSeconds(1);
        BakedCookied++;
        bakedcookie.text = "Печений приготовлено:" + BakedCookied.ToString();
        PlayerPrefs.SetInt("BakedCookied", BakedCookied);
        yield return new WaitForSeconds(1);
        BakedCookied++;
        bakedcookie.text = "Печений приготовлено:" + BakedCookied.ToString();
        PlayerPrefs.SetInt("BakedCookied", BakedCookied);
        yield return new WaitForSeconds(1);
        BakedCookied++;
        bakedcookie.text = "Печений приготовлено:" + BakedCookied.ToString();
        PlayerPrefs.SetInt("BakedCookied", BakedCookied);
        yield return new WaitForSeconds(1);
        BakedCookied++;
        bakedcookie.text = "Печений приготовлено:" + BakedCookied.ToString();
        PlayerPrefs.SetInt("BakedCookied", BakedCookied);
        yield return new WaitForSeconds(1);
        BakedCookied++;
        bakedcookie.text = "Печений приготовлено:" + BakedCookied.ToString();
        PlayerPrefs.SetInt("BakedCookied", BakedCookied);
        yield return new WaitForSeconds(1);
        BakedCookied++;
        bakedcookie.text = "Печений приготовлено:" + BakedCookied.ToString();
        PlayerPrefs.SetInt("BakedCookied", BakedCookied);
        yield return new WaitForSeconds(1);
        BakedCookied++;
        bakedcookie.text = "Печений приготовлено:" + BakedCookied.ToString();
        PlayerPrefs.SetInt("BakedCookied", BakedCookied);
        yield return new WaitForSeconds(1);
        BakedCookied++;
        bakedcookie.text = "Печений приготовлено:" + BakedCookied.ToString();
        PlayerPrefs.SetInt("BakedCookied", BakedCookied);
        yield return new WaitForSeconds(1);
        BakedCookied++;
        bakedcookie.text = "Печений приготовлено:" + BakedCookied.ToString();
        PlayerPrefs.SetInt("BakedCookied", BakedCookied);
        yield return new WaitForSeconds(1);
        BakedCookied++;
        bakedcookie.text = "Печений приготовлено:" + BakedCookied.ToString();
        PlayerPrefs.SetInt("BakedCookied", BakedCookied);
        yield return new WaitForSeconds(1);
        BakedCookied++;
        bakedcookie.text = "Печений приготовлено:" + BakedCookied.ToString();
        PlayerPrefs.SetInt("BakedCookied", BakedCookied);
        yield return new WaitForSeconds(1);
        BakedCookied++;
        bakedcookie.text = "Печений приготовлено:" + BakedCookied.ToString();
        PlayerPrefs.SetInt("BakedCookied", BakedCookied);
        yield return new WaitForSeconds(1);
        BakedCookied++;
        AutoClickAbilka = false;

    }


}

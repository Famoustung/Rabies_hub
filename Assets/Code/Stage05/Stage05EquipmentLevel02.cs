using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;
using UnityEngine.UI;
using Slider = UnityEngine.UI.Slider;

public class Stage05EquipmentLevel02 : MonoBehaviour, IDropHandler
{
    public GameObject[] allItem;
    [SerializeField] private Slider imagePower;
    public float amtPower;
    public Image oldImage;
    public Sprite sp1, sp2, sp3, sp4;
    public ScoreManager scoreManager;
    
   
    
    // WaterSet
    [SerializeField] private GameObject alertWater;
    [SerializeField] private GameObject alertSoap;
    [SerializeField] private GameObject textGreen01;
    [SerializeField] private GameObject textGreen01_2;
    [SerializeField] private GameObject textGreen02;
    [SerializeField] private GameObject textGreen03;
    [SerializeField] private GameObject waterSet;
    [SerializeField] private GameObject soapSet,BetadineSet,BandageSet;
    [SerializeField] private GameObject water;
    [SerializeField] private GameObject waterButtom;
    [SerializeField] private int delayWhater;
    [SerializeField] private int delayalert;
    // WaterSet
    
    [SerializeField] GameObject Box;
    [SerializeField] private String A;
    [SerializeField] private String B;
    [SerializeField] private String C;
    [SerializeField] private String D;
    
    private bool stepA = true;
    private bool stepB = false;
    private bool stepC = false;
    private bool stepD = false;
    
    private void Start()
    {
        scoreManager = ScoreManager.Instance;
    }

    public void Update()
    {
        imagePower.value = amtPower; // WaterSet
    }

    //  Soap 2 amtPower DexterWater 1.5 amtPower ==> w = 3 , s = 4 , w = 3 ==> Green End  || เริ่มมาต้องใส่ Water ==> S ==> W ถ้าผิดให้ขึ้นแจ้งเตือนให้ล่างสบู่หรือล่างน้ำก่อนตามลำดับ
    public void onClickSoap()
    {
        soapSet.SetActive(true);
        for (int i = 0; i < allItem.Length; i++)
        {
            allItem[i].SetActive(false);
        }
    }
    public void omClickSoapHand()
    {
        if (amtPower == 0.3f)
        {
            amtPower = 0.5f;
        }
        else if (amtPower == 0.5f)
        {
            amtPower = 0.7f;
            textGreen01_2.SetActive(true);
            oldImage.sprite = sp1; // รูปถูสบู่
        }
        else
        {
            alertWater.SetActive(true);
            StartCoroutine(delayAlert());
            Debug.Log("Use Water");
        }
    }
    // Soap
    
    // WaterSet ---------------------------------------------------------------
    public void onClinkWaterSet()
    {
        waterSet.SetActive(true);
        for (int i = 0; i < allItem.Length; i++)
        {
            allItem[i].SetActive(false);
        }
    }

    public void delaySpay()
    {
        StartCoroutine(delayWhaterSpay());
    }
    public void waterSetGamePlay()
    {
        if (amtPower == 0.0f)
        {
            amtPower = 0.15f;
        }
        else if (amtPower == 0.15f)
        {
            amtPower = 0.3f;
        }
        else if (amtPower == 0.7f)
        {
            amtPower = 0.85f;
        }
        else if (amtPower == 0.85f)
        {
            stepB = false;
            stepC = true;
            amtPower = 1f;
            oldImage.sprite = sp2; // รูปล้างแขนแล้ว
            textGreen01.SetActive(true);
        }
        else
        {
            alertSoap.SetActive(true);
            StartCoroutine(delayAlert());
            Debug.Log("Use Soap");
        }
    }
    public void ClickBetadine()
    {
        BetadineSet.SetActive(true);
        for (int i = 0; i < allItem.Length; i++)
        {
            allItem[i].SetActive(false);
        }
    }
    public void onClickBetadine()
    {
        if (stepC && !stepD)
        {
            Debug.Log("C-Ok = Next");
            oldImage.sprite = sp3;
            scoreManager.plusScoreLevel02();
            textGreen02.SetActive(true);
            stepC = false;
            stepD = true;
        }
        else if (!stepC)
        {
            scoreManager.minusScoreLevel02();
        }
    }
    public void ClickBandage()
    {
        BandageSet.SetActive(true);
        for (int i = 0; i < allItem.Length; i++)
        {
            allItem[i].SetActive(false);
        }
    }
    public void onClickBBandages()
    {
        if (stepD)
        {
            Debug.Log("D-Ok +1");
            Destroy(Box);
            oldImage.sprite = sp4;
            textGreen03.SetActive(true);
            stepD = false;
        }
        else if (!stepD)
        {
            scoreManager.minusScoreLevel02();
        } 

    }


    private IEnumerator delayAlert()
    {
        yield return new WaitForSeconds(delayalert);
        if (alertWater.activeSelf == true)
        {
            alertWater.SetActive(false);
            Debug.Log(alertWater);
        }
        else if (alertSoap.activeSelf == true)
        {
            alertSoap.SetActive(false);
            Debug.Log(alertSoap);
        }
    }
    
    private IEnumerator delayWhaterSpay()
    {
        water.SetActive(true);
        waterButtom.SetActive(false);
        waterSetGamePlay();
        yield return new WaitForSeconds(delayWhater);
        water.SetActive(false);
        waterButtom.SetActive(true);
    }
    // WaterSet ---------------------------------------------------------------
    
    public void OnDrop(PointerEventData eventData)
    {
        GameObject dropped = eventData.pointerDrag;
        DraggabInBox draggabInBox = dropped.GetComponent<DraggabInBox>();
        
        if (dropped.CompareTag(A) && stepA)
        {
            Debug.Log("A-Ok = Next");
            oldImage.sprite = sp1;
            scoreManager.plusScoreLevel02();
            
        }
   
        else if (dropped.CompareTag(B) && stepB && !stepC && !stepD)
        {
            Debug.Log("B-Ok = Next");
            oldImage.sprite = sp2;
            scoreManager.plusScoreLevel02();
            
        }
     
        else if (dropped.CompareTag(C) && stepC && !stepD)
        {
            Debug.Log("C-Ok = Next");
            oldImage.sprite = sp3;
            /*scoreManager.plusScoreLevel02();*/
            textGreen02.SetActive(true);
            stepC = false;
            stepD = true;
        }
        else if (dropped.CompareTag(D) && stepD)
        {
            Debug.Log("D-Ok +1");
            Destroy(Box);
            oldImage.sprite = sp4;
            /*scoreManager.plusScoreLevel02();*/
            textGreen03.SetActive(true);
            stepD = false;
        }
        else if (dropped.CompareTag(D) && !stepD || dropped.CompareTag(B) && !stepB || dropped.CompareTag(C) && !stepC || dropped.CompareTag(A) && !stepA)
        {
            Debug.Log("D-Bug -1");
            scoreManager.minusScoreLevel02();
        }
        else
        {
            Debug.Log("Bug");
        }
    }
}

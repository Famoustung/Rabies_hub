using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Stage6 : MonoBehaviour
{
    public GameObject HOWTOPLAY;
    
    public GameObject WinObj; 
    
    [Header("siling")] 
    public GameObject pass;
    public GameObject fail;
    
    [Header("Text")] 
    public TextMeshProUGUI amountText,WinText;
    
    

    [Header("trigger")] 
    public GameObject trigger;
    public bool Istrigger = false;
    
    
    [Header("amountLeft")] 
    public GameObject[] Medic;
    public int numberDone = 0;
    
    public GameObject box;
    
    public float speed = 0.00002f; // ความเร็วเริ่มต้นของบล็อก
    public float maxSpeed = 0.001f; // ความเร็วสูงสุดของบล็อก
    public float acceleration = 0.000001f; // อัตราเร่งของบล็อก
    public float blockHeight = 0.0f; // ความสูงเริ่มต้นของบล็อก
    public float maxHeight; // ความสูงสูงสุดของบล็อก
    public float barWidth = 0.1f; // ความกว้างของบาร์
    public float barOffset = 0.1f; // ระยะห่างระหว่างบาร์
    public float timeToInject = 1.0f; // ระยะเวลาที่ผู้เล่นต้องกดปุ่มเพื่อฉีดยา
    public float injectionCooldown = 1.0f; // ระยะเวลา cooldown ของการฉีดยา
    public float timeSinceLastInjection = 0.0f; // เวลาที่ผ่านไปตั้งแต่การฉีดยาครั้งล่าสุด
    public bool canInject = true; // 

    public bool isWin,isGameOver = false;
    

    [Header("PowerBar")]  
    public Slider imagePower;
    public float amtPower;
    public float powerSpeed = 1f;
    public bool Isfull = false;
    
    [Header("Button")] 
    public Button stopBtn;
    public bool IsPress = true;
    public Sprite image1,image2;


    private void Start()
    {
        // เริ่มต้นเกม
        maxHeight = 800;
        amtPower = 0f;
        acceleration = acceleration / 5;
        pass.SetActive(false);
        fail.SetActive(false);
        HOWTOPLAY.SetActive(true);
    }

    private void Update()
    {

        amountText.text = "ฉีดไปแล้ว : " + numberDone + " เข็ม";
        
        
        imagePower.value = amtPower;

        if (!HOWTOPLAY.activeInHierarchy)
        {
            if (box.transform.localScale.y <= 0)
            {
                box.transform.localScale = new Vector3(15f, 0.0f, 281.8912f);
            }
        
            ImageSystem();

            if (blockHeight <= 0)
            {
                blockHeight = 0;
            }

            if (numberDone < 5)
            { 
                play();
            
                SliderPlay();
            }
            else if (numberDone == 5)
            {
                stopBtn.enabled = false;
                
                    Win();
                   
                
            }


            if (numberDone < 0)
            {
                numberDone = 0;
            }
 
        }
        
        
       



    }

    public void play()
    {
        // ตรวจสอบว่าบล็อกสูงเกินไปหรือไม่
        if (Istrigger)
        {
            
                // เกมโอเวอร์
                GameOver();
            
        }
        else
        {
            // อัปเดตเกม

            // เพิ่มความสูงของบล็อก
            blockHeight += speed * Time.deltaTime;

            // เร่งความเร็วของบล็อก
            speed += acceleration * Time.deltaTime;
            speed = Mathf.Clamp(speed, 0.0f, maxSpeed);
            // วาดบาร์
            DrawBar(); 
        } 
    }
    
    
    
    
    public void ImageSystem()
    {
        switch (numberDone)
        {
            
            case 1 : Medic[0].SetActive(false);
                break;
            case 2 : Medic[1].SetActive(false); 
                break;
            case 3 : Medic[2].SetActive(false);
                break;
            case 4 : Medic[3].SetActive(false);
                break;
            case 5:
                Medic[4].SetActive(false);
                break;
        }
    }

    public void Inject()
    {
        // ลดความสูงของบล็อก
        blockHeight -= 0.003f;
        box.transform.localScale -= new Vector3(0, 10.0f, 0);

      

    }
    
    public void BottonDwn()
    {
        
        
        IsPress = true;
        
        if (IsPress)
        {
            stopBtn.interactable = false;
            stopBtn.GetComponent<Image>().sprite = image2;
            StartCoroutine(BtnDelay());
            
        }
        
        
        if (IsPress)
        {
            
            if (amtPower >= 0f && amtPower < 0.3f)
            {
                
                //  Score indicator = Instantiate(MinusScoreText, transform.position, Quaternion.identity).GetComponent<Score>();
                //  score -= 10;
                box.transform.localScale += new Vector3(0, 2.0f, 0);
                Medic[numberDone].SetActive(false); 
                StartCoroutine(WaitOneSecond());
              
                acceleration += 0.0001f/5;
                SoundManager.Instance.PlaySound(SoundType.fail, false);
                Debug.Log("fail");
                
                IsPress = false; 
                
                fail.SetActive(true);
                StartCoroutine(animationFail());
               
            }
            
            if (amtPower >= 0.31f && amtPower < 0.6f)
            {
                
             
             //   Score indicator = Instantiate(ScoreText, transform.position, Quaternion.identity).GetComponent<Score>(); 
             //   score += 10; 
             //   i++;
                acceleration -= 0.00005f;
                numberDone++;
                Inject();
                SoundManager.Instance.PlaySound(SoundType.correct, false);
                Debug.Log("pass");
                IsPress = false; 
                pass.SetActive(true);
                StartCoroutine(animationPass()); 
                 
            }

            if (amtPower > 0.61f && amtPower <= 0.99f)
            {
                
                
                //  Score indicator = Instantiate(MinusScoreText, transform.position, Quaternion.identity).GetComponent<Score>();
                //  score -= 10;
                box.transform.localScale += new Vector3(0, 2.0f, 0);
                Medic[numberDone].SetActive(false); 
                StartCoroutine(WaitOneSecond());
                SoundManager.Instance.PlaySound(SoundType.fail, false);
                acceleration += 0.0001f/5;
                Debug.Log("fail");
                IsPress = false;
                fail.SetActive(true);
                StartCoroutine(animationFail()); 
                
            } 
        }
    }

    private void DrawBar()
    {
        box.transform.localScale += new Vector3(0, blockHeight, 0);
    }

    private void GameOver()
    {
        if (!trigger.gameObject.activeInHierarchy)
        {
            SoundManager.Instance.PlaySound(SoundType.game_over, false);
        }
        trigger.SetActive(true);
        Debug.Log("Game Over!");
        
    }

    private void Win()
    {
        if (!WinObj.gameObject.activeInHierarchy)
        {
            SoundManager.Instance.PlaySound(SoundType.victory, false);
        }
        WinObj.SetActive(true);
        
        Debug.Log("Win");

    }
    
    void SliderPlay()
    {
        if (!Isfull)
        {
            amtPower += Time.deltaTime * powerSpeed;
            if (amtPower >= 1f)
            {
                Isfull = true;
                
            } 
        }
        else if (Isfull)
        {
            amtPower -= Time.deltaTime * powerSpeed; 
            if (amtPower <= 0.0f )
            {
                Isfull = false;
                        
            }
        } 
    }
    IEnumerator WaitOneSecond()
    {
        
        
        
        yield return new WaitForSeconds(1.0f);
        
        Medic[numberDone].SetActive(true);
        
        
    }
    IEnumerator BtnDelay()
    {
        
        
        
        yield return new WaitForSeconds(1.5f);
        stopBtn.interactable = true ;
        stopBtn.GetComponent<Image>().sprite = image1;


    }

    IEnumerator animationFail()
    {
        yield return new WaitForSeconds(1.8f);
        fail.SetActive(false);
    }

    IEnumerator animationPass()
    {
        yield return new WaitForSeconds(1.4f);
        pass.SetActive(false);
    }
    
}


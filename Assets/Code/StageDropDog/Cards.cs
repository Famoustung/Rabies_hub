using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cards : MonoBehaviour
{

    

    [Header("CardsInfo")] 
    public int CardsNumber;
    
    private bool isDragging;
    private Vector3 initialPosition;
    private GameManager2 gameManager2;
    private Vector3 place;
    [Header("Indicator")]
    public GameObject ScoreText;
    public GameObject MinusScoreText;
    public GameManager2 Game;
    private bool isCardOverCollider = false;
    public Image spriteRenderer1, spriteRenderer2, spriteRenderer3, spriteRenderer4, spriteRenderer5, spriteRenderer6,imagee;
    public GameObject Indicator1, Indicator2, Indicator3, Indicator4, Indicator5, Indicator6;
    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;

          spriteRenderer1.GetComponent<Image>().color = new Color32(255,255,225,70);
          spriteRenderer2.GetComponent<Image>().color = new Color32(255, 255, 225, 70);
        spriteRenderer3.GetComponent<Image>().color = new Color32(255, 255, 255, 70);
        spriteRenderer4.GetComponent<Image>().color = new Color32(255, 255, 225, 70);
        spriteRenderer5.GetComponent<Image>().color = new Color32(255, 255, 225, 70);
        spriteRenderer6.GetComponent<Image>().color = new Color32(255, 255, 225, 70);

        Indicator1.SetActive(false);
        Indicator2.SetActive(false); 
        Indicator3.SetActive(false);
        Indicator4.SetActive(false);
        Indicator5.SetActive(false);
        Indicator6.SetActive(false);

        // Game = GetComponent<GameManager2>();

        /* Game.minus1();
         Game.minus2();
         Game.minus3();
         Game.minus4();
         Game.minus5();
         Game.minus6();*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnMouseDown()
    {
        if (!isDragging)
        {
            isDragging = true;
        }
        Indicator1.SetActive(true);
        Indicator2.SetActive(true);
        Indicator3.SetActive(true);
        Indicator4.SetActive(true);
        Indicator5.SetActive(true);
        Indicator6.SetActive(true);
    }

    private void OnMouseDrag()
    {
        if (isDragging)
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(mousePosition.x, mousePosition.y, transform.position.z);

            Indicator1.SetActive(true);
            Indicator2.SetActive(true);
            Indicator3.SetActive(true);
            Indicator4.SetActive(true);
            Indicator5.SetActive(true);
            Indicator6.SetActive(true);




        }
    }

    private void OnMouseUp()
    {
        if (isDragging)
        {
            isDragging = false;

            // Check if the object is within the drop area
           // StartCoroutine(WaitForFunction());
            if (Input.GetMouseButtonUp(0) && isCardOverCollider)
            {
                isCardOverCollider = false;
                spriteRenderer1.GetComponent<Image>().color = new Color32(255, 255, 225, 70);
                spriteRenderer2.GetComponent<Image>().color = new Color32(255, 255, 225, 70);
                spriteRenderer3.GetComponent<Image>().color = new Color32(255, 255, 255, 70);
                spriteRenderer4.GetComponent<Image>().color = new Color32(255, 255, 225, 70);
                spriteRenderer5.GetComponent<Image>().color = new Color32(255, 255, 225, 70);
                spriteRenderer6.GetComponent<Image>().color = new Color32(255, 255, 225, 70);
            }
            Indicator1.SetActive(false);
            Indicator2.SetActive(false);
            Indicator3.SetActive(false);
            Indicator4.SetActive(false);
            Indicator5.SetActive(false);
            Indicator6.SetActive(false);

        }
            
        }
    
    IEnumerator WaitForFunction()
    {
        yield return new WaitForSeconds(0);
        initialPosition = transform.position;
        this.transform.position = initialPosition;
    }

    private void OnTriggerStay(Collider other)
    {



        if (other.gameObject.tag == "Choice1")
        {
            isCardOverCollider = true;
            spriteRenderer1.GetComponent<Image>().color = new Color32(255, 0, 0, 70);
            spriteRenderer2.GetComponent<Image>().color = new Color32(255, 255, 225, 70);
            spriteRenderer3.GetComponent<Image>().color = new Color32(255, 255, 255, 70);
            spriteRenderer4.GetComponent<Image>().color = new Color32(255, 255, 225, 70);
            spriteRenderer5.GetComponent<Image>().color = new Color32(255, 255, 225, 70);
            spriteRenderer6.GetComponent<Image>().color = new Color32(255, 255, 225, 70);

          
        }
        if (other.gameObject.tag == "Choice2")
        {
            isCardOverCollider = true;
            spriteRenderer2.GetComponent<Image>().color = new Color32(255, 0, 0, 70);
            spriteRenderer1.GetComponent<Image>().color = new Color32(255, 255, 225, 70);
          
            spriteRenderer3.GetComponent<Image>().color = new Color32(255, 255, 255, 70);
            spriteRenderer4.GetComponent<Image>().color = new Color32(255, 255, 225, 70);
            spriteRenderer5.GetComponent<Image>().color = new Color32(255, 255, 225, 70);
            spriteRenderer6.GetComponent<Image>().color = new Color32(255, 255, 225, 70);

        }
        if (other.gameObject.tag == "Choice3")
        {
            isCardOverCollider = true;
            spriteRenderer3.GetComponent<Image>().color = new Color32(255, 0, 0, 70);
            spriteRenderer1.GetComponent<Image>().color = new Color32(255, 255, 225, 70);
            spriteRenderer2.GetComponent<Image>().color = new Color32(255, 255, 225, 70);
   
            spriteRenderer4.GetComponent<Image>().color = new Color32(255, 255, 225, 70);
            spriteRenderer5.GetComponent<Image>().color = new Color32(255, 255, 225, 70);
            spriteRenderer6.GetComponent<Image>().color = new Color32(255, 255, 225, 70);

            
        }
        if (other.gameObject.tag == "Choice4")
        {
            isCardOverCollider = true;
            spriteRenderer4.GetComponent<Image>().color = new Color32(255, 0, 0, 70);
            spriteRenderer1.GetComponent<Image>().color = new Color32(255, 255, 225, 70);
            spriteRenderer2.GetComponent<Image>().color = new Color32(255, 255, 225, 70);
            spriteRenderer3.GetComponent<Image>().color = new Color32(255, 255, 255, 70);
           
            spriteRenderer5.GetComponent<Image>().color = new Color32(255, 255, 225, 70);
            spriteRenderer6.GetComponent<Image>().color = new Color32(255, 255, 225, 70);

           
        }
        if (other.gameObject.tag == "Choice5")
        {
            isCardOverCollider = true;
            spriteRenderer5.GetComponent<Image>().color = new Color32(255, 0, 0, 70);
            spriteRenderer1.GetComponent<Image>().color = new Color32(255, 255, 225, 70);
            spriteRenderer2.GetComponent<Image>().color = new Color32(255, 255, 225, 70);
            spriteRenderer3.GetComponent<Image>().color = new Color32(255, 255, 255, 70);
            spriteRenderer4.GetComponent<Image>().color = new Color32(255, 255, 225, 70);
        
            spriteRenderer6.GetComponent<Image>().color = new Color32(255, 255, 225, 70);

           
        }
        if (other.gameObject.tag == "Choice6")
        {
            isCardOverCollider = true;
            spriteRenderer6.GetComponent<Image>().color = new Color32(255, 0, 0, 70);
            spriteRenderer1.GetComponent<Image>().color = new Color32(255, 255, 225, 70);
            spriteRenderer2.GetComponent<Image>().color = new Color32(255, 255, 225, 70);
            spriteRenderer3.GetComponent<Image>().color = new Color32(255, 255, 255, 70);
            spriteRenderer4.GetComponent<Image>().color = new Color32(255, 255, 225, 70);
            spriteRenderer5.GetComponent<Image>().color = new Color32(255, 255, 225, 70);
          
            
        }


        if (!isDragging)
        {
            if (other.gameObject.tag == "Choice1")
            {


                // ScoreIndicator indicator = Instantiate(damageText, transform.position, Quaternion.identity).GetComponent<ScoreIndicator>();
                // indicator.SetDamageText(20);
                gameManager2 = GameObject.Find("GameManager").GetComponent<GameManager2>();
                if (gameManager2 == GameObject.Find("GameManager").GetComponent<GameManager2>())
                {
                    gameManager2.RandomCard();
                }


                this.gameObject.SetActive(false);
                transform.position = initialPosition;
                Debug.Log("Cage add score");

                if (CardsNumber == 1)
                {
                    gameManager2.AddScore(20);
                    SoundManager.Instance.PlaySound(SoundType.correct, false);
                    Score indicator1 = Instantiate(ScoreText, initialPosition, Quaternion.identity).GetComponent<Score>();
                    Game.minus1();
                }
                else
                {
                    gameManager2.AddScore(-20);
                    SoundManager.Instance.PlaySound(SoundType.wrong, false);
                    Score indicator2 = Instantiate(MinusScoreText, initialPosition, Quaternion.identity).GetComponent<Score>();
                }



                // indicator1 = GameObject.Find("indicator1").GetComponent<SpriteRenderer>();
                //indicator2 = GameObject.Find("indicator2").GetComponent<SpriteRenderer>();

                // indicator1.enabled = false;
                //indicator2.enabled = false;
            }
            if (other.gameObject.tag == "Choice2")
            {


                // ScoreIndicator indicator = Instantiate(damageText, transform.position, Quaternion.identity).GetComponent<ScoreIndicator>();
                // indicator.SetDamageText(20);
                gameManager2 = GameObject.Find("GameManager").GetComponent<GameManager2>();
                if (gameManager2 == GameObject.Find("GameManager").GetComponent<GameManager2>())
                {
                    gameManager2.RandomCard();
                }


                this.gameObject.SetActive(false);
                transform.position = initialPosition;
                Debug.Log("Cage add score");

                if (CardsNumber == 2)
                {
                    gameManager2.AddScore(20);
                    SoundManager.Instance.PlaySound(SoundType.correct, false);
                    Score indicator1 = Instantiate(ScoreText, initialPosition, Quaternion.identity).GetComponent<Score>();
                    Game.minus2();
                }
                else
                {
                    gameManager2.AddScore(-20);
                    SoundManager.Instance.PlaySound(SoundType.wrong, false);
                    Score indicator2 = Instantiate(MinusScoreText, initialPosition, Quaternion.identity)
                        .GetComponent<Score>();

                }

                // indicator1 = GameObject.Find("indicator1").GetComponent<SpriteRenderer>();
                //indicator2 = GameObject.Find("indicator2").GetComponent<SpriteRenderer>();

                // indicator1.enabled = false;
                //indicator2.enabled = false;
            }
            if (other.gameObject.tag == "Choice3")
            {


                // ScoreIndicator indicator = Instantiate(damageText, transform.position, Quaternion.identity).GetComponent<ScoreIndicator>();
                // indicator.SetDamageText(20);
                gameManager2 = GameObject.Find("GameManager").GetComponent<GameManager2>();
                if (gameManager2 == GameObject.Find("GameManager").GetComponent<GameManager2>())
                {
                    gameManager2.RandomCard();
                }


                this.gameObject.SetActive(false);
                transform.position = initialPosition;
                Debug.Log("Cage add score");

                if (CardsNumber == 3)
                {
                    gameManager2.AddScore(20);
                    SoundManager.Instance.PlaySound(SoundType.correct, false);
                    Score indicator1 = Instantiate(ScoreText, initialPosition, Quaternion.identity).GetComponent<Score>();
                    Game.minus3();
                }
                else
                {
                    gameManager2.AddScore(-20);
                    SoundManager.Instance.PlaySound(SoundType.wrong, false);
                    Score indicator2 = Instantiate(MinusScoreText, initialPosition, Quaternion.identity)
                        .GetComponent<Score>();

                }

                // indicator1 = GameObject.Find("indicator1").GetComponent<SpriteRenderer>();
                //indicator2 = GameObject.Find("indicator2").GetComponent<SpriteRenderer>();

                // indicator1.enabled = false;
                //indicator2.enabled = false;
            }
            if (other.gameObject.tag == "Choice4")
            {


                // ScoreIndicator indicator = Instantiate(damageText, transform.position, Quaternion.identity).GetComponent<ScoreIndicator>();
                // indicator.SetDamageText(20);
                gameManager2 = GameObject.Find("GameManager").GetComponent<GameManager2>();
                if (gameManager2 == GameObject.Find("GameManager").GetComponent<GameManager2>())
                {
                    gameManager2.RandomCard();
                }


                this.gameObject.SetActive(false);
                transform.position = initialPosition;
                Debug.Log("Cage add score");

                if (CardsNumber == 4)
                {
                    gameManager2.AddScore(20);
                    SoundManager.Instance.PlaySound(SoundType.correct, false);
                    Score indicator1 = Instantiate(ScoreText, initialPosition, Quaternion.identity).GetComponent<Score>();
                    Game.minus4();
                }
                else
                {
                    gameManager2.AddScore(-20);
                    SoundManager.Instance.PlaySound(SoundType.wrong, false);
                    Score indicator2 = Instantiate(MinusScoreText, initialPosition, Quaternion.identity)
                        .GetComponent<Score>();


                }
                // indicator1 = GameObject.Find("indicator1").GetComponent<SpriteRenderer>();
                //indicator2 = GameObject.Find("indicator2").GetComponent<SpriteRenderer>();

                // indicator1.enabled = false;
                //indicator2.enabled = false;
            }

            if (other.gameObject.tag == "Choice5")
            {


                // ScoreIndicator indicator = Instantiate(damageText, transform.position, Quaternion.identity).GetComponent<ScoreIndicator>();
                // indicator.SetDamageText(20);
                gameManager2 = GameObject.Find("GameManager").GetComponent<GameManager2>();
                if (gameManager2 == GameObject.Find("GameManager").GetComponent<GameManager2>())
                {
                    gameManager2.RandomCard();
                }


                this.gameObject.SetActive(false);
                transform.position = initialPosition;
                Debug.Log("Cage add score");

                if (CardsNumber == 5)
                {
                    gameManager2.AddScore(20);
                    SoundManager.Instance.PlaySound(SoundType.correct, false);
                    Score indicator1 = Instantiate(ScoreText, initialPosition, Quaternion.identity).GetComponent<Score>();
                    Game.minus5();
                }
                else
                {
                    gameManager2.AddScore(-20);
                    SoundManager.Instance.PlaySound(SoundType.wrong, false);
                    Score indicator2 = Instantiate(MinusScoreText, initialPosition, Quaternion.identity)
                            .GetComponent<Score>();

                }

                // indicator1 = GameObject.Find("indicator1").GetComponent<SpriteRenderer>();
                //indicator2 = GameObject.Find("indicator2").GetComponent<SpriteRenderer>();

                // indicator1.enabled = false;
                //indicator2.enabled = false;
            }

            if (other.gameObject.tag == "Choice6")
            {


                // ScoreIndicator indicator = Instantiate(damageText, transform.position, Quaternion.identity).GetComponent<ScoreIndicator>();
                // indicator.SetDamageText(20);
                gameManager2 = GameObject.Find("GameManager").GetComponent<GameManager2>();
                if (gameManager2 == GameObject.Find("GameManager").GetComponent<GameManager2>())
                {
                    gameManager2.RandomCard();
                }


                this.gameObject.SetActive(false);
                transform.position = initialPosition;
                Debug.Log("Cage add score");

                if (CardsNumber == 6)
                {
                    gameManager2.AddScore(20);
                    SoundManager.Instance.PlaySound(SoundType.correct, false);
                    Score indicator1 = Instantiate(ScoreText, initialPosition, Quaternion.identity).GetComponent<Score>();
                    Game.minus6();
                }
                else
                {
                    gameManager2.AddScore(-20);
                    SoundManager.Instance.PlaySound(SoundType.wrong, false);
                    Score indicator2 = Instantiate(MinusScoreText, initialPosition, Quaternion.identity)
                                .GetComponent<Score>();

                }

                // indicator1 = GameObject.Find("indicator1").GetComponent<SpriteRenderer>();
                //indicator2 = GameObject.Find("indicator2").GetComponent<SpriteRenderer>();

                // indicator1.enabled = false;
                //indicator2.enabled = false;
            }

        }
            
        }
}

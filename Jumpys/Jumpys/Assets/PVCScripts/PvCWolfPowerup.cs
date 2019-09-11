using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PvCWolfPowerup : MonoBehaviour {

    private PvCWolfMovement script;
    private PvCCharacterController2D script2;

    public Slider slider;

    public GameObject sheild;
    public GameObject sheildText;
    public GameObject speedText;
    public GameObject jumpText;

    private bool powerUp;

    private void Start()
    {
        script = GetComponent<PvCWolfMovement>();
        script2 = GetComponent<PvCCharacterController2D>();
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "speedBoost")
        {
            if (!powerUp)
            {
                script.runSpeed += 30;
                speedText.SetActive(true);
                Destroy(coll.gameObject);
                powerUp = true;
                StartCoroutine(SpeedBoost());
                StartCoroutine(TextFade());
            }          
        }

        if (coll.gameObject.tag == "sheild")
        {
            if (!powerUp)
            {
                script.isSheild = true;
                sheildText.SetActive(true);
                sheild.SetActive(true);
                Destroy(coll.gameObject);
                powerUp = true;
                StartCoroutine(Sheild());
                StartCoroutine(TextFade());
            }
        }
        if (coll.gameObject.tag == "jump")
        {
            if (!powerUp)
            {
                script2.m_JumpForce = 1000;
                jumpText.SetActive(true);
                Destroy(coll.gameObject);
                powerUp = true;
                StartCoroutine(Jump());
                StartCoroutine(TextFade());
            }
        }
    }

    private void Update()
    {
        if (powerUp)
        {
            slider.gameObject.SetActive(true);
            slider.value -= Time.deltaTime;
        }
    }


    IEnumerator SpeedBoost()
    {
        yield return new WaitForSeconds(10);
        script.runSpeed = 80;
        slider.gameObject.SetActive(false);
        powerUp = false;
        slider.value = 10;
    }

    IEnumerator Jump()
    {
        yield return new WaitForSeconds(10);
        script2.m_JumpForce = 700;
        slider.gameObject.SetActive(false);
        powerUp = false;
        slider.value = 10;
    }

    IEnumerator Sheild()
    {
        yield return new WaitForSeconds(10);
        sheild.SetActive(false);
        script.isSheild = false;
        slider.gameObject.SetActive(false);
        powerUp = false;
        slider.value = 10;
    }
    IEnumerator TextFade()
    {
        yield return new WaitForSeconds(1f);
        jumpText.SetActive(false);
        sheildText.SetActive(false);
        speedText.SetActive(false);
    }
}

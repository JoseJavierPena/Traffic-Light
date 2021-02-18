using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System.Threading.Tasks;
using System;

public class Manager : MonoBehaviour
{

    public List<GameObject> S1;
    public List<GameObject> S2;
    public List<GameObject> S3;
    public List<GameObject> S4;
    public bool OneThree;
    public bool TwoFour;
    public float vel1;
    public float vel2;
    public float vel3;
    public float vel4;
    public SliderTimer sliderTimer;


    // Start is called before the first frame update
    void Start()
    {
        AllOff();
        StartCoroutine(trafficLightEnumerator());
        Timeout.timeScale = sliderTimer.timer;
    }

    // Update is called once per frame
    void Update()
    {
        Timeout.timeScale = sliderTimer.timer;
    }

    async void trafficLightAsync()
    {
        while(true)
        {
            SemaphoreGreen1_3();
            await Task.Delay(TimeSpan.FromSeconds(sliderTimer.timer));
            SemaphoreYellow1_3();

            await Task.Delay(TimeSpan.FromSeconds(sliderTimer.timer));
            SemaphoreGreen2_4();

            await Task.Delay(TimeSpan.FromSeconds(sliderTimer.timer));
            SemaphoreYellow2_4();

            await Task.Delay(TimeSpan.FromSeconds(sliderTimer.timer));
        }
    }

    IEnumerator trafficLightEnumerator()
    {
        while(true)
        {
            SemaphoreGreen1_3();

            yield return new WaitForSeconds(sliderTimer.timer);
            SemaphoreYellow1_3();

            yield return new WaitForSeconds(sliderTimer.timer);
            SemaphoreGreen2_4();

            yield return new WaitForSeconds(sliderTimer.timer);
            SemaphoreYellow2_4();

            yield return new WaitForSeconds(sliderTimer.timer);
        }    
    }

    void SemaphoreGreen1_3()
    {
        S1[0].SetActive(true);
        S1[1].SetActive(false);
        S1[2].SetActive(false);

        S2[0].SetActive(false);
        S2[1].SetActive(false);
        S2[2].SetActive(true);

        S3[0].SetActive(true);
        S3[1].SetActive(false);
        S3[2].SetActive(false);

        S4[0].SetActive(false);
        S4[1].SetActive(false);
        S4[2].SetActive(true);

        OneThree = true;
        TwoFour = false;
    }

    void SemaphoreGreen1_3()
    {
        S1[0].SetActive(false);
        S1[1].SetActive(true);
        S1[2].SetActive(false);

        S2[0].SetActive(false);
        S2[1].SetActive(false);
        S2[2].SetActive(true);

        S3[0].SetActive(false);
        S3[1].SetActive(true);
        S3[2].SetActive(false);

        S4[0].SetActive(false);
        S4[1].SetActive(false);
        S4[2].SetActive(true);

        OneThree = true;
        TwoFour = false;
    }

    void SemaphoreGreen2_4()
    {
        S1[0].SetActive(false);
        S1[1].SetActive(false);
        S1[2].SetActive(true);

        S2[0].SetActive(true);
        S2[1].SetActive(false);
        S2[2].SetActive(false);

        S3[0].SetActive(false);
        S3[1].SetActive(false);
        S3[2].SetActive(true);

        S4[0].SetActive(true);
        S4[1].SetActive(false);
        S4[2].SetActive(false);

        OneThree = false;
        TwoFour = true;
    }

    void SemaphoreGreen2_4()
    {
        S1[0].SetActive(false);
        S1[1].SetActive(false);
        S1[2].SetActive(true);

        S2[0].SetActive(false);
        S2[1].SetActive(true);
        S2[2].SetActive(false);

        S3[0].SetActive(false);
        S3[1].SetActive(false);
        S3[2].SetActive(true);

        S4[0].SetActive(false);
        S4[1].SetActive(true);
        S4[2].SetActive(false);

        OneThree = false;
        TwoFour = true;
    }

    void AllOff()
    {
        S1[0].SetActive(false);
        S1[1].SetActive(false);
        S1[2].SetActive(false);

        S2[0].SetActive(false);
        S2[1].SetActive(false);
        S2[2].SetActive(false);

        S3[0].SetActive(false);
        S3[1].SetActive(false);
        S3[2].SetActive(false);

        S4[0].SetActive(false);
        S4[1].SetActive(false);
        S4[2].SetActive(false);
        
    }

}

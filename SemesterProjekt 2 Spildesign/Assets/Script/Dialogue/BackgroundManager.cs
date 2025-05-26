using System;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundManager : MonoBehaviour
{
    public int currentSlide = 0;

    public GameObject pictureOne;
    public GameObject pictureTwo;
    public GameObject pictureThree;
    public GameObject pictureFour;
    public GameObject pictureFive;
    public GameObject pictureSix;

    public void Start()
    {
        pictureOne.SetActive(false);
        pictureTwo.SetActive(false);
        pictureThree.SetActive(false);
        pictureFour.SetActive(false);
        pictureFive.SetActive(false);
        pictureSix.SetActive(false);
    }

    public void Update()
    {
        if (currentSlide == 1)
        {
            pictureOne.SetActive(true);
        }
        
        if (currentSlide == 2)
        {
            pictureTwo.SetActive(true);
            pictureOne.SetActive(false);
        }

        if (currentSlide == 3)
        {
            pictureThree.SetActive(true);
            pictureTwo.SetActive(false);
        }
        
        if (currentSlide == 4)
        {
            pictureFour.SetActive(true);
            pictureThree.SetActive(false);
        }
        
        if (currentSlide == 8)
        {
            pictureFive.SetActive(true);
            pictureFour.SetActive(false);
        }
        
        if (currentSlide == 10)
        {
            pictureSix.SetActive(true);
            pictureFive.SetActive(false);
        }
    }

    public void AddOneToCurrentSlide()
    {
        currentSlide++;
    }

}

using System;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundManager : MonoBehaviour
{
    public int currentSlide = 1;

    public GameObject pictureOne;
    public GameObject pictureTwo;
    public GameObject pictureThree;
    public GameObject pictureFour;
    public GameObject pictureFive;
    public GameObject pictureSix;

    public void Start()
    {
        pictureOne.SetActive(true);
        pictureTwo.SetActive(false);
        pictureThree.SetActive(false);
        pictureFour.SetActive(false);
        pictureFive.SetActive(false);
        pictureSix.SetActive(false);
    }

    public void Update()
    {
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
        
        if (currentSlide == 7)
        {
            pictureFive.SetActive(true);
            pictureFour.SetActive(false);
        }
        
        if (currentSlide == 9)
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

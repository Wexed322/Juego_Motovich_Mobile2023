using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Options : MonoBehaviour
{
    public MenuManager menuManager;


    public Slider volume;
    public Slider brillo;
    public Image brilloImage;
    void Start()
    {
        menuManager = this.transform.parent.gameObject.GetComponent<MenuManager>();
        volume.value = PlayerPrefs.GetFloat("Volume");
        brillo.value = PlayerPrefs.GetFloat("Brillo");
    }

    public void closeMenu() 
    {
        menuManager.CurrentMainMenu.gameObject.SetActive(true);
        this.gameObject.SetActive(false);
    }
    public void setVolume() 
    {
        PlayerPrefs.SetFloat("Volume", volume.value);
    }

    public void setBrightness()
    {
        PlayerPrefs.SetFloat("Brillo", brillo.value);
        brilloImage.color = new Color(brilloImage.color.r, brilloImage.color.g, brilloImage.color.b, 1 - brillo.value);
    }
}

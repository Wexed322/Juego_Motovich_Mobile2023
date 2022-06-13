using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] GameObject MainMenu1;
    [SerializeField] GameObject MainMenu2;

    public GameObject CurrentMainMenu;
    //posicionamiento
    /*public GameObject canvas_panel;
    public RectTransform myRectTransform;*/


    public bool inGame;

    private void Awake()
    {
        //desctivar menu siempre, consultar la variable de inGame en el game manager, poner prefabs del menu en todos lados y setear las variables necesarios con playerPrefs

        //RAZON, SI ESTO CRECE, COMO EN UN JUEGO REAL, TENDRIAMOS QUE SETEAR NO SOLO CON PLAYERPREFS EN EL START, HACER FUNCIONES EXTRAS ANTES Y DESPUES DE LA CARGA DE ESCENAS QUE PAJA
    }
    void Start()
    {
        //TOMAR REFERENCIA DE IN GAME DEL GAMEMANAGER



        MainMenu1.gameObject.SetActive(false);
        MainMenu2.gameObject.SetActive(false);

        if (inGame)
        {
            CurrentMainMenu = MainMenu2;
        }
        else 
        {
            CurrentMainMenu = MainMenu1;
        }
        CurrentMainMenu.gameObject.SetActive(true);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    /*public void goRoot() 
    {
        this.transform.SetParent(null);
        canvas_panel = null;
    }

    public void findCanvas() 
    {
        canvas_panel = GameObject.Find("Panel");
        this.transform.SetParent(canvas_panel.transform);
        myRectTransform.localPosition = Vector3.zero;
        myRectTransform.localScale = Vector3.one;
    }*/
}

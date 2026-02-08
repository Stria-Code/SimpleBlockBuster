using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject CreditsObj;
    [SerializeField] private GameObject MenuObj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void ToggleCredits()
    {
        if(CreditsObj.activeInHierarchy)
        {
            CreditsObj.SetActive(false);
            MenuObj.SetActive(true);
        }

        MenuObj.SetActive(false);
        CreditsObj.SetActive(true);
    }

    public void Quit()
    {
        Application.Quit();
    }

}

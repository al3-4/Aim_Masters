using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_Menu : MonoBehaviour
{
    public GameObject SegundoMenu;
    public GameObject PrimerMenu;

    public bool estapausado = false;
    public GameObject PanelPausa;

    void Start()
    {
        PrimerMenu.SetActive(true);
        SegundoMenu.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {

        }
    }

    public void TogglePausa()
    {
        estapausado = !estapausado;
        PanelPausa.SetActive(estapausado);

        if (estapausado)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }
    public void AbrirsegundoMenu()
    {
        PrimerMenu.SetActive(false);
        SegundoMenu.SetActive(true);
    }

    public void CerrandoSegundoMenu()
    {
        PrimerMenu.SetActive(true);
        SegundoMenu.SetActive(false);
    }

    public void Botton(string CambiaScene)
    {
        SceneManager.LoadScene(CambiaScene);
    }

    public void SalirDelJuego()
    {
        Application.Quit();
    }
}

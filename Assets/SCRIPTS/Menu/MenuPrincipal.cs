using UnityEngine;
using UnityEngine.SceneManagement; // Required for managing scenes

public class MenuPrincipal : MonoBehaviour
{
    public string MenuModos;
    [SerializeField] private GameObject painelOpcoes;
    [SerializeField] private GameObject painelCreditos;
    [SerializeField] private GameObject painelLanguage;
    [SerializeField] private GameObject painelAudio;
    [SerializeField] private GameObject painelVideo;
    [SerializeField] private GameObject painelComoJogar;
    [SerializeField] private GameObject Cubo;

    public void OnJogar()
    {
        SceneManager.LoadScene(MenuModos);
    }

    public void OnOpcoes()
    {
        painelOpcoes.SetActive(true);
    }

    public void OnLanguage()
    {
        painelLanguage.SetActive(true);
    }

    public void OnAudio()
    {
        painelAudio.SetActive(true);
        painelOpcoes.SetActive(false);
    }

    public void OnVideo()
    {
        painelVideo.SetActive(true);
    }

    public void OnComoJogar()
    {
        painelComoJogar.SetActive(true);
    }

    public void OnCreditos()
    {
        painelCreditos.SetActive(true);
        Cubo.SetActive(false);
    }

    public void VoltarOpcoes()
    {
        painelOpcoes.SetActive(false);
    }

    public void VoltarLanguage()
    {
        painelLanguage.SetActive(false);
        painelOpcoes.SetActive(true);
    }
    public void VoltarAudio()
    {
        painelAudio.SetActive(false);
        painelOpcoes.SetActive(true);
    }

    public void VoltarCreditos()
    {
        painelCreditos.SetActive(false);
        Cubo.SetActive(true);
    }

    public void VoltarComoJogar()
    {
        painelComoJogar.SetActive(false);
        Cubo.SetActive(true);
    }

    public void Sair()
    {
        Debug.Log("saiu do jogo!");
        Application.Quit();
    }
}

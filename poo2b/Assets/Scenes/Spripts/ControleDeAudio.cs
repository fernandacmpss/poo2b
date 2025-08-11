using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ControleDeAudio : MonoBehaviour
{
    public int volume;
    public int volumeSFX;
    public bool musica;

    public Slider volumeSlider;
    public Slider volumeSFXSlider;
    public Toggle toglleMusica;
    public TMP_Text textoMusica;
    
    void Start()
    {
        musica = toglleMusica.isOn;
        volume = (int)volumeSlider.value;
        volumeSFX = (int)volumeSFXSlider.value;
    }

    
    void Update()
    {
        musica = toglleMusica.isOn;
        volume = (int)volumeSlider.value;
        volumeSFX = (int)volumeSFXSlider.value;

        if (musica == true)
        {
            textoMusica.text = "Ligado";
            textoMusica.color = Color.green;   

        }
        else
        {
            textoMusica.text = "Desligado";
            textoMusica.color = Color.red;   
        }
    }
}
using TMPro;
using UnityEngine;

public class TextoRandomizado : MonoBehaviour
{
    public string novoTexto;

    public TextMeshProUGUI UITexto;

    void Update()

    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            UITexto.text = novoTexto;
        }
    }
}
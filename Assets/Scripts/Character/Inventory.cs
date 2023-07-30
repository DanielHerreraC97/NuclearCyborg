using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Inventory : MonoBehaviour
{
    public int Cantidad = 0;
    public TMP_Text points;
    public TMP_Text gameOverText;

    private void Start()
    {
        gameOverText.gameObject.SetActive(false);
    }
    private void Update()
            {
        points.text = Cantidad.ToString();
        if (Cantidad == 6)
        {
            gameOverText.gameObject.SetActive(true);
            gameOverText.text = "¡Has Recolectado Todas las Celdas de Combustible Nuclear!";
            StartCoroutine(Transition());
        }
    }
    IEnumerator Transition()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene("MainMenu");
    }
}



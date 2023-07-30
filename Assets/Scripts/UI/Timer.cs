using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] private TMP_Text timerText;

    [SerializeField, Tooltip("Time in minutes")] private float timerTime;
    private int minutes, seconds, cents;
    public TMP_Text gameOverText;
    // Update is called once per frame
    private void Update()
    {
        timerTime -= Time.deltaTime;

        if (timerTime < 0) timerTime = 0;

        minutes = (int)(timerTime / 60f);
        seconds = (int)(timerTime - minutes * 60f);
        cents = (int)((timerTime - (int)timerTime) * 100f);

        timerText.text = string.Format("{0:00}:{1:00}:{2:00}", minutes, seconds, cents);

        if(timerTime == 0)
        {
            gameOverText.gameObject.SetActive(true);
            gameOverText.text = "¡Se acabó el combustible! ¡Estás muerto!";
            StartCoroutine(Transition());
        }
    }
    IEnumerator Transition()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene("MainMenu");

        Destroy(this);
    }
}

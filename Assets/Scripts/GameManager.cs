using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI tiempotext, puntuaciontext;
    public int puntuacion = 0;
    public float tiempo = 0f;
    public static GameManager reference;
    public void Awake()
    {
        if (reference == null)
            reference = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        puntuacion = 0;
        tiempo = 0;

    }

    // Update is called once per frame
    void Update()
    {
        tiempo += Time.time;
        tiempo = Mathf.Round((float)2);
        tiempotext.text = tiempo.ToString();
    }
}

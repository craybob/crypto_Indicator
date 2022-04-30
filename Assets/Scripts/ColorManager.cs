using UnityEngine;

public class ColorManager : MonoBehaviour
{
    //amb = ameba,  tuf = tufelka

    [SerializeField]
    private Material material1;
    [SerializeField]
    private Material material2;
    [SerializeField]
    private Material material3;

    [SerializeField]
    private Material materialamb1;
    [SerializeField]
    private Material materialamb2;
    [SerializeField]
    private Material materialamb3;

    [SerializeField]
    private Material materialtuf1;
    [SerializeField]
    private Material materialtuf2;
    [SerializeField]
    private Material materialtuf3;

    [SerializeField]
    private Color green;
    [SerializeField]
    private Color red;

    public bool tendencia1;
    private bool oldTendencia1;
    public bool tendencia2;
    private bool oldTendencia2;
    public bool tendencia3;
    private bool oldTendencia3;

    public bool tendenciaamb1;
    private bool oldTendenciaamb1;
    public bool tendenciaamb2;
    private bool oldTendenciaamb2;
    public bool tendenciaamb3;
    private bool oldTendenciaamb3;

    public bool tendenciatuf1;
    private bool oldTendenciatuf1;
    public bool tendenciatuf2;
    private bool oldTendenciatuf2;
    public bool tendenciatuf3;
    private bool oldTendenciatuf3;

    private float timer1 = 0;
    private float timer2 = 0;
    private float timer3 = 0;

    private float timeramb1 = 0;
    private float timeramb2 = 0;
    private float timeramb3 = 0;

    private float timertuf1 = 0;
    private float timertuf2 = 0;
    private float timertuf3 = 0;

    private void Update()
    {
        timer1 += Time.deltaTime;
        timer2 += Time.deltaTime;
        timer3 += Time.deltaTime;

        timeramb1 += Time.deltaTime;
        timeramb2 += Time.deltaTime;
        timeramb3 += Time.deltaTime;

        timertuf1 += Time.deltaTime;
        timertuf2 += Time.deltaTime;
        timertuf3 += Time.deltaTime;

        // Bacteria old tendencia Check
        if (tendencia1 != oldTendencia1)
        {
            timer1 = 0;
            oldTendencia1 = tendencia1;
        }

        if (tendencia2 != oldTendencia2)
        {
            timer2 = 0;
            oldTendencia2 = tendencia2;
        }

        if (tendencia3 != oldTendencia3)
        {
            timer3 = 0;
            oldTendencia3 = tendencia3;
        }
        
        //Ameba old tendencia Check
        if (tendenciaamb1 != oldTendenciaamb1)
        {
            timeramb1 = 0;
            oldTendenciaamb1 = tendenciaamb1;
        }

        if (tendenciaamb2 != oldTendenciaamb2)
        {
            timeramb2 = 0;
            oldTendenciaamb2 = tendenciaamb2;
        }

        if (tendenciaamb3 != oldTendenciaamb3)
        {
            timeramb3 = 0;
            oldTendenciaamb3 = tendenciaamb3;
        }

        //tufelka old tendencia Check
        if (tendenciatuf1 != oldTendenciatuf1)
        {
            timertuf1 = 0;
            oldTendenciatuf1 = tendenciatuf1;
        }

        if (tendenciatuf2 != oldTendenciatuf2)
        {
            timertuf2 = 0;
            oldTendenciatuf2 = tendenciatuf2;
        }

        if (tendenciatuf3 != oldTendenciatuf3)
        {
            timertuf3 = 0;
            oldTendenciatuf3 = tendenciatuf3;
        }

        //COLOR CHANGE
        //bateria color change
        if (tendencia1)
        {
            material1.color = Color.Lerp(material1.color, green, timer1 * 0.01f);
        }
        else
        {
            material1.color = Color.Lerp(material1.color, red, timer1 * 0.01f);
        }

        if (tendencia2)
        {
            material2.color = Color.Lerp(material2.color, green, timer2 * 0.01f);
        }
        else
        {
            material2.color = Color.Lerp(material2.color, red, timer2 * 0.01f);
        }

        if (tendencia3)
        {
            material3.color = Color.Lerp(material3.color, green, timer3 * 0.01f);
        }
        else
        {
            material3.color = Color.Lerp(material3.color, red, timer3 * 0.01f);
        }

        //ameba color change
        if (tendenciaamb1)
        {
            materialamb1.color = Color.Lerp(materialamb1.color, green, timeramb1 * 0.01f);
        }
        else
        {
            materialamb1.color = Color.Lerp(materialamb1.color, red, timeramb1 * 0.01f);
        }

        if (tendenciaamb2)
        {
            materialamb2.color = Color.Lerp(materialamb2.color, green, timeramb2 * 0.01f);
        }
        else
        {
            materialamb2.color = Color.Lerp(materialamb2.color, red, timeramb2 * 0.01f);
        }

        if (tendenciaamb3)
        {
            materialamb3.color = Color.Lerp(materialamb3.color, green, timeramb3 * 0.01f);
        }
        else
        {
            materialamb3.color = Color.Lerp(materialamb3.color, red, timeramb3 * 0.01f);
        }

        //tufelka color change
        if (tendenciatuf1)
        {
            materialtuf1.color = Color.Lerp(materialtuf1.color, green, timertuf1 * 0.01f);
        }
        else
        {
            materialtuf1.color = Color.Lerp(materialtuf1.color, red, timertuf1 * 0.01f);
        }

        if (tendenciatuf2)
        {
            materialtuf2.color = Color.Lerp(materialtuf2.color, green, timertuf2 * 0.01f);
        }
        else
        {
            materialtuf2.color = Color.Lerp(materialtuf2.color, red, timertuf2 * 0.01f);
        }

        if (tendenciatuf3)
        {
            materialtuf3.color = Color.Lerp(materialtuf3.color, green, timertuf3 * 0.01f);
        }
        else
        {
            materialtuf3.color = Color.Lerp(materialtuf3.color, red, timertuf3 * 0.01f);
        }
    }
}
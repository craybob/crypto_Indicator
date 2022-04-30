using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

public class BitcointPrise : MonoBehaviour
{
    //amb-Ameba ; tuf-Tufelka

    [SerializeField]
    private string url;
    [SerializeField]
    private string url2;
    [SerializeField]
    private string url3;

    [SerializeField]
    private ColorManager colorManager;

    private float oldPrise1 = 0;
    private float oldPrise2 = 0;
    private float oldPrise3 = 0;

    private float oldPriseamb1 = 0;
    private float oldPriseamb2 = 0;
    private float oldPriseamb3 = 0;

    [SerializeField]private float oldPrisetuf1 = 0;
    [SerializeField]private float oldPrisetuf2 = 0;
    [SerializeField]private float oldPrisetuf3 = 0;

    private void Start()
    {
        StartCoroutine(GetRequest1());
        StartCoroutine(GetRequest2());
        StartCoroutine(GetRequest3());
        StartCoroutine(GetRequestamb1());
        StartCoroutine(GetRequestamb2());
        StartCoroutine(GetRequestamb3());
        StartCoroutine(GetRequesttuf1());
        StartCoroutine(GetRequesttuf2());
        StartCoroutine(GetRequesttuf3());
    }

    private IEnumerator GetRequest1()
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(url))
        {

            yield return webRequest.SendWebRequest();

            var tmp = webRequest.downloadHandler.text.Split(' ');
            var currentPrise = float.Parse(tmp[9].Trim(',').Replace('.', ','));

            if (currentPrise >= oldPrise1)
            {
                colorManager.tendencia1 = true;
            }
            else
            {
                colorManager.tendencia1 = false;
            }
            oldPrise1 = currentPrise;
        }
        yield return new WaitForSeconds(10);
        StartCoroutine(GetRequest1());
    }

    private IEnumerator GetRequest2()
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(url2))
        {

            yield return webRequest.SendWebRequest();

            var tmp = webRequest.downloadHandler.text.Split(' ');
            var currentPrise = float.Parse(tmp[9].Trim(',').Replace('.', ','));

            if (currentPrise >= oldPrise2)
            {
                colorManager.tendencia2 = true;
            }
            else
            {
                colorManager.tendencia2 = false;
            }
            oldPrise2 = currentPrise;
        }
        yield return new WaitForSeconds(10);
        StartCoroutine(GetRequest2());
    }
    private IEnumerator GetRequest3()
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(url3))
        {

            yield return webRequest.SendWebRequest();

            var tmp = webRequest.downloadHandler.text.Split(' ');
            var currentPrise = float.Parse(tmp[9].Trim(',').Replace('.', ','));

            if (currentPrise >= oldPrise3)
            {
                colorManager.tendencia3 = true;
            }
            else
            {
                colorManager.tendencia3 = false;
            }
            oldPrise3 = currentPrise;
        }
        yield return new WaitForSeconds(10);
        StartCoroutine(GetRequest3());
    }

    private IEnumerator GetRequestamb1()
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(url))
        {

            yield return webRequest.SendWebRequest();

            var tmp = webRequest.downloadHandler.text.Split(' ');
            var currentPrise = float.Parse(tmp[9].Trim(',').Replace('.', ','));

            if (currentPrise >= oldPriseamb1)
            {
                colorManager.tendenciaamb1 = true;
            }
            else
            {
                colorManager.tendenciaamb1 = false;
            }
            oldPriseamb1 = currentPrise;
        }
        yield return new WaitForSeconds(15);
        StartCoroutine(GetRequestamb1());
    }

    private IEnumerator GetRequestamb2()
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(url2))
        {

            yield return webRequest.SendWebRequest();

            var tmp = webRequest.downloadHandler.text.Split(' ');
            var currentPrise = float.Parse(tmp[9].Trim(',').Replace('.', ','));

            if (currentPrise >= oldPriseamb2)
            {
                colorManager.tendenciaamb2 = true;
            }
            else
            {
                colorManager.tendenciaamb2 = false;
            }
            oldPriseamb2 = currentPrise;
        }
        yield return new WaitForSeconds(15);
        StartCoroutine(GetRequestamb2());
    }

    private IEnumerator GetRequestamb3()
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(url3))
        {

            yield return webRequest.SendWebRequest();

            var tmp = webRequest.downloadHandler.text.Split(' ');
            var currentPrise = float.Parse(tmp[9].Trim(',').Replace('.', ','));

            if (currentPrise >= oldPriseamb3)
            {
                colorManager.tendenciaamb3 = true;
            }
            else
            {
                colorManager.tendenciaamb3 = false;
            }
            oldPriseamb3 = currentPrise;
        }
        yield return new WaitForSeconds(15);
        StartCoroutine(GetRequestamb3());
    }

    private IEnumerator GetRequesttuf1()
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(url))
        {

            yield return webRequest.SendWebRequest();

            var tmp = webRequest.downloadHandler.text.Split(' ');
            var currentPrise = float.Parse(tmp[9].Trim(',').Replace('.', ','));

            if (currentPrise >= oldPrisetuf1)
            {
                colorManager.tendenciatuf1 = true;
            }
            else
            {
                colorManager.tendenciatuf1 = false;
            }
            oldPrisetuf1 = currentPrise;
        }
        yield return new WaitForSeconds(15);
        StartCoroutine(GetRequesttuf1());
    }

    private IEnumerator GetRequesttuf2()
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(url2))
        {

            yield return webRequest.SendWebRequest();

            var tmp = webRequest.downloadHandler.text.Split(' ');
            var currentPrise = float.Parse(tmp[9].Trim(',').Replace('.', ','));

            if (currentPrise >= oldPrisetuf2)
            {
                colorManager.tendenciatuf2 = true;
            }
            else
            {
                colorManager.tendenciatuf2 = false;
            }
            oldPrisetuf2 = currentPrise;
        }
        yield return new WaitForSeconds(15);
        StartCoroutine(GetRequesttuf2());
    }

    private IEnumerator GetRequesttuf3()
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(url3))
        {

            yield return webRequest.SendWebRequest();

            var tmp = webRequest.downloadHandler.text.Split(' ');
            var currentPrise = float.Parse(tmp[9].Trim(',').Replace('.', ','));

            if (currentPrise >= oldPrisetuf3)
            {
                colorManager.tendenciatuf3 = true;
            }
            else
            {
                colorManager.tendenciatuf3 = false;
            }
            oldPrisetuf3 = currentPrise;
        }
        yield return new WaitForSeconds(15);
        StartCoroutine(GetRequesttuf3());
    }
}
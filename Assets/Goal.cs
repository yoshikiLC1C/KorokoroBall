using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameObject clearText;
    public GameObject nextButton;
    public AudioSource audioSource;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("�S�[���I");

        clearText.SetActive(true);
        nextButton.SetActive(true);
        audioSource.Play();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

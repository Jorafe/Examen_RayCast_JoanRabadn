using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement;  

public class RayCast : MonoBehaviour
{
    public Text countdownText; 

    bool raycast = false; 

    void Update()
    {
        if(Input.GetButtonDown("Fire1") && raycast == false) 
        {
            Ray ray =  Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;  
            
            if(Physics.Raycast(ray, out hit))

            {
                if(hit.transform.tag == "Cubo 1") 
                {    
                    StartCoroutine(Countdown("Scene1 1")); 
                    raycast = true; 
                }

                else if(hit.transform.tag == "Esfera 1") 
                {
                    StartCoroutine(Countdown("Scene1 2"));
                    raycast = true; 
                }

                else if(hit.transform.tag == "Cubo 2") 
                {
                    StartCoroutine(Countdown("Scene1 3")); 
                    raycast = true; 
                }

            }
        }
    }

     IEnumerator Countdown(string scene) 
    {
        while(countdownText.text != "GOO!") 
        {
            countdownText.text = "5";
            yield return new WaitForSeconds(1f);

            countdownText.text = "4";
            yield return new WaitForSeconds(1f);

            countdownText.text = "3";
            yield return new WaitForSeconds(1f);

            countdownText.text = "2";
            yield return new WaitForSeconds(1f);

            countdownText.text = "1";
            yield return new WaitForSeconds(1f);
            
            countdownText.text = "GOO!";
            yield return new WaitForSeconds(1f);
            
            SceneManager.LoadScene(scene);
           
        }


    }
}

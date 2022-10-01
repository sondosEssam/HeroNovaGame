using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrogressBar : MonoBehaviour
{
    public float FillSpeed =0.2f;
    private float targetProgress=0;
    private Slider slider;// Start is called before the first frame update
    
    private void Awake(){
        slider =gameObject.GetComponent<Slider>();
    }



    void Start()
    {
       IncrementProgress(0.75f);
        
    }

    // Update is called once per frame
    void Update()
    {
         if(slider.value <targetProgress)
        slider.value += FillSpeed *Time.deltaTime;
    }
    public void IncrementProgress(float newProgress){
        targetProgress = slider.value + newProgress;
    }
} 

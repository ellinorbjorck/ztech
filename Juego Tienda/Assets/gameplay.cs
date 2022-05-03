using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameplay : MonoBehaviour
{
    int minutes = 0;
    int hours = 8;
    public TextMeshProUGUI day;
    public TextMeshProUGUI time;
    public TextMeshProUGUI day_over;
    public Button next_day;
   // GameObject day_over_canvas;
    static int days = 1;
    int offset;

    // Start is called before the first frame update
    void Start()
    {
        
       // day_over_canvas = GameObject.Find("Day_over");
      //  day_over_canvas.SetActive(false);
        next_day.onClick.AddListener(TaskOnClick);

    }

    // Update is called once per frame
    void Update()
    {
        
        if (hours < 10)
        {
            offset = (hours - 8) * 60;
            minutes = (int)Time.timeSinceLevelLoad-offset;
            if (minutes > 59) { hours += 1; }
            if (hours < 10 && minutes < 10)
            {
                
                time.text = "time: 0" + hours + ".0" + minutes;
            }
            else if (hours < 10)
            {
                time.text = "time: 0" + hours + "." + minutes;
            }
            else if (minutes < 10)
            {
                time.text = "time: " + hours + ".0" + minutes;
            }
            else { time.text = "time: " + hours + "." + minutes; }

        }
        else
        {
           // day_over_canvas.SetActive(true);
            
        }
        day.text = "day: " + days;



    }
    void TaskOnClick() {


        days += 1;
       // day_over_canvas.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        

    }
}

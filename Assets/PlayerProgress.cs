using UnityEngine;
using UnityEngine.UI;

public class PlayerProgress : MonoBehaviour
{

    public Transform player;
    public Transform goal;
    public Slider slider;

    void Start()
    {
        slider.minValue = player.position.z;
        slider.maxValue = goal.position.z;
    }
    // Update is called once per frame
    void Update()
    {
        
        slider.value = player.position.z;
    }
}

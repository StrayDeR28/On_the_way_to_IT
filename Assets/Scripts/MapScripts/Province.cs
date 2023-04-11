using UnityEngine;
using UnityEngine.UI;

public class Province : MonoBehaviour
{
    public GameObject Task1, Task2, Task3, Task4;
    public Sprite NewSprite;
    public GameObject ThisProvince;
    public GameObject Flag;
    bool[] IsPassed = {false, false, false, false};
    [SerializeField] private ProvincesEnum ProvinceNumber;
    [SerializeField] private enum ProvincesEnum
    {
        Province1,
        Province2,
        Province3,
        Province4,
        Province5,
        Province6,
        Province7
    }
    void Awake()
    {
        for(int i = 0; i < 4; i++)
        {
            if(WebManager.player.progress[(int)ProvinceNumber * 4 + i] > 0) IsPassed[i] = true;
        }
        if(IsPassed[0] || IsPassed[1] || IsPassed[2] || IsPassed[3]) 
        {
            ThisProvince.GetComponent<Image>().sprite = NewSprite;
        }
        if(IsPassed[0] && IsPassed[1] && IsPassed[2] && IsPassed[3]) 
        {
            Flag.SetActive(true);
            ThisProvince.GetComponent<Button>().interactable = false;
        }
    }
    public void ActiveTasks()
    {
        Task1.SetActive(true);
        Task2.SetActive(true);
        Task3.SetActive(true);
        Task4.SetActive(true);

        if(!IsPassed[0])
        {
            Task1.GetComponent<Button>().interactable = true;
        }
        else 
        {
            Task1.GetComponent<Button>().interactable = false;
            Task1.transform.GetChild(0).gameObject.SetActive(false);
        }
        if(!IsPassed[1])
        {
            Task2.GetComponent<Button>().interactable = true;
        }
        else 
        {
            Task2.GetComponent<Button>().interactable = false;
            Task2.transform.GetChild(0).gameObject.SetActive(false);
        }
        if(!IsPassed[2])
        {
            Task3.GetComponent<Button>().interactable = true;
        }
        else 
        {
            Task3.GetComponent<Button>().interactable = false;
            Task3.transform.GetChild(0).gameObject.SetActive(false);
        }
        if(!IsPassed[3])
        {
            Task4.GetComponent<Button>().interactable = true;
        }
        else 
        {
            Task4.GetComponent<Button>().interactable = false;
            Task4.transform.GetChild(0).gameObject.SetActive(false);
        }
        
    }
    public void UnActiveTasks()
    {
        Task1.SetActive(false);
        Task2.SetActive(false);
        Task3.SetActive(false);
        Task4.SetActive(false);
    }
}

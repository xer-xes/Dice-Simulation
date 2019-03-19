using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelloWorld : MonoBehaviour
{
    public Text HelloText;
    public Image[] Dice = new Image[6];

    public string[] Hellos = new string[4] { "Hello World", "Hola Mundo", "Bonjour Le Monde", "Hallo Welt" };
    public int[] DiceNumber = new int[6] { 1, 2, 3, 4, 5, 6 };
    // Start is called before the first frame update
    void Awake()
    {
        Random.seed = (int)System.DateTime.Now.Ticks;
        int RandomIndex = Random.Range(0, Hellos.Length);
        int RandomNumber = Random.Range(0, DiceNumber.Length);
        if(RandomNumber == 1)
        {
            Dice[0].gameObject.SetActive(true);
        }else if(RandomNumber == 2)
        {
            Dice[1].gameObject.SetActive(true);
        }
        else if(RandomNumber == 3)
        {
            Dice[2].gameObject.SetActive(true);
        }
        else if(RandomNumber == 4)
        {
            Dice[3].gameObject.SetActive(true);
        }
        else if(RandomNumber == 5)
        {
            Dice[4].gameObject.SetActive(true);
        }
        else if(RandomNumber == 6)
        {
            Dice[5].gameObject.SetActive(true);
        }
        HelloText.text = Hellos[RandomIndex];
    }
}

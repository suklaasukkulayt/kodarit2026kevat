using UnityEngine;
using TMPro;


public class Selector : MonoBehaviour
{
    public TMP_Text [] items;
    public Color normalColor = Color.white;
    public Color highlightColor = Color.yellow;
    private int index = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateColors();
    }

    // Update is called once per frame
    void Update()
    {

        //Ylös
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            index = (index - 1 + items.Length) % items.Length;
            UpdateColors();
            //Debug.Log("meni ylös oho" + index);
        }

        //Alas
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            index = (index +1) % items.Length;
            UpdateColors();
            //Debug.Log("meni alas oho" + index);
        }

        //Valitse
        if (Input.GetKeyDown(KeyCode.Return))
        {
            ActivateItem(index);
        }
    }


    private void UpdateColors()
    {
        for(int i = 0; i < items.Length; i++)
        {
            items[i].color = (i == index) ? highlightColor : normalColor;
        }
    }


    public void ActivateItem(int i)
    {
        Debug.Log("Selcted: " + items[i].text);
    }

}

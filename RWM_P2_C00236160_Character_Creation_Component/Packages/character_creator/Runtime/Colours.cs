using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class Colours : MonoBehaviour
{
    public Button rightArrowSkin;
    public Button leftArrowSkin;
    public Button rightArrowHair;
    public Button leftArrowHair;
    public Button rightArrowShirt;
    public Button leftArrowShirt;
    public Button rightArrowPants;
    public Button leftArrowPants;



    public TMP_Text skinText;
    public TMP_Text hairText;
    public TMP_Text shirtText;
    public TMP_Text pantsText;

    private string[] colourNames = new string[5];

    public GameObject skin;
    public GameObject hair;
    public GameObject shirt;
    public GameObject pants;

    private Color32[] skinColours = new Color32[5];
    private Color32[] hairColours = new Color32[5];
    private Color32[] shirtColours = new Color32[5];
    private Color32[] pantsColours = new Color32[5];

    int currentSkinColour = 0;
    int currentHairColour = 0;
    int currentShirtColour = 0;
    int currentPantsColour = 0;

    Color32 Brown = new Color32(125, 31, 0, 255);
    Color32 Blonde = new Color32(244, 169, 2, 255);
    Color32 Blue = new Color32(0, 0, 255, 255);
    Color32 Peach = new Color32(200, 216, 212, 255);
    Color32 custom = new Color32(0, 0, 0, 255);

    // Start is called before the first frame update
    void Start()
    {
        skinColours[0] = Brown;
        skinColours[1] = Blonde;
        skinColours[2] = Blue;
        skinColours[3] = Peach;
        skinColours[4] = custom;

        hairColours[0] = Brown;
        hairColours[1] = Blonde;
        hairColours[2] = Blue;
        hairColours[3] = Peach;
        hairColours[4] = custom;

        shirtColours[0] = Brown;
        shirtColours[1] = Blonde;
        shirtColours[2] = Blue;
        shirtColours[3] = Peach;
        shirtColours[4] = custom;

        pantsColours[0] = Brown;
        pantsColours[1] = Blonde;
        pantsColours[2] = Blue;
        pantsColours[3] = Peach;
        pantsColours[4] = custom;



        colourNames[0] = "Brown";
        colourNames[1] = "Blonde";
        colourNames[2] = "Blue";
        colourNames[3] = "White";
        colourNames[4] = "custom";

        skin.GetComponent<SpriteRenderer>().color = skinColours[0];
        hair.GetComponent<SpriteRenderer>().color = hairColours[1];
        shirt.GetComponent<SpriteRenderer>().color = shirtColours[3];
        pants.GetComponent<SpriteRenderer>().color = pantsColours[2];
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void RightSkinToneArrowClicked()
    {
        changeColourRight(skinColours, ref currentSkinColour, ref skin, skinText);
    }
    public void RightHairColourArrowClicked()
    {
        changeColourRight(hairColours, ref currentHairColour, ref hair, hairText);
    }
    public void RightShirtColourArrowClicked()
    {
        changeColourRight(shirtColours, ref currentShirtColour, ref shirt, shirtText);
    }
    public void RightPantsColourArrowClicked()
    {
        changeColourRight(pantsColours, ref currentPantsColour, ref pants, pantsText);
    }
    public void LeftSkinToneArrowClicked()
    {
        changeColourLeft(skinColours, ref currentSkinColour, ref skin, skinText);
    }
    public void LeftHairColourArrowClicked()
    {
        changeColourLeft(hairColours, ref currentHairColour, ref hair, hairText);
    }
    public void LeftShirtColourArrowClicked()
    {
        changeColourLeft(shirtColours, ref currentShirtColour, ref shirt, shirtText);
    }
    public void LeftPantsColourArrowClicked()
    {
        changeColourLeft(pantsColours, ref currentPantsColour, ref pants, pantsText);
    }




    void changeColourRight(Color32[] t_colours, ref int t_currentColour, ref GameObject t_object, TMP_Text t_text)
    {
        if (t_currentColour < t_colours.Length -1)
        {
            t_currentColour += 1;
            t_text.text = colourNames[t_currentColour];
            t_object.GetComponent<SpriteRenderer>().color = t_colours[t_currentColour];
        }
        else
        {
            t_currentColour = 0;
            t_text.text = colourNames[t_currentColour];
            t_object.GetComponent<SpriteRenderer>().color = t_colours[t_currentColour];
        }
    }

    void changeColourLeft(Color32[] t_colours, ref int t_currentColour, ref GameObject t_object, TMP_Text t_text)
    {
        if (t_currentColour > 0)
        {
            t_currentColour -= 1;
            t_text.text = colourNames[t_currentColour];
            t_object.GetComponent<SpriteRenderer>().color = t_colours[t_currentColour];
        }
        else
        {
            t_currentColour = 4;
            t_text.text = colourNames[t_currentColour];
            t_object.GetComponent<SpriteRenderer>().color = t_colours[t_currentColour];
        }
    }
}


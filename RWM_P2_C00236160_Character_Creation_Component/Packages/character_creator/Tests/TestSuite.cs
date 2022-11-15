using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class TestSuite
{
    private ColourChanger colourChanger;
    private Colours m_colours;
    Color32 currentColour;
    Color32 newColour;


    // 1
    [UnityTest]
    public IEnumerator AsteroidsMoveDown()
    {
        yield return new WaitForSeconds(0.1f);


    }
}

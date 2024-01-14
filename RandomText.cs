using UnityEngine;
using TMPro;

public class RandomText : MonoBehaviour
{
    public TextMeshProUGUI textMeshProObject;
    public string[] stringList = {"Also try Geometry Dash!", "est nivel funk"};

    void Start()
    {
        if (textMeshProObject != null && stringList != null && stringList.Length > 0)
        {
            string randomString = stringList[Random.Range(0, stringList.Length)];
            textMeshProObject.text = randomString;
        }
        else
        {
            Debug.LogError("TextMeshPro object or string list not assigned properly.");
        }
    }
}

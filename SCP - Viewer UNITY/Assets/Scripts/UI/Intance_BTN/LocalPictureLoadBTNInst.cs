using UnityEngine.UI;
using UnityEngine;

public class LocalPictureLoadBTNInst : MonoBehaviour
{
    private Image image => GetComponent<Image>();
    private string updateTextCheck;

    private async void Start()
    {
        while (true)
        {
            await Awaitable.NextFrameAsync();
            try
            {
                string slotName = transform.parent.GetChild(0).GetComponent<Text>().text;
                if (updateTextCheck != slotName)
                {
                    updateTextCheck = slotName;
                    image.sprite = Resources.Load($"SpawnListPictures/{slotName}", typeof(Sprite)) as Sprite;
                }
            }
            catch { return; }
        }     
    }
}

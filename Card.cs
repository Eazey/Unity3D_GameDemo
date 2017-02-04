using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Card : MonoBehaviour {

    public int ID
    {
        get
        {
            return id;
        }
    }
    private int id;

    private Sprite frontImg;
    private Sprite backImg;
    private Sprite successImg;

    private Image showImg;
    public Button cardBtn;

    public void InitCard(int Id, Sprite FrontImg,Sprite BackImg,Sprite SuccessImg)
    {
        this.id = Id;
        this.frontImg = FrontImg;
        this.backImg = BackImg;
        this.successImg = SuccessImg;

        showImg = GetComponent<Image>();
        showImg.sprite = this.backImg;

        cardBtn = GetComponent<Button>();
    }

    public void SetFanPai()
    {
        showImg.sprite = frontImg;
        cardBtn.interactable = false;
    }

    public void SetSuccess()
    {
        showImg.sprite = successImg;
    }

    public void SetRecover()
    {
        showImg.sprite = backImg;
        cardBtn.interactable = true;
    }
}

using UnityEngine;

[CreateAssetMenu(fileName = "New Clothing", menuName = "CharacterCreation/New Clothing")]
public class Clothing : ScriptableObject
{
    //Category is created so that all selectable options can be created with same scriptable object "New Clothing".
    public enum Category
    {
        NotSelected,
        Hair,
        Shirt,
        Pants,
        Shoes,
        Accessory
    };

    //These options are seen in Inspector, when a new clothing is created. 
    new public string name = "New Clothing";
    public Sprite icon = null;
    //thisCloth is the 3D model of the clothing that is instantiated to game.
    public GameObject thisCloth;
    public Category category;
    

    //Instantiates thisCloth to player and saves the selected option to "Selection". Deletes the previous selection so that a player only has one object on of a certain category.
    public virtual void ChangeTo(Transform player)
    {
        switch (category)
        {
            case Category.Hair:
                if (FindObjectOfType<Selection>().hair != null)
                {
                    Destroy(FindObjectOfType<Selection>().hair);
                }
                FindObjectOfType<Selection>().hair = Instantiate(thisCloth, player);
                break;

            case Category.Shirt:
                if (FindObjectOfType<Selection>().shirt != null)
                {
                    Destroy(FindObjectOfType<Selection>().shirt);
                }
                FindObjectOfType<Selection>().shirt = Instantiate(thisCloth, player);
                break;

            case Category.Pants:
                if (FindObjectOfType<Selection>().pants != null)
                {
                    Destroy(FindObjectOfType<Selection>().pants);
                }
                FindObjectOfType<Selection>().pants = Instantiate(thisCloth, player);
                break;

            case Category.Shoes:
                if (FindObjectOfType<Selection>().shoes != null)
                {
                    Destroy(FindObjectOfType<Selection>().shoes);
                }
                FindObjectOfType<Selection>().shoes = Instantiate(thisCloth, player);
                break;

            case Category.Accessory:
                if (FindObjectOfType<Selection>().accessory != null)
                {
                    Destroy(FindObjectOfType<Selection>().accessory);
                }
                FindObjectOfType<Selection>().accessory = Instantiate(thisCloth, player);
                break;
        }
    }
}
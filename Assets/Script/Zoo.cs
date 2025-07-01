using UnityEngine;

public class Zoo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Animal tom = new Animal("톰", "냐옹!");
        // tom.name = "톰";
        // tom.sound = "냐옹!";

        Animal jerry = new Animal("제리", "찍찍!");
        // jerry.name = "제리";
        // jerry.sound = "찍찍";

        tom.PlaySound();
        jerry.PlaySound();

        jerry = tom;
        jerry.name = "미키";

        Debug.Log("jerry에 tom 할당한 뒤 : ");
        tom.PlaySound();
        jerry.PlaySound();
    }
}

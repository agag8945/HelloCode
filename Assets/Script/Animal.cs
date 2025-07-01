using UnityEngine;

public class Animal
{
    public string name;
    public string sound;

    public Animal()
    {
        
    }

    public Animal(string name, string sound)
    {
        this.name = name;
        this.sound = sound;
    }


    // 울음소리를 재생하는 메서드
    public void PlaySound()
    {
        Debug.Log(name + " : " + sound);
    }
}

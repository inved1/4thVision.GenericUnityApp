using UnityEngine;
using Zenject;

public class invInstaller : MonoInstaller
{
    public override void InstallBindings()
    {

        Container.Bind<string>()
            .FromInstance("Hello World");

        Container.Bind<Greeter>()
            .AsSingle()
            .NonLazy();
        
    }
}


public class Greeter
{

    private int iCounter = 0;
    public Greeter(string message)
    {
        Debug.Log(message); 
    }

    public int Counter()
    {
        return ++iCounter;
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveDropOff : MonoBehaviour, IDropOff
{
    [Tooltip("The text that is displayed when looked at.")]
    [SerializeField]
    protected string displayText = nameof(InteractiveDropOff);

    public virtual string DisplayText => displayText;

    protected AudioSource audioSource;

    public virtual void DropOff()
    {
        throw new System.NotImplementedException();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

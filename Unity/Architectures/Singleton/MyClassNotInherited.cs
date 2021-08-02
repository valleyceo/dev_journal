// Non-inherited singleton pattern (commonly used in Unity)
public class MyClassNotInherited : MonoBehaviour
{
    public static MyClassNotInherited Instance { set; get; }

    private void Start()
    {
    	 Instance = this;
    }
}
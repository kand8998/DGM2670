public class Drag : MousePosition
{
    public GameAction Action;
    private void Start()
    {
        Action.action += Dragging;
    }
    private void Dragging()
    {
        transform.position = GetMouseWorldPos() + offsetPosition;
    }
}

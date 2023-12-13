namespace System.Windows.Forms
{
    internal class EventHandler
    {
        private Action<object, EventArgs> playerCar_DoubleClick;

        public EventHandler(Action<object, EventArgs> playerCar_DoubleClick)
        {
            this.playerCar_DoubleClick = playerCar_DoubleClick;
        }
    }
}
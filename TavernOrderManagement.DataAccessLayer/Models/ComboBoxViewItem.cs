namespace TavernOrderManagement.DataAccessLayer.Models
{
    public class ComboBoxViewItem
    {
        public string Text { get; set; }
        public object Value { get; set; }
        public override string ToString() => Text;
    }
}

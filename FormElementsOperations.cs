using System.Drawing;
using System.Windows.Forms;

namespace Sklad_Predpriyatiya
{
    internal class FormElementsOperations
    {
        public Button AddButton(string Text, Point Location, Size Size, string Name = null)
        {
            Button _Result = new Button();
            _Result.Text = Text;
            _Result.Location = Location;
            if(Size != new Size(0, 0))
                _Result.Size = Size;
            if(Name != null)
                _Result.Name = Name;
            return _Result;
        }

        public TextBox AddTextBoxToForm(string Text, Point Location, Size Size, Form form, string Name = null)
        {
            Label _Label = new Label();
            _Label.Text = Text;
            _Label.Location = Location;
            form.Controls.Add(_Label);
            TextBox _Result = new TextBox();
            if(Name != null)
                _Result.Name = Name;
            _Result.Size = Size;
            _Result.Location = new Point(_Label.Location.X, _Label.Location.Y + 23);
            form.Controls.Add(_Result);
            return _Result;
        }
    }
}

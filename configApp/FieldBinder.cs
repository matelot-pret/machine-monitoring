using System;
using System.Collections.Generic;
using System.Text;

namespace configApp
{
    public class FieldBinder
    {
        /// <summary>
        /// holds the IsValid predicate and Store action for one field
        /// </summary>
        private class FieldBinding
        { 
            public required Func<string, bool> IsValid;
            public required Action<string> Store;
        }

        private readonly Dictionary<TextBox, FieldBinding> bindings = new Dictionary<TextBox, FieldBinding>();

        /// <summary>
        /// Events raised after a value is stored on leave
        /// </summary>
        public event EventHandler? FieldStored;
        /// <summary>
        /// Event raised after recoloring on text changed
        /// </summary>
        public event EventHandler? FieldChanged;

        /// <summary>
        /// wires a Textbox to a validation rule and a store action.
        /// </summary>
        /// <param name="box">the TextBox</param>
        /// <param name="isValid">the predicate which decide the BackColor</param>
        /// <param name="store">the action writing the value on leave</param>
        /// <note>need to subscribe Leave and TextChanged first</note>
        public void Bind(TextBox box, Func<string, bool> isValid, Action<string> store)
        {
            bindings[box] = new FieldBinding { IsValid = isValid, Store = store };
            box.Leave += OnFieldLeave;
            box.TextChanged += OnFieldTextChanged;
        }

        /// <summary>
        /// stores the textBox value via its bound Store then raise FieldStored event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnFieldLeave(object? sender, EventArgs e)
        {
            if (sender is not null)//for remove the warnings
            {
                TextBox box = (TextBox)sender;
                FieldBinding binding = bindings[box];
                binding.Store(box.Text);
                FieldStored?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// recolors the TextBox then raises FieldChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnFieldTextChanged(object? sender, EventArgs e)
        {
            if(sender is not null)//for remove the warning
            {
                TextBox box = (TextBox)sender;
                box.BackColor = bindings[box].IsValid(box.Text) ? Color.White : Color.LightPink;
                FieldChanged?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}

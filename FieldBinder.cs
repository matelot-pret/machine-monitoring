using System;
using System.Collections.Generic;
using System.Text;

namespace configApp
{
    public class FieldBinder
    {
        private class FieldBinding
        {
            public required Func<string, bool> IsValid;
            public required Action<string> Store;
        }

        private readonly Dictionary<Control, FieldBinding> bindings = new Dictionary<Control, FieldBinding>();

        public event EventHandler? FieldStored;

        public void Bind(TextBox box, Func<string, bool> isValid, Action<string> store)
        {
            bindings[box] = new FieldBinding { IsValid = isValid, Store = store };
            box.Leave += OnFieldLeave;
            box.TextChanged += OnFieldTextChanged;
        }

        private void OnFieldLeave(object? sender, EventArgs e)
        {
            if (sender != null)//for remove the warnings
            {
                TextBox box = (TextBox)sender;
                FieldBinding binding = bindings[box];
                binding.Store(box.Text);
                FieldStored?.Invoke(this, EventArgs.Empty);
            }
        }

        private void OnFieldTextChanged(object? sender, EventArgs e)
        {
            if(sender != null)//for remove the warning
            {
                TextBox box = (TextBox)sender;
                box.BackColor = bindings[box].IsValid(box.Text) ? Color.White : Color.LightPink;
            }
        }
    }
}

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

        private readonly Dictionary<TextBox, FieldBinding> bindings = new Dictionary<TextBox, FieldBinding>();

        public event EventHandler? FieldStored;
        public event EventHandler? FieldChanged;

        public void Bind(TextBox box, Func<string, bool> isValid, Action<string> store)
        {
            bindings[box] = new FieldBinding { IsValid = isValid, Store = store };
            box.Leave += OnFieldLeave;
            box.TextChanged += OnFieldTextChanged;
        }

        private void OnFieldLeave(object? sender, EventArgs e)
        {
            if (sender is TextBox box)//for remove the warnings
            {
                FieldBinding binding = bindings[box];
                binding.Store(box.Text);
                FieldStored?.Invoke(this, EventArgs.Empty);
            }
        }

        private void OnFieldTextChanged(object? sender, EventArgs e)
        {
            if(sender is TextBox box)//for remove the warning
            {
                box.BackColor = bindings[box].IsValid(box.Text) ? Color.White : Color.LightPink;
                FieldChanged?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}

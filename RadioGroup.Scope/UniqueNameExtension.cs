using System;
using System.Windows.Markup;

namespace RadioGroup.Scope
{
    public class UniqueNameExtension : MarkupExtension
    {
        private string _name;

        public UniqueNameExtension()
        {
            _name = Guid.NewGuid().ToString("N");
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return _name;
        }
    }
}
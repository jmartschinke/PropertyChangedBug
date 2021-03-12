using PropertyChanged;

namespace PropertyChangedBug.Working
{
    [AddINotifyPropertyChangedInterface]
    public class BaseClass
    {
        [OnChangedMethod(nameof(ProcessPropertyWasChanged))]
        public object Property { get; set; }

        public virtual void ProcessPropertyWasChanged()
        {
            // Do something
        }
    }

    public class DerivedClass : BaseClass
    {
        public override void ProcessPropertyWasChanged()
        {
            base.ProcessPropertyWasChanged();
        }
    }
}

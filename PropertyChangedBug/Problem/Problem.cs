using PropertyChanged;

namespace PropertyChangedBug.Problem
{
    [AddINotifyPropertyChangedInterface]
    public class BaseClass
    {
        [OnChangedMethod(nameof(ProcessPropertyWasChanged))]
        public object Property { get; set; }

        public void ProcessPropertyWasChanged()
        {
            // Do something
        }
    }

    public class DerivedClass : BaseClass
    {

    }
}

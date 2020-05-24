using FormsControls.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Transition
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page3 : ContentPage, IAnimationPage
    {
        public IPageAnimation PageAnimation { get; } = new RollPageAnimation
        {
            Duration = AnimationDuration.Long,
            Subtype = AnimationSubtype.FromBottom
        };

        public Page3()
        {
            InitializeComponent();

            PageAnimation = new RollPageAnimation
            {
                Duration = AnimationDuration.Long,
                Subtype = AnimationSubtype.FromBottom
            };
        }

        public void OnAnimationFinished(bool isPopAnimation)
        {
            //throw new NotImplementedException();
        }

        public void OnAnimationStarted(bool isPopAnimation)
        {
            //throw new NotImplementedException();
        }
    }
}
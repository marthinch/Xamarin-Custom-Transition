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
	public partial class Page2 : ContentPage, IAnimationPage
    {
        public IPageAnimation PageAnimation { get; } 

        public Page2 ()
		{
			InitializeComponent ();

            PageAnimation = new FadePageAnimation
            {
                Duration = AnimationDuration.Long,
                Subtype = AnimationSubtype.FromRight
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
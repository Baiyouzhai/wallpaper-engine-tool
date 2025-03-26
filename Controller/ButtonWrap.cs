using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wallpaper.Controller {

    public class ButtonWrap {

        public static readonly Action<object, EventArgs> Null = (sender, e) => { };

        protected Button button;
        protected Action<object, EventArgs> callback;

        public ButtonWrap(Button button, Action<object, EventArgs> callback) {
            this.button = button;
            this.callback = callback ?? Null;
        }

        public string Name {
            get => button.Text;
            set => button.Text = value ?? string.Empty;
        }

        public bool Display {
            get => button.Visible;
            set {
                if (value) {
                    button.Show();
                } else {
                    button.Hide();
                }
            }
        }

        public Action<object, EventArgs> Callback {
            get => callback ?? Null;
            set => callback = value ?? throw new ArgumentNullException(nameof(value));
        }

    }

}

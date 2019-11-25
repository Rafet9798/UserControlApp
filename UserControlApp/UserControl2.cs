
using System.Windows.Forms;

namespace UserControlApp
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        private static  UserControl1 _instance;
        public static UserControl1 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl1();
                return _instance;
            }
        }
        private void UserControl2_Load(object sender, System.EventArgs e)
        {

        }
    }
}

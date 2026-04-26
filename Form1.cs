using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PASSWORD_GENERATOR
{
    

    public partial class Form1 : Form
    {

        List<string> Copy = new List<string>();

        enum enCharType
        {
             CapitalLetter = 1, smallLetter = 2, Digit = 3, MixChar = 4, specialCharactor = 5
        };

        public Form1()
        {
            InitializeComponent();
              CinematicUI.ApplyCinematicStyle(this);
            // CinematicUI.ApplyTheme(this);

            // ﬂÊœ ≈÷«›Ì ·Ã⁄· ’‰œÊﬁ «·‰’ ›Ì «·„‰ ’› Ê»œÊ‰ ÕÊ«› ﬁœÌ„…
            // txtPassword.SelectionAlignment = HorizontalAlignment.Center;
        }


        private static Random _Random = new Random();


        private int GetRandomNumber(int From, int To)
        {
            return (int) _Random.Next(From, To + 1);
        }


        private char GetRandomCharacter(enCharType charType)
        {
            switch (charType)
            {
                case enCharType.smallLetter:
                    return (char)GetRandomNumber(97, 122);

                case enCharType.CapitalLetter:
                    return (char)GetRandomNumber(65, 90);

                case enCharType.Digit:
                    return (char)GetRandomNumber(48, 57);

                case enCharType.specialCharactor:
                    return (char)GetRandomNumber(33, 47);

                case enCharType.MixChar:
                    return (char)GetRandomNumber(33, 122);

                default:
                    return (char)GetRandomNumber(65, 90);
            }
        }


        private string GetPassword()
        {
            StringBuilder Password = new StringBuilder();
            int Length = (int)PasswordLength.Value;

            var selectedTypes = new System.Collections.Generic.List<enCharType>();

            if (chkSmall.Checked) selectedTypes.Add(enCharType.smallLetter);
            if (chkCapital.Checked) selectedTypes.Add(enCharType.CapitalLetter);
            if (chkDigits.Checked) selectedTypes.Add(enCharType.Digit);
            if (chkSpecial.Checked) selectedTypes.Add(enCharType.specialCharactor);
            if (chkMix.Checked) selectedTypes.Add(enCharType.MixChar);


            for (int i = 0; i < Length; i++)
            {
                var charType = selectedTypes[GetRandomNumber(0, selectedTypes.Count - 1)];
                Password.Append(GetRandomCharacter(charType));
            }

            return Password.ToString();

        }


        private void PasswordLength_Scroll(object sender, EventArgs e)
        {
            lblPasswordLength.Text = PasswordLength.Value.ToString();

        }

  
        private void bntGenerate_Click(object sender, EventArgs e)
        {
            if (!chkSmall.Checked && !chkCapital.Checked && !chkDigits.Checked && !chkSpecial.Checked && !chkMix.Checked)
            {
                errorProvider1.SetError(bntGenerate, "Please select at least one type.");
                txtPassword.Focus();
                return;
            }

            errorProvider1.Clear();
            txtPassword.Text = GetPassword();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void bntCopy_Click(object sender, EventArgs e)
        {
            Copy = txtPassword.Text.ToCharArray().Select(c => c.ToString()).ToList();
        }

        private void bntReset_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
             chkSmall.Checked = false;
             chkCapital.Checked = false;
             chkDigits.Checked = false;
             chkSpecial.Checked = false;
             chkMix.Checked = false;
             PasswordLength.Value = 0;
            lblPasswordLength.Text = 0.ToString();
        }

        private void pictureClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
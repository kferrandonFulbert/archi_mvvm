using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Contact.ViewModel;

namespace Contact
{
    public partial class Form1 : Form
    {
        private ContactViewModel _viewModel;
        public Form1()
        {
            InitializeComponent();
            this._viewModel = new ContactViewModel();
            // Lier les propriétés des TextBox aux propriétés du vue-modèle
            nameTextBox.DataBindings.Add("Text", this._viewModel, "Name");
            emailTextBox.DataBindings.Add("Text", this._viewModel, "Email");
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveContact(_viewModel.Name, _viewModel.Email);
        }
        private void SaveContact(string name, string email)
        {
            // Implémenter la logique de sauvegarde du contact ici
            MessageBox.Show($"Contact enregistré : {name}, {email}");
        }
    }
}

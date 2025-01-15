    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
using System.Security.Cryptography;
using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    namespace FormFeedBack
    {
    public partial class Form1 : Form
    {
        private int currentRating = 0;
        private FeedbackService feedbackService;
        private DataManager dataManager;
        private const string AdminPassword = "240be518fabd2724ddb6f04eeb1da5967448d7e831c08c8fa822809f74c720a9";
        public Form1()
        {
            InitializeComponent();
            feedbackService = new FeedbackService();
            dataManager = new DataManager(feedbackService);
            LoadData();
        }

        private void LoadData()
        {
            dataManager.LoadFromFile();  
            UpdateListBox();
        }

        private void SaveData()
        {
            dataManager.SaveToFile();  
        }

        private void UpdateListBox()
        {
            listBoxFeedbacks.DataSource = null;
            listBoxFeedbacks.DataSource = feedbackService.GetFeedback();
        }

        // Clear the list box when switching tabs to prevent unauthorized access 
        private void ClearListbox(object sender, TabControlEventArgs e) 
        {
            listBoxFeedbacks.DataSource = null;
        }

        private void BtnDeleteFeedback_Click_1(object sender, EventArgs e)
        {
            if(listBoxFeedbacks.SelectedItem != null)
            {
                Feedback selectedFeedback = listBoxFeedbacks.SelectedItem as Feedback;

                if (selectedFeedback != null) 
                {
                    feedbackService.Remove(selectedFeedback);
                    dataManager.DeleteFromFile(selectedFeedback);
                    UpdateListBox();
                    SaveData();
                    MessageBox.Show("Feedback deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else 
            {
                MessageBox.Show("Please select a feedback to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnSubmitFeedback_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxName.Text) && !string.IsNullOrWhiteSpace(textBoxFeedback.Text) && currentRating > 0)
            {
                string name = textBoxName.Text;
                string comment = textBoxFeedback.Text;
                int rating = currentRating;

                Feedback newFeedback = new Feedback(name, comment, rating);

                feedbackService.Add(newFeedback);
                dataManager.SaveToFile();

                MessageBox.Show("Thank you for your feedback!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBoxName.Clear();
                textBoxFeedback.Clear();
                currentRating = 0;
            }
            else 
            {
                MessageBox.Show("Please fill in all fields and select a rating.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Handle the click event for rating buttons. It determines which button was clicked,
        // retrieves its text (representing the rating), and updates the currentRating
        private void BtnRating_Click(object sender, EventArgs e) {
            Button btn = sender as Button;
            if (btn != null) {
                int rating = int.Parse(btn.Text);
                this.currentRating = rating;
                MessageBox.Show($"Rating set to {currentRating}", "Rating", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Log in using the correct password. Once logged in, show all available feedback.
        private void BtnAdminLogin_Click_1(object sender, EventArgs e) {
            string enteredPassword = txtAdminPassword.Text;
            string hashedEnteredPassword = HashPassword(enteredPassword);

            if (hashedEnteredPassword == AdminPassword)
            {
                MessageBox.Show("Admin login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateListBox();
                txtAdminPassword.Clear();
            }
            else 
            {
                MessageBox.Show("Incorrect password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void HidePassword(object sender, EventArgs e) {
            txtAdminPassword.PasswordChar = '*';
        }
        private string HashPassword(string password) {
            using (var sha256 = SHA256.Create()) {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                byte[] hashedBytes = sha256.ComputeHash(passwordBytes);

                // Convert the hashed byte array to a hexadecimal string
                StringBuilder hexString = new StringBuilder();
                foreach (byte b in hashedBytes)
                {
                    hexString.Append(b.ToString("x2"));
                }
                return hexString.ToString();
            }
        }
    }
}

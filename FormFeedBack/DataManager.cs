using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace FormFeedBack
{
    public class DataManager
    {
        private string filePath = "C:\\Users\\andre\\Desktop\\FormFeedBack\\FormFeedBack\\FormFeedBack\\feedback_data.txt";
        private FeedbackService feedbackService;

        public DataManager(FeedbackService feedbackService) {
            this.feedbackService = feedbackService;
        }
        public void LoadFromFile() {
            FileStream fs = null;
            StreamReader sr = null;
            try {
                fs = new FileStream(this.filePath, FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);
                string line;

                while ((line = sr.ReadLine()) != null) {
                    string[] data = line.Split('|');
                    string name = data[0];
                    string comment = data[1];
                    int rating = int.Parse(data[2]);

                    Feedback newFeedback = new Feedback(name, comment, rating);
                    feedbackService.Add(newFeedback);
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Error loading feedback: " + ex.ToString());
            }
            finally {
                if (fs != null) {
                    fs.Close();
                }
            }
        }
        public void SaveToFile() {
            StreamWriter sw = null;
            try {
                sw = new StreamWriter(this.filePath, false);

                foreach (Feedback feedback in feedbackService.GetFeedback()) {
                    sw.WriteLine($"{feedback.GetName()}|{feedback.GetComment()}|{feedback.GetRating()}");
                }
            }
            catch (Exception e) {
                MessageBox.Show("Error writing feedback to file: " + e.ToString());
            }
            finally {
                if (sw != null) {
                    sw.Close();
                }
            }
        }
        public void DeleteFromFile(Feedback feedbackToDelete) {
            try {
                List<string> lines = new List<string>();
                lines = File.ReadAllLines(filePath).ToList();

                string feedback = $"{feedbackToDelete.GetName()}|{feedbackToDelete.GetComment()}|{feedbackToDelete.GetRating()}";
                
                for (int i = 0; i < lines.Count; i++) {
                    if (lines[i].Trim() == feedback.Trim()) {
                        lines.RemoveAt(i);
                        break;
                    }
                }
                File.WriteAllLines(filePath, lines);
            }
            catch (Exception ex) {
                MessageBox.Show("Error deleting feedback from file: " + ex.ToString());
            }
        }
    }
}
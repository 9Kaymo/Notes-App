using System.IO;
namespace NotesApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = this.fileName.Text.ToString();
            if (string.IsNullOrWhiteSpace(path))
            {
                MessageBox.Show("Please enter a valid file name.");
                return;
            }
            try
            {
                string file = File.ReadAllText(path);
                textBox1.Text = file;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading file: {ex}");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string path = this.fileName.Text.ToString();
            string text = textBox1.Text.ToString();

            if (string.IsNullOrWhiteSpace(path))
            {
                MessageBox.Show("Please enter a valid file name.");
                return;
            }
            try
            {
                File.WriteAllText(path, text);
                MessageBox.Show("File saved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving file: {ex}");
            }
        }

    }

}

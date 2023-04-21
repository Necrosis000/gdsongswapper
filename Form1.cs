using System.Windows.Forms;

namespace gdsongswapper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void browseFiles_Click(object sender, EventArgs e)
        {
            browseFileDialog.DefaultExt = "mp3";
            browseFileDialog.AddExtension = true;
            browseFileDialog.InitialDirectory = @"C:\";
            browseFileDialog.Title = "Find Audio File";
            browseFileDialog.Filter = "audio files (*.mp3)|*.mp3";

            if (browseFileDialog.ShowDialog() == DialogResult.OK)
            {
                // If file is found and correct
                Console.WriteLine("Ok");
                audioFileNameLbl.Text = browseFileDialog.SafeFileName;
            }
            }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Replace Song
            try
            {
                var appdata = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                File.Move(browseFileDialog.FileName, appdata + "\\GeometryDash\\" + songIdLbl.Text + ".mp3", true);
                MessageBox.Show("Song Succesfully Replaced!");
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("An error occured: File not Found (possibly forgot to change input file)");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
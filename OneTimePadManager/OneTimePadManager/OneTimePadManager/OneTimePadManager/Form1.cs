using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OneTimePadManager
{
    /// <summary>
    /// this is a form that will act as teh view in a one time pad manager that will encrypt and decrypt
    /// user input using a specified key or generated key from the user to create data that cannot mathem-
    /// atically by decrypted without the key regardless of time or energy potential. 
    /// </summary>
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //defaults to text input
            manualTxtInputRadioButton.Select();
            keyTextUploadRadioButton.Select();
            
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            
           
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            //if text box input is not empty, assume valid and try to open or process data. 
            if (inputTextBox.Text != "" && keyTextBox.Text != "")
            {
                //calls data input functions depending on user choice
                if (fileIORadioButton.Checked)
                {
                  
                   string encryptedMessage = infoFileUpload(inputTextBox.Text); //grabs inputted file contents before decrypting
                   if (encryptedMessage != null)
                   {
                        outputLabel.Text = encryptedMessage;
                   } 
                }
                else if (manualTxtInputRadioButton.Checked)
                {
                    decrypt(inputTextBox.Text); //directly decrypts the text box contents
                }
            }
            else
            {
                outputLabel.Text = "Error, please ensure text box fields either include the raw" +
                    " encrypted text or the proper file name.";
            }
        }
        /// <summary>
        /// reads the file uploaded by the user and returns the contents as a string. 
        /// if contents cannot be read returns null. 
        /// </summary>
        /// <param name="fileName">the file name the user has entered</param>
        /// <returns>file contents or null in the event of an error</returns>
        private string infoFileUpload(string fileName)
        {
            FileStream file;
            StreamReader data;
            try //checks for file presence.
            {
                file = new FileStream($"{fileName}.txt", FileMode.Open, FileAccess.Read);
                data = new StreamReader(file);
            }
            catch (Exception ex)
            {
                outputLabel.Text = "Error, file cannot be accessed, \nensure proper file name entered and file " +
                    "is present within the directory bin/Debug";
                return null;
            }
            try //tries to read file contents.
            {
                string contents = data.ReadToEnd();
                return contents;
            }
            catch
            {
                outputLabel.Text =  "error, cannot read file. ensure file is not corrupted.";
                return null;
            }
           
        }
        private void decrypt(string encryptedInfo)
        {

        }
    }
}

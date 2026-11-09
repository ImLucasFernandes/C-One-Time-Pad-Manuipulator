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
            //if text box input is not empty, assume valid and try to open or process data. 
            if (inputTextBox.Text != "" && keyTextBox.Text != "")
            {
                //empty by default
                string decryptedMessage = "";
                string key = "";
                //calls data input functions depending on user choice
                if (fileIORadioButton.Checked) //if message file upload chosen
                {
                    decryptedMessage = infoFileUpload(inputTextBox.Text);
                }
                else if (manualTxtInputRadioButton.Checked) //if manual message text upload
                {
                    decryptedMessage = inputTextBox.Text;
                }
                if (keyFileRadioButton.Checked) //if key file uploaded
                {
                    key = infoFileUpload(keyTextBox.Text);
                }
                else if (keyTextUploadRadioButton.Checked)
                {
                    key = keyTextBox.Text;
                }
                encrypt(decryptedMessage, key);
            }
            else
            {
                outputTextBox.Text = "Error, please ensure text box fields either include the raw" +
                    " encrypted text or the proper file name.";
            }

        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            //if text box input is not empty, assume valid and try to open or process data. 
            if (inputTextBox.Text != "" && keyTextBox.Text != "")
            {
                //empty by default
                string encryptedMessage = "";
                string key = "";
                //calls data input functions depending on user choice
                if (fileIORadioButton.Checked) //if message file upload chosen
                {
                    encryptedMessage = infoFileUpload(inputTextBox.Text);
                }
                else if (manualTxtInputRadioButton.Checked) //if manual message text upload
                {
                    encryptedMessage = inputTextBox.Text;
                }
                if (keyFileRadioButton.Checked) //if key file uploaded
                {
                    key = infoFileUpload(keyTextBox.Text);
                }
                else if (keyTextUploadRadioButton.Checked)
                {
                    key = keyTextBox.Text;
                }
                decrypt(encryptedMessage, key);
            }
            else
            {
                outputTextBox.Text = "Error, please ensure text box fields either include the raw" +
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
                outputTextBox.Text = "Error, file cannot be accessed, \nensure proper file name entered and file " +
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
                outputTextBox.Text =  "error, cannot read file. ensure file is not corrupted.";
                return null;
            }
           
        }
        private void decrypt(string encryptedMessage, string key)
        {
            char[] encryptedArray = encryptedMessage.ToArray();
            char[] keyArray = key.ToArray();
            string decryptedMessage = "";
            //AI used to learn the difference between binary conversion requiring XOR operation and alphanumeric using +/- instead
            //this encryption method with use addition for encryption and subtraction as the inverse for decryption
            for (int i = 0; i < encryptedArray.Length; i++)
            {
                char keyChar = keyArray[i];
                char encryptedChar = encryptedArray[i];
                decryptedMessage += (char)(encryptedChar - keyChar);

            }
            outputTextBox.Text = decryptedMessage;
        }
        private void encrypt(string decryptedMessage, string key)
        {
            char[] decryptedArray = decryptedMessage.ToArray();
            char[] keyArray = key.ToArray();
            string encryptedMessage = "";
            //AI used to learn the difference between binary requiring XOR operation and alphanumeric using +/- instead,
            //also used as a decryt and encrypt examples to compare to my own code. 
            //this encryption method with use addition for encryption and subtraction as the inverse for decryption
            for (int i = 0; i < decryptedArray.Length; i++)
            {
                char keyChar = keyArray[i];
                char encryptedChar = decryptedArray[i];
                encryptedMessage += (char)(encryptedChar + keyChar);
            }
            outputTextBox.Text = encryptedMessage;
        }
    }
}

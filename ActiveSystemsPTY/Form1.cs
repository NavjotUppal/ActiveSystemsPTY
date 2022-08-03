// Active Systems PTY by Navjot Kaur

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ActiveSystemsPTY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<String> regoList = new List<String>(); //RegoList declaration


        // Button Enter Code
        private void ButtonEnter_Click(object sender, EventArgs e)
        {
            StatusMsg.Items.Clear(); // Clear the message in Status Strip
            if (TextBoxVehicleDetails.Text == "")
            {
                MessageBox.Show("Please Enter the Car Details in Text Field Provided");
                TextBoxVehicleDetails.Focus();
            }
            else if (TextBoxVehicleDetails.Text != "")
            {
                String car1 = TextBoxVehicleDetails.Text;
                String car = TextBoxVehicleDetails.Text.ToUpper();
                if (regoList.Contains(car) || regoList.Contains("z" + car) || regoList.Contains(car1)) // check if the car exist in the system already
                {
                    MessageBox.Show("Rego Already Exist in the system.");
                    TextBoxVehicleDetails.Clear(); // Clear the Contents of textbox                                         
                    TextBoxVehicleDetails.Focus(); // Brings the focus back to texbox
                    StatusMsg.Items.Add(car + " already exist in the list");

                }
                else
                {
                    ListBoxVehicleDetails.Items.Add(TextBoxVehicleDetails.Text.ToUpper()); // Add the Rego of the car eneterd in textbox to the list box
                    regoList.Add(car); // Adding data to List <regoList>
                    regoList.Sort(); // Sort the list
                    ListBoxVehicleDetails.Sorted = true;
                    TextBoxVehicleDetails.Clear(); // Clear the Contents of textbox
                                                   //TextBoxVehicleDetails.SelectAll();
                    TextBoxVehicleDetails.Focus(); // Brings the focus back to texbox
                    StatusMsg.Items.Add(car+ " has been added to the list"); // display the message in status strip
                }
            }

        }
        // To Exit a car from the system
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            StatusMsg.Items.Clear();

            String item = ListBoxVehicleDetails.SelectedItem.ToString(); // Selects the Rego (item) from the list
            if (item == "")
            {
                StatusMsg.Items.Add("Click is Void");

            }
            else if (item != "")
            {
                foreach (String target in ListBoxVehicleDetails.SelectedItems.OfType<string>().ToList())
                    ListBoxVehicleDetails.Items.Remove(target); // Remove the selected Rego from the list

                regoList.Sort(); // Sort the list
                ListBoxVehicleDetails.Sorted = true;
                TextBoxVehicleDetails.Clear();
                StatusMsg.Items.Add((string)item + " has been removed from the list"); // display the message in status strip
            }
        }
        // Double click to remove the car from the list
        private void ListBoxVehicleDetails_doubleClick(object sender, MouseEventArgs e)
        {
            StatusMsg.Items.Clear();
            if (ListBoxVehicleDetails.SelectedItem != null)
            {
                MessageBox.Show("Delete Car Details " + ListBoxVehicleDetails.SelectedItem);
                ListBoxVehicleDetails.Items.Remove(ListBoxVehicleDetails.SelectedItem); // Remove the selected rego from the list
                regoList.Sort();
                ListBoxVehicleDetails.Sorted = true;
                StatusMsg.Items.Add(ListBoxVehicleDetails.SelectedItem + " has been removed from the list");

            }
        }
        // Single click to display the car rego in text box
        private void ListBoxVehicleDetails_Click(object sender, EventArgs e)
        {
            StatusMsg.Items.Clear();
            if (ListBoxVehicleDetails.SelectedItem == null)
            {
                MessageBox.Show("Click is void");
                StatusMsg.Items.Add("Click is Void");
            }
            else
            {
                //ButtonEnter.Enabled = false; // disable the Enter and Exit Buttons
                // ButtonExit.Enabled = false;
                TextBoxVehicleDetails.Clear();
                TextBoxVehicleDetails.SelectedText = ListBoxVehicleDetails.SelectedItem.ToString(); // shows the car rego in the text
                StatusMsg.Items.Add(ListBoxVehicleDetails.SelectedItem + " is selected.");
            }


        }
        // Code for Edit button
        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            //String target = ListBoxVehicleDetails.SelectedItem.ToString();
            StatusMsg.Items.Clear();

            if (ListBoxVehicleDetails.SelectedItem.ToString() != null)
            {
                Object item = TextBoxVehicleDetails.Text.ToString();

                int index = ListBoxVehicleDetails.SelectedIndex;
                ListBoxVehicleDetails.Items.RemoveAt(index); // Remove the rego using the index
                // insert modified item...
                ListBoxVehicleDetails.Items.Insert(index, item); // Insert the updated rego at the same index
                regoList.Sort();
                ListBoxVehicleDetails.Sorted = true;

                TextBoxVehicleDetails.Clear();
                TextBoxVehicleDetails.Focus();

            }


        }
        // Code for Reset Button
        private void ButtonReset_Click(object sender, EventArgs e)
        {
            StatusMsg.Items.Clear();
            MessageBox.Show("Are you sure you want to Reset the Form?");
            ListBoxVehicleDetails.Items.Clear();
            TextBoxVehicleDetails.Clear();
            StatusMsg.Items.Add("Form has been Reset");
        }
        public String TakeValue()
        {
            if (TextBoxVehicleDetails.Text != null)
            {
                String target = TextBoxVehicleDetails.Text;
                if (target.StartsWith("z"))
                {
                    target = target.Substring(1); // substring will start from 2nd letter in the Rego, z will be removed
                }
                return target;
            }
            else
            {

                return null;
            }
        }
        // Code for binary search
        private void ButtonBinarySearch_Click(object sender, EventArgs e)
        {

            StatusMsg.Items.Clear();
            String target = TakeValue();
            if (target == "")
            {
                MessageBox.Show("The text field should not be null");
                TextBoxVehicleDetails.Focus();
            }
            else
            {
                int index = regoList.BinarySearch(target); // default method for binary search
                if (index != -1)  // shows if the search is successful
                {
                    MessageBox.Show("Rego Plate found at index: " + index);
                    StatusMsg.Items.Add("Rego Plate found at index: " + index);
                }
                else // if the search is unsuccessful 
                {
                    MessageBox.Show("Rego Plate-Not Found");
                    StatusMsg.Items.Add("Rego Plate Not Found");
                }
                TextBoxVehicleDetails.Clear();
                TextBoxVehicleDetails.Focus();

                // ts.Add(ListBoxVehicleDetails.Items);
            }

        }
        // Code for Linear Search Button
        private void ButtonLinearSearch_Click(object sender, EventArgs e)
        {
            // String target = TextBoxVehicleDetails.Text;
            StatusMsg.Items.Clear();
            String target = TakeValue();
            if (target == "")
            {
                MessageBox.Show("The text field should not be null");
                TextBoxVehicleDetails.Focus();
            }
            else
            {
                bool flag = false;
                int index = 0;
                //int index = ts.Search(target);
                for (int i = 0; i < regoList.Count; i++)
                {
                    if (regoList[i] == target)
                    {
                        index = i;
                        flag = true;
                        MessageBox.Show("Rego Plate found at index: " + index);
                        StatusMsg.Items.Add("Rego Plate found at index: " + index);
                        TextBoxVehicleDetails.Clear();
                        TextBoxVehicleDetails.Focus();
                    }

                }
                if (!flag)
                {
                    MessageBox.Show("Rego Plate-Not Found");
                    StatusMsg.Items.Add("Rego Plate Not Found");
                }
                TextBoxVehicleDetails.Clear();
                TextBoxVehicleDetails.Focus();

                // ts.Add(ListBoxVehicleDetails.Items);
            }

        }
        //Code for Save file button
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (ListBoxVehicleDetails.Items.Count == 0)
            {
                MessageBox.Show("List Box is empty");

            }
            else if (ListBoxVehicleDetails.Items.Count > 0)
            {
                StatusMsg.Items.Clear();

                SaveFileDialog fileDialog1 = new SaveFileDialog(); // to open save dialog box
                fileDialog1.Filter = "Text File | *.txt"; // file to be saved as text file
                fileDialog1.ShowDialog(); // to show the dialog box

                if (fileDialog1.FileName != "") // if file name is not null
                {

                    StreamWriter writefile = new StreamWriter(fileDialog1.FileName); // allows user to give name to their file

                    foreach (String s in regoList)
                        writefile.WriteLine(s); // Writes the contents of the regoList into text file
                                                //MessageBox.Show(writefile.ToString());
                    writefile.Close();
                    StatusMsg.Items.Add("List has been saved in text file");
                }
                TextBoxVehicleDetails.Clear();
                ListBoxVehicleDetails.Items.Clear();

            }

        }
        // Code for Open file button
        private void ButtonOPEN_Click(object sender, EventArgs e)
        {
            StatusMsg.Items.Clear();
            TextBoxVehicleDetails.Clear();
            ListBoxVehicleDetails.Items.Clear();
            TextBoxVehicleDetails.Clear();
            // List<String> line = new List<String>();
            OpenFileDialog fileDialog1 = new OpenFileDialog(); // for Open dialog box
            fileDialog1.Filter = "Text File | *.txt"; // file to be open should be text file
            fileDialog1.ShowDialog();
            if (fileDialog1.FileName != null) // if file exists
            {
                StreamReader readfile = new StreamReader(fileDialog1.OpenFile()); // Read the contents of the file
                // StreamReader readfile = new StreamReader(fileDialog1.FileName);
                var fileContent = string.Empty; ;
                while ((fileContent = readfile.ReadLine()) != null)
                {
                    ListBoxVehicleDetails.Items.Add(fileContent); // adding the contents to the list box
                    regoList.Add(fileContent);
                }

                readfile.Close();
            }
            StatusMsg.Items.Add("List has been loaded with the contents of .txt file");

        }

        // Code for TAG button
        private void ButtonTAG_Click(object sender, EventArgs e)
        {
            StatusMsg.Items.Clear();
            String prefix = "z";
            //String target = TakeValue();
            String text1;
            if (ListBoxVehicleDetails.SelectedItem.ToString() != null) // if selected item is not null
            {
                String item = TextBoxVehicleDetails.Text.ToString();

                int index = ListBoxVehicleDetails.SelectedIndex;
                if (item.StartsWith(prefix)) // if already tagged, Untag it
                {
                    ListBoxVehicleDetails.Items.RemoveAt(index);
                    text1 = item.Substring(1);
                    // insert modified item...
                    ListBoxVehicleDetails.Items.Insert(index, text1);
                    regoList.Sort();
                    ListBoxVehicleDetails.Sorted = true;
                    //ListBoxVehicleDetails.Items.Insert();
                    TextBoxVehicleDetails.Clear();
                    //TextBoxVehicleDetails.SelectAll();

                    TextBoxVehicleDetails.Focus();
                    StatusMsg.Items.Add(text1 + " has been UNTAGGED");

                }
                else // tag the selected rego
                {
                    ListBoxVehicleDetails.Items.RemoveAt(index);
                    text1 = prefix + item;
                    // insert modified item...
                    ListBoxVehicleDetails.Items.Insert(index, text1);
                    regoList.Sort();
                    ListBoxVehicleDetails.Sorted = true;
                    //ListBoxVehicleDetails.Items.Insert();
                    TextBoxVehicleDetails.Clear();
                    //TextBoxVehicleDetails.SelectAll();

                    TextBoxVehicleDetails.Focus();
                    StatusMsg.Items.Add(item + " has been TAGGED");
                }

            }
        }
        // Code for when close the form
        private void CloseForm_Click(object sender, FormClosingEventArgs e)
        {
            // StatusMsg.Items.Clear();
            DialogResult result;
            // Displays the MessageBox.
            result = MessageBox.Show("Do you wish to close the form", "Form Close", MessageBoxButtons.YesNo);
            //String text = result.ToString();

            if (result == DialogResult.Yes && ListBoxVehicleDetails.Items.Count > 0) // if Yes and the List Box is not empty, saves the data into text file
            {

                int filecount = 0;
                string path = Environment.CurrentDirectory; // path to save the file
                while (File.Exists(path + @"\demo_" + filecount + ".txt"))
                {
                    filecount++;

                }

                StreamWriter writefile = new StreamWriter(path + @"\demo_" + filecount + ".txt");


                foreach (String str in regoList) // writes the contents of listbox into text file
                    writefile.WriteLine(str);

                writefile.Close();
                // e.Cancel = true;
                ListBoxVehicleDetails.Items.Count.Equals(null);
                //Application.Exit();
                MessageBox.Show("Your Data has been saved under file name: demo_" + filecount);// message to show the data has been saved
                                                                                               //this.Hide();



            }

            
            
            else if (result == DialogResult.No) // if No, the form remains open 
            {
                e.Cancel = true;

            }

        }

        private void ListBoxVehicleDetails_MouseHover(object sender, EventArgs e)
        {
            toolTip_ListBoxVehicleDetails.SetToolTip(ListBoxVehicleDetails, "List of Cars Entered into the System");
        }

        private void TextBoxVehicleDetails_MouseHover(object sender, EventArgs e)
        {
            toolTip_TextBoxVehicleDetails.SetToolTip(TextBoxVehicleDetails, "Rego Number");
        }
        private void ButtonOPEN_MouseHover(object sender, EventArgs e)
        {
            toolTip_ButtonOPEN.SetToolTip(ButtonOPEN, "Click to Open the files");
        }
        private void ButtonEnter_MouseHover(object sender, EventArgs e)
        {
            toolTip_ButtonEnter.SetToolTip(ButtonEnter, "Click to Enter Car Rego into System");
        }
        private void ButtonExit_MouseHover(object sender, EventArgs e)
        {
            toolTip_ButtonExit.SetToolTip(ButtonExit, "Click to Exit Car Rego from the System");
        }
        private void ButtonTAG_MouseHover(object sender, EventArgs e)
        {
            toolTip_ButtonTAG.SetToolTip(ButtonTAG, "Click to TAG/UNTAG the Car");
        }
        private void ButtonSave_MouseHover(object sender, EventArgs e)
        {
            toolTip_ButtonSave.SetToolTip(ButtonSave, "Click to Save the list of Regos into System");
        }
        private void ButtonBinarySearch_MouseHover(object sender, EventArgs e)
        {
            toolTip_ButtonBinarySearch.SetToolTip(ButtonBinarySearch, "Click to Binary Search Car Regos from the List");
        }
        private void ButtonLinearSearch_MouseHover(object sender, EventArgs e)
        {
            toolTip_ButtonLinearSearch.SetToolTip(ButtonLinearSearch, "Click to Linear Search Car Regos from the List");
        }
        private void ButtonReset_MouseHover(object sender, EventArgs e)
        {
            toolTip_ButtonReset.SetToolTip(ButtonReset, "Click to Reset the Form");
        }
    }
}
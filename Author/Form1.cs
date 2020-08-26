using GetAuthor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Author
{
    public partial class FormMajor : Form
    {
        private readonly IAuthorInfo writer;

        //Instance of the interface is passed as a parameter to the Form Constructor
        public FormMajor(IAuthorInfo star)
        {
            InitializeComponent();
            this.writer= star;
        }
        /// <summary>
        /// Event Handler for Comment Count
        /// When clicked calls the Get Username By Comment count Returns a List 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCommentClick(object sender, EventArgs e)
        {
            Authors.DataSource = null;
            var display = writer.GetUsernamesByCommentCount();
           
            Authors.DataSource = display;
           

        }

        /// <summary>
        /// Event Handler for Submission Count
        /// When clicked calls the Get Username By Submission Count Method and returns a List
        /// It Catches if there was no threshold added
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSubmission_Click(object sender, EventArgs e)
        {
            Authors.DataSource = null;
            try
            {
                
                int threshold = Int32.Parse(textBox1.Text);
                var disp = writer.GetUsernamesBySubmissionCount(threshold);
                Authors.DataSource = disp;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Threshold Cannot be Empty!!!{0}", ex.Message);
            }   
        }


        /// <summary>
        /// It Clears
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonclear_Click(object sender, EventArgs e)
        {
            Authors.DataSource = null;
        }

        /// <summary>
        /// This method takes a threshold of Datetime and returns Author that was Created before the threshold
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 


        //It has two options of querying data by TimeSpan format and Datetime format depending on information supplied.
        //If time is given in timespan format. It uses that to query Data from the API
        //If the timespan format is not given it uses the datetime picker to query Author by Record Date.
        private void buttonDate_Click(object sender, EventArgs e)
        {
            Authors.DataSource = null;
           if(textBoxDate.Text != "" && textBoxDate.Text.Length ==10)
            {
                long threshold = Int32.Parse(textBoxDate.Text);
                var display = writer.GetUsernamesByRecordDate(threshold);
                Authors.DataSource = display;

            }
            else
            {
                var dt = dateTimePicker1.Value;
                long threshold = (dt.Ticks - 621356166000000000) / 10000000;
                var display = writer.GetUsernamesByRecordDate(threshold);
                Authors.DataSource = display;
            }
        }

        
    }
}

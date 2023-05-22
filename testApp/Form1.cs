namespace testApp
{
    public partial class Form1 : Form
    {
        List<Person> persons = new List<Person>();
        public Form1()
        {
            InitializeComponent();
            FillData();
            UpdateData();

        }


        private void FillData()
        {
            for (int i = 0; i < 10; i++)
            {
                Person person = new Person() { Id = $"1234{i * 11}", Name = $"saxeli {i + 1}", Surname = $"gvari {i + 1}" };
                persons.Add(person);
            }
        }
        private void UpdateData()
        {
            dtgData.DataSource = null;
            dtgData.DataSource = persons;
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(persons.Count() > 0)
            {
                persons.RemoveAt(0);
                UpdateData();
            }
        }
    }
}
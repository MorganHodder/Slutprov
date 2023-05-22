using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace SlutProvReal
{
    public partial class Form1 : Form
    {
        private Thread backgroundThread;

        List<Company> companies = new List<Company>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbxEmployees.Text.All(char.IsDigit))
            {
                Company newCompany = new Company(tbxCompany.Text, int.Parse(tbxEmployees.Text));
                companies.Add(newCompany);
                lbxCompanies.Items.Add($"{newCompany.Name} ({newCompany.Employees})");
            }
            else if(tbxEmployees.Text.All(char.IsLetter))
            {
                tbxEmployees.Text = string.Empty;
                tbxEmployees.Text = "Bara siffror tillåtna";
                Thread.Sleep(1500);
                tbxEmployees.Text = string.Empty;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var selectedItems = lbxCompanies.SelectedItems;
            if (lbxCompanies.SelectedIndex != -1)
            {
                for (int i = selectedItems.Count - 1; i >= 0; i--)
                {
                    lbxCompanies.Items.Remove(selectedItems[i]);
                    companies.RemoveAt(i);
                }
            }
            else if (lbxCompanies.SelectedIndex == -1)
            {
                MessageBox.Show("Ingen bolag markerat", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (tbxFilter.Text == "")
            {
                lbxCompanies.Items.Clear();
                foreach(Company company in companies)
                {
                    lbxCompanies.Items.Add($"{company.Name} ({company.Employees})");
                }
            }
            else
            {
                List<Company> FilteredCompanies = companies.Where(c => c.Employees > int.Parse(tbxFilter.Text)).ToList();
                lbxCompanies.Items.Clear();
                foreach (Company company in FilteredCompanies)
                {
                    lbxCompanies.Items.Add($"{company.Name} ({company.Employees})");
                }
            }
        }
    }

    class Company
    {
        public string Name { get; set; }
        public int Employees { get; set; }
        public Company(string N, int E)
        {
            Name = N; Employees = E;
        }
    }
}

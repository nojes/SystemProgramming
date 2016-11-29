using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using _02_AsyncShop.WinForms.Entities;
using _02_AsyncShop.WinForms.Models;

namespace _02_AsyncShop.WinForms
{
    public partial class MainForm : Form
    {
        private ShopContext context;

        private IEnumerable<Category> AllCategories {
            get
            {
                yield return new Category() {
                    CategoryId = 0,
                    CategoryName = "All categories",
                };
            }
        }

        private IEnumerable<Manufacturer> AllManufacturers {
            get
            {
                yield return new Manufacturer() {
                    ManufacturerId = 0,
                    ManufacturerName = "All manufacturers",
                };
            }
        }

        public MainForm()
        {
            InitializeComponent();

            context = new ShopContext();

            cbCategory.ValueMember = "CategoryId";
            cbCategory.DisplayMember = "CategoryName";
            cbCategory.DataSource = AllCategories
                .Union(context.Categories)
                .ToList();

            cbManufacturer.ValueMember = "ManufacturerId";
            cbManufacturer.DisplayMember = "ManufacturerName";
            cbManufacturer.DataSource = AllManufacturers
                .Union(context.Manufacturers)
                .ToList();
        }

        private async void btnLoadData_Click(object sender, EventArgs e)
        {
            string btnText = btnLoadData.Text;
            btnLoadData.Text = "Loading...";
            btnLoadData.Enabled = false;

            try {
                await LoadData();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error");
            }
           
            btnLoadData.Text = btnText;
            btnLoadData.Enabled = true;
        }

        private async Task LoadData()
        {
            int manufacturerId = Convert.ToInt32(cbManufacturer.SelectedValue);
            int categoryId = Convert.ToInt32(cbCategory.SelectedValue);
            dynamic dynManufacturerId = manufacturerId != 0 ? manufacturerId : (dynamic)"NULL";
            dynamic dynCategoryId = categoryId != 0 ? categoryId : (dynamic)"NULL";

            string query = $"EXEC dbo.GetGoods {dynManufacturerId}, {dynCategoryId}";
            dgvProducts.DataSource = await context.Database.SqlQuery<Good>(query)
                .ToListAsync();
        }
    }
}

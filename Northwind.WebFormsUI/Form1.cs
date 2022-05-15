using Northwind.Business.Concrete;
using Northwind.Business.Abstract;
using Northwind.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Northwind.Business.DependencyResolvers.Ninject;
using Northwind.Entities.Concrete;

namespace Northwind.WebFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _productService = InstanceFactory.GetInstance<IProductService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
        }

        private IProductService _productService;
        private ICategoryService _categoryService;
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadProducts();
        }

        private void LoadCategories()
        {
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";
            cbxCategory.DataSource = _categoryService.GetAll();

            cbxAddCategory.DisplayMember = "CategoryName";
            cbxAddCategory.ValueMember = "CategoryId";
            cbxAddCategory.DataSource = _categoryService.GetAll();

            cbxUpdateCategory.DisplayMember = "CategoryName";
            cbxUpdateCategory.ValueMember = "CategoryId";
            cbxUpdateCategory.DataSource = _categoryService.GetAll();
        }

        private void LoadProducts()
        {
            //ProductManager productManager = new ProductManager(new EfProductDal());
            //ProductManager productManager = new ProductManager(new NhProductDal());
            dgwProduct.DataSource = _productService.GetAll();
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgwProduct.DataSource = _productService.GetProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
        }

        private void tbxProductName_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxProductName.Text))
            {
                dgwProduct.DataSource = _productService.GetProductsByProductName(tbxProductName.Text);
            }
            else
            {
                LoadProducts();
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Add(new Product
                {
                    ProductName = tbxAddProductName.Text,
                    CategoryId = Convert.ToInt32(cbxAddCategory.SelectedValue),
                    UnitPrice = Convert.ToDecimal(tbxAddUnitPrice.Text),
                    QuantityPerUnit = tbxAddQuantityPerUnit.Text,
                    UnitsInStock = Convert.ToInt16(tbxAddUnitsInStock.Text)
                });
                MessageBox.Show("Urun eklendi!");
                LoadProducts();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Update(new Product
                {
                    ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                    ProductName = tbxUpdateProductName.Text,
                    CategoryId = Convert.ToInt32(cbxUpdateCategory.SelectedValue),
                    UnitPrice = Convert.ToDecimal(tbxUpdateUnitPrice.Text),
                    QuantityPerUnit = tbxUpdateQuantityPerUnit.Text,
                    UnitsInStock = Convert.ToInt16(tbxUpdateUnitsInStock.Text)
                });
                MessageBox.Show("Urun guncellendi!");
                LoadProducts();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwProduct.CurrentRow;
            tbxUpdateProductName.Text = row.Cells[1].Value.ToString();
            cbxUpdateCategory.SelectedValue = row.Cells[2].Value;
            tbxUpdateUnitPrice.Text = row.Cells[3].Value.ToString();
            tbxUpdateQuantityPerUnit.Text = row.Cells[4].Value.ToString();
            tbxUpdateUnitsInStock.Text = row.Cells[5].Value.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgwProduct.CurrentRow != null)
                {
                    _productService.Delete(new Product
                    {
                        ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value)
                    });
                }
                MessageBox.Show("Urun silindi!");
                LoadProducts();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}

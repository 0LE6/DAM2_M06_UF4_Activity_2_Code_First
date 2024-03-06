using CsvHelper;
using DAM2_M06_UF4_Activity_2_Code_First.MODEL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAM2_M06_UF4_Activity_2_Code_First.DAO
{
    public class DAOManager : IDAOManager
    {
        // TODO
        ClassicModelDbContext dbContext = null;
        public DAOManager(ClassicModelDbContext context)
        {
            dbContext = context;
        }
        public void LoadDatabase()
        {
            LoadProductLines();
        }
        private void LoadProductLines()
        {

            // "productLine","textDescription","htmlDescription","image"
            CultureInfo culture = CultureInfo.InvariantCulture;
            using (var reader = new StreamReader("PRODUCTLINES.csv"))
            using (var csv = new CsvReader(reader, culture))
            {
                csv.Read(); //Saltem la primera linia
                while (csv.Read())
                {
                    var productLine = csv.GetField(0);
                    var textDescription = csv.GetField(1);
                    var htmlDescription = csv.GetField(2);
                    var image = csv.GetField(3);

                    ProductLine p = new ProductLine();
                    p.ProductLineCode = productLine;
                    p.TextDescription = textDescription;
                    p.HtmlDescription = htmlDescription;
                    if (image != null) p.Image = Encoding.UTF8.GetBytes(image);
                    AddProductLine(p);
                }
            }
            
        }
        private void AddProductLine(ProductLine p)
        {
           dbContext.ProductLines.Add(p);
           dbContext.SaveChanges();
        }
    }
}

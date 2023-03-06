using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KTLT2_TAODOITUONG
{
    public class Product
    {
        /// <summary>
        /// id ma hang hoa
        /// </summary>
        private int id;
        /// <summary>
        /// name hang hoa
        /// </summary>
        private string name;
        /// <summary>
        /// ngay nhap hang hoa
        /// </summary>
        private DateTime inputDate;
        /// <summary>
        /// so luong
        /// </summary>
        private int quantity;
        /// <summary>
        /// don gia hang hoa
        /// </summary>
        private double price;
        /// <summary>
        /// Thành tiền
        /// </summary>
        private double totalPrice;



        /// <summary>
        /// Khởi tạo hàng hóa tĩnh
        /// </summary>
        public Product()
        {
            id = 0;
            name = "";
            inputDate = DateTime.Now;
            quantity = 0;
            price = 0;
            totalPrice = quantity * price;
        }

        /// <summary>
        /// Khởi tạo hàng hóa có tham só thay đổi
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="inputDate"></param>
        /// <param name="quantity"></param>
        /// <param name="price"></param>
        public Product(int id, string name, DateTime inputDate, int quantity, double price)
        {
            this.id = id;
            this.name = name;
            this.inputDate = inputDate;
            this.quantity = quantity;
            this.price = price;
            this.totalPrice = quantity * price;
        }

        /// <summary>
        /// get set id
        /// </summary>
        public int ID
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// get set Name
        /// </summary>
        public string Name
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// get set ngay nhap
        /// </summary>
        public DateTime InputDate
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// get set So luong
        /// </summary>
        public int Quantity
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// get set Đơn giá
        /// </summary>
        public double Price
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// Nhập 1 hàng hóa
        /// </summary>
        public Product InputProduct()
        {
            Product product = new Product();
            Random r = new Random();
            product.id = r.Next(10000, 99999);
            product.name = $"{TaoRandom.TaoKiTuChuHoa()}{TaoRandom.TaoKiTuChuThuong()}{TaoRandom.TaoKiTuSo()}";
            product.price = double.Parse(TaoRandom.TaoKiTuSo().ToString()) * r.Next(2000, 4000);
            product.inputDate = TaoRandom.TaoNgaySinhTuDongDateTime();
            product.quantity = r.Next(200, 400);
            return product;
        }

        /// <summary>
        /// Nhập danh sách hàng hóa
        /// </summary>
        /// <param name="quantity">Đầu vào yêu cầu nhập số lượng hàng hóa cần lưu</param>
        public List<Product> InputListProduct(int quantity)
        {
            List<Product> products = new List<Product>();
            for (int i = 0; i < quantity; i++)
            {
                products.Add(InputProduct());
            }
            // sort by ten hang hoa
            products.Sort((product1, product2) => product1.name.CompareTo(product2.name));
            return products;
        }

        /// <summary>
        /// Xuất thông tin danh sách hàng hóa
        /// </summary>
        public void PrintListProduct(List<Product> products)
        {
            foreach (Product p in products)
            {
                Console.WriteLine(PrintProduct(p));
            }
        }

        /// <summary>
        /// Xuất thông tin In 1 hàng hóa
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public string PrintProduct(Product p)
        {
            return $"{p.id}-{p.name}-{p.inputDate}-{p.quantity}-{p.price}={p.totalPrice}";
        }
    }
}
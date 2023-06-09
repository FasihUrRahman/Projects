namespace EComProductDetailsMethodOverLoading
{
    internal class Product
    {
        private string productName;
        private string productDescription;
        private string productCategory;
        private double productPrice;
        public void SetValue(string productName,string productDescription, string productCategory, double productPrice)
        {
            this.productName = productName;
            this.productDescription = productDescription;
            this.productCategory = productCategory;
            this.productPrice = productPrice;
        }
        public void SetValue(string productDescription, string productCategory, double productPrice, string productName)
        {
            this.productName = productName;
            this.productDescription = productDescription;
            this.productCategory = productCategory;
            this.productPrice = productPrice;
        }
        public void SetValue(string productCategory, double productPrice, string productName, string productDescription)
        {
            this.productName = productName;
            this.productDescription = productDescription;
            this.productCategory = productCategory;
            this.productPrice = productPrice;
        }
        public void SetValue(double productPrice, string productName, string productDescription, string productCategory)
        {
            this.productName = productName;
            this.productDescription = productDescription;
            this.productCategory = productCategory;
            this.productPrice = productPrice;
        }
        public void GetValue()
        {
            Console.WriteLine($"Your Product Name {productName}, Product Description is {productDescription}, Product Category is {productCategory} and Product Price is {productPrice}PKR");
        }
    }
}

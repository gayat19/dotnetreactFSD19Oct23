import './Product.css';

function Product(){
//var productName="Pencil";
var product = {
    name:"Pencil",
    price:12.5,
    quantity:5
}
var checkQuantity = product.quantity>0?true:false;
return(
    <div className='product'>
        {checkQuantity?
            <div>
            Product Name : {product.name}
             <br/>
             Product Price : {product.price}
             <br/>
             Product Quantity: {product.quantity}
            </div>
            :
            <div>No Product available in stock</div>}
    </div>
    );
}


export default Product;
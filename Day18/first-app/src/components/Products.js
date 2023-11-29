import { useState } from "react";

function Products(){
    const [productList,setProductList]=useState([])
    var getProducts = ()=>{
        fetch('http://localhost:5271/api/Product',{
            method:'GET',
            headers:{
                'Accept':'application/json',
                'Content-Type':'application/json',
                'Authorization':'Bearer '+localStorage.getItem("token")
            }
        }).then(
            async (data)=>{
                var myData = await data.json();
                await console.log(myData);
                await setProductList(myData);
            }
        ).catch((e)=>{
            console.log(e)
        })
    }
    var checkProducts = productList.length>0?true:false;
return(
    <div>
        <h1 className="alert alert-success">Products</h1>
        <button className="btn btn-success" onClick={getProducts}>Get All Products</button>
        <hr/>
        {checkProducts? 
            <div >
                {productList.map((product)=>
                    <div key={product.id} className="alert alert-primary">
                        Product Name : {product.name}
                        <br/>
                        Product Price : {product.price}
                        <br/>
                        Product Quantity: {product.quantity}
                </div>)}
            </div>
            :
            <div>No products available yet</div>
            }
    </div>
);
}

export default Products;
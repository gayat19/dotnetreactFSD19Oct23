import { useState } from "react";
import './AddProduct.css';

function AddProduct(){
    const [name,setName] = useState("");
    const [quantity,setQuantity] = useState(0);
    const [price,setPrice] = useState(0);
    var product;
    var clickAdd = ()=>{
        alert('You clicked the button');
       product={
        "name":name,
        "quantity":quantity,
        "price":price
        }
        console.log(product);
        fetch('http://localhost:5271/api/Product',{
            method:'POST',
            headers:{
                'Accept':'application/json',
                'Content-Type':'application/json'
            },
            body:JSON.stringify(product)
        }).then(
            ()=>{
                alert("Product Added");
            }
        ).catch((e)=>{
            console.log(e)
        })
    }


    return(
        <div className="inputcontainer">
            <label className="form-control" for="pname">Product Name</label>
            <input id="pname" type="text" className="form-control" value={name} onChange={(e)=>{setName(e.target.value)}}/>
            <label className="form-control"  for="pqty">Product Quantity</label>
            <input id="pqty" type="number" className="form-control" value={quantity} onChange={(e)=>{setQuantity(e.target.value)}}/>
            <label className="form-control"  for="pprice">Product Cost</label>
            <input id="pprice" type="number" className="form-control" value={price} onChange={(e)=>{setPrice(e.target.value)}}/>
            <button onClick={clickAdd} className="btn btn-primary">Add Product</button>
        </div>
    );
}

export default AddProduct;
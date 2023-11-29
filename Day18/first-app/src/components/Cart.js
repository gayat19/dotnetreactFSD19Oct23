import { useState } from "react";
import { useSelector } from "react-redux";


function Cart(props){
    //const[cart,setCart]=useState([]);
   const cart = useSelector((state)=>state.cart);
    
    return(
        <div>
          {cart.length==0?<div>No items is cart yet</div>:
           <div>
            <h1>Your cart</h1> 
            {cart.map((item,idx)=>
               <tr key={idx}>
                <td>{item.id}</td>
                <td>{item.name}</td>
                <td>{item.price}</td>
                <td>{item.quantity}</td>
               </tr>
            )}
             </div>} 
        </div>
    )
}

export default Cart;
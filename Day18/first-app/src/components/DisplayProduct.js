import { useDispatch } from "react-redux";
import { useSelector } from "react-redux";
import{addItem} from '../CartSlice';

function DisplayProduct(props){
var dispatch = useDispatch();

var cartItems = useSelector((state)=>state.cart)
var addToCart = ()=>{

    var myProduct = {
        id:props.product.id,
        name:props.product.name,
        price:props.product.price,
        quantity:1
    }
    //console.log(myProduct);
   
    dispatch(addItem(myProduct));
   
    console.log(cartItems)
}
return(
    <div>
        Product Name : {props.product.name}
        <br/>
        Product Price : {props.product.price}
        <br/>
        Product Quantity: {props.product.quantity}
        <br/>
        <button className="btn btn-primary" onClick={addToCart}>Add To Cart</button>
    </div>
);

}

export default DisplayProduct;
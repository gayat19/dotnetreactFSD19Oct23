import DisplayProduct from "./DisplayProduct";

function ProductListing(props){


    return(
        <div>
            {props.products.map((product)=>
                    <div key={product.id} className="alert alert-primary">
                       <DisplayProduct product={product}/>
                </div>)}
        </div>
    )
}

export default ProductListing;
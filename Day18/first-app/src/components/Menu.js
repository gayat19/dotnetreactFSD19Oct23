import { Link } from "react-router-dom";

function Menu(){
    return (
<nav className="navbar navbar-expand-lg navbar-light bg-light">
  
  <div className="collapse navbar-collapse" id="navbarNav">
    <ul className="navbar-nav">
      <li className="nav-item active">
        <Link className="nav-link" to="/" >Register</Link>
      </li>
      <li className="nav-item">
        <Link className="nav-link" to="/shop" >Shop</Link>
      </li>
      <li className="nav-item">
        <Link className="nav-link" to="/products" >Products</Link>
      </li>
      <li className="nav-item">
        <Link className="nav-link" to="/cart" >Cart</Link>
      </li>

    </ul>
  </div>
</nav>
    );
}

export default Menu;
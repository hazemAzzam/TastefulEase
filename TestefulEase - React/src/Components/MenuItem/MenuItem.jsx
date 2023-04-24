import React from "react";
import { useDispatch, useSelector } from "react-redux";
import { Link } from "react-router-dom";
import { sendOrder } from "../../Redux/SendOrderSlice";


export default function MenuItem() {
  let dispatch = useDispatch();
  let { menuItem } = useSelector((state) => state.menuItem);

  const sendOrderToItemsCart = (id)=> {
    console.log(id);
    dispatch(sendOrder(id))
  }

  return (
    <>
      <section id="products" className='menuItem' >
        <div className="container">
          <div className="row">
            <div className="col-md-8">
              <div className="row">
                {menuItem.map((product) => (
                  <div className="col-md-4 pb-5" key={product.id}>
                    <div className="product">
                      <div class="card">
                        <img
                          src={product.image}
                          class="card-img-top"
                          alt="..."
                        />
                        <div class="card-body">
                          <h5 class="card-title">{product.name}</h5>
                          <p
                            class="card-text text-muted"
                            title={product.description}
                          >
                            {product.description}
                          </p>
                        </div>
                        <ul class=" list-group-flush">
                          <li class="list-group-item price">
                            {product.price} EGP
                          </li>
                        </ul>
                        <div class="card-body">
                          <button
                            onClick={()=> sendOrderToItemsCart(product.id)}
                            className="btn btn-outline-danger w-100"
                          >
                            <Link to="" class="card-link text-danger fs-6">
                              + ADD TO CARD
                            </Link>
                          </button>
                        </div>
                      </div>
                    </div>
                  </div>
                ))}
              </div>
            </div>
            <div className="col-md-4">
                <div className="cart shadow-sm">
                    <h4>Your Cart is Empty</h4>
                    <img className="my-4" src="https://egypt.kfc.me/static/media/emptyCart.052e2617.svg" alt="" />
                    <h5 className="text-center">Explore our menu to add some delicious items to your cart</h5>
                </div>
            </div>
          </div>
        </div>
      </section>
    </>
  );
}

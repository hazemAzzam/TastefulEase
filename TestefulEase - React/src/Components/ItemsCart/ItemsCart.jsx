import React, { useState } from "react";
import { useDispatch, useSelector } from "react-redux";
import { increase, decrease } from "../../Redux/ItemsCartSlice";

export default function ItemsCart() {
  let { order } = useSelector((state) => state.sendOrder);
  let { counter, price } = useSelector((state) => state.itemsCart);
  let dispatch = useDispatch();


  const [isClicked, setIsClicked] = useState(false);

  const handleClicked = () => {
    setIsClicked(!isClicked);
  };

  return (
    <>
      <section id="items-cart" className="mt-5">
        <div className="container">
          <div className={isClicked ? "clicked" : "not-clicked"}>
            Concratulations!
          </div>
          <div className="row">
            <div className="col-md-8">
              <div className="items">
                <h4>Items from your Cart</h4>
                <hr />
                <div className="row">
                  {order.map((order) => (
                    <div className="col-md-12" key={order.id}>
                      <div className="item">
                        <h3>{order.name}</h3>
                        <p>{order.description}</p>
                        <div className="d-flex align-items-center justify-content-between pe-5">
                          <div className="d-flex align-items-center">
                            <h5 className="ps-3 pe-5">{price} EGP</h5>
                            <button
                              onClick={() => dispatch(decrease(order.price))}
                              className="btn btn-outline-danger"
                            >
                              <i className="fa-solid fa-minus"></i>
                            </button>
                            <h4 className="px-2 fs-3">{counter}</h4>
                            <button
                              onClick={() => dispatch(increase(order.price))}
                              className="btn btn-danger"
                            >
                              <i className="fa-solid fa-plus"></i>
                            </button>
                          </div>
                          <img src={order.image} alt="" />
                        </div>
                      </div>
                    </div>
                  ))}
                </div>
              </div>
            </div>

            <div className="col-md-4">
              <div className="order-summary">
                <h4>Order Summary</h4>
                <div className="location">
                  <input
                    type="text"
                    className="form-control w-100 text-center mt-4"
                    placeholder="Select Location"
                  />

                  <input
                    type="text"
                    className="form-control w-100 text-center mt-5"
                    placeholder="Apply Coupon"
                  />

                  <div className="total-price pt-5">
                    <p>Sub Total</p>
                    <span>{price} EGP</span>
                  </div>

                  <div className="total-price">
                    <p>Delivery</p>
                    <span>{price == 0 ? 0 : 25} EGP</span>
                  </div>

                  <hr />

                  <div className="total-price">
                    <p>Total</p>
                    <span>{price > 0 ? price + 25 : price} EGP</span>
                  </div>
                  <div className="d-flex  justify-content-center">
                    <button onClick={handleClicked} className="place-order">
                      Place Order
                    </button>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </section>
    </>
  );
}

import React, { useEffect } from "react";
import "slick-carousel/slick/slick.css";
import "slick-carousel/slick/slick-theme.css";
import Slider from "react-slick";
import { Link, useNavigate } from "react-router-dom";
import { useDispatch, useSelector} from "react-redux";
import { increase } from "../../Redux/ItemsCartSlice";
import { getProducts } from "../../Redux/ProductsSlice";
import { getCategories } from "../../Redux/CategoriesSlice";
import { getMenuItem } from "../../Redux/MenuItemSlice";
import { sendOrder } from "../../Redux/SendOrderSlice";

export default function Home() {

  let dispatch = useDispatch();
  let {products} = useSelector((state)=> state.products);
  let {categories} = useSelector((state)=> state.categories);
  let navigate = useNavigate();


  const handleMenuItem = (name) => {
    dispatch(getMenuItem(name));
    navigate(`/menuItem/`);
  };

  const sendOrderToItemsCart = (id)=> {
    console.log(id);
    dispatch(sendOrder(id))
  }


  const settings = {
    dots: true,
    infinite: true,
    speed: 500,
    slidesToShow: 4,
    slidesToScroll: 1,
  };


  useEffect(() => {
    dispatch(getCategories());
    dispatch(getProducts());
  }, []);

  return (
    <>
      <section id="home">
        <div className="container">
          <div className="container-fluid pt-4">
            <div className="title mb-5">
              <img
                className="w-100"
                src="https://kfcprodnecmsimage.azureedge.net/cmsimages/imagestemp/desktop/DinnerPlus_EG14_En_1104.jpg"
                alt=""
              />
              <h4 className="fw-bolder fs-5 pt-5">
                EXPLORE MENU
                <img
                  className="steck"
                  src="https://egypt.kfc.me/static/media/explore-menu.255f631f.png"
                  alt=""
                />
              </h4>
            </div>

            <div className="row">

              {categories.map((cat) => (
                
                <div
                  className="col-md-3"
                  key={cat.id}
                  onClick={() => {
                    handleMenuItem(cat.name);
                  }}
                >
                  <div className="cat text-center">
                    <h4>{cat.name}</h4>
                  </div>
                </div>
               
              ))}
            </div>
          </div>
        </div>
      </section>

      <section id="products">
        <div className="container">
          <div className="row">
            <div className="col-md-12">
              <div className="products">
                <Slider {...settings}>
                  {products.map((product) => (
                    <div className="pb-5" key={product.id}>
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
                            <button onClick={()=> sendOrderToItemsCart(product.id)} className="btn btn-outline-danger w-100">
                              <Link href="#" class="card-link text-danger fs-6">
                                + ADD TO CARD
                              </Link>
                            </button>
                          </div>
                        </div>
                      </div>
                    </div>
                  ))}
                </Slider>

                <div className="row mt-5">
                  {products.map((product) => (
                    <div className="col-md-3 pb-5" key={product.id}>
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
                            <button onClick={()=> sendOrderToItemsCart(product.id)} className="btn btn-outline-danger w-100">
                              <Link to='' class="card-link text-danger fs-6">
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
            </div>
          </div>
        </div>
      </section>
    </>
  );
}

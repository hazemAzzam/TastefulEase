import React, { useState, useEffect } from "react";
import { RouterProvider, createBrowserRouter } from "react-router-dom";
import Layout from "./Layout/Layout";
import Home from "./Home/Home";
import Offers from "./Offers/Offers";
import ItemsCart from "./ItemsCart/ItemsCart";
import MenuItem from "./MenuItem/MenuItem";
import { Provider } from "react-redux";
import store from "../Redux/Store";
import Login from "./Login/Login";
import Register from "./Register/Register";
import jwtDecode from "jwt-decode";
import NotFound from "./NotFound/NotFound";
import Profile from "./Profile/Profile";



function App() {
  const [userData, setUserData] = useState(null);
  const [isOpen, setIsOpen] = useState(false);

  useEffect(() => {

    if(localStorage.getItem('userToken') !== null){
      saveUserData();
    }

  }, [])
  


  function saveUserData(){
    let encodedToken = localStorage.getItem('userToken');
    let decodedToken = jwtDecode(encodedToken);
    setUserData(decodedToken);
  }

  const toggleSidebar = () => {
    setIsOpen(!isOpen);
  }

  let routers = createBrowserRouter([
    {path: '/', element: <Layout setUserData={setUserData} userData={userData}  toggleSidebar={toggleSidebar} isOpen={isOpen}/>, children:[
      {index: true, element: <Home/>},
      {path: 'itemscart', element: <ItemsCart/>},
      {path: 'offers', element: <Offers/>},
      {path: 'menuItem', element: <MenuItem/>},
      {path: 'login', element: <Login saveUserData={saveUserData}/>},
      {path: 'register', element: <Register/>},
      {path: '*', element: <NotFound/>},
      {path: 'profile', element: <Profile/>},
    ]}
  ])

  return <Provider store={store}>
            <RouterProvider router={routers}/>
  </Provider> 
}

export default App;

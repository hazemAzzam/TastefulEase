import React from "react";
import Sidebar from "../Sidebar/Sidebar";
import { Outlet, useNavigate } from "react-router-dom";
import Navbar from "../Navbar/Navbar";

export default function Layout({ toggleSidebar, isOpen, userData, setUserData }) {

  let navigate = useNavigate();

  function logOut(){
    localStorage.removeItem('userToken');
    setUserData(null);
    navigate('login');
  }

  return (
    <>
      <Navbar toggleSidebar={toggleSidebar} userData={userData} logOut={logOut} />
      <div className="d-flex">
        {isOpen ? (
          <>
            <section id="sidebar">
              <div className="sidebar">
                <Sidebar />
              </div>
            </section>
          </>
        ) : (
          ""
        )}
        <div className="w-100">
          <Outlet></Outlet>
        </div>
      </div>
    </>
  );
}

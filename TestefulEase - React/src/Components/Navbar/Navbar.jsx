import React from "react";
import { Link } from "react-router-dom";

export default function Navbar({ toggleSidebar, userData, logOut }) {
  return (
    <>
      <nav
        id="navbar"
        className="navbar navbar-expand-lg navbar-light bg-light shadow "
      >
        <div className="container">
          <span
            onClick={toggleSidebar}
            className="navbar-toggler-icon sideToggle"
          ></span>
          <Link to="/" className="logo py-1">
            HBC
          </Link>
          <button
            className="navbar-toggler"
            type="button"
            data-bs-toggle="collapse"
            data-bs-target="#navbarSupportedContent"
            aria-controls="navbarSupportedContent"
            aria-expanded="false"
            aria-label="Toggle navigation"
          >
            <span className="navbar-toggler-icon"></span>
          </button>
          <div className="collapse navbar-collapse" id="navbarSupportedContent">
            <ul className="navbar-nav ms-auto mb-2  mb-lg-0">
              <li className="nav-item px-3">
                <Link className="nav-link fw-bolder fs-5" to="/itemscart">
                  <i class="fa-solid fa-basket-shopping"></i>
                </Link>
              </li>

              {userData ? (
                <>
                  <li className="nav-item px-3 " onClick={logOut}>
                    <Link to="logout" className="nav-link fw-bolder fs-5">
                      LogOut
                    </Link>
                  </li>
                  <li className="nav-item px-3">
                    <Link to="profile" className="nav-link fw-bolder fs-5">
                      Profile
                    </Link>
                  </li>
                </>
              ) : (
                <>
                  <li className="nav-item px-2">
                    <Link to="login" className="nav-link fw-bolder fs-5">
                      Login
                    </Link>{" "}
                  </li>
                  <li className="nav-item px-2">
                    <Link to="register" className="nav-link fw-bolder fs-5">
                      Register
                    </Link>{" "}
                  </li>
                </>
              )}
            </ul>
          </div>
        </div>
      </nav>
    </>
  );
}

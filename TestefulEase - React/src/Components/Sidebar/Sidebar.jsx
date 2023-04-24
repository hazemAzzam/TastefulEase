import React from "react";
import { Link } from "react-router-dom";

export default function Sidebar({ toggleSidebar }) {
  return (
    <>
      <h3>HBC</h3>
      <ul className="list-unstyled mt-4">
        <li>
          <Link to="/">Products</Link>
        </li>
        <li>
          <Link to="/itemscart">Orders</Link>
        </li>
        <li>
          <Link to="/offers">Offers</Link>
        </li>
      </ul>
    </>
  );
}

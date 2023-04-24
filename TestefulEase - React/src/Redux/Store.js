import { configureStore } from "@reduxjs/toolkit";
import { productsReducer } from "./ProductsSlice";
import { ItemsCartReducer } from "./ItemsCartSlice";
import { categoriesReducer } from "./CategoriesSlice";
import { menuItemReducer } from "./MenuItemSlice";
import { sendOrderReducer } from "./SendOrderSlice";


let store = configureStore({
    reducer:{ 
        products: productsReducer,
        itemsCart: ItemsCartReducer,
        categories: categoriesReducer,
        menuItem: menuItemReducer,
        sendOrder:sendOrderReducer,
    }
})

export default store;
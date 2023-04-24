import { createAsyncThunk, createSlice } from "@reduxjs/toolkit";
import axios from "axios";

export let getProducts = createAsyncThunk('/', async ()=>{
    let {data} = await axios.get(`http://127.0.0.1:8000/api/menu-items/`);
    return data;
})  


let initialState = {products:[], loading: false}

let productsSlice = createSlice({
    name: 'products',
    initialState:initialState,
    extraReducers:(builder)=>{
        builder.addCase(getProducts.fulfilled, (state, action)=> {
            state.products = action.payload;
        })
    }
})


export let productsReducer = productsSlice.reducer;
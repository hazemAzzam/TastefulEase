import { createAsyncThunk, createSlice } from "@reduxjs/toolkit";
import axios from "axios";



export let sendOrder = createAsyncThunk('/itemsCart', async (id)=>{
    let {data} = await axios.get(`http://127.0.0.1:8000/api/menu-items/${id}`);
    console.log(data)
    return data;
})

let initialState = {order:[], loading:false, counter:1}

let sendOrderSlice = createSlice({
    name: 'sendOrder',
    initialState:initialState,
    extraReducers:(builder)=>{
        builder.addCase(sendOrder.fulfilled, (state, action)=> {
            state.order = [...state.order, action.payload];
        })
    },

})

export let sendOrderReducer = sendOrderSlice.reducer;
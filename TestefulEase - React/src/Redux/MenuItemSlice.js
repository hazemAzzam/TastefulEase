import { createAsyncThunk, createSlice } from "@reduxjs/toolkit";
import axios from "axios";

export let getMenuItem = createAsyncThunk('/menuItem', async (callback)=> {
    let {data} = await axios.get(`http://127.0.0.1:8000/api/menu-items/?categories=${callback}`);
    console.log(callback)
    return data; 
})

let initialState = {menuItem:[], loading: false}

let menuItemSlice = createSlice({
    name: 'menuItem',
    initialState:initialState,
    extraReducers:(builder)=>{
        builder.addCase(getMenuItem.fulfilled, (state, action)=> {
            state.menuItem = action.payload;
        })
    }
})

export let menuItemReducer = menuItemSlice.reducer;
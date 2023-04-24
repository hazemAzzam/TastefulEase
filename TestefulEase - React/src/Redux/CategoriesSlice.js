import { createAsyncThunk, createSlice } from "@reduxjs/toolkit";
import axios from "axios";

export let getCategories = createAsyncThunk('', async ()=> {
    let {data} = await axios.get(`http://127.0.0.1:8000/api/categories/`)
    return data;
})

let initialState = {categories:[], loading: false}

let categoriesSlice = createSlice({
    name: 'categories',
    initialState:initialState,
    extraReducers:(builder)=>{
        builder.addCase(getCategories.fulfilled, (state, action)=> {
            state.categories = action.payload;
        })  
    }
})

export let categoriesReducer = categoriesSlice.reducer;
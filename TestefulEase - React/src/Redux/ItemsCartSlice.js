import { createSlice } from "@reduxjs/toolkit";


export let initialState = {counter:0, price:0 }

let itemsCartSlice = createSlice({
    name: 'itemsCart',
    initialState:initialState,
    reducers:{
        increase:(state = initialState, action) => {
            state.counter += 1;
            state.price += action.payload
        },
        decrease:(state = initialState, action) => {
            state.counter -= 1;
            state.price -= action.payload
        },

    }
})

export let ItemsCartReducer = itemsCartSlice.reducer;
export let {increase, decrease, updatePrice} = itemsCartSlice.actions;
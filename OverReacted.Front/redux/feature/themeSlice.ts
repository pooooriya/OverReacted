import { createSlice } from "@reduxjs/toolkit"
import type { PayloadAction } from '@reduxjs/toolkit'

export interface themeState {
    value: 'light' | 'dark'
}

const initialState: themeState = {
    value: 'light',
}

export const themeSlice = createSlice({
    name: 'theme',
    initialState,
    reducers: {
        themeSwitcher: (state, action: PayloadAction<themeState>) => {
            document.documentElement.classList.remove(state.value);
            document.documentElement.classList.add(action.payload.value);
            state.value = action.payload.value;
        }
    },
})

export const { themeSwitcher } = themeSlice.actions

export default themeSlice.reducer
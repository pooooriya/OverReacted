import counterReducer from './feature/themeSlice';
import { configureStore } from '@reduxjs/toolkit'

export const store = configureStore({
    reducer: { theme: counterReducer },
})

export type RootState = ReturnType<typeof store.getState>
export type AppDispatch = typeof store.dispatch
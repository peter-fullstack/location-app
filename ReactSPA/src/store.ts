import { configureStore } from '@reduxjs/toolkit'
import locationsReducer from './slices/LocationsSlice';

const reducer = {
   locations: locationsReducer,
}

const store = configureStore({
  reducer: reducer,
  devTools: true,
})

export type AppDispatch = typeof store.dispatch

export default store;
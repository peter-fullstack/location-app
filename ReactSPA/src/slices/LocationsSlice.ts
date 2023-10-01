import { createSlice, createAsyncThunk, isAnyOf } from "@reduxjs/toolkit";
import { StateModel } from "../models/SateModel";
import LocationsService from "../services/LocationService";
import { fetchStatus } from "../models/FetchStatus";
import LocationModel from "../models/LocationModel";
import CoordinateModel from "../models/CoordinateModel";

const initialState: StateModel = {
  loadingStatus: fetchStatus.idle,
  locations: [],
  nearestSuburb: null
};

export const getAllLocations = createAsyncThunk<Array<LocationModel>>(
  "locations-list/get-all",
  async () => {
    const res = await LocationsService.getAll();

    var models = res.data;

    return models;
  }
);

export const getNearestSuburb = createAsyncThunk<LocationModel, CoordinateModel>(
  "company-list/get-company",
  async (id: CoordinateModel) => {
    const res = await LocationsService.getNearestSuburb(id);

    var model = res.data;

    return model;
  }
);

const locationsSlice = createSlice({
  name: "locations",
  initialState,
  reducers: {
    setLoadingStatus: (state: StateModel) => {
      state.loadingStatus = fetchStatus.idle;
    }
  },
  extraReducers: (builder) => {
    // All locations
    builder.addCase(getAllLocations.pending, (state: StateModel) => {
      state.loadingStatus = fetchStatus.loading;
    });

    builder.addCase(getAllLocations.fulfilled, (state: StateModel, action: any) => {
      state.loadingStatus = fetchStatus.fetchComplete;
      state.locations = action.payload;
    });

    builder.addCase(getAllLocations.rejected, (state: StateModel) => {
      state.loadingStatus = fetchStatus.error;
    });

    // Nearest suburb
    builder.addCase(getNearestSuburb.pending, (state: StateModel) => {
      state.loadingStatus = fetchStatus.loading;
    });

    builder.addCase(getNearestSuburb.fulfilled, (state: StateModel, action: any) => {
      state.loadingStatus = fetchStatus.fetchComplete;
      state.nearestSuburb = action.payload;
    });

    builder.addCase(getNearestSuburb.rejected, (state: StateModel) => {
      state.loadingStatus = fetchStatus.error;
    });    
  }
});

export const { setLoadingStatus } = locationsSlice.actions
const { reducer } = locationsSlice;
export default reducer;
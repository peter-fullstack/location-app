import { FormEvent, useState } from "react";
import CoordinateModel from "../models/CoordinateModel";
import { useDispatch, useSelector } from "react-redux";
import { getNearestSuburb, setLoadingStatus, getAllLocations } from "../slices/LocationsSlice";
import { AppDispatch } from "../store";
import { fetchStatus } from "../models/FetchStatus";
import { useNavigate } from "react-router-dom";

export const NearestSuburb = () => {

    const state = useSelector((state: any) => {
        return state.locations;
    });

    const navigate = useNavigate();

    const [coordinates, setCoordinates] = useState(new CoordinateModel());

    const [longitudeValidation, setLongitudeValidation] = useState("");
    const [latitudeValidation, setLatitudeValidation] = useState("");

    const dispatch = useDispatch<AppDispatch>();

    if (state.loadingStatus === fetchStatus.success) {
        dispatch(setLoadingStatus());
    }

    if (state.loadingStatus === fetchStatus.success) {
        dispatch(setLoadingStatus());
        //navigate("/");
    }

    const handleInputChange = (event: FormEvent<HTMLInputElement>) => {
        if (state.loadingStatus !== fetchStatus.idle) {
            dispatch(setLoadingStatus());
        }

        const { name, value } = event.currentTarget;
        setCoordinates({ ...coordinates, [name]: value });
    };

    const submitCoordinates = () => {
        console.log(coordinates);
        dispatch(getNearestSuburb(coordinates));
    };

    const validateLongitude = () => {
        // -90 to 90 degrees
    }

    const validateLatitude = () => {
        // -180 to 180 degrees


    }

    return (
        <div className="submit-form">
            <div className="container">
                <div className="row">
                    <div className="col-6">

                        <div className="card">
                            <div className="card-body">
                                <h5 className="card-title">Find nearest suburb</h5>
                                <div className="form-group">
                                    <label htmlFor="longitude">Longititude</label>
                                    <input
                                        type="number"
                                        className="form-control"
                                        id="longitude"
                                        required
                                        value={coordinates.longitude}
                                        onChange={handleInputChange}
                                        name="longitude"
                                    />
                                </div>

                                <div className="form-group">
                                    <label htmlFor="latitude">Latitude</label>
                                    <input
                                        type="number"
                                        className="form-control"
                                        id="latitude"
                                        value={coordinates.latitude}
                                        onChange={handleInputChange}
                                        name="latitude"
                                    />
                                </div>
                            </div>
                        </div>
                    </div>

                    <div className="col-6">
                        <div className="card">
                            <div className="card-body">
                                <h5 className="card-title">Result</h5>
                                {state.nearestSuburb ? (
                                    <span>{state.nearestSuburb.suburbName}</span>
                                ) : (null)}

                            </div>

                        </div>
                    </div>
                </div>
                <div className="row">
                    <div className="col-6">
                        <button onClick={submitCoordinates} className="btn btn-success" style={{ width: "200px", margin: "10px" }}>
                            {state.loadingStatus === fetchStatus.loading ? (
                                <div>
                                    <span className="spinner-border spinner-border-sm">
                                    </span>
                                    <span style={{ paddingLeft: "5px" }}>
                                        Processing ...
                                    </span>
                                </div>
                            ) : (
                                <span>Submit</span>
                            )}
                        </button>
                    </div>
                    <div className="col-6" style={{ padding: "10px", color: "red" }}>

                        {state.loadingStatus === fetchStatus.error ? (
                            <span>
                                Sorry there was an error processing your request
                            </span>
                        ) : (null)}
                    </div>
                </div>

            </div>
        </div>
    );
};

export default NearestSuburb
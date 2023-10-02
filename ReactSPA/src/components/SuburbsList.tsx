import { useCallback, useEffect, useState } from "react";
import { useDispatch, useSelector } from "react-redux";
import { AppDispatch } from "../store";
import { setLoadingStatus, getAllLocations } from "../slices/LocationsSlice";
import { fetchStatus } from "../models/FetchStatus";
import LocationModel from "../models/LocationModel";

export const SuburbsList = () => {

    const [currentIndex, setCurrentIndex] = useState(-1);
    const [currentLocation, setCurrentLocation] = useState<LocationModel | null>(null);
    const dispatch = useDispatch<AppDispatch>();

    const initFetch = useCallback(() => {
        dispatch(getAllLocations());
    }, [dispatch])

    useEffect(() => {
        initFetch();
    }, [initFetch])

    const state = useSelector((state: any) => {
        return state.locations;
    });

    if (state.loadingStatus === fetchStatus.success) {
        dispatch(setLoadingStatus());
    }

    const setActiveLocation = (company: LocationModel, index: number) => {
        setCurrentLocation(company);
        setCurrentIndex(index);
    };

    return (

        <div className="list row">
            <div className="col-md-6">
                <h4>Suburbs</h4>

                <ul className="list-group">
                    {state.locations &&
                        state.locations.map((location: LocationModel, index: number) => (
                            <li
                                className={
                                    "list-group-item " + (index === currentIndex ? "active" : "")
                                }
                                onClick={() => setActiveLocation(location, index)}
                                key={index}
                            >
                                {location.suburbName}
                            </li>
                        ))}
                </ul>
            </div>
        </div>
    )
}
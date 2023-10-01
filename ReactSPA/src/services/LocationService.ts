import http from "../http-common";
import CoordinateModel from "../models/CoordinateModel";

const getAll = async (): Promise<any> => {
    return http.get("/locations/");
};

const getNearestSuburb = async (coordinates: CoordinateModel): Promise<any> => {
    return http.get("/locations/nearest");
};

const LocationsService = {
    getAll,
    getNearestSuburb
};

export default LocationsService;
import { fetchStatus } from "./FetchStatus";
import LocationModel from "./LocationModel";

export class StateModel {
    loadingStatus: fetchStatus = fetchStatus.idle;
    locations: LocationModel[] = [];
    nearestSuburb: LocationModel | null = null; 
}
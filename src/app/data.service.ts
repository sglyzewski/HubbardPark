import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable()
export class DataService {

    private _url: string;

    constructor(private _http: HttpClient) {
        this._url = 'https://localhost:44353/';
    }

    getValues(): Observable<string> {
        const url = this._url + 'api/Values/';
        return this._http.get(url, {withCredentials: true, responseType: 'text'});
    }
}

import { HttpHeaders } from '@angular/common/http';
import { throwError } from 'rxjs';

export abstract class ServiceBase
{
    protected UrlServiceV1: string = "http://localhost:8287/api/v1/";
    
    protected ObterHeaderJson() {
        return {
            headers: new HttpHeaders({
                'content-type': 'application/json'
            })
        };
    }

    protected ObterHeaderJsonToken() {
        return {
            headers: new HttpHeaders({
                'content-type': 'application/json',
                'Authorization': 'Bearer ' + this.getUserToken()
            })
        };
    }

    protected extractData(response: any) {
        return response.data || {};
    }

    protected serviceError(error: Response | any) {
        let errMsg: string;

        if(error instanceof Response ) {
            errMsg = `${error.status} - ${error.statusText || ''}`;
        }
        else {
            errMsg = error.message ? error.message : error.toString();
        }

        console.error(error);
        return throwError(error);
    }

    public setLocalStorage(token: string, user: string) {
        localStorage.setItem('eio.token', token);
        localStorage.setItem('eio.user', user);
    }

    public getUserToken(): string {
        return localStorage.getItem('eio.token')
    }

    public getUser(): string {
        return localStorage.getItem('eio.user')
    }

    public removeUserToken(){
        localStorage.removeItem('eio.token');
        localStorage.removeItem('eio.user');
    }

    public isAuthenticated(): boolean {
        let token = this.getUserToken();
        return token !== null;
    }
}
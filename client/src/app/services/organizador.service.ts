import { Injectable } from '@angular/core'
import { ServiceBase } from './service.base';
import { HttpClient } from '@angular/common/http';

import { Observable } from 'rxjs';
import { catchError, map } from 'rxjs/operators';
import { Organizador } from '../usuario/models/organizador';

@Injectable()
export class OrganizadorService extends ServiceBase
{
    constructor(private http: HttpClient) { super(); }

    registrarOrganizador(organizador: Organizador): Observable<Organizador> {
        return this.http
        .post(this.UrlServiceV1 + 'nova-conta', organizador, super.ObterHeaderJson())
        .pipe(
            map(super.extractData),
            catchError(super.serviceError)
        );
    }

    login(organizador: Organizador): Observable<Organizador> {
        return this.http
        .post(this.UrlServiceV1 + 'conta', organizador, super.ObterHeaderJson())
        .pipe(
            map(super.extractData),
            catchError(super.serviceError)
        );
    }
}
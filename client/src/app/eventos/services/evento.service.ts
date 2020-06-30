import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { ServiceBase } from 'src/app/services/service.base';
import { Evento, Categoria, Endereco } from '../models/evento';

import { Observable } from 'rxjs';
import { catchError, map } from 'rxjs/operators';


@Injectable()
export class EventoService extends ServiceBase{
    constructor(private http: HttpClient){super()}

    registrarEvento(evento: Evento): Observable<Evento>{
        return this.http
          .post(this.UrlServiceV1 + 'eventos', evento, super.ObterHeaderJsonToken())
          .pipe(
            map(super.extractData),
            catchError(super.serviceError)  
        );
    }

    atualizarEvento(evento: Evento) : Observable<Evento>{
      return this.http
        .put(this.UrlServiceV1 + "eventos", evento, super.ObterHeaderJsonToken())
        .pipe(
          map(super.extractData),
          catchError(super.serviceError));
    }

    excluirEvento(id: string) : Observable<Evento>{
      return this.http
        .delete(this.UrlServiceV1 + "eventos/" + id, super.ObterHeaderJsonToken())
        .pipe(
          map(super.extractData),
          catchError(super.serviceError));
    }

    obterCategorias(): Observable<Categoria[]>{
      return this.http
        .get<Categoria[]>(this.UrlServiceV1 + 'eventos/categorias')
        .pipe(
          catchError(super.serviceError)
        );
    }

    obterTodos():Observable<Evento[]> {
      return this.http
        .get<Evento[]>(this.UrlServiceV1 + 'eventos')
        .pipe(
          catchError(super.serviceError)
        );
    }

    obterMeusEventos():Observable<Evento[]> {
      return this.http
        .get<Evento[]>(this.UrlServiceV1 + 'eventos/meus-eventos', super.ObterHeaderJsonToken())
        .pipe(
          catchError(super.serviceError)
        );
    }

    obterMeuEvento(id: string):Observable<Evento> {
      return this.http
        .get<Evento>(this.UrlServiceV1 + 'eventos/meus-eventos/' + id, super.ObterHeaderJsonToken())
        .pipe(
          map(super.extractData),
          catchError(super.serviceError)
        );
    }

    obterEvento(id: string):Observable<Evento> {
      return this.http
        .get<Evento>(this.UrlServiceV1 + 'eventos/' + id)
        .pipe(
          catchError(super.serviceError)
        );
    }

    adicionarEndereco(endereco: Endereco) : Observable<Endereco>{
      let response = this.http
        .post(this.UrlServiceV1 + "endereco", endereco, super.ObterHeaderJsonToken())
        .pipe(
          map(super.extractData),
          catchError(super.serviceError)
        );
      return response
      ;
    }

    atualizarEndereco(endereco: Endereco) : Observable<Endereco>{
      let response = this.http
        .put(this.UrlServiceV1 + "endereco", endereco, super.ObterHeaderJsonToken())
        .pipe(
          map(super.extractData),
          catchError(super.serviceError)
        );
      return response;
    }
}
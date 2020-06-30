import { Injectable } from "@angular/core";
import { HttpInterceptor, HttpRequest, HttpHandler, HttpEvent } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { OrganizadorService } from './organizador.service';
import { Router } from '@angular/router';

@Injectable()
export class ErrorHandlerService implements HttpInterceptor {

    constructor(private organizadorService: OrganizadorService, 
        private router: Router){}

    intercept(req: HttpRequest<any>, next:HttpHandler) : Observable<HttpEvent<any>> {
        return next.handle(req).pipe(
            catchError(err => {
                
                if(err.status === 401){
                    this.organizadorService.removeUserToken();
                    this.router.navigate(['/entrar']);
                }
                if(err.status === 403){
                    this.router.navigate(['/acesso-negado']);
                }
                if(err.status === 404){
                    this.router.navigate(['/nao-encontrado']);
                }

                return throwError(err);
            })
        );
    }
}
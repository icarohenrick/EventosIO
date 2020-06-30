import { Injectable } from "@angular/core";
import { CanActivate, ActivatedRouteSnapshot, Router } from '@angular/router';
import { OrganizadorService } from 'src/app/services/organizador.service';

@Injectable()
export class EventoAuthService  implements CanActivate {

    constructor(private organizadorService: OrganizadorService,
        private router: Router) {}

    canActivate(routeAc: ActivatedRouteSnapshot): boolean {

        if(!this.organizadorService.isAuthenticated()) {
            this.router.navigate(['/entrar']);
        }

        let claim: any = routeAc.data[0];
        if(claim !== undefined) {
            let claim = routeAc.data[0]['claim']

            if(claim){
                let user = JSON.parse(this.organizadorService.getUser());

                if(!user.claims){
                    this.router.navigate(['/acesso-negado']);
                }

                let userClaims = user.claims.some(x => x.type === claim.nome && x.value === claim.valor);
                if(!userClaims){
                    this.router.navigate(['/acesso-negado']);
                }
            }
        }
        return true;
    }
}
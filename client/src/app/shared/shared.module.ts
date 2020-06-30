import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { RouterModule } from '@angular/router';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';

import { MainPrincipalComponent } from './main-principal/main-principal.component';
import { MenuLoginComponent } from './menu-login/menu-login.component';
import { MenuSuperiorComponent } from './menu-superior/menu-superior.component';
import { FooterComponent } from './footer/footer.component';
import { AcessoNegadoComponent } from './acesso-negado/acesso-negado.component';
import { NaoEncontradoComponent } from './nao-encontrado/nao-encontrado.component';

@NgModule({
    imports: [
        CommonModule,
        RouterModule,
        NgbModule
    ],
    declarations: [
        MainPrincipalComponent,
        MenuLoginComponent,
        MenuSuperiorComponent,
        FooterComponent,
        AcessoNegadoComponent,
        NaoEncontradoComponent
    ],
    exports: [
        MainPrincipalComponent,
        MenuLoginComponent,
        MenuSuperiorComponent,
        FooterComponent,
        AcessoNegadoComponent,
        NaoEncontradoComponent
    ]
})
export class SharedModule {}
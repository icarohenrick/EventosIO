import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { RouterModule } from '@angular/router';

import { FormsModule, ReactiveFormsModule } from '@angular/forms'
import { HttpClientModule } from '@angular/common/http';

import { UsuarioComponent } from './usuario.component';
import { SeoService } from '../services/seo.services';
import { Title } from '@angular/platform-browser';

//Componente usuario
import { InscricaoComponent } from './inscricao/inscricao.component';
import { LoginComponent } from './login/login.component';

import { usuarioRouterConfig } from './usuario.routes';

@NgModule({
    imports:[
        CommonModule,
        HttpClientModule,
        FormsModule,
        ReactiveFormsModule,
        RouterModule.forChild(usuarioRouterConfig)
    ],
    declarations:[
        UsuarioComponent,
        InscricaoComponent,
        LoginComponent
    ],
    providers:[
        Title,
        SeoService,
    ],
    exports:[]
})
export class UsuarioModule{}
import { Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { AcessoNegadoComponent } from './shared/acesso-negado/acesso-negado.component';
import { NaoEncontradoComponent } from './shared/nao-encontrado/nao-encontrado.component';

export const rootRouterConfig: Routes = [
    { path: '', redirectTo: 'home', pathMatch: 'full' },
    { path: 'home', component: HomeComponent },
    { path: 'acesso-negado', component: AcessoNegadoComponent },
    { path: 'nao-encontrado', component: NaoEncontradoComponent },
    { path: 'usuarios', loadChildren: './usuario/usuario.module#UsuarioModule'},
    { path: 'eventos', loadChildren: './eventos/evento.module#EventosModule'}
]
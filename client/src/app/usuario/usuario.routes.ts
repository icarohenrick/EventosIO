import { Routes } from '@angular/router';
import { UsuarioComponent } from './usuario.component';
import { InscricaoComponent } from './inscricao/inscricao.component';
import { LoginComponent } from './login/login.component';

export const usuarioRouterConfig: Routes = [
    { 
        path:'usuarios', component: UsuarioComponent,
        children: [
            { path: '', component: UsuarioComponent },
            { path: 'inscricao', component: InscricaoComponent },
            { path: 'entrar', component: LoginComponent },
        ]
    }
]
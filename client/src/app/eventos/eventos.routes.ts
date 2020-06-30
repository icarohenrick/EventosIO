import { Routes } from '@angular/router';
import { EventoComponent } from './evento.component';
import { ListaEventosComponent } from './lista-eventos/lista-eventos.component';
import { DetalhesEventoComponent } from './detalhes-evento/detalhes-evento.component';

import { AdicionarEventoComponent } from './adicionar-evento/adicionar-evento.component';
import { MeusEventosComponent } from './meus-eventos/meus-eventos.component';
import { EditarEventoComponent } from './editar-evento/editar-evento.component';
import { ExcluirEventoComponent } from './excluir-evento/excluir-evento.component';

import { EventoAuthService } from './services/auth.evento.service';

export const eventosRouterConfig: Routes = [
    { 
        path:'eventos', component: EventoComponent,
        children: [
            { path: '', component: ListaEventosComponent },
            { path: 'lista-eventos', component: ListaEventosComponent },
            { path: 'proximos-eventos', component: ListaEventosComponent },
            { path: 'detalhes-evento/:id', component: DetalhesEventoComponent },
            { path: 'novo-evento', canActivate:[EventoAuthService], data: [{claim: { nome: 'Eventos', valor: 'Gravar'}}], component: AdicionarEventoComponent },
            { path: 'meus-eventos', canActivate:[EventoAuthService], data: [{claim: { nome: 'Eventos', valor: 'Gravar'}}], component: MeusEventosComponent },
            { path: 'editar-evento/:id', canActivate:[EventoAuthService], data: [{claim: { nome: 'Eventos', valor: 'Gravar'}}], component: EditarEventoComponent },
            { path: 'excluir-evento/:id', canActivate:[EventoAuthService], data: [{claim: { nome: 'Eventos', valor: 'Gravar'}}], component: ExcluirEventoComponent }
        ]
    }
]
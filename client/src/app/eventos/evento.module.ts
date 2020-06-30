import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Title } from '@angular/platform-browser';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { eventosRouterConfig } from './eventos.routes';

import { MyDatePickerModule } from 'mydatepicker';

// Components Eventos
import { EventoComponent } from './evento.component';
import { ListaEventosComponent } from './lista-eventos/lista-eventos.component';
import { MeusEventosComponent } from './meus-eventos/meus-eventos.component';
import { AdicionarEventoComponent } from './adicionar-evento/adicionar-evento.component';
import { EditarEventoComponent } from './editar-evento/editar-evento.component';
import { DetalhesEventoComponent } from './detalhes-evento/detalhes-evento.component';
import { ExcluirEventoComponent } from './excluir-evento/excluir-evento.component';

//Router
import { RouterModule } from '@angular/router';

//Services
import { SeoService } from '../services/seo.services';
import { EventoAuthService } from './services/auth.evento.service';
import { EventoService } from './services/evento.service';
import { ErrorHandlerService } from '../services/error.handler.service';

@NgModule({
    imports:[
        CommonModule,
        HttpClientModule,
        FormsModule,
        ReactiveFormsModule,
        MyDatePickerModule,
        RouterModule.forChild(eventosRouterConfig)
    ],
    declarations:[
        EventoComponent,
        ListaEventosComponent,
        MeusEventosComponent,
        AdicionarEventoComponent,
        EditarEventoComponent,
        DetalhesEventoComponent,
        ExcluirEventoComponent
    ],
    providers:[
        Title,
        SeoService,
        EventoAuthService,
        EventoService,
        {
            provide: HTTP_INTERCEPTORS,
            useClass: ErrorHandlerService,
            multi: true
        }
    ],
    exports:[
        RouterModule
    ]
})
export class EventosModule{}
import { BrowserModule, Title, Meta } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms'
import { RouterModule } from '@angular/router';
import { rootRouterConfig } from './app.routes';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { CommonModule } from '@angular/common';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { registerLocaleData } from '@angular/common'
import localePt from '@angular/common/locales/pt';
registerLocaleData(localePt);
 
import { ToastrModule } from 'ngx-toastr';

// Bootstrap
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
 
// Components Home
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';

//Services
import { SeoService } from './services/seo.services';
import { OrganizadorService } from './services/organizador.service';
import { ErrorHandlerService } from './services/error.handler.service';

//Shared Modules
import { SharedModule } from './shared/shared.module';
import { EventosModule } from './eventos/evento.module';
import { UsuarioModule } from './usuario/usuario.module';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent
  ],
  imports: [
    SharedModule,
    EventosModule,
    UsuarioModule,
    BrowserModule,
    NgbModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
    CommonModule,
    BrowserAnimationsModule,
    ToastrModule.forRoot(),
    RouterModule.forRoot(rootRouterConfig, { useHash:false })
  ],
  providers: [
    Title,
    Meta,
    SeoService,
    OrganizadorService,
    {
      provide: HTTP_INTERCEPTORS,
      useClass: ErrorHandlerService,
      multi: true
    }
  ],
  // exports: [AppComponent],
  bootstrap: [AppComponent]
})
export class AppModule { }

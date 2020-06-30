import { Component, OnInit } from '@angular/core';
import { OrganizadorService } from 'src/app/services/organizador.service';

@Component({
  selector: 'app-menu-superior',
  templateUrl: './menu-superior.component.html',
  styleUrls: []
})
export class MenuSuperiorComponent {

  isMenuCollapsed: boolean = true;

  constructor(private organizadorService: OrganizadorService) { }

  usuarioLogado(): boolean{
    return this.organizadorService.isAuthenticated();
  }
}
